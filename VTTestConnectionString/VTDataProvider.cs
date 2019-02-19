namespace ConnectionStringTester
{
    public class VTDataProvider
    {
        public string name { get; set; }
        public string description { get; set; }
        public string invariant { get; set; }
        public string type { get; set; }

        public VTDataProvider(string _name, string _description, string _invariant, string _type)
        {
            name = _name;
            description = _description;
            invariant = _invariant;
            type = _type;
        }
    }
}
