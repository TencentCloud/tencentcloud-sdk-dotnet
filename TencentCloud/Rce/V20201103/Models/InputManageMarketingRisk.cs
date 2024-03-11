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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputManageMarketingRisk : AbstractModel
    {
        
        /// <summary>
        /// 用户账号类型；默认开通QQOpenId、手机号MD5权限；如果需要使用微信OpenId入参，则需要"提交工单"或联系对接人进行资格审核，审核通过后方可正常使用微信开放账号。
        /// 1：QQ开放账号
        /// 2：微信开放账号
        /// 8：设备号，仅支持IMEI、IMEIMD5、IDFA、IDFAMD5
        /// 10004：手机号MD5，中国大陆11位手机号进行MD5加密，取32位小写值。
        /// </summary>
        [JsonProperty("Account")]
        public AccountInfo Account{ get; set; }

        /// <summary>
        /// 场景码，用于识别和区分不同的业务场景，可在控制台上新建和管理
        /// 控制台链接：https://console.cloud.tencent.com/rce/risk/strategy/scene-root
        /// 活动防刷默认场景码：e_activity_antirush 
        /// 登录保护默认场景码：e_login_protection
        /// 注册保护默认场景码：e_register_protection
        /// </summary>
        [JsonProperty("SceneCode")]
        public string SceneCode{ get; set; }

        /// <summary>
        /// 用户外网ip（传入用户非外网ip会影响判断结果）。
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 用户操作时间戳，精确到秒。
        /// </summary>
        [JsonProperty("PostTime")]
        public ulong? PostTime{ get; set; }

        /// <summary>
        /// 业务平台用户唯一标识，支持自定义。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 设备指纹DeviceToken值，集成设备指纹后获取；如果集成了相应的设备指纹，该字段必填。
        /// </summary>
        [JsonProperty("DeviceToken")]
        public string DeviceToken{ get; set; }

        /// <summary>
        /// 设备指纹 BusinessId。
        /// </summary>
        [JsonProperty("DeviceBusinessId")]
        public long? DeviceBusinessId{ get; set; }

        /// <summary>
        /// 业务ID。网站或应用在多个业务中使用此服务，通过此ID区分统计数据。
        /// </summary>
        [JsonProperty("BusinessId")]
        public ulong? BusinessId{ get; set; }

        /// <summary>
        /// 昵称，UTF-8 编码。
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 用户邮箱地址。
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress{ get; set; }

        /// <summary>
        /// 是否识别设备异常：
        /// 0：不识别。
        /// 1：识别。
        /// </summary>
        [JsonProperty("CheckDevice")]
        public long? CheckDevice{ get; set; }

        /// <summary>
        /// 用户HTTP请求中的Cookie进行2次hash的值，只要保证相同Cookie的hash值一致即可。
        /// </summary>
        [JsonProperty("CookieHash")]
        public string CookieHash{ get; set; }

        /// <summary>
        /// 用户HTTP请求的Referer值。
        /// </summary>
        [JsonProperty("Referer")]
        public string Referer{ get; set; }

        /// <summary>
        /// 用户HTTP请求的User-Agent值。
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// 用户HTTP请求的X-Forwarded-For值。
        /// </summary>
        [JsonProperty("XForwardedFor")]
        public string XForwardedFor{ get; set; }

        /// <summary>
        /// MAC地址或设备唯一标识。
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// 手机制造商ID，如果手机注册，请带上此信息。
        /// </summary>
        [JsonProperty("VendorId")]
        public string VendorId{ get; set; }

        /// <summary>
        /// 设备类型，账号类型（AccountType）为8时填写。
        /// 1:IMEI；国际移动设备识别号（15-17位数字）；
        /// 2:IMEIMD5；国际移动设备识别号，通过MD5加密后取32位小写值；
        /// 3:IDFA；
        /// 4:IDFAMD5；国际移动设备识别号，通过MD5加密后取32位小写值。
        /// </summary>
        [JsonProperty("DeviceType")]
        public long? DeviceType{ get; set; }

        /// <summary>
        /// 扩展字段。
        /// </summary>
        [JsonProperty("Details")]
        public InputDetails[] Details{ get; set; }

        /// <summary>
        /// 邀请助力场景相关信息。
        /// </summary>
        [JsonProperty("Sponsor")]
        public SponsorInfo Sponsor{ get; set; }

        /// <summary>
        /// 详情请跳转至OnlineScamInfo查看。
        /// </summary>
        [JsonProperty("OnlineScam")]
        public OnlineScamInfo OnlineScam{ get; set; }

        /// <summary>
        /// 1：Android
        /// 2：iOS
        /// 3：H5
        /// 4：小程序
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }


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
        }
    }
}

