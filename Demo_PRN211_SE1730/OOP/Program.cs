using Language;
namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, OOP!");

            //Gọi hàm main ở Language
            Language.Program.Main(args);

            Language.Program p= new Language.Program();
            p.thichgi();
            */
            //Tạo 1 danh sách Teacher
            List<Teacher> data=new List<Teacher>()
            {
                new FullTimeTeacher("T01","Nguyen Van A",2),
                new FullTimeTeacher("T02","Nguyen Van B",1.5),
                new PartTimeTeacher("T03","Nguyen Van C",10),
                new PartTimeTeacher("T04","Nguyen Van D",10),
                new PartTimeTeacher("T05","Nguyen Van E",15)
            };
            
            IManager m=new Manager(data);
            string filename = "..\\..\\..\\data.txt";
            while (true)
            {
                Console.WriteLine("1.Input list Teacher.");
                Console.WriteLine("2.Show list Teacher.");
                Console.WriteLine("3.Count parttime with slot=10.");
                Console.WriteLine("4.Save data to file.");
                Console.WriteLine("5.Load data from file.");
                int option=inputInt("Choose an option:");
                
                switch (option)
                {
                    case 1:
                        {
                            int size = inputInt("Enter size:");
                            m.InputList(size);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("List Teacher:");
                            m.OutputList();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Count="+m.CountSlot10());
                            break;
                        }
                    case 4:
                        {
                            m.saveFile(filename);
                            break;
                        }
                    case 5:
                        {
                            m.loadFile(filename);
                            break;
                        }
                }
            }

        }

        public static int inputInt(string v)
        {
            int option;
            while (true)
            {
                try
                {
                    Console.WriteLine(v);
                    option = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input invalid!!");
                }
            }
            return option;
        }
    }
}