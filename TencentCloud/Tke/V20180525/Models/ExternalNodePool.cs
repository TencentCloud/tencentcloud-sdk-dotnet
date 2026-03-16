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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalNodePool : AbstractModel
    {
        
        /// <summary>
        /// 第三方节点池ID
        /// </summary>
        [JsonProperty("NodePoolId")]
        public string NodePoolId{ get; set; }

        /// <summary>
        /// 第三方节点池名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 节点池生命周期
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }

        /// <summary>
        /// 集群CIDR
        /// </summary>
        [JsonProperty("ClusterCIDR")]
        public string ClusterCIDR{ get; set; }

        /// <summary>
        /// 集群网络插件类型
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 第三方节点Runtime配置
        /// </summary>
        [JsonProperty("RuntimeConfig")]
        public RuntimeConfig RuntimeConfig{ get; set; }

        /// <summary>
        /// 第三方节点label
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// 第三方节点taint
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// 第三方节点高级设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }

        /// <summary>
        /// 删除保护开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodePoolId", this.NodePoolId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
            this.SetParamSimple(map, prefix + "ClusterCIDR", this.ClusterCIDR);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamObj(map, prefix + "RuntimeConfig.", this.RuntimeConfig);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
        }
    }
}

