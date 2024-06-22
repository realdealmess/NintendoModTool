using System;
using System.IO;

namespace NintendoModTool
{
    public class NESRom
    {
        const int HeaderSize = 16;

        public byte[] Header { get; private set; }
        public byte[] PRG { get; private set; }
        public byte[] CHR { get; private set; }

        public NESRom(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // Read header
                Header = new byte[HeaderSize];
                stream.Read(Header, 0, HeaderSize);

                // Get PRG and CHR sizes
                int prgSize = Header[4] * 16 * 1024; // 16KB units
                int chrSize = Header[5] * 8 * 1024;  // 8KB units

                // Read PRG data
                PRG = new byte[prgSize];
                stream.Read(PRG, 0, prgSize);

                // Read CHR data
                CHR = new byte[chrSize];
                stream.Read(CHR, 0, chrSize);
            }
        }

        public string GetHeaderInfo()
        {
            return $"PRG ROM Size: {Header[4] * 16} KB\n"
                 + $" | CHR ROM Size: {Header[5] * 8} KB\n"
                 + $" | Mapper Number: {Header[6] >> 4}";
        }

        public void ModifyPRGData(int offset, byte newValue)
        {
            if (offset < 0 || offset >= PRG.Length)
                throw new ArgumentOutOfRangeException(nameof(offset), "Offset is out of range.");

            PRG[offset] = newValue;
        }

        public void ModifyCHRData(int offset, byte newValue)
        {
            if (offset < 0 || offset >= CHR.Length)
                throw new ArgumentOutOfRangeException(nameof(offset), "Offset is out of range.");

            CHR[offset] = newValue;
        }

        public void SaveRom(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                // Write header
                stream.Write(Header, 0, Header.Length);

                // Write PRG data
                stream.Write(PRG, 0, PRG.Length);

                // Write CHR data
                stream.Write(CHR, 0, CHR.Length);
            }
        }
    }
}
