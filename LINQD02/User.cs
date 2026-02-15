namespace LINQD02
{
    /*------------------------------------------------------------------*/
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
    /*------------------------------------------------------------------*/
    public class Male : User
    {
    }
    /*------------------------------------------------------------------*/
    public class Female : User
    {
    }
    /*------------------------------------------------------------------*/
}
