namespace ExplicitArchitectureStructureCreator.FileTemplate.Csproj
{
    internal sealed class CoreTemplate : CsprojFileTemplateBase
    {
        public static string GetContentFile()
        {
            return $@"
<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include=""..\..\..\{Constants.LIB}\{Constants.DOT_NET_EXTENSIONS}\{Constants.SRC}\{Constants.DOT_NET_EXTENSIONS_PROJ}\{Constants.DOT_NET_EXTENSIONS_PROJ}.csproj"" />
  </ItemGroup>

  <ItemGroup>
    <Folder Include=""Port\"" />
  </ItemGroup>

</Project>
            ";
        }
    }
}
