/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputManageMarketingRisk : AbstractModel
    {
        
        /// <summary>
        /// <p>用户账号类型；默认开通QQOpenId、手机号MD5权限；如果需要使用微信OpenId入参，则需要&quot;提交工单&quot;或联系对接人进行资格审核，审核通过后方可正常使用微信开放账号。<br>1：QQ开放账号<br>2：微信开放账号<br>10004：手机号MD5，中国大陆11位手机号进行MD5加密，取32位小写值<br>10005：手机号SHA256，中国大陆11位手机号进行SHA256加密，取64位小写值</p>
        /// </summary>
        [JsonProperty("Account")]
        public AccountInfo Account{ get; set; }

        /// <summary>
        /// <p>场景码，用于识别和区分不同的业务场景，可在控制台上新建和管理<br>控制台链接：https://console.cloud.tencent.com/rce/risk/strategy/scene-root<br>活动防刷默认场景码：e_activity_antirush<br>登录保护默认场景码：e_login_protection<br>注册保护默认场景码：e_register_protection</p>
        /// </summary>
        [JsonProperty("SceneCode")]
        public string SceneCode{ get; set; }

        /// <summary>
        /// <p>用户外网ip（传入用户非外网ip会影响判断结果）。</p>
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// <p>用户操作时间戳，精确到秒。</p>
        /// </summary>
        [JsonProperty("PostTime")]
        public ulong? PostTime{ get; set; }

        /// <summary>
        /// <p>业务平台用户唯一标识，支持自定义。</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>设备指纹DeviceToken值，集成设备指纹后获取；如果集成了相应的设备指纹，该字段必填。</p>
        /// </summary>
        [JsonProperty("DeviceToken")]
        public string DeviceToken{ get; set; }

        /// <summary>
        /// <p>设备指纹 BusinessId。</p>
        /// </summary>
        [JsonProperty("DeviceBusinessId")]
        public long? DeviceBusinessId{ get; set; }

        /// <summary>
        /// <p>业务ID。网站或应用在多个业务中使用此服务，通过此ID区分统计数据。</p>
        /// </summary>
        [JsonProperty("BusinessId")]
        public ulong? BusinessId{ get; set; }

        /// <summary>
        /// <p>昵称，UTF-8 编码。</p>
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// <p>用户邮箱地址。</p>
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress{ get; set; }

        /// <summary>
        /// <p>是否识别设备异常：<br>0：不识别。<br>1：识别。</p>
        /// </summary>
        [JsonProperty("CheckDevice")]
        public long? CheckDevice{ get; set; }

        /// <summary>
        /// <p>用户HTTP请求中的Cookie进行2次hash的值，只要保证相同Cookie的hash值一致即可。</p>
        /// </summary>
        [JsonProperty("CookieHash")]
        public string CookieHash{ get; set; }

        /// <summary>
        /// <p>用户HTTP请求的Referer值。</p>
        /// </summary>
        [JsonProperty("Referer")]
        public string Referer{ get; set; }

        /// <summary>
        /// <p>用户HTTP请求的User-Agent值。</p>
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// <p>用户HTTP请求的X-Forwarded-For值。</p>
        /// </summary>
        [JsonProperty("XForwardedFor")]
        public string XForwardedFor{ get; set; }

        /// <summary>
        /// <p>MAC地址或设备唯一标识。</p>
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// <p>手机制造商ID，如果手机注册，请带上此信息。</p>
        /// </summary>
        [JsonProperty("VendorId")]
        public string VendorId{ get; set; }

        /// <summary>
        /// <p>设备类型(已不推荐使用)。</p>
        /// </summary>
        [JsonProperty("DeviceType")]
        public long? DeviceType{ get; set; }

        /// <summary>
        /// <p>扩展字段。</p>
        /// </summary>
        [JsonProperty("Details")]
        public InputDetails[] Details{ get; set; }

        /// <summary>
        /// <p>邀请助力场景相关信息。</p>
        /// </summary>
        [JsonProperty("Sponsor")]
        public SponsorInfo Sponsor{ get; set; }

        /// <summary>
        /// <p>详情请跳转至OnlineScamInfo查看。</p>
        /// </summary>
        [JsonProperty("OnlineScam")]
        public OnlineScamInfo OnlineScam{ get; set; }

        /// <summary>
        /// <p>1：Android<br>2：iOS<br>3：H5<br>4：小程序<br>5：鸿蒙</p>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// <p>数据授权信息。<br>注意：新接入通用业务欺诈保护（RCE）服务的客户该字段【必传】。</p>
        /// </summary>
        [JsonProperty("DataAuthorization")]
        public DataAuthorizationInfo DataAuthorization{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Account.", this.Account);
            this.SetParamSimple(map, prefix + "SceneCode", this.SceneCode);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "DeviceToken", this.DeviceToken);
            this.SetParamSimple(map, prefix + "DeviceBusinessId", this.DeviceBusinessId);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "EmailAddress", this.EmailAddress);
            this.SetParamSimple(map, prefix + "CheckDevice", this.CheckDevice);
            this.SetParamSimple(map, prefix + "CookieHash", this.CookieHash);
            this.SetParamSimple(map, prefix + "Referer", this.Referer);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "XForwardedFor", this.XForwardedFor);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "VendorId", this.VendorId);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
            this.SetParamObj(map, prefix + "Sponsor.", this.Sponsor);
            this.SetParamObj(map, prefix + "OnlineScam.", this.OnlineScam);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamObj(map, prefix + "DataAuthorization.", this.DataAuthorization);
        }
    }
}

