using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Manager : IManager
    {
        public Manager(List<Teacher> data)
        {
            Data = data;
        }

        public List<Teacher> Data { get; }

        public int CountSlot10()
        {
            int count = 0;
            foreach (Teacher item in Data)
            {
                if (item is PartTimeTeacher && ((PartTimeTeacher)item).Slot == 10)
                {
                    count++;
                }
            }
            return count;
        }

        public void InputList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter code:");
                string code = Console.ReadLine();
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                int option = Program.inputInt("Mày là loại gv nào? 0:full,1:part?");
                Teacher T;
                if (option == 0)
                {
                    Console.WriteLine("Enter heso:");
                    double heso = Convert.ToDouble(Console.ReadLine()); ;
                    T = new FullTimeTeacher(code, name, heso);
                }
                else
                {
                    int slot = Program.inputInt("Enter slot:");
                    T = new PartTimeTeacher(code, name, slot);
                }
                Data.Add(T);
            }
        }

        public void loadFile(string filename)
        {
            Data.Clear();
            try
            {
                using (StreamReader sr=new StreamReader(filename))
                {
                    string line=sr.ReadLine();
                    while (line!=null)
                    {
                        //Add data đã load vào Data
                        string[] s = line.Split("\t");
                        if (s.Length==4 && !checkEmpty(s))
                        {
                            Console.WriteLine(line);
                            string code = s[0];
                            string name = s[1];
                            Teacher T;
                            if (s[3].Equals("0"))
                            {
                                double heso = Double.Parse(s[2]) / 2000000;
                                T = new FullTimeTeacher(code, name, heso);
                            }
                            else
                            {
                                int slot = Int32.Parse(s[2]) / 50000;
                                T = new PartTimeTeacher(code, name, slot);
                            }
                            Data.Add(T);
                        }
                        
                        line = sr.ReadLine();
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Load file error:" + e.Message);
            }
        }

        private bool checkEmpty(string[] s)
        {
            foreach (string item in s)
            {
                if (String.IsNullOrEmpty(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void OutputList()
        {
            foreach (Teacher item in Data)
            {
                Console.WriteLine(item);
            }
        }

        public void saveFile(string filename)
        {
            try
            {
                //C1:
                /*
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine("Save file successfully!");
                sw.Close();
                */

                //C2:
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (Teacher item in Data)
                    {
                        if (item is FullTimeTeacher)
                        {
                            sw.WriteLine(item+"\t0");
                        }
                        else
                        {
                            sw.WriteLine(item + "\t1");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Save file error:" + e.Message);
            }
        }
    }
}
