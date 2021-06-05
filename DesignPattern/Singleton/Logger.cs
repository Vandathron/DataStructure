using System;
namespace DataStructure.DesignPattern.Singleton
{
    public class Logger
    {
        private static Logger logger;

        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            if(logger == null)
            {
                Console.WriteLine("Object not instantiated yet");
                logger = new Logger();
            } else
            {
                Console.WriteLine("Object already instantiated. Can not create another instance");
            }

            return logger;
        }
    }


    public class SingletonTwo
    {
        private SingletonTwo()
        {

        }

        private static SingletonTwo instance;


        public static SingletonTwo Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingletonTwo();
                }

                return Instance;
            }
        }
    }
}
