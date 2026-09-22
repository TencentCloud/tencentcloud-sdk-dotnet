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

namespace TencentCloud.Workbuddyenterprise.V20260709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAgentA2AConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Agent 业务 ID</p>
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>Agent 级唯一 A2A 开关</p>
        /// </summary>
        [JsonProperty("A2AEnabled")]
        public bool? A2AEnabled{ get; set; }

        /// <summary>
        /// <p>A2A 技能集合（原 A2ASkills）</p>
        /// </summary>
        [JsonProperty("A2ASkillSet")]
        public A2ASkillInput[] A2ASkillSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "A2AEnabled", this.A2AEnabled);
            this.SetParamArrayObj(map, prefix + "A2ASkillSet.", this.A2ASkillSet);
        }
    }
}

