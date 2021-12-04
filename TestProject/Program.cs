using System;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        public static async Task Main()
        {
            await new Pipeline().Generate(2,
                @"C:\OneDrive\Maxim\OneDrive\Desktop\Lab4\GeneratedTests",
                @"C:\OneDrive\Maxim\OneDrive\Desktop\Lab4\TestProject\TestClass.cs",
                @"C:\OneDrive\Maxim\OneDrive\Desktop\Lab4\TestProject\AnotherTestClass.cs"); 
        }
    }
}
