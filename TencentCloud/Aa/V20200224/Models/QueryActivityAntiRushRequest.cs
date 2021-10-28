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

namespace TencentCloud.Aa.V20200224.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryActivityAntiRushRequest : AbstractModel
    {
        
        /// <summary>
        /// 账号类型
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// uid值
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// 用户的真实外网 IP。若填入非外网有效ip，会返回level=0的风控结果，risktype中会有205的风险码返回作为标识
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 用户操作时间戳。
        /// </summary>
        [JsonProperty("PostTime")]
        public string PostTime{ get; set; }

        /// <summary>
        /// accountType 是QQ开放账号时，该参数必填，表示 QQ 开放平台分配给网站或应用的 AppID，用来唯一标识网站或应用。
        /// </summary>
        [JsonProperty("AppIdU")]
        public string AppIdU{ get; set; }

        /// <summary>
        /// 昵称，UTF-8 编码。
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 用户邮箱地址。
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress{ get; set; }

        /// <summary>
        /// 注册时间戳。
        /// </summary>
        [JsonProperty("RegisterTime")]
        public string RegisterTime{ get; set; }

        /// <summary>
        /// 注册来源的外网 IP。
        /// </summary>
        [JsonProperty("RegisterIp")]
        public string RegisterIp{ get; set; }

        /// <summary>
        /// 用户 HTTP 请求中的 cookie 进行2次 hash 的值，只要保证相同 cookie 的 hash 值一致即可。
        /// </summary>
        [JsonProperty("CookieHash")]
        public string CookieHash{ get; set; }

        /// <summary>
        /// 地址。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 登录来源：
        /// 0：其他。
        /// 1：PC 网页。
        /// 2：移动页面。
        /// 3：App。
        /// 4：微信公众号。
        /// </summary>
        [JsonProperty("LoginSource")]
        public string LoginSource{ get; set; }

        /// <summary>
        /// 登录方式：
        /// 0：其他。
        /// 1：手动账号密码输入。
        /// 2：动态短信密码登录。
        /// 3：二维码扫描登录。
        /// </summary>
        [JsonProperty("LoginType")]
        public string LoginType{ get; set; }

        /// <summary>
        /// 登录耗时，单位：秒。
        /// </summary>
        [JsonProperty("LoginSpend")]
        public string LoginSpend{ get; set; }

        /// <summary>
        /// 用户操作的目的 ID，如点赞等，该字段就是被点赞的消息 ID，如果是投票，则为被投号码的 ID。
        /// </summary>
        [JsonProperty("RootId")]
        public string RootId{ get; set; }

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
        /// 手机设备号。支持以下格式：
        /// 1.imei明文
        /// 2.idfa明文,
        /// 3.imei小写后MD5值小写
        /// 4.idfa大写后MD5值小写
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// App 客户端版本。
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// 业务 ID 网站或应用在多个业务中使用此服务，通过此 ID 区分统计数据。
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 1：微信公众号。
        /// 2：微信小程序。
        /// </summary>
        [JsonProperty("WxSubType")]
        public string WxSubType{ get; set; }

        /// <summary>
        /// Token 签名随机数，WxSubType为微信小程序时必填，建议16个字符。
        /// </summary>
        [JsonProperty("RandNum")]
        public string RandNum{ get; set; }

        /// <summary>
        /// token
        /// </summary>
        [JsonProperty("WxToken")]
        public string WxToken{ get; set; }

        /// <summary>
        /// 是否识别设备异常：
        /// 0：不识别。
        /// 1：识别。
        /// </summary>
        [JsonProperty("CheckDevice")]
        public string CheckDevice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "AppIdU", this.AppIdU);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "EmailAddress", this.EmailAddress);
            this.SetParamSimple(map, prefix + "RegisterTime", this.RegisterTime);
            this.SetParamSimple(map, prefix + "RegisterIp", this.RegisterIp);
            this.SetParamSimple(map, prefix + "CookieHash", this.CookieHash);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "LoginSource", this.LoginSource);
            this.SetParamSimple(map, prefix + "LoginType", this.LoginType);
            this.SetParamSimple(map, prefix + "LoginSpend", this.LoginSpend);
            this.SetParamSimple(map, prefix + "RootId", this.RootId);
            this.SetParamSimple(map, prefix + "Referer", this.Referer);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "XForwardedFor", this.XForwardedFor);
            this.SetParamSimple(map, prefix + "MouseClickCount", this.MouseClickCount);
            this.SetParamSimple(map, prefix + "KeyboardClickCount", this.KeyboardClickCount);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "VendorId", this.VendorId);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "WxSubType", this.WxSubType);
            this.SetParamSimple(map, prefix + "RandNum", this.RandNum);
            this.SetParamSimple(map, prefix + "WxToken", this.WxToken);
            this.SetParamSimple(map, prefix + "CheckDevice", this.CheckDevice);
        }
    }
}

