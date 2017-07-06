using System.Linq;

namespace csVision
{
    public class list : iMech
    {
        public iMech first { get; set; }
        public list rest { get; set; }

        public iMech go
        {
            get { return this; }
        }

        public float asNum
        {
            get { return first?.asNum ?? 0; }
        }

        public string asStr
        {
            get
            {
                return first?.asStr + (rest?.asStr != null ? " " + rest?.asStr : null);
            }
        }

        public static implicit operator list(iMech[] items)
        {
            list ret = new list();
            var start = ret;
            for (int i = 0; i < items.Length; i++)
            {
                iMech t = items[i];
                start.first = t;
                if (i < items.Length - 1)
                {
                    start.rest = new list();
                    start = (list) start.rest;
                }
            }

            return ret;
        }

        public static implicit operator list(num[] items)
        {
            return items.Cast<iMech>().ToArray();
        }
    }
}