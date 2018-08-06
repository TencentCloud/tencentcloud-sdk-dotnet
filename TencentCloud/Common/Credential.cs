namespace TencentCloud.Common
{
    /// <summary>
    ///  认证相关信息类
    /// </summary>
    public class Credential
    {
        /// <summary>
        /// secretId,在控制台申请
        /// </summary>
        public string SecretId { get; set; }

        /// <summary>
        /// secretKey,在控制台申请
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        public string Token { get; set; }
    }
}
