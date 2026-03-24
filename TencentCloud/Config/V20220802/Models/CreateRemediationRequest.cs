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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRemediationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>规则 ID</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>修正类型取值：   SCF：云函数（自定义修正）。</p>
        /// </summary>
        [JsonProperty("RemediationType")]
        public string RemediationType{ get; set; }

        /// <summary>
        /// <p>修正模板 ID</p>
        /// </summary>
        [JsonProperty("RemediationTemplateId")]
        public string RemediationTemplateId{ get; set; }

        /// <summary>
        /// <p>修正执行方式。<br>取值：   MANUAL_EXECUTION：手动执行</p>
        /// </summary>
        [JsonProperty("InvokeType")]
        public string InvokeType{ get; set; }

        /// <summary>
        /// <p>执行修正的模板来源<br>CUSTOM：自定义模板。</p>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RemediationType", this.RemediationType);
            this.SetParamSimple(map, prefix + "RemediationTemplateId", this.RemediationTemplateId);
            this.SetParamSimple(map, prefix + "InvokeType", this.InvokeType);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
        }
    }
}

