using System;

namespace Project_1
{
    public sealed class SingletonExample
    {
        private SingletonExample()
        { }
        private static SingletonExample instance=null;
        public static SingletonExample Instance
            {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonExample();
                }

                return instance;
            }
            }
    }
    class Program
    {
        public static void Main()
        {
            SingletonExample s1 = SingletonExample.Instance;
            SingletonExample s2 = SingletonExample.Instance;
            if(s1==s2)
            Console.WriteLine("Even though two instances are tried to be created here but both the instances are same and hence only one instance is being created here logically");
  
        }
    }
}
