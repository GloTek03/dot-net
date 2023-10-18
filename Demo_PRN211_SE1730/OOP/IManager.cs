using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IManager
    {
        public void InputList(int size);
        public void OutputList();
        public int CountSlot10();
        void saveFile(string filename);
        void loadFile(string filename);
    }
}
