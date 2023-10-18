namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo 3 nút
            Button btnAsa = new Button("ASA");
            Button btnHiru = new Button("HIRU");
            Button btnBan = new Button("BAN");

            //Gán sự kiện cho 3 nut
            btnAsa.OnClick += BtnAsa_OnClick;
            btnHiru.OnClick += BtnHiru_OnClick;
            btnBan.OnClick += BtnBan_OnClick;

            //Cho 3 nút lên giao diện
            while (true)
            {
                Console.WriteLine("1.Button ASA.");
                Console.WriteLine("2.Button HIRU.");
                Console.WriteLine("3.Button BAN.");
                Console.WriteLine("Click a button:");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            btnAsa.click();
                            break;
                        }
                    case 2:
                        {
                            btnHiru.click();
                            break;
                        }
                    case 3:
                        {
                            btnBan.click();
                            break;
                        }
                }
            }
        }

        private static void BtnBan_OnClick(string name)
        {
            Console.WriteLine("Konbanwa!");
        }

        private static void BtnHiru_OnClick(string name)
        {
            Console.WriteLine("Konichiwa!");
        }

        private static void BtnAsa_OnClick(string name)
        {
            //Khi nhấn nút thì sẽ có chuyện gì đó xảy ra
            //xảy ra chuyện gì thì viết code ở đây
            Console.WriteLine("Ohayou gozaimasu!");
        }
    }
}