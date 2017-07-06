namespace csVision {

	public class mul : iMech {
	    public iMech left { get; set; } = null;

	    public iMech right { get; set; } = null;

	    public iMech go => (num)asNum;

	    public float asNum => left.go.asNum * right.go.asNum;

	    public string asStr => $"({left.asStr} * {right.asStr})";
	}

}
