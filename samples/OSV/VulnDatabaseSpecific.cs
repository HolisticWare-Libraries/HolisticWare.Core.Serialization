using System;

namespace OSV;

public partial class VulnDatabaseSpecific
{
    public DateTimeOffset GithubReviewedAt { get; set; }

    public bool GithubReviewed { get; set; }

    public string Severity { get; set; }

    public string[] CweIds { get; set; }

    public DateTimeOffset NvdPublishedAt { get; set; }
}
