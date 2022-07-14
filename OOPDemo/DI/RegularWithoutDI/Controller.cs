namespace OOPDemo.DI.RegularWithoutDI
{
    public class Controller
    {
        private Service service;

        public Controller()
        {
            service = new Service();
        }

        public void Method()
        {
            service.handle();
        }
    }
}