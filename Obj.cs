namespace TestSkill
{
    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;
        public Obj()
        {
            Console.WriteLine("This's default ctor");
        }
        public Obj(string name,string owner,int length,int count) : this()
        {
            this.name = name;
            this.owner = owner;
            this.length = length;
            this.count = count;
        }
    }
}
