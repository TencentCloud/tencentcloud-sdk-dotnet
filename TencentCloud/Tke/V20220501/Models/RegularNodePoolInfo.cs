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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegularNodePoolInfo : AbstractModel
    {
        
        /// <summary>
        /// LaunchConfigurationId 配置
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// AutoscalingGroupId 分组id
        /// </summary>
        [JsonProperty("AutoscalingGroupId")]
        public string AutoscalingGroupId{ get; set; }

        /// <summary>
        /// NodeCountSummary 节点列表
        /// </summary>
        [JsonProperty("NodeCountSummary")]
        public NodeCountSummary NodeCountSummary{ get; set; }

        /// <summary>
        /// 状态信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoscalingGroupStatus")]
        public string AutoscalingGroupStatus{ get; set; }

        /// <summary>
        /// 最大节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxNodesNum")]
        public long? MaxNodesNum{ get; set; }

        /// <summary>
        /// 最小节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinNodesNum")]
        public long? MinNodesNum{ get; set; }

        /// <summary>
        /// 期望的节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DesiredNodesNum")]
        public long? DesiredNodesNum{ get; set; }

        /// <summary>
        /// 节点池osName
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodePoolOs")]
        public string NodePoolOs{ get; set; }

        /// <summary>
        /// 节点配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "AutoscalingGroupId", this.AutoscalingGroupId);
            this.SetParamObj(map, prefix + "NodeCountSummary.", this.NodeCountSummary);
            this.SetParamSimple(map, prefix + "AutoscalingGroupStatus", this.AutoscalingGroupStatus);
            this.SetParamSimple(map, prefix + "MaxNodesNum", this.MaxNodesNum);
            this.SetParamSimple(map, prefix + "MinNodesNum", this.MinNodesNum);
            this.SetParamSimple(map, prefix + "DesiredNodesNum", this.DesiredNodesNum);
            this.SetParamSimple(map, prefix + "NodePoolOs", this.NodePoolOs);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
        }
    }
}

