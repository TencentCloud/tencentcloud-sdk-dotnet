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

    public class NodePool : AbstractModel
    {
        
        /// <summary>
        /// 集群 ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 节点池 ID
        /// </summary>
        [JsonProperty("NodePoolId")]
        public string NodePoolId{ get; set; }

        /// <summary>
        /// 节点污点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// 是否开启删除保护
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// 节点池类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 节点  Labels
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// 节点池状态
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 节点池名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 原生节点池参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Native")]
        public NativeNodePoolInfo Native{ get; set; }

        /// <summary>
        /// 节点 Annotation 列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Annotations")]
        public Annotation[] Annotations{ get; set; }

        /// <summary>
        /// 超级节点池参数，在Type等于Super该字段才有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Super")]
        public SuperNodePoolInfo Super{ get; set; }

        /// <summary>
        /// 普通节点池参数，在Type等于Regular该字段才有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Regular")]
        public RegularNodePoolInfo Regular{ get; set; }

        /// <summary>
        /// 第三方节点池参数，在Type等于External该字段才有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("External")]
        public ExternalNodePoolInfo External{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NodePoolId", this.NodePoolId);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Native.", this.Native);
            this.SetParamArrayObj(map, prefix + "Annotations.", this.Annotations);
            this.SetParamObj(map, prefix + "Super.", this.Super);
            this.SetParamObj(map, prefix + "Regular.", this.Regular);
            this.SetParamObj(map, prefix + "External.", this.External);
        }
    }
}

