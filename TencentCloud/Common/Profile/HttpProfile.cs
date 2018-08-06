namespace TencentCloud.Common.Profile
{
    /// <summary>
    /// http选项类
    /// </summary>
    public class HttpProfile
    {
        /// <summary>
        /// https协议
        /// </summary>
        public static readonly string REQ_HTTPS = "https://";

        /// <summary>
        /// http协议
        /// </summary>
        public static readonly string REQ_HTTP = "http://";

        /// <summary>
        /// post请求
        /// </summary>
        public static readonly  string REQ_POST = "POST";

        /// <summary>
        /// get请求
        /// </summary>
        public static readonly string REQ_GET = "GET";

        /// <summary>
        /// 时间单位，1分钟   60s
        /// </summary>
        public static readonly int TM_MINUTE = 60;

        public HttpProfile()
        {
            this.ReqMethod = REQ_POST;
            this.Endpoint = null;
            this.Protocol = REQ_HTTPS;
            this.Timeout = TM_MINUTE;
        }

        /// <summary>
        /// 请求方法
        /// </summary>
        public string ReqMethod { get; set; }

        /// <summary>
        /// 请求域名
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// 请求协议
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// 代理服务器
        /// </summary>
        public string WebProxy { get; set; }
    }
}
