using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FTLContinueEditor
{
    public class FTLContinueReader
    {
        private BinaryReader reader;

        public FTLContinueReader(Stream stream)
        {
            reader = new BinaryReader(stream);
        }

        public string readString()
        {
            int length = reader.ReadInt32();
            string str = "";
            for (int i = 0; i < length; i++)
                str += reader.ReadChar();
            return str;
        }

        public int readInt()
        {
            return reader.ReadInt32();
        }

        public BinaryReader Reader
        {
            get
            {
                return reader;
            }
        }
    }
}
