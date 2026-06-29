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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppModeConfig : AbstractModel
    {
        
        /// <summary>
        /// 多智能体配置(Agent模式)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiAgentConfig")]
        public MultiAgentConfig MultiAgentConfig{ get; set; }

        /// <summary>
        /// 单工作流配置(单工作流模式)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SingleWorkflowConfig")]
        public SingleWorkflowConfig SingleWorkflowConfig{ get; set; }

        /// <summary>
        /// ClawAgent配置(ClawAgent模式)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClawAgentConfig")]
        public ClawAgentConfig ClawAgentConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MultiAgentConfig.", this.MultiAgentConfig);
            this.SetParamObj(map, prefix + "SingleWorkflowConfig.", this.SingleWorkflowConfig);
            this.SetParamObj(map, prefix + "ClawAgentConfig.", this.ClawAgentConfig);
        }
    }
}

