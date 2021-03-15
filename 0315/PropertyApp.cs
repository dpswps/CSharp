using System;

namespace PropertyApp //패키지 개념
{
    class PropertyClass {
        private int privateValue;
        public int PrivateValue {
            get { return privateValue; }
            set { privateValue = value; }
        }
        public void Printvalue() {
            Console.WriteLine("Hidden Value = " + privateValue);
        }
    }
    class PropertyApp { 
        static void Main(string[] args) {
            int n;
            PropertyClass obj = new PropertyClass();
            obj.PrivateValue = 100;
            obj.Printvalue();
            n = obj.PrivateValue;
            Console.WriteLine("Value = " + n);
        }
    }
}
