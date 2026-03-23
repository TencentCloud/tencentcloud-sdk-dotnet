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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillInfo : AbstractModel
    {
        
        /// <summary>
        /// Skill名称
        /// </summary>
        [JsonProperty("SkillName")]
        public string SkillName{ get; set; }

        /// <summary>
        /// Skill 描述
        /// </summary>
        [JsonProperty("SkillDesc")]
        public string SkillDesc{ get; set; }

        /// <summary>
        /// Skill来源
        /// </summary>
        [JsonProperty("SkillSource")]
        public string SkillSource{ get; set; }

        /// <summary>
        /// Skill风险标签
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// skill风险描述
        /// </summary>
        [JsonProperty("RiskDesc")]
        public string RiskDesc{ get; set; }

        /// <summary>
        /// 证据链
        /// </summary>
        [JsonProperty("Evidence")]
        public string Evidence{ get; set; }

        /// <summary>
        /// 事件ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkillName", this.SkillName);
            this.SetParamSimple(map, prefix + "SkillDesc", this.SkillDesc);
            this.SetParamSimple(map, prefix + "SkillSource", this.SkillSource);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RiskDesc", this.RiskDesc);
            this.SetParamSimple(map, prefix + "Evidence", this.Evidence);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

