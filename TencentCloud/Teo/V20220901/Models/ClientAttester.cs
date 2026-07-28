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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClientAttester : AbstractModel
    {
        
        /// <summary>
        /// <p>认证选项 ID。</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>认证选项名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>认证规则类型。仅出参返回，取值有：</p><li>PRESET: 系统预置规则，仅允许修改 AttesterDuration；</li><li>CUSTOM: 用户自定义规则。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>认证方法。取值有：</p><li>TC-RCE: 使用风险识别 RCE 进行认证；</li><li>TC-CAPTCHA: 使用天御验证码进行认证；</li><li>TC-EO-CAPTCHA: 使用 EdgeOne 人机校验进行认证。</li>
        /// </summary>
        [JsonProperty("AttesterSource")]
        public string AttesterSource{ get; set; }

        /// <summary>
        /// <p>认证有效时间。默认为 60s，支持的单位有：</p><li>s：秒，取值范围 60～43200；</li><li>m：分，取值范围 1～720；</li><li>h：小时，取值范围 1～12。</li>
        /// </summary>
        [JsonProperty("AttesterDuration")]
        public string AttesterDuration{ get; set; }

        /// <summary>
        /// <p>是否开启认证结果使用限制。 </p><p>枚举值：</p><ul><li>on： 开启</li><li>off： 关闭</li></ul><p>默认值：off</p>
        /// </summary>
        [JsonProperty("UsageLimit")]
        public string UsageLimit{ get; set; }

        /// <summary>
        /// <p>认证结果最大使用次数。当 UsageLimit 为 on 时，此字段必填。</p><p>取值范围：[1, 100000]</p>
        /// </summary>
        [JsonProperty("MaxUsageCount")]
        public long? MaxUsageCount{ get; set; }

        /// <summary>
        /// <p>TC-RCE 认证的配置信息。</p><li>当 AttesterSource 参数值为 TC-RCE 时，此字段必填。</li>
        /// </summary>
        [JsonProperty("TCRCEOption")]
        public TCRCEOption TCRCEOption{ get; set; }

        /// <summary>
        /// <p>TC-CAPTCHA 认证的配置信息。</p><li>当 AttesterSource 参数值为 TC-CAPTCHA 时，此字段必填。</li>
        /// </summary>
        [JsonProperty("TCCaptchaOption")]
        public TCCaptchaOption TCCaptchaOption{ get; set; }

        /// <summary>
        /// <p>TC-EO-CAPTCHA 认证的配置信息。</p><li>当 AttesterSource 参数值为 TC-EO-CAPTCHA 时，此字段必填。</li>
        /// </summary>
        [JsonProperty("TCEOCaptchaOption")]
        public TCEOCaptchaOption TCEOCaptchaOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AttesterSource", this.AttesterSource);
            this.SetParamSimple(map, prefix + "AttesterDuration", this.AttesterDuration);
            this.SetParamSimple(map, prefix + "UsageLimit", this.UsageLimit);
            this.SetParamSimple(map, prefix + "MaxUsageCount", this.MaxUsageCount);
            this.SetParamObj(map, prefix + "TCRCEOption.", this.TCRCEOption);
            this.SetParamObj(map, prefix + "TCCaptchaOption.", this.TCCaptchaOption);
            this.SetParamObj(map, prefix + "TCEOCaptchaOption.", this.TCEOCaptchaOption);
        }
    }
}

