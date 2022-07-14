using OOPDemo.DI.IoC;

namespace OOPDemo.DI.IoC
{
    }
    public class Factory
    {
        public static Service GetService()
        {
            return new Service();
        }
}