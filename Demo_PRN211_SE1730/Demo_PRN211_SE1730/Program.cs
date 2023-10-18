namespace Language
{
    public class Program
    {
        /// <summary>
        /// Ôn lại cú pháp của C# Language
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Language!");

            while (true)
            {
                Console.WriteLine("1.Basic.");
                Console.WriteLine("2.String demo.");
                Console.WriteLine("3.Demo list.");
                Console.WriteLine("0.Exit.");
                Console.WriteLine("Choose an option:");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: return;
                    case 1:
                        {
                            basic();
                            break;
                        }
                    case 2:
                        {
                            demoString();
                            break;
                        }
                    case 3:
                        {
                            DemoList();
                            break;
                        }
                }
            }

        }

        private static void DemoList()
        {
            //Tạo 1 danh sách tên sinh viên
            List<String> list = new List<String>() {
                "Pham Duc Minh",
                "Nguyen Tuyet Nhu",
                "Nguyen Hai Minh",
                "Vu Huy Duong",
                "Nguyen Huu Huy"
            };

            while (true)
            {
                Console.WriteLine("\t1.Hiển thị danh sách sinh viên.");
                Console.WriteLine("\t2.Add thêm sinh viên vào list nếu không trùng.");
                Console.WriteLine("\t3.Hiển thị những sinh viên có họ kết thúc bởi 'n'");
                Console.WriteLine("\t4.Có bao nhiêu sinh viên mà firstname bắt đầu 'h'");
                Console.WriteLine("\t5.Số lượng sinh viên mà họ dài 3 ký tự");
                Console.WriteLine("\t6.Hiển thị danh sách sinh viên kèm theo tên viết tắt.");
                //Ví dụ:Pham Duc Minh --> MinhPD
                Console.WriteLine("Choose an option:");
                int option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {

                            break;
                        }
                }
            }

        }

        private static void basic()
        {
            //1.Nhập 2 số nguyên a và b từ bàn phím
            int a, b;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a:");
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a invalid.");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input b invalid.");
                }
            }

            //2.So sánh a và b
            //3.Có bao nhiêu số nguyên tố từ a đến b
            //4.Tính tổng các số chính phương từ a đến b
            //5.Hiển thị a số chính phương lớn hơn b

        }

        private static void demoString()
        {
            //1.Nhập fullname từ bàn phím
            //2.Chuẩn hóa chuỗi fullname ở trên:
            //- Cắt bỏ dấu cách thừa ở đầu, cuối và giữa các từ
            //- Viết chữ hoa chữ cái đầu, chữ thường những chữ cái còn lại
            //3.hiển thị riêng lẻ họ,tên và tên đệm
            Console.WriteLine("Enter your fullname:");
            string fullname = Console.ReadLine().Trim().ToLower();

            string[] s = fullname.Split(" ");

            string lastname = s[0];
            lastname = lastname.Substring(0, 1).ToUpper() + lastname.Substring(1);
            Console.WriteLine("Lastname:" + lastname + ".");

            string firstname = s[s.Length - 1];
            firstname = firstname.Substring(0, 1).ToUpper() + firstname.Substring(1);
            Console.WriteLine("Firstname:" + firstname + ".");

            string surname = "";
            for (int i = 1; i < s.Length - 1; i++)
            {
                if (!String.IsNullOrEmpty(s[i]))
                {
                    s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1);
                    surname += s[i] + " ";
                }
            }
            surname = surname.Trim();
            Console.WriteLine("Surname:" + surname + ".");

            if (String.IsNullOrEmpty(surname))
            {
                fullname = lastname + " " + firstname;
            }
            else
            {
                fullname = lastname + " " + surname + " " + firstname;
            }

            Console.WriteLine("Fullname:" + fullname + ".");
        }

        /// <summary>
        /// Hàm thích gì đấy
        /// </summary>
        public void thichgi()
        {
            Console.WriteLine("Tao khong thich gi day duoc khong?");
        }
    }
}