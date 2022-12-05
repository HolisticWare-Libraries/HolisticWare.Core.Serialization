#load "./nuget-restore.cake"

LibSourceSolutions = GetFiles(source_solutions);
LibSourceProjects = GetFiles(source_projects);

//---------------------------------------------------------------------------------------
Task("libs")
    .IsDependentOn ("nuget-restore-libs")
    .IsDependentOn ("libs-msbuild-solutions")
    .IsDependentOn ("libs-msbuild-projects")
    .IsDependentOn ("libs-dotnet-solutions")
    .IsDependentOn ("libs-dotnet-projects")
    ;

Task("libs-msbuild-solutions")
    .Does
    (
        () =>
        {
            foreach(FilePath sln in LibSourceSolutions)
            {
				foreach (string config in configs)
                {
                    DotNetMSBuild
                    (
                        sln.ToString(),
                        new DotNetMSBuildSettings
                        {
                        }
                        .SetConfiguration(configuration)
                        //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                    );
                }
            }

            return;
        }
    );

Task("libs-dotnet-solutions")
    .Does
    (
        () =>
        {
            foreach(FilePath sln in LibSourceSolutions)
            {
				foreach (string config in configs)
                {
                    DotNetBuild
                    (
                        sln.ToString(),
                        new DotNetBuildSettings
                        {
                            Configuration = config,
                        }
                        //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                    );
                }
            }

            return;
        }
    );

Task("libs-msbuild-projects")
    .Does
    (
        () =>
        {
            foreach(FilePath prj in LibSourceProjects)
            {
                foreach(FilePath prj in LibrarySourceProjects)
                {
                    DotNetMSBuild
                    (
                        prj.ToString(),
                        new DotNetMSBuildSettings
                        {
                        }
                        .SetConfiguration(configuration)
                        //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                    );
                }
            }

            return;
        }
    );

Task("libs-dotnet-projects")
    .Does
    (
        () =>
        {
            foreach(FilePath prj in LibSourceProjects)
            {
                foreach(FilePath prj in LibrarySourceProjects)
                {
                    DotNetBuild
                    (
                        prj.ToString(),
                        new DotNetBuildSettings
                        {
                            Configuration = configuration,
                        }
                        //.WithProperty("DefineConstants", "TRACE;DEBUG;NETCOREAPP2_0;NUNIT")
                    );
                }
            }

            return;
        }
    );

public void Build(string pattern)
{
	FilePathCollection files = GetFiles(pattern);

	foreach(FilePath file in files)
	{
		foreach (string config in configs)
		{
			DotNetMSBuild
			(
				file.ToString(),
				new DotNetMSBuildSettings
				{
					Configuration = config,
                }
				.WithProperty("AndroidClassParser", "jar2xml")
			);
		}
	}
	
	return;
}
//---------------------------------------------------------------------------------------
