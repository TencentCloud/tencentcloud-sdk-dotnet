/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Lp.V20200224.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryLoginProtectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 登录来源的外网 IP。
        /// </summary>
        [JsonProperty("LoginIp")]
        public string LoginIp{ get; set; }

        /// <summary>
        /// 用户 ID 不同的 accountType 对应不同的用户 ID。如果是 QQ，则填入对应的 openid，微信用户则填入对应的 openid/unionid，手机号则填入对应真实用户手机号（如13123456789）。
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// 登录时间戳，单位：秒。
        /// </summary>
        [JsonProperty("LoginTime")]
        public string LoginTime{ get; set; }

        /// <summary>
        /// 用户账号类型（QQ 开放帐号、微信开放账号需要 提交工单 由腾讯云进行资格审核）：
        /// 1：QQ 开放帐号。
        /// 2：微信开放账号。
        /// 4：手机号。
        /// 0：其他。
        /// 10004：手机号 MD5。
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// accountType 是 QQ 或微信开放账号时，该参数必填，表示 QQ 或微信分配给网站或应用的 AppID，用来唯一标识网站或应用。
        /// </summary>
        [JsonProperty("AppIdU")]
        public string AppIdU{ get; set; }

        /// <summary>
        /// accountType 是 QQ 或微信开放账号时，用于标识 QQ 或微信用户登录后关联业务自身的账号 ID。
        /// </summary>
        [JsonProperty("AssociateAccount")]
        public string AssociateAccount{ get; set; }

        /// <summary>
        /// 昵称，UTF-8 编码。
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 手机号：国家代码-手机号， 如0086-15912345687（0086前不需要+号）。
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 用户邮箱地址（非系统自动生成）。
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress{ get; set; }

        /// <summary>
        /// 注册来源的外网 IP。
        /// </summary>
        [JsonProperty("RegisterTime")]
        public string RegisterTime{ get; set; }

        /// <summary>
        /// 地址。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 用户 HTTP 请求中的 cookie 进行2次 hash 的值，只要保证相同 cookie 的 hash 值一致即可。
        /// </summary>
        [JsonProperty("CookieHash")]
        public string CookieHash{ get; set; }

        /// <summary>
        /// 登录来源：
        /// 0：其他
        /// 1：PC 网页
        /// 2：移动页面
        /// 3：App
        /// 4：微信公众号
        /// </summary>
        [JsonProperty("LoginSource")]
        public string LoginSource{ get; set; }

        /// <summary>
        /// 登录方式：
        /// 0：其他
        /// 1：手动帐号密码输入
        /// 2：动态短信密码登录
        /// 3：二维码扫描登录
        /// </summary>
        [JsonProperty("LoginType")]
        public string LoginType{ get; set; }

        /// <summary>
        /// 用户 HTTP 请求的 referer 值。
        /// </summary>
        [JsonProperty("Referer")]
        public string Referer{ get; set; }

        /// <summary>
        /// 登录成功后跳转页面。
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 用户 HTTP 请求的 userAgent。
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// 用户 HTTP 请求中的 x_forward_for。
        /// </summary>
        [JsonProperty("XForwardedFor")]
        public string XForwardedFor{ get; set; }

        /// <summary>
        /// 用户操作过程中鼠标单击次数。
        /// </summary>
        [JsonProperty("MouseClickCount")]
        public string MouseClickCount{ get; set; }

        /// <summary>
        /// 用户操作过程中键盘单击次数。
        /// </summary>
        [JsonProperty("KeyboardClickCount")]
        public string KeyboardClickCount{ get; set; }

        /// <summary>
        /// 注册结果：
        /// 0：失败
        /// 1：成功
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 失败原因：
        /// 0：其他
        /// 1：参数错误
        /// 2：帐号冲突
        /// 3：验证错误
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 登录耗时，单位：秒。
        /// </summary>
        [JsonProperty("LoginSpend")]
        public string LoginSpend{ get; set; }

        /// <summary>
        /// MAC 地址或设备唯一标识。
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// 手机制造商 ID，如果手机注册，请带上此信息。
        /// </summary>
        [JsonProperty("VendorId")]
        public string VendorId{ get; set; }

        /// <summary>
        /// App 客户端版本。
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// 手机设备号。
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// 业务 ID 网站或应用在多个业务中使用此服务，通过此 ID 区分统计数据。
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 1：微信公众号
        /// 2：微信小程序
        /// </summary>
        [JsonProperty("WxSubType")]
        public string WxSubType{ get; set; }

        /// <summary>
        /// Token 签名随机数，微信小程序必填，建议16个字符。
        /// </summary>
        [JsonProperty("RandNum")]
        public string RandNum{ get; set; }

        /// <summary>
        /// 如果是微信小程序，该字段为以 ssesion_key 为 key 去签名随机数radnNum得到的值（hmac_sha256 签名算法）。
        /// 如果是微信公众号或第三方登录，则为授权的 access_token（注意：不是普通 access_token，具体看 微信官方文档）。
        /// </summary>
        [JsonProperty("WxToken")]
        public string WxToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoginIp", this.LoginIp);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "AppIdU", this.AppIdU);
            this.SetParamSimple(map, prefix + "AssociateAccount", this.AssociateAccount);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "EmailAddress", this.EmailAddress);
            this.SetParamSimple(map, prefix + "RegisterTime", this.RegisterTime);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "CookieHash", this.CookieHash);
            this.SetParamSimple(map, prefix + "LoginSource", this.LoginSource);
            this.SetParamSimple(map, prefix + "LoginType", this.LoginType);
            this.SetParamSimple(map, prefix + "Referer", this.Referer);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "XForwardedFor", this.XForwardedFor);
            this.SetParamSimple(map, prefix + "MouseClickCount", this.MouseClickCount);
            this.SetParamSimple(map, prefix + "KeyboardClickCount", this.KeyboardClickCount);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "LoginSpend", this.LoginSpend);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "VendorId", this.VendorId);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "WxSubType", this.WxSubType);
            this.SetParamSimple(map, prefix + "RandNum", this.RandNum);
            this.SetParamSimple(map, prefix + "WxToken", this.WxToken);
        }
    }
}

