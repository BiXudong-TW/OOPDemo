namespace OOPDemo.Class_Diagram.Dependency
{
    public class DependencyDemo
    {
        public class A
        {
            //This is Association, A has C, one to one
            private C c;
            //This is Dependency, A reference B
            public void AMethod(B b)
            {
                b.callMethod();
            }
        }

        public class B
        {
            public void callMethod()
            {
                //do something
            }
        }

        public class C
        {

        }
    }
}