namespace OOPDemo.DI.IoC
{
    public class Controller
    {
        private Service service;

        public Controller()
        {
            service = Factory.GetService();
        }

        public void Method()
        {
            service.Handle();
        }
    }
}