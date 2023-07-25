namespace ExplicitArchitectureStructureCreator.FileTemplate.Solution
{
    internal sealed class SolutionTemplate
    {
        public static string GetContentFile(string projectName)
        {
            return $@"
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.3.32825.248
MinimumVisualStudioVersion = 10.0.40219.1
Project(""{{9A19103F-16F7-4668-BE54-9A1E7A4F7556}}"") = ""{projectName}.{Constants.CORE}"", ""{projectName}.{Constants.CORE}\{projectName}.{Constants.CORE}.csproj"", ""{{FCE925A8-9152-4238-8E40-A75126A2EB30}}""
EndProject
Project(""{{9A19103F-16F7-4668-BE54-9A1E7A4F7556}}"") = ""{projectName}.{Constants.INFRASTRUCTURE}"", ""{projectName}.{Constants.INFRASTRUCTURE}\{projectName}.{Constants.INFRASTRUCTURE}.csproj"", ""{{F817DEE6-7275-4DE3-8F89-CE5E25CB4607}}""
EndProject
Project(""{{9A19103F-16F7-4668-BE54-9A1E7A4F7556}}"") = ""{projectName}.{Constants.WEB_API}"", ""{Constants.USER_INTERFACE}\{projectName}.{Constants.WEB_API}\{projectName}.{Constants.WEB_API}.csproj"", ""{{D1636312-84AB-4130-8ACF-3F838BA84397}}""
EndProject
Project(""{{9A19103F-16F7-4668-BE54-9A1E7A4F7556}}"") = ""{projectName}.{Constants.CORE}.{Constants.TESTS_PROJECT}"", ""..\{Constants.TESTS_FOLDER}\{projectName}.{Constants.CORE}.{Constants.TESTS_PROJECT}\{projectName}.{Constants.CORE}.{Constants.TESTS_PROJECT}.csproj"", ""{{00C68AB5-E41C-4235-9BC8-0D22CEFB4027}}""
EndProject
Project(""{{9A19103F-16F7-4668-BE54-9A1E7A4F7556}}"") = ""{Constants.DOT_NET_EXTENSIONS_PROJ}"", ""..\..\{Constants.LIB}\{Constants.DOT_NET_EXTENSIONS}\{Constants.SRC}\{Constants.DOT_NET_EXTENSIONS_PROJ}\{Constants.DOT_NET_EXTENSIONS_PROJ}.csproj"", ""{{24D5F000-55A0-4538-BA97-40675CC0E066}}""
EndProject
Project(""{{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}}"") = ""{Constants.DOT_NET_EXTENSIONS_PROJ_TEST}"", ""..\..\{Constants.LIB}\{Constants.DOT_NET_EXTENSIONS}\{Constants.TESTS_FOLDER}\{Constants.DOT_NET_EXTENSIONS_PROJ_TEST}\{Constants.DOT_NET_EXTENSIONS_PROJ_TEST}.csproj"", ""{{9870FEFE-3C50-4E1B-998B-1521DF1D340C}}""
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{{FCE925A8-9152-4238-8E40-A75126A2EB30}}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{{FCE925A8-9152-4238-8E40-A75126A2EB30}}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{{FCE925A8-9152-4238-8E40-A75126A2EB30}}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{{FCE925A8-9152-4238-8E40-A75126A2EB30}}.Release|Any CPU.Build.0 = Release|Any CPU
		{{F817DEE6-7275-4DE3-8F89-CE5E25CB4607}}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{{F817DEE6-7275-4DE3-8F89-CE5E25CB4607}}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{{F817DEE6-7275-4DE3-8F89-CE5E25CB4607}}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{{F817DEE6-7275-4DE3-8F89-CE5E25CB4607}}.Release|Any CPU.Build.0 = Release|Any CPU
		{{D1636312-84AB-4130-8ACF-3F838BA84397}}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{{D1636312-84AB-4130-8ACF-3F838BA84397}}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{{D1636312-84AB-4130-8ACF-3F838BA84397}}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{{D1636312-84AB-4130-8ACF-3F838BA84397}}.Release|Any CPU.Build.0 = Release|Any CPU
		{{00C68AB5-E41C-4235-9BC8-0D22CEFB4027}}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{{00C68AB5-E41C-4235-9BC8-0D22CEFB4027}}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{{00C68AB5-E41C-4235-9BC8-0D22CEFB4027}}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{{00C68AB5-E41C-4235-9BC8-0D22CEFB4027}}.Release|Any CPU.Build.0 = Release|Any CPU
		{{24D5F000-55A0-4538-BA97-40675CC0E066}}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{{24D5F000-55A0-4538-BA97-40675CC0E066}}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{{24D5F000-55A0-4538-BA97-40675CC0E066}}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{{24D5F000-55A0-4538-BA97-40675CC0E066}}.Release|Any CPU.Build.0 = Release|Any CPU
		{{9870FEFE-3C50-4E1B-998B-1521DF1D340C}}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{{9870FEFE-3C50-4E1B-998B-1521DF1D340C}}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{{9870FEFE-3C50-4E1B-998B-1521DF1D340C}}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{{9870FEFE-3C50-4E1B-998B-1521DF1D340C}}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {{7AF15B49-0735-4C73-8719-D5E47CB6E849}}
	EndGlobalSection
EndGlobal";
        }
    }
}
