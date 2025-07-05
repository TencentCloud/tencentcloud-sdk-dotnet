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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCaptchaMiniRiskResultRequest : AbstractModel
    {
        
        /// <summary>
        /// 固定填值：9（滑块验证码）
        /// </summary>
        [JsonProperty("CaptchaType")]
        public ulong? CaptchaType{ get; set; }

        /// <summary>
        /// 验证码返回给用户的票据
        /// </summary>
        [JsonProperty("Ticket")]
        public string Ticket{ get; set; }

        /// <summary>
        /// 业务侧获取到的验证码使用者的外网IP
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 验证码应用APPID
        /// </summary>
        [JsonProperty("CaptchaAppId")]
        public ulong? CaptchaAppId{ get; set; }

        /// <summary>
        /// 用于服务器端校验验证码票据的验证密钥，请妥善保密，请勿泄露给第三方
        /// </summary>
        [JsonProperty("AppSecretKey")]
        public string AppSecretKey{ get; set; }

        /// <summary>
        /// 业务 ID，网站或应用在多个业务中使用此服务，通过此 ID 区分统计数据
        /// </summary>
        [JsonProperty("BusinessId")]
        public ulong? BusinessId{ get; set; }

        /// <summary>
        /// 场景 ID，网站或应用的业务下有多个场景使用此服务，通过此 ID 区分统计数据
        /// </summary>
        [JsonProperty("SceneId")]
        public ulong? SceneId{ get; set; }

        /// <summary>
        /// mac 地址或设备唯一标识
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// 手机设备号
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// 验证场景：1 活动防刷场景，2 登录保护场景，3 注册保护场景。根据需求选择场景参数。
        /// </summary>
        [JsonProperty("SceneCode")]
        public long? SceneCode{ get; set; }

        /// <summary>
        /// 用户操作来源的微信开放账号
        /// </summary>
        [JsonProperty("WeChatOpenId")]
        public string WeChatOpenId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaptchaType", this.CaptchaType);
            this.SetParamSimple(map, prefix + "Ticket", this.Ticket);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "CaptchaAppId", this.CaptchaAppId);
            this.SetParamSimple(map, prefix + "AppSecretKey", this.AppSecretKey);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "SceneCode", this.SceneCode);
            this.SetParamSimple(map, prefix + "WeChatOpenId", this.WeChatOpenId);
        }
    }
}

