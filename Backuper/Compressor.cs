using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backuper
{
    static class Compressor
    {
        static public int CompressGZ(Config cfg)
        {
            int errors = 0;

            string CurrentDir = CreateTemp(cfg.TargetPath, false);
            DirectoryInfo directorySelected = new DirectoryInfo(cfg.HomePath);
            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
            {
                try
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

                        }
                    }

                }
                catch
                {
                    errors++;
                    continue;
                }
            }
            return errors;
        }

        public static int CompressZip(Config cfg)
        {
            string CurrentDir = CreateTemp(cfg.TargetPath, true);
            try
            {
                ZipFile.CreateFromDirectory(cfg.HomePath, CurrentDir);
            }
            catch
            {
                return 1;
            }
            return 0;
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

