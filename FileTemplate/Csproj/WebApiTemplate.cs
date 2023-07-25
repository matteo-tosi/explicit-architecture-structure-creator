namespace ExplicitArchitectureStructureCreator.FileTemplate.Csproj
{
    internal sealed class WebApiTemplate : CsprojFileTemplateBase
    {
        public static string GetContentFile(string projectName)
        {
            return @$"
<Project Sdk=""Microsoft.NET.Sdk.Web"">

    <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    </PropertyGroup>

    <ItemGroup>
    <PackageReference Include=""MediatR.Extensions.Microsoft.DependencyInjection"" Version=""11.0.0"" />
    <PackageReference Include=""Scrutor"" Version=""4.2.0"" />
    <PackageReference Include=""Swashbuckle.AspNetCore"" Version=""6.2.3"" />
    </ItemGroup>

    <ItemGroup>
    <ProjectReference Include=""..\..\{projectName}.{Constants.CORE}\{projectName}.{Constants.CORE}.csproj"" />
    <ProjectReference Include=""..\..\{projectName}.{Constants.INFRASTRUCTURE}\{projectName}.{Constants.INFRASTRUCTURE}.csproj"" />
    </ItemGroup>

</Project>
            ";
        }
    }
}
