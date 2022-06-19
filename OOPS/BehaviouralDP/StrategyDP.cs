using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP
{
    interface ICompression
    {
        void CompressFolder(string compressedArchiveFileName);
    }
    class RarCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + compressedArchiveFileName
                 + ".rar' file is created");
        }
    }

    class ZipCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using zip approach: '" + compressedArchiveFileName
                 + ".zip' file is created");
        }
    }
    class CompressionContext
    {
        private ICompression Compression;

        public CompressionContext(ICompression Compression)
        {
            this.Compression = Compression;
        }
        public void SetStrategy(ICompression Compression)
        {
            this.Compression = Compression;
        }
        public void CreateArchive(string compressedArchiveFileName)
        {
            Compression.CompressFolder(compressedArchiveFileName);
        }
    }

    internal class StrategyDP
    {
        public static void test()
        {
            CompressionContext ctx = new CompressionContext(new ZipCompression());
            ctx.CreateArchive("DesignPattern");
            ctx.SetStrategy(new RarCompression());
            ctx.CreateArchive("DesignPattern");
            Console.Read();
        }
    }
}
