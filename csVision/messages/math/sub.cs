namespace csVision {

	public class sub : iMech {
	    public iMech left { get; set; } = null;

	    public iMech right { get; set; } = null;

	    public iMech go => (num)asNum;

	    public float asNum => left.asNum - right.asNum;

	    public string asStr => $"({left.asStr} - {right.asStr})";
	}

}
