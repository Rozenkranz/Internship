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
            Application.Run(new Form1());
        }
    }
    static class Config
    {
        public static string TargetPath { get; set; }
        public static string HomePath { get; set; }
    }

    static class Copier
    {
        static public int CopyAndCompress()
        {
            if (System.IO.Directory.Exists(Config.TargetPath))
            {
                string CurrentDir = CreateTemp(Config.TargetPath);
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
                            //Console.WriteLine($"Compressed {fileToCompress.Name} from {fileToCompress.Length.ToString()} to {info.Length.ToString()} bytes.");
                        }
                    }  
                }
            }
            return 0;
        }
            
        static public string CreateTemp(string TargetPath)
        {
            string DirName = TargetPath
                + "/Temp_" + $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}";
            if (!Directory.Exists(DirName))
                Directory.CreateDirectory(DirName);
            return DirName;
        }
    }
    
}