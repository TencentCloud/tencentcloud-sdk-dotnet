using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 扩展了SynchronizationContext方法，添加了GetAwaiter类
    /// 
    /// 本类参考了知乎上的回答，在此感谢知乎用户:
    /// https://www.zhihu.com/question/35284600/answer/583728189
    /// </summary>
    static class UIThreadContext
    {
        public static SynchronizationContextAwaiter GetAwaiter(this SynchronizationContext context)
        {
            return new SynchronizationContextAwaiter(context);
        }
    }
}
