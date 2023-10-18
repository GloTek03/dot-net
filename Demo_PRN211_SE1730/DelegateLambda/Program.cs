namespace DelegateLambda
{
    internal class Program
    {
        //Khai báo delegate
        delegate void myDelegate1(int kha,int nhu);
        delegate int myDelegate2(int n);
        static void Main(string[] args)
        {
            //Khi chưa sử dụng delegate
            Console.WriteLine("Not use delegate:");
            Cong(12, 16);
            Sosanh(12, 16);
            UCLN(12, 16);

            Cong(12, 18);
            Sosanh(12, 18);
            UCLN(12, 18);

            //Khi sử dụng delegate
            Console.WriteLine("Use delegate:");
            //C1:
            myDelegate1 my1 = new myDelegate1(Cong);
            my1 += Sosanh;
            my1+= UCLN;

            my1(12,16);
            my1 -= UCLN;
            my1(12, 18);

            //C2:
            myDelegate2 my2 = delegate (int a) {
                return a * a;
            };
            Console.WriteLine("a*a="+my2(5));

            //Biến hình my2 thành lambda
            myDelegate2 my3 = (int a) => a * a;
            Console.WriteLine("a*a=" + my3(5));

            //Biến hình tiếp
            myDelegate2 my4 = (a) => a * a;
            Console.WriteLine("a*a=" + my4(5));

            //Biến hình lần cuối
            myDelegate2 my5 = a => a * a;
            Console.WriteLine("a*a=" + my5(5));
        }
        //Tạo các hàm
        public static void Cong(int a, int b)
        {
            Console.WriteLine("a+b=" + (a + b));
        }
        public static void Sosanh(int m, int n)
        {
            if (m == n) Console.WriteLine("m=n");
            if (m > n) Console.WriteLine("m>n");
            if (m < n) Console.WriteLine("m<n");
        }
        public static void UCLN(int k, int l)
        {
            while (k != l)
            {
                if (k > l) k = k - l;
                else l = l - k;
            }
            Console.WriteLine("UCLN=" + k);
        }
    }
}