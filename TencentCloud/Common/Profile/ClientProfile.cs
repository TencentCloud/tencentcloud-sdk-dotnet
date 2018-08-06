namespace TencentCloud.Common.Profile
{
    /// <summary>
    /// client选项类
    /// </summary>
    public class ClientProfile
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="signMethod">签名方法</param>
        /// <param name="httpProfile">HttpProfile实例</param>
        public ClientProfile(string signMethod, HttpProfile httpProfile)
        {
            this.SignMethod = signMethod;
            this.HttpProfile = httpProfile;
        }

        public ClientProfile(string signMethod)
            : this(signMethod, new HttpProfile())
        {
            
        }

        public ClientProfile()
        {
            SignMethod = SIGN_SHA256;
            HttpProfile = new HttpProfile();
        }

        /// <summary>
        /// http相关选项，请参考 <seealso cref="HttpProfile"/>
        /// </summary>
        public HttpProfile HttpProfile { get; set; }

        /// <summary>
        /// 签名方法
        /// </summary>
        public string SignMethod { get; set; }


        /// <summary>
        /// HmacSHA1签名方法
        /// </summary>
        public const string SIGN_SHA1 = "HmacSHA1";

        /// <summary>
        /// HmacSHA256签名方法
        /// </summary>
        public static string SIGN_SHA256 = "HmacSHA256";
    }
}
