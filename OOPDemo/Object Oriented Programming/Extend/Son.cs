namespace OOPDemo.Object_Oriented_Programming.Extend
{
    public class Son : Father
    {
        private string FirstName { get; set; }

        private string FamilyName { get; set; }

        private int Age { get; set; }

        private string Advantage { get; set; }

        private string Hobby { get; set; }

        public Son() : base(advantage: "kind", hobby:"swimming")
        {
            FirstName = FatherFirstName;
            FatherBehaviour();
        }
    }
}