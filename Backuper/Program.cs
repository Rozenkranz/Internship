using System.Diagnostics;
using System.IO.Compression;
namespace Backuper
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
    static class Config
    {
        static public string ConfigPath { get; set; }
        static public string TargetPath { get; set; }
        static public string HomePath { get; set; }
        static public string LogPath { get; set; }
        static public string CompressionType { get; set; }

       
    }

    static class Copier
    {
        static public void CompressGZ()
        {
            
                string CurrentDir = CreateTemp(Config.TargetPath,false);
                DirectoryInfo directorySelected = new DirectoryInfo(Config.HomePath);
                foreach (FileInfo fileToCompress in directorySelected.GetFiles())
                {
                    string FileTargetPath = CurrentDir + "/" + fileToCompress.Name;
                    using (FileStream originalFileStream = fileToCompress.OpenRead())
                    {
                        if ((File.GetAttributes(fileToCompress.FullName) &
                           FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                        {
                            using (FileStream compressedFileStream = File.Create(FileTargetPath + ".gz"))
                            {
    
                                using (GZipStream compressionStream = new GZipStream(compressedFileStream,
                                   CompressionMode.Compress))
                                {
                                    originalFileStream.CopyTo(compressionStream);
                                }
                            }
                            FileInfo info = new FileInfo(Config.HomePath + Path.DirectorySeparatorChar + fileToCompress.Name + ".gz");
                            
                        }
                    }  
                }
            
        }
        
        public static void CompressZip()
        {
            string CurrentDir = CreateTemp(Config.TargetPath, true);

            ZipFile.CreateFromDirectory(Config.HomePath, CurrentDir);
        }
        static public string CreateTemp(string TempPath, bool archive)
        {
            string DirName = TempPath
                + "/Temp_" + $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}";
            if (!Directory.Exists(DirName))
                Directory.CreateDirectory(DirName);
            if (archive)
                DirName += "/Temp_" + $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.zip";
            return DirName;
        }
    }
    
}