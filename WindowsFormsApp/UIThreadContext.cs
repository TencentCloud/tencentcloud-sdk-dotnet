using System.Threading;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 扩展了SynchronizationContext方法，添加了GetAwaiter类
    /// </summary>
    static class UIThreadContext
    {
        public static SynchronizationContextAwaiter GetAwaiter(this SynchronizationContext context)
        {
            return new SynchronizationContextAwaiter(context);
        }
    }
}
