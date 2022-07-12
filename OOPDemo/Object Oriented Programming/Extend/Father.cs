namespace OOPDemo.Object_Oriented_Programming.Extend
{
    public class Father
    {
        public string FatherFirstName { get; set; }

        private string FatherFamilyName { get; set; }

        private int Age { get; set; }

        private string Advantage { get; set; }

        private string Hobby { get; set; }

        public Father(string advantage, string hobby)
        {
            Advantage = advantage;
            Hobby = hobby;
        }

        public void FatherBehaviour()
        {
            //do something
        }
    }
}