using ExplicitArchitectureStructureCreator.FileTemplate.Csproj;
using ExplicitArchitectureStructureCreator.FileTemplate.Solution;

namespace ExplicitArchitectureStructureCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~                  Explicit architecture structure creator                  ~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Name of project (press ENTER to confirm):");
            var projectName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(projectName))
            {
                throw new ArgumentNullException(nameof(projectName));
            }

            var currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());

            Console.WriteLine($"Creation of {projectName} project in {currentDirectory.FullName}.");

            CreateProjectStructure(projectName, currentDirectory);
            CreateLibStructure(currentDirectory);

            Console.WriteLine("Project structure created. Press ENTER to close.");
            _ = Console.ReadLine();
        }

        private static void CreateTestForProject(string projectName, DirectoryInfo testsDirectory)
        {
            var directoryName = $"{projectName}.{Constants.CORE}.{Constants.TESTS_PROJECT}";
            DirectoryInfo? testsProjDirectory = CreateFolder(testsDirectory, directoryName);

            var fileName = $"{directoryName}.{CoreTestTemplate.GetExtension()}";
            CreatFile(fileName, testsProjDirectory, CoreTestTemplate.GetContentFile());
        }

        private static void CreateTestStructure(string projectName, DirectoryInfo projectDirectory)
        {
            DirectoryInfo? testsDirectory = CreateFolder(projectDirectory, Constants.TESTS_FOLDER);

            CreateTestForProject(projectName, testsDirectory);
        }

        private static void CreateSolution(string projectName, DirectoryInfo srcDirectory)
        {
            var solutionFileName = $"{projectName}.sln";
            CreatFile(solutionFileName, srcDirectory, SolutionTemplate.GetContentFile(projectName));
        }

        private static void CreateWebAppStructure(string projectName, DirectoryInfo userInterfaceDirectory)
        {
            var directoryName = $"{projectName}.{Constants.WEB_APP}";
            _ = CreateFolder(userInterfaceDirectory, directoryName);
        }

        private static void CreateWebApiStructure(string projectName, DirectoryInfo userInterfaceDirectory)
        {
            var directoryName = $"{projectName}.{Constants.WEB_API}";
            DirectoryInfo? userInterfaceProjectDirectory = CreateFolder(userInterfaceDirectory, directoryName);

            var fileName = $"{directoryName}.{WebApiTemplate.GetExtension()}";
            CreatFile(fileName, userInterfaceProjectDirectory, WebApiTemplate.GetContentFile(projectName));
        }

        private static void CreateUserInterfaceStructure(string projectName, DirectoryInfo srcDirectory)
        {
            DirectoryInfo? userInterfaceDirectory = CreateFolder(srcDirectory, Constants.USER_INTERFACE);

            CreateWebApiStructure(projectName, userInterfaceDirectory);
            CreateWebAppStructure(projectName, userInterfaceDirectory);
        }

        private static void CreateInfrastructureStructure(string projectName, DirectoryInfo srcDirectory)
        {
            var directoryName = $"{projectName}.{Constants.INFRASTRUCTURE}";
            DirectoryInfo? infrastructureDirectory = CreateFolder(srcDirectory, directoryName);

            var fileName = $"{directoryName}.{InfrastructureTemplate.GetExtension()}";
            CreatFile(fileName, infrastructureDirectory, InfrastructureTemplate.GetContentFile(projectName));
        }

        private static void CreateSharedKernelStructure(DirectoryInfo coreDirectory)
        {
            DirectoryInfo? sharedKernelDirectory = CreateFolder(coreDirectory, Constants.SHARED_KERNEL);

            DirectoryInfo? valueObjectDirectory = CreateFolder(sharedKernelDirectory, Constants.VALUE_OBJECT);

            CreatFile("Default.cs", valueObjectDirectory, string.Empty);

            var componentDirectory = CreateFolder(sharedKernelDirectory, Constants.COMPONENT);

            DirectoryInfo? defaultComponentDirectory = CreateFolder(componentDirectory, Constants.DEFAULT_COMPONENT);

            DirectoryInfo? defaultAggregateDirectory = CreateFolder(defaultComponentDirectory, Constants.DEFAULT_AGGREGATE);

            CreatFile("Default.cs", defaultAggregateDirectory, string.Empty);
        }

        private static void CreateDefaultDomainStructure(DirectoryInfo defaultComponentDirectory)
        {
            DirectoryInfo? domainDirectory = CreateFolder(defaultComponentDirectory, Constants.DOMAIN);

            DirectoryInfo? defaultAggregateDirectory = CreateFolder(domainDirectory, Constants.DEFAULT_AGGREGATE);

            CreatFile("Default.cs", defaultAggregateDirectory, string.Empty);
        }

        private static void CreateDefaultComponetStructure(DirectoryInfo componentDirectory)
        {
            DirectoryInfo? defaultComponentDirectory = CreateFolder(componentDirectory, Constants.DEFAULT_COMPONENT);

            _ = CreateFolder(defaultComponentDirectory, Constants.APPLICATION);
            CreateDefaultDomainStructure(defaultComponentDirectory);
        }

        private static void CreateComponentStructure(DirectoryInfo coreDirectory)
        {
            DirectoryInfo? componentDirectory = CreateFolder(coreDirectory, Constants.COMPONENT);

            CreateDefaultComponetStructure(componentDirectory);
        }

        private static void CreateCoreStructure(string projectName, DirectoryInfo srcDirectory)
        {
            var directoryName = $"{projectName}.{Constants.CORE}";
            DirectoryInfo? coreDirectory = CreateFolder(srcDirectory, directoryName);

            CreateComponentStructure(coreDirectory);
            CreateSharedKernelStructure(coreDirectory);

            var fileName = $"{directoryName}.{CoreTemplate.GetExtension()}";
            CreatFile(fileName, coreDirectory, CoreTemplate.GetContentFile());
        }

        private static void CreateSrcStructure(string projectName, DirectoryInfo projectDirectory)
        {
            DirectoryInfo? srcDirectory = CreateFolder(projectDirectory, Constants.SRC);

            CreateCoreStructure(projectName, srcDirectory);
            CreateInfrastructureStructure(projectName, srcDirectory);
            CreateUserInterfaceStructure(projectName, srcDirectory);
            CreateSolution(projectName, srcDirectory);
        }

        private static void CreateProjectStructure(string projectName, DirectoryInfo currentDirectory)
        {
            DirectoryInfo? projectDirectory = CreateFolder(currentDirectory, projectName);

            CreateSrcStructure(projectName, projectDirectory);
            CreateTestStructure(projectName, projectDirectory);
        }


        private static void CreateDotNetExtensionsTestsProjectStructure(DirectoryInfo dotNetExtensionsTestDirectory)
        {
            DirectoryInfo? dotNetExtensionsTestProjectDirectory = CreateFolder(dotNetExtensionsTestDirectory, Constants.DOT_NET_EXTENSIONS_PROJ_TEST);

            var fileName = $"{Constants.DOT_NET_EXTENSIONS_PROJ_TEST}.{DotNetExtensionsTestTemplate.GetExtension()}";
            CreatFile(fileName, dotNetExtensionsTestProjectDirectory, DotNetExtensionsTestTemplate.GetContentFile());
        }

        private static void CreateDotNetExtensionsTestsStructure(DirectoryInfo dotNetExtensionsDirectory)
        {
            DirectoryInfo? dotNetExtensionsTestDirectory = CreateFolder(dotNetExtensionsDirectory, Constants.TESTS_FOLDER);

            CreateDotNetExtensionsTestsProjectStructure(dotNetExtensionsTestDirectory);
        }

        private static void CreateDotNetExtensionsProjectStructure(DirectoryInfo dotNetExtensionsSrcDirectory)
        {
            DirectoryInfo? dotNetExtensionsSrcProjectDirectory = CreateFolder(dotNetExtensionsSrcDirectory, Constants.DOT_NET_EXTENSIONS_PROJ);

            var fileName = $"{Constants.DOT_NET_EXTENSIONS_PROJ}.{DotNetExtensionsProjectTemplate.GetExtension()}";
            CreatFile(fileName, dotNetExtensionsSrcProjectDirectory, DotNetExtensionsProjectTemplate.GetContentFile());
        }

        private static void CreateDotNetExtensionsSrcStructure(DirectoryInfo dotNetExtensionsDirectory)
        {
            DirectoryInfo? dotNetExtensionsSrcDirectory = CreateFolder(dotNetExtensionsDirectory, Constants.SRC);

            CreateDotNetExtensionsProjectStructure(dotNetExtensionsSrcDirectory);
        }

        private static void CreateDotNetExtensionsStructure(DirectoryInfo libDirectory)
        {
            DirectoryInfo? dotNetExtensionsDirectory = CreateFolder(libDirectory, Constants.DOT_NET_EXTENSIONS);

            CreateDotNetExtensionsSrcStructure(dotNetExtensionsDirectory);
            CreateDotNetExtensionsTestsStructure(dotNetExtensionsDirectory);
        }

        private static void CreateLibStructure(DirectoryInfo currentDirectory)
        {
            DirectoryInfo? libDirectory = CreateFolder(currentDirectory, Constants.LIB);

            CreateDotNetExtensionsStructure(libDirectory);
        }

        private static void CreatFile(string fileName, DirectoryInfo sourceDirectory, string content)
        {
            var filePath = Path.Combine(sourceDirectory.FullName, fileName);

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, contents: content);
            }

            Console.WriteLine($"{filePath} file created.");
        }

        private static DirectoryInfo CreateFolder(DirectoryInfo source, string destination)
        {
            var destinationPath = Path.Combine(source.FullName, destination);

            DirectoryInfo? destinationDirectory;
            if (!Directory.Exists(destinationPath))
            {
                destinationDirectory = Directory.CreateDirectory(destinationPath);
                Console.WriteLine($"{destinationPath} folder created.");
            }
            else
            {
                destinationDirectory = new DirectoryInfo(destinationPath);
            }

            return destinationDirectory;
        }
    }
}