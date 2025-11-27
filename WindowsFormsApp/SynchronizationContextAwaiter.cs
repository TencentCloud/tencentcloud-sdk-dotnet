using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 用于同步等待的<code>SynchronizationContext</code>类。
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
