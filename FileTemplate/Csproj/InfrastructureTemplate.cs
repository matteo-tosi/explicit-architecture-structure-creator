namespace ExplicitArchitectureStructureCreator.FileTemplate.Csproj
{
    internal sealed class InfrastructureTemplate : CsprojFileTemplateBase
    {
        public static string GetContentFile(string projectName)
        {
            return @$"
<Project Sdk=""Microsoft.NET.Sdk"">

    <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    </PropertyGroup>

    <ItemGroup>
    <PackageReference Include=""Microsoft.EntityFrameworkCore"" Version=""7.0.0"" />
    <PackageReference Include=""Microsoft.EntityFrameworkCore.Relational"" Version=""7.0.0"" />
    </ItemGroup>

    <ItemGroup>
    <ProjectReference Include=""..\{projectName}.{Constants.CORE}\{projectName}.{Constants.CORE}.csproj"" />
    </ItemGroup>

</Project>
            ";
        }
    }
}
