namespace csVision
{
    public class last : iMech
    {
        public iMech val { get; set; }

        public iMech go
        {
            get
            {
                var list = val as list;
                if (list != null)
                {
                    while (list.rest!=null)
                    {
                        list = list.rest;
                    }
                    return list.first;
                }
                else
                {
                    return null;
                }
            }
        }

        public float asNum
        {
            get { return go.asNum; }
        }

        public string asStr
        {
            get { return go.asStr; }
        }

        public static implicit operator last(list l)
        {
            return new last() {val = l};
        }
    }
}