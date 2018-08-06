using System;

namespace TencentCloud.Common
{
    public class TencentCloudSDKException : Exception
    {
        public TencentCloudSDKException(string message)
            : this(message,"")
        {

        }

        public TencentCloudSDKException(string message,string requestId):
            base(message)
        {
            this.RequestId = requestId;
        }

        /// <summary>
        /// 获取请求id
        /// </summary>
        public string RequestId { get; private set; }

        public override string ToString()
        {
            return $"message：{this.Message} requestId{RequestId}";
        }
    }
}
