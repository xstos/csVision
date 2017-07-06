namespace csVision {

	public class div : iMech {
	    public iMech left { get; set; } = null;

	    public iMech right { get; set; } = null;

	    public iMech go => new num { val = asNum };

	    public float asNum => 0 == right.go.asNum ? float.PositiveInfinity : left.go.asNum / right.go.asNum;

	    public string asStr => $"({left.asStr} / {right.asStr})";
	}

}
