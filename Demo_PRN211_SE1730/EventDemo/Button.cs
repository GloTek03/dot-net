namespace EventDemo
{
    internal class Button
    {
        public Button(string name)
        {
            Name=name;
        }

        public string Name { get; set; }

        //Tạo sự kiện clik cho button
        public delegate void ButtonEventHandler(string name);
        public event ButtonEventHandler OnClick;

        //Mô phỏng thao tác nhấn chuột
        internal void click()
        {
            if (OnClick!=null)//Nếu Button được gán sự kiện OnClick
            {
                OnClick(Name);
            }
            else
            {
                Console.WriteLine(Name +" chua duoc gan su kien.");
            }
        }
    }
}