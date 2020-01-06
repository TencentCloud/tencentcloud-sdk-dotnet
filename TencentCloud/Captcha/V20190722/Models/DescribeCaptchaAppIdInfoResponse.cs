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

    public class DescribeCaptchaAppIdInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 界面风格
        /// </summary>
        [JsonProperty("SchemeColor")]
        public string SchemeColor{ get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        [JsonProperty("Language")]
        public long? Language{ get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [JsonProperty("SceneType")]
        public long? SceneType{ get; set; }

        /// <summary>
        /// 防控风险等级
        /// </summary>
        [JsonProperty("EvilInterceptGrade")]
        public long? EvilInterceptGrade{ get; set; }

        /// <summary>
        /// 智能验证
        /// </summary>
        [JsonProperty("SmartVerify")]
        public long? SmartVerify{ get; set; }

        /// <summary>
        /// 智能引擎
        /// </summary>
        [JsonProperty("SmartEngine")]
        public long? SmartEngine{ get; set; }

        /// <summary>
        /// 验证码类型
        /// </summary>
        [JsonProperty("CapType")]
        public long? CapType{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 域名限制
        /// </summary>
        [JsonProperty("DomainLimit")]
        public string DomainLimit{ get; set; }

        /// <summary>
        /// 邮件告警
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MailAlarm")]
        public string[] MailAlarm{ get; set; }

        /// <summary>
        /// 流量控制
        /// </summary>
        [JsonProperty("TrafficThreshold")]
        public long? TrafficThreshold{ get; set; }

        /// <summary>
        /// 加密key
        /// </summary>
        [JsonProperty("EncryptKey")]
        public string EncryptKey{ get; set; }

        /// <summary>
        /// 是否全屏
        /// </summary>
        [JsonProperty("TopFullScreen")]
        public long? TopFullScreen{ get; set; }

        /// <summary>
        /// 成功返回0 其它失败
        /// </summary>
        [JsonProperty("CaptchaCode")]
        public long? CaptchaCode{ get; set; }

        /// <summary>
        /// 返回操作信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CaptchaMsg")]
        public string CaptchaMsg{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SchemeColor", this.SchemeColor);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "EvilInterceptGrade", this.EvilInterceptGrade);
            this.SetParamSimple(map, prefix + "SmartVerify", this.SmartVerify);
            this.SetParamSimple(map, prefix + "SmartEngine", this.SmartEngine);
            this.SetParamSimple(map, prefix + "CapType", this.CapType);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "DomainLimit", this.DomainLimit);
            this.SetParamArraySimple(map, prefix + "MailAlarm.", this.MailAlarm);
            this.SetParamSimple(map, prefix + "TrafficThreshold", this.TrafficThreshold);
            this.SetParamSimple(map, prefix + "EncryptKey", this.EncryptKey);
            this.SetParamSimple(map, prefix + "TopFullScreen", this.TopFullScreen);
            this.SetParamSimple(map, prefix + "CaptchaCode", this.CaptchaCode);
            this.SetParamSimple(map, prefix + "CaptchaMsg", this.CaptchaMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

