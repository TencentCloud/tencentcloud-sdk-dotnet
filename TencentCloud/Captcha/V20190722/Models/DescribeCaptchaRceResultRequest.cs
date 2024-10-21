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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCaptchaRceResultRequest : AbstractModel
    {
        
        /// <summary>
        /// 固定填值：9。
        /// </summary>
        [JsonProperty("CaptchaType")]
        public ulong? CaptchaType{ get; set; }

        /// <summary>
        /// 前端回调函数返回的用户验证票据
        /// </summary>
        [JsonProperty("Ticket")]
        public string Ticket{ get; set; }

        /// <summary>
        /// 业务侧获取到的验证码使用者的外网IP
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 前端回调函数返回的随机字符串
        /// </summary>
        [JsonProperty("Randstr")]
        public string Randstr{ get; set; }

        /// <summary>
        /// 验证码应用ID。登录 [验证码控制台](https://console.cloud.tencent.com/captcha/graphical)，在验证列表的【密钥】列，即可查看到CaptchaAppId。
        /// </summary>
        [JsonProperty("CaptchaAppId")]
        public ulong? CaptchaAppId{ get; set; }

        /// <summary>
        /// 验证码应用密钥。登录 [验证码控制台](https://console.cloud.tencent.com/captcha/graphical)，在验证列表的【密钥】列，即可查看到AppSecretKey。AppSecretKey属于服务器端校验验证码票据的密钥，请妥善保密，请勿泄露给第三方。
        /// </summary>
        [JsonProperty("AppSecretKey")]
        public string AppSecretKey{ get; set; }

        /// <summary>
        /// 预留字段
        /// </summary>
        [JsonProperty("BusinessId")]
        public ulong? BusinessId{ get; set; }

        /// <summary>
        /// 预留字段
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
        /// 是否返回前端获取验证码时间，取值1：需要返回
        /// </summary>
        [JsonProperty("NeedGetCaptchaTime")]
        public long? NeedGetCaptchaTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaptchaType", this.CaptchaType);
            this.SetParamSimple(map, prefix + "Ticket", this.Ticket);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "Randstr", this.Randstr);
            this.SetParamSimple(map, prefix + "CaptchaAppId", this.CaptchaAppId);
            this.SetParamSimple(map, prefix + "AppSecretKey", this.AppSecretKey);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "NeedGetCaptchaTime", this.NeedGetCaptchaTime);
        }
    }
}

