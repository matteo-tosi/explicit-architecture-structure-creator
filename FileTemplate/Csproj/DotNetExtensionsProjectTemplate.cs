﻿namespace ExplicitArchitectureStructureCreator.FileTemplate.Csproj
{
    internal sealed class DotNetExtensionsProjectTemplate : CsprojFileTemplateBase
    {
        public static string GetContentFile()
        {
            return @"
<Project Sdk=""Microsoft.NET.Sdk"">

    <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    </PropertyGroup>

    <ItemGroup>
    <PackageReference Include=""MediatR"" Version=""11.0.0"" />
    <PackageReference Include=""Microsoft.Extensions.DependencyInjection.Abstractions"" Version=""7.0.0"" />
    </ItemGroup>

</Project>
            ";
        }
    }
}
