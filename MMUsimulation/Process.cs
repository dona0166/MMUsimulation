using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMUsimulation
{
    class Process
    {
       
        private char id;

        public char Id
        {
            get { return GenerateId(); }
            set { id = value; }
        }
        private int size;

        public int Size
        {
            get { return GenerateSize(); }
            set { size = value; }
        }
        private int logicalAddress;

        public int LogicalAddress
        {
            get { return GetLogicalAddress(); }
            set { logicalAddress = value; }
        }

        Random r = new Random();

        public char GenerateId()
        {
            
            int num = r.Next(65, 90);
            return Convert.ToChar(num);
        }
        
        
        public int GenerateSize()
        {
            int num = r.Next(1, 6);
            return num;
        }

        public int GetLogicalAddress()
        {
            return (Size * 100) - 1;
        }
    }
}
