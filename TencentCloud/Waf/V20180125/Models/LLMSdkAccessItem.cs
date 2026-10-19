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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LLMSdkAccessItem : AbstractModel
    {
        
        /// <summary>
        /// <p>服务id</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>服务名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>SDK接入来源，可不填</p>
        /// </summary>
        [JsonProperty("SdkSource")]
        public string SdkSource{ get; set; }

        /// <summary>
        /// <p>总开关</p>
        /// </summary>
        [JsonProperty("MainStatus")]
        public bool? MainStatus{ get; set; }

        /// <summary>
        /// <p>限速开关</p>
        /// </summary>
        [JsonProperty("LimitRuleStatus")]
        public bool? LimitRuleStatus{ get; set; }

        /// <summary>
        /// <p>内容安全开关</p>
        /// </summary>
        [JsonProperty("ContentRuleStatus")]
        public bool? ContentRuleStatus{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>修改时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// <p>限流规则数量</p>
        /// </summary>
        [JsonProperty("LimitRuleCount")]
        public ulong? LimitRuleCount{ get; set; }

        /// <summary>
        /// <p>内容安全规则数量</p>
        /// </summary>
        [JsonProperty("ContentRuleCount")]
        public ulong? ContentRuleCount{ get; set; }

        /// <summary>
        /// <p>toolcall防护开关</p>
        /// </summary>
        [JsonProperty("ToolCallStatus")]
        public bool? ToolCallStatus{ get; set; }

        /// <summary>
        /// <p>llm推理防护开关</p>
        /// </summary>
        [JsonProperty("LLMProtectStatus")]
        public bool? LLMProtectStatus{ get; set; }

        /// <summary>
        /// <p>内容合规检测开关</p>
        /// </summary>
        [JsonProperty("ContentComplianceStatus")]
        public bool? ContentComplianceStatus{ get; set; }

        /// <summary>
        /// <p>dlp防护开关</p>
        /// </summary>
        [JsonProperty("DLPStatus")]
        public bool? DLPStatus{ get; set; }

        /// <summary>
        /// <p>skills防护开关</p>
        /// </summary>
        [JsonProperty("SkillsStatus")]
        public bool? SkillsStatus{ get; set; }

        /// <summary>
        /// <p>意图识别检测开关</p>
        /// </summary>
        [JsonProperty("IntentStatus")]
        public bool? IntentStatus{ get; set; }

        /// <summary>
        /// <p>恶意URL检测开关</p>
        /// </summary>
        [JsonProperty("UrlDetectStatus")]
        public bool? UrlDetectStatus{ get; set; }

        /// <summary>
        /// <p>生效规则数量</p>
        /// </summary>
        [JsonProperty("EffectiveRules")]
        public long? EffectiveRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SdkSource", this.SdkSource);
            this.SetParamSimple(map, prefix + "MainStatus", this.MainStatus);
            this.SetParamSimple(map, prefix + "LimitRuleStatus", this.LimitRuleStatus);
            this.SetParamSimple(map, prefix + "ContentRuleStatus", this.ContentRuleStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LimitRuleCount", this.LimitRuleCount);
            this.SetParamSimple(map, prefix + "ContentRuleCount", this.ContentRuleCount);
            this.SetParamSimple(map, prefix + "ToolCallStatus", this.ToolCallStatus);
            this.SetParamSimple(map, prefix + "LLMProtectStatus", this.LLMProtectStatus);
            this.SetParamSimple(map, prefix + "ContentComplianceStatus", this.ContentComplianceStatus);
            this.SetParamSimple(map, prefix + "DLPStatus", this.DLPStatus);
            this.SetParamSimple(map, prefix + "SkillsStatus", this.SkillsStatus);
            this.SetParamSimple(map, prefix + "IntentStatus", this.IntentStatus);
            this.SetParamSimple(map, prefix + "UrlDetectStatus", this.UrlDetectStatus);
            this.SetParamSimple(map, prefix + "EffectiveRules", this.EffectiveRules);
        }
    }
}

