namespace OSV;

public partial class Affected
{
    public Package Package { get; set; }

    public Range[] Ranges { get; set; }

    public string[] Versions { get; set; }

    public AffectedDatabaseSpecific DatabaseSpecific { get; set; }
}
