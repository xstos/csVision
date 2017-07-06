namespace csVision
{
    public class concat : iMech
    {
        public iMech left { get; set; }
        public iMech right { get; set; }

        public iMech go
        {
            get {
                //todo:
                //if (left is list)
                //{
                //    var l = left as list;
                //    if (right is list)
                //    {
                        
                //    }
                //}
                return null;
            }
            
        }

        public float asNum
        {
            get { return 0; }
        }

        public string asStr
        {
            get { return ""; }
        }
    }
}