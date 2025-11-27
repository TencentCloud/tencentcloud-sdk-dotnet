using System;
using System.Linq;
using System.Reflection;

namespace TencentCloudExamples
{
    class Entrypoint
    {
        /// <summary>
        /// Usage instructions:
        /// Command line arguments:
        ///  - The first command line argument (args[0]) specifies the name of the example class to execute.
        ///  - If this argument is not provided, DescribeZones is used as the default class name.
        ///  - The remaining command line arguments (args[1:]) will be passed as parameters to the Run method of the example class.
        ///
        /// Example:
        ///   Running the DescribeZones example class:
        ///   Assume there is a class TencentCloudExamples.DescribeZones, and it has a static Run method.
        ///   Use the following command to run the example class:
        ///   TENCENTCLOUD_SECRET_ID=xxx TENCENTCLOUD_SECRET_KEY=yyy dotnet run DescribeZones arg1 arg2 arg3
        ///   The program will then:
        ///   1. Load the TencentCloudExamples.DescribeZones class.
        ///   2. Call the Run method.
        ///   3. Pass arg1 arg2 arg3 as arguments to the Run method.
        /// </summary>
        static void Main(string[] args)
        {
            var entryTypename = $"{nameof(TencentCloudExamples)}.{args.ElementAtOrDefault(0) ?? nameof(DescribeZones)}";
            var entryType = Type.GetType(entryTypename)!;
            var entryMethod = entryType.GetMethod("Run", BindingFlags.Static | BindingFlags.Public)!;
            var entryArgs = args.Skip(1).ToArray();

            Console.WriteLine($"Running example: {entryTypename}.{entryMethod.Name}");
            entryMethod.Invoke(null, new[] { entryArgs });
        }
    }
}