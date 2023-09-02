namespace Backuper
{
    class Config
    {
        public string TargetPath { get; set; }
        public string HomePath { get; set; }
        public string CompressionType { get; set; }

        public Config()
        {
            TargetPath = null;
            HomePath = null;
            CompressionType = "gzip";
        }

    }
}
