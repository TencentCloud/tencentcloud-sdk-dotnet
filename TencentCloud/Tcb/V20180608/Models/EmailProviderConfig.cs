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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmailProviderConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>smtp配置</p>
        /// </summary>
        [JsonProperty("SmtpConfig")]
        public EmailSmtpConfig SmtpConfig{ get; set; }

        /// <summary>
        /// <p>可选：TRUE，FALSE，如果On为TRUE，则表示采用默认代发。</p>
        /// </summary>
        [JsonProperty("On")]
        public string On{ get; set; }

        /// <summary>
        /// <p>邮件模板配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateConfig")]
        public EmailTemplateConfig TemplateConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SmtpConfig.", this.SmtpConfig);
            this.SetParamSimple(map, prefix + "On", this.On);
            this.SetParamObj(map, prefix + "TemplateConfig.", this.TemplateConfig);
        }
    }
}

