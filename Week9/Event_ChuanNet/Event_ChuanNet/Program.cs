using System.Runtime.Serialization;
using System.Text;
using System.Threading.Channels;

namespace Event_ChuanNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            HocSinh hocSinh = new HocSinh();
            hocSinh.NameChanged += HS_NameChanged;
            hocSinh.Name = "Thay doi lan 1";
            hocSinh.Name = "Thay doi lan 2";
            hocSinh.Name = "Thay doi lan 3";
            hocSinh.Name = "Thay doi lan 4";

            Console.ReadLine();
        }
        
        static void HS_NameChanged(object sender, NameChangedEvnetArgs e)
        {
            Console.WriteLine("Ten co su thay doi la " + e.Name);
        }
    }

    class HocSinh
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value; 
                OnChanged(value);
            }
        }
        
        private event EventHandler<NameChangedEvnetArgs> _NameChanged;
        
        public  event EventHandler<NameChangedEvnetArgs> NameChanged
        {
            add
            {
                _NameChanged += value;
            }
            remove
            {
                _NameChanged -= value;
            }
        }

        void OnChanged(string name)
        {
            if (_NameChanged != null)
            {
                _NameChanged(this, new NameChangedEvnetArgs(name));
            }
        }
    }
    public  class NameChangedEvnetArgs : EventArgs
    {
        public string Name { get; set; }
        public  NameChangedEvnetArgs(string name)
        {
            Name = name;
        }
        
    }
    
}

