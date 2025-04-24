using System;
using System.Linq;
using System.Reflection;

namespace TencentCloudExamples
{
    class Entrypoint
    {
        /// <summary>
        /// 使用说明：
        /// 命令行参数：
        ///  - 第一个命令行参数（args[0]）指定要执行的示例类名称。
        ///  - 如果未提供该参数，则默认使用 DescribeZones 作为类名。
        ///  - 其余的命令行参数（args[1:]）会作为参数传递给示例类的 Run 方法。
        ///
        /// 示例：
        ///   运行 DescribeZones 示例类：
        ///   假设有一个类 TencentCloudExamples.DescribeZones，并且它有一个静态的 Run 方法。
        ///   使用以下命令运行示例类：
        ///   TENCENTCLOUD_SECRET_ID=xxx TENCENTCLOUD_SECRET_KEY=yyy dotnet run DescribeZones arg1 arg2 arg3
        ///   这时程序会：
        ///   1. 加载 TencentCloudExamples.DescribeZones 类。
        ///   2. 调用 Run 方法。
        ///   3. 将 arg1 arg2 arg3 作为参数传递给 Run 方法。
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