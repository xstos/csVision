using System;

namespace csVision {

	public class num : iMech {

        public float val { get; set; }

	    public iMech go => this;

	    public float asNum => val;

	    public string asStr => val.ToString();

	    public static implicit operator string(num n)
	    {
	        return n.asStr;
	    }

	    public static implicit operator float(num n)
	    {
	        return n.asNum;
	    }

	    public static implicit operator num(float n)
	    {
	        return new num() {val = n};
	    }
	}

}
