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
        /// 认证选项 ID。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 认证选项名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 认证规则类型。仅出参返回，取值有：
        /// <li>PRESET: 系统预置规则，仅允许修改 AttesterDuration；</li>
        /// <li>CUSTOM: 用户自定义规则。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 认证方法。取值有：
        /// <li>TC-RCE: 使用全栈式风控引擎进行认证；</li>
        /// <li>TC-CAPTCHA: 使用天御验证码进行认证。</li>
        /// </summary>
        [JsonProperty("AttesterSource")]
        public string AttesterSource{ get; set; }

        /// <summary>
        /// 认证有效时间。默认为 60s，支持的单位有：
        /// <li>s：秒，取值范围 60～43200；</li>
        /// <li>m：分，取值范围 1～720；</li>
        /// <li>h：小时，取值范围 1～12。</li>
        /// </summary>
        [JsonProperty("AttesterDuration")]
        public string AttesterDuration{ get; set; }

        /// <summary>
        /// TC-RCE 认证的配置信息。
        /// <li>当 AttesterSource 参数值为 TC-RCE 时，此字段必填。</li>
        /// </summary>
        [JsonProperty("TCRCEOption")]
        public TCRCEOption TCRCEOption{ get; set; }

        /// <summary>
        /// TC-CAPTCHA 认证的配置信息。
        /// <li>当 AttesterSource 参数值为 TC-CAPTCHA 时，此字段必填。</li>
        /// </summary>
        [JsonProperty("TCCaptchaOption")]
        public TCCaptchaOption TCCaptchaOption{ get; set; }


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
            this.SetParamObj(map, prefix + "TCRCEOption.", this.TCRCEOption);
            this.SetParamObj(map, prefix + "TCCaptchaOption.", this.TCCaptchaOption);
        }
    }
}

