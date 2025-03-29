

```csharp
public partial class Response
{
    public Vuln[] Vulns { get; set; }
}

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

public partial class VulnDatabaseSpecific
{
    public DateTimeOffset GithubReviewedAt { get; set; }
    public bool GithubReviewed { get; set; }
    public string Severity { get; set; }
    public string[] CweIds { get; set; }
    public DateTimeOffset NvdPublishedAt { get; set; }
}

public partial class Reference
{
    public Types Type { get; set; }
    public Uri Url { get; set; }
}

public partial class Severity
{
    public string Type { get; set; }
    public string Score { get; set; }
}

public partial class Range
{
    public string Type { get; set; }
    public Event[] Events { get; set; }
}

public partial class Package
{
    public string Name { get; set; }
    public string Ecosystem { get; set; }
    public string Purl { get; set; }
}

public partial class Event
{
    public string Introduced { get; set; }
    public string Fixed { get; set; }
    public string LastAffected { get; set; }
}

public partial class AffectedDatabaseSpecific
{
    public Uri Source { get; set; }
}

public partial class Affected
{
    public Package Package { get; set; }
    public Range[] Ranges { get; set; }
    public string[] Versions { get; set; }
    public AffectedDatabaseSpecific DatabaseSpecific { get; set; }
}

public enum Types
{
    Advisory,
    Package,
    Web
};
```