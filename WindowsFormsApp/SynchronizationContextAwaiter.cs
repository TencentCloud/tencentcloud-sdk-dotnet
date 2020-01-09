using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 用于同步等待的<code>SynchronizationContext</code>类。
    /// 
    /// 本类参考了知乎上的回答，在此感谢知乎用户:
    /// https://www.zhihu.com/question/35284600/answer/583728189
    /// </summary>
    public sealed class SynchronizationContextAwaiter : INotifyCompletion
    {
        private readonly SynchronizationContext context;
        public SynchronizationContextAwaiter(SynchronizationContext context)
        {
            this.context = context;
        }

        public bool IsCompleted
        {
            get
            {
                return SynchronizationContext.Current == context;
            }
        }

        public void OnCompleted(Action action)
        {
            this.context.Post(x => action(), null);
        }

        public void GetResult() 
        { 
        }
    }
}
