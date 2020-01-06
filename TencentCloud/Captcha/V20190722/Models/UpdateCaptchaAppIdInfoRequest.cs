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

    public class UpdateCaptchaAppIdInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 验证码应用ID
        /// </summary>
        [JsonProperty("CaptchaAppId")]
        public long? CaptchaAppId{ get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 域名限制
        /// </summary>
        [JsonProperty("DomainLimit")]
        public string DomainLimit{ get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [JsonProperty("SceneType")]
        public long? SceneType{ get; set; }

        /// <summary>
        /// 验证码类型
        /// </summary>
        [JsonProperty("CapType")]
        public long? CapType{ get; set; }

        /// <summary>
        /// 风险级别
        /// </summary>
        [JsonProperty("EvilInterceptGrade")]
        public long? EvilInterceptGrade{ get; set; }

        /// <summary>
        /// 智能检测
        /// </summary>
        [JsonProperty("SmartVerify")]
        public long? SmartVerify{ get; set; }

        /// <summary>
        /// 开启智能引擎
        /// </summary>
        [JsonProperty("SmartEngine")]
        public long? SmartEngine{ get; set; }

        /// <summary>
        /// web风格
        /// </summary>
        [JsonProperty("SchemeColor")]
        public string SchemeColor{ get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        [JsonProperty("CaptchaLanguage")]
        public long? CaptchaLanguage{ get; set; }

        /// <summary>
        /// 告警邮箱
        /// </summary>
        [JsonProperty("MailAlarm")]
        public string MailAlarm{ get; set; }

        /// <summary>
        /// 是否全屏
        /// </summary>
        [JsonProperty("TopFullScreen")]
        public long? TopFullScreen{ get; set; }

        /// <summary>
        /// 流量限制
        /// </summary>
        [JsonProperty("TrafficThreshold")]
        public long? TrafficThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaptchaAppId", this.CaptchaAppId);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "DomainLimit", this.DomainLimit);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "CapType", this.CapType);
            this.SetParamSimple(map, prefix + "EvilInterceptGrade", this.EvilInterceptGrade);
            this.SetParamSimple(map, prefix + "SmartVerify", this.SmartVerify);
            this.SetParamSimple(map, prefix + "SmartEngine", this.SmartEngine);
            this.SetParamSimple(map, prefix + "SchemeColor", this.SchemeColor);
            this.SetParamSimple(map, prefix + "CaptchaLanguage", this.CaptchaLanguage);
            this.SetParamSimple(map, prefix + "MailAlarm", this.MailAlarm);
            this.SetParamSimple(map, prefix + "TopFullScreen", this.TopFullScreen);
            this.SetParamSimple(map, prefix + "TrafficThreshold", this.TrafficThreshold);
        }
    }
}

