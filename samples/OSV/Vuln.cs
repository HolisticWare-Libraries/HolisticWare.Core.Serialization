using System;

namespace OSV;

public partial class Vuln
{
    public string Id { get; set; }

    public string Summary { get; set; }

    public string Details { get; set; }

    public string[] Aliases { get; set; }

    public DateTimeOffset Modified { get; set; }

    public DateTimeOffset Published { get; set; }

    public string[] Related { get; set; }

    public VulnDatabaseSpecific DatabaseSpecific { get; set; }

    public Reference[] References { get; set; }

    public Affected[] Affected { get; set; }

    public string SchemaVersion { get; set; }

    public Severity[] Severity { get; set; }
}
