using System;
using System.Collections.Generic;
using System.Text;

namespace HashTool
{
    public class CRC32
    {
        private readonly uint[] table;
        private uint crc = 0xFFFFFFFF;
        public CRC32()
        {
            table = new uint[256];
            const uint poly = 0xEDB88320u;
            for (uint i = 0; i < 256; i++)
            {
                uint temp = i;
                for (int j = 0; j < 8; j++)
                    temp = (temp & 1) != 0 ? (poly ^ (temp >> 1)) : (temp >> 1);
                table[i] = temp;
            }
        }

        public void Update(byte[] buffer, int offset, int count)
        {
            for (int i = offset; i < offset + count; i++)
                crc = table[(crc ^ buffer[i]) & 0xFF] ^ (crc >> 8);
        }

        public uint Hash => ~crc;
        public string HashString => Hash.ToString("X8");
    }
}
