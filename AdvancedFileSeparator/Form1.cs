using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace AdvancedFileSeparator
{
    public partial class Form1 : Form
    {
        string[] files = null;
        Thread th, th_AllFileConvert;
        bool th_Run;
        string selPatternFromArr;
        Bitmap img;
        string listboxItemName;
        ImageFormat selImageFormat;
        public Form1()
        {
            InitializeComponent();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            th_Run = false;
            SearchPattern = "";
            selPatternFromArr = "";
            SelectedFileType = "*.*";
            NeedDeleteOrigFile = deleteAfterSeparateChk.Checked;
            FilesPerFolder = 0;
        }
        public int FilesPerFolder { get; set; }
        public bool NeedDeleteOrigFile { get; set; }
        public string SelectedNewExtension { get; set; }
        public string SearchPattern { get; set; }
        public string SelectedFileType { get; set; }
        public string SourceFolder { get; set; }
        public string DestinationFolder { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (button3.Text=="Stopped")
                {
                    th_Run = true;
                    th = new Thread(new ThreadStart(MainThread));
                    th.IsBackground = true;
                    th.Start();
                    button3.Text = "Started";
                    deleteAfterSeparateChk.Enabled = false;
                }
                else
                {                 
                    th_Run = false;
                    button3.Text = "Stopped";
                    deleteAfterSeparateChk.Enabled = true;
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }

        private void setSourceFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SourceFolder = folderBrowserDialog1.SelectedPath;
                sourceFolderLabel.Text = "Source folder: "+SourceFolder;              
                files = Directory.GetFiles(SourceFolder, SelectedFileType, SearchOption.AllDirectories);
                if (files == null || files.Length == 0) { MessageBox.Show("not find file in " + SourceFolder); button3_Click(null,null);return; }                          
                sepaFileNameTextBox.Text = files[0].Substring(files[0].LastIndexOf("\\")+1);
                allFileCounter.Text = "All file(s) in source folder: " + files.Length;
                setDestinationFolderToolStripMenuItem.Enabled = true;//start button
                foreach (string item in files)
                {
                    if (item.Contains(".jpg") ||
                        item.Contains(".jpeg") ||
                        item.Contains(".png") ||
                        item.Contains(".bmp"))
                    {
                        listBox1.Items.Add(item);
                    }
                }
                imageNumberLabel.Text = "Image number: "+listBox1.Items.Count;
            }
        }

        private void setDestinationFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DestinationFolder = folderBrowserDialog1.SelectedPath;
                destinationFolderLabel.Text = "Destination folder: " + DestinationFolder;
                button3.Enabled = true;
            }
        }

        private void MainThread()
        {
            int counter = 0, findedFileCounter=0,counterPerFolder=0;
            string[] patternArr = null;
            string writedFilesLogmsg = "";
            int folderSepaName = 1;
            try
            {              
                foreach (string it in files)
                {
                    if (!th_Run) break;
                    patternArr = SearchPattern.Split(',');
                    if (patternArr.Length>0)
                    {
                        foreach (var item in patternArr)
                        {                        
                            selPatternFromArr = item;
                            if (it.Contains(selPatternFromArr))
                            {
                                if (FilesPerFolder !=0&& counterPerFolder >= FilesPerFolder)
                                {
                                    folderSepaName++;
                                    counterPerFolder = 0;
                                }
                                if (!Directory.Exists(DestinationFolder + "\\" + selPatternFromArr +"\\"+ folderSepaName))
                                {
                                    Directory.CreateDirectory(DestinationFolder + "\\" + selPatternFromArr + "\\" + folderSepaName);
                                }
                                File.Copy(it, DestinationFolder + "\\" + selPatternFromArr + "\\" + folderSepaName +"\\"+ it.Substring(it.LastIndexOf("\\") + 1),true);
                                writedFilesLogmsg += $"{findedFileCounter}.\tFrom: {it}\n\tTo: {DestinationFolder + "\\" + selPatternFromArr + "\\" + folderSepaName + "\\" + it.Substring(it.LastIndexOf("\\") + 1)} Copy OK\n";
                                if (NeedDeleteOrigFile) { File.Delete(it); writedFilesLogmsg += $"\tDelete: {it} OK\n"; }

                                ++counterPerFolder;
                                findedFileCounterLabel.Invoke((MethodInvoker)(() => findedFileCounterLabel.Text = "Finded file counter:  " + ++findedFileCounter));
                                Console.WriteLine(it + " ->" + selPatternFromArr + " ->"+ findedFileCounter);
                            }
                        }                      
                    } 
                    checkedFileCounter.Invoke(
                        (MethodInvoker)(() =>
                        {
                            checkedFileCounter.Text = "Checked file(s) counter: " + ++counter;    
                        }
                        ));            
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
            WriteLog(writedFilesLogmsg);
            button3.Invoke((MethodInvoker)(() => { button3.Text = "Stopped"; deleteAfterSeparateChk.Enabled = true; }));      
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th_Run = false;
            Environment.Exit(0);
        }

        private void searchPatternTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchPattern = searchPatternTextBox.Text;
        }

        private void sepaFileNameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void selFileTypeText_TextChanged(object sender, EventArgs e)
        {
            SelectedFileType = selFileTypeText.Text;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "File separation:\nSeparates files from the source folder to the destiny folder under certain conditions.\n" +
                "Image conversion:\nConverts images from the source folder to the" +
                "destination folder under specified conditions.", "Help");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selFile = listBox1.GetItemText(listBox1.SelectedItem);
            listboxItemName = selFile.Substring(selFile.LastIndexOf("\\")+1);
            try
            {
                newTypeCB.SelectedIndex = 0;
                img =(Bitmap)Image.FromFile(selFile);
                FileInfo fi = new FileInfo(selFile);
                origWidtText.Text = img.Width.ToString();
                origHeightText.Text = img.Height.ToString();
                string imgFormat = img.PixelFormat.ToString();             
                if (img.PixelFormat!= PixelFormat.Indexed||
                    img.PixelFormat != PixelFormat.Gdi ||
                    img.PixelFormat != PixelFormat.Alpha ||
                    img.PixelFormat != PixelFormat.Canonical ||
                    img.PixelFormat != PixelFormat.DontCare||
                    img.PixelFormat != PixelFormat.Extended ||
                    img.PixelFormat != PixelFormat.PAlpha ||
                    img.PixelFormat != PixelFormat.Undefined)
                {
                    imgFormat = imgFormat.Substring(6);
                    origColorText.Text = imgFormat.Substring(imgFormat.LastIndexOf("p")+1);
                    origDepthText.Text = imgFormat.Substring(0,imgFormat.LastIndexOf("p")+1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n"+ex.StackTrace);
            }
        }
        private Image CropImage(Image image,int startX, int startY,int width,int height)
        {
            Bitmap bmpImage = new Bitmap(image);
            if (startX+width<=image.Width&& startX + width > 0 && startY +height<=image.Height && startY + height > 0)
            {             
                return bmpImage.Clone(new Rectangle(startX, startY, width, height), image.PixelFormat);
            }
            else
            {
                return bmpImage;
            }          
        }
        private Image ResizeImage(Image image,int width, int height)
        {
            Bitmap bmpImage = new Bitmap(image);
            if (width>0&& height>0)
            {
                return new Bitmap(bmpImage, width, height);
            }
            else
            {
                return bmpImage;
            }
            
        }

       private void ConvertImage(Image oldImgName,string newFilePlaceAndName,string codec)
        {
            try
            {
                Bitmap bitmap= new Bitmap(oldImgName);
                ImageCodecInfo myImageCodecInfo;
                Encoder myEncoder;
                EncoderParameter myEncoderParameter;
                EncoderParameters myEncoderParameters;
                // Get an ImageCodecInfo object that represents the JPEG codec.
                myEncoderParameters = new EncoderParameters(1);
                myImageCodecInfo = GetEncoderInfo("image/" + codec);
                myEncoder = Encoder.Quality;            
                myEncoderParameter = new EncoderParameter(myEncoder, 100L);                         
                myEncoderParameters.Param[0] = myEncoderParameter;             
                bitmap.Save(newFilePlaceAndName + "." + codec, myImageCodecInfo, myEncoderParameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }          
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType) 
                    return encoders[j];
            }
            return null;
        }

        private void AllFileConvertThread()
        {
            try
            {
                int counter = 0;
                string fileName = "";
                int newWidth = Convert.ToInt32(newWidtText.Text), newHeight = Convert.ToInt32(newHeightText.Text);
                int startX = Convert.ToInt32(cropImgStartX.Text), startY = Convert.ToInt32(cropImgStartY.Text);
                Image tmpImg;
                foreach (string item in listBox1.Items)
                {
                    fileName = item.Substring(item.LastIndexOf('\\') + 1);
                    fileName = fileName.Substring(0, fileName.LastIndexOf('.'));
                    using (Image img2 = (Bitmap)Image.FromFile(item))
                    {
                        tmpImg = img2;
                        if (cropImageChk.Checked)
                        {
                            tmpImg = CropImage(img2,startX,startY,newWidth,newHeight);
                        }
                        else
                        {
                            tmpImg = ResizeImage(img2,newWidth,newHeight);
                        }
                        ConvertImage(tmpImg, DestinationFolder + "\\" + fileName, SelectedNewExtension);
                    }
                    imageConverterCounterLabel.Invoke(
                        (MethodInvoker)(() =>
                        imageConverterCounterLabel.Text = "Converted fileCount: " + ++counter));
                }
                MessageBox.Show("OK");
                applySelectedBtn.Invoke((MethodInvoker)(() => {
                    applySelectedBtn.Enabled = true;
                    newTypeCB.Enabled = true;
                    newWidtText.Enabled = true;
                    newHeightText.Enabled = true;
                    cropImageChk.Enabled = true;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }                
        }

        private void applySelectedBtn_Click(object sender, EventArgs e)
        {
            Image tmpImg;
            if (listBox1.SelectedIndex!=-1)
            {
                string fileName = listBox1.Text.Substring(listBox1.Text.LastIndexOf('\\') + 1);
                fileName = fileName.Substring(0, fileName.LastIndexOf('.'));
                DialogResult res = MessageBox.Show(this, "Az összes fájl-t kívánja konvertálni?\n" +
                    "Nem válasz esetén csak a kijelölt fájl lesz konvertálva.", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res==DialogResult.No)
                {
                    int newWidth = Convert.ToInt32(newWidtText.Text), newHeight = Convert.ToInt32(newHeightText.Text);
                    int startX = Convert.ToInt32(cropImgStartX.Text), startY = Convert.ToInt32(cropImgStartY.Text);
                    tmpImg = img;
                    if (cropImageChk.Checked)
                    {
                        tmpImg = CropImage(img, startX, startY, newWidth, newHeight);
                    }
                    else
                    {
                        tmpImg = ResizeImage(img, newWidth, newHeight);
                    }
                    ConvertImage(tmpImg, DestinationFolder + "\\" + fileName, SelectedNewExtension);
                }
                else if (res==DialogResult.Yes)
                {
                    applySelectedBtn.Enabled = false;
                    newTypeCB.Enabled = false;
                    newWidtText.Enabled = false;
                    newHeightText.Enabled = false;
                    cropImageChk.Enabled = false;
                    th_AllFileConvert = new Thread(new ThreadStart(AllFileConvertThread));
                    th_AllFileConvert.IsBackground = true;
                    th_AllFileConvert.Start();                                  
                }              
            }          
        }

        private void newTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (newTypeCB.Text)
            {
                case "png":
                    selImageFormat = ImageFormat.Png;
                    SelectedNewExtension = "png";
                    break;
                case "bmp":
                    selImageFormat = ImageFormat.Bmp;
                    SelectedNewExtension = "bmp";
                    break;
                case "jpeg":
                    selImageFormat = ImageFormat.Jpeg;
                    SelectedNewExtension = "jpeg";
                    break;
            }
        }

        private void deleteAfterSeparateChk_CheckedChanged(object sender, EventArgs e)
        {
            NeedDeleteOrigFile = deleteAfterSeparateChk.Checked;
        }

        private void sourceFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SourceFolder != null&&SourceFolder !="")
            {
                Process.Start(SourceFolder);
            }         
        }

        private void destinationFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DestinationFolder != null && DestinationFolder != "")
            {
                Process.Start(DestinationFolder);
            }
        }

        private void outputFilePerFolderText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilesPerFolder = Convert.ToInt32(outputFilePerFolderText.Text);
            }
            catch (Exception)
            {
                if (outputFilePerFolderText.Text!="")
                {
                    outputFilePerFolderText.Text = outputFilePerFolderText.Text.Substring(0, outputFilePerFolderText.Text.Length - 1);
                    FilesPerFolder = Convert.ToInt32(outputFilePerFolderText.Text);
                }
                else
                {
                    outputFilePerFolderText.Text = "0";
                    FilesPerFolder = Convert.ToInt32(outputFilePerFolderText.Text);
                } 
            }
            Console.WriteLine(FilesPerFolder.ToString());
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(DestinationFolder + "\\log.txt"))
            {
                Process.Start(DestinationFolder + "\\log.txt");
            }
        }

        private void WriteLog(string data)
        {
            try
            {
                using (StreamWriter sr= new StreamWriter(DestinationFolder+"\\log.txt",true))
                {
                    sr.WriteLine($"- {DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss")}:\n{data}");
                    sr.Flush();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a log fájl írása közben:\n"+
                    ex.Message+"\n"+ex.StackTrace);
            }
        }
    }
}
