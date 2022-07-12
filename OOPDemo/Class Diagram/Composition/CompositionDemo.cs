namespace OOPDemo.Class_Diagram.Composition
{
    public class CompositionDemo
    {
        public class Engine {
            //This is car engine
        }

        public class Glass
        {
            // This is car glass
        }
        /**
         * if the car is destroyed, the engine and glass destroyed as well.
         */
        public class Car {
            Engine eng = new Engine();
            Glass glass = new Glass();
            // other component
        }
    }
}