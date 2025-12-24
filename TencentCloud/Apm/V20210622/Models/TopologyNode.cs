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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopologyNode : AbstractModel
    {
        
        /// <summary>
        /// 错误率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrRate")]
        public float? ErrRate{ get; set; }

        /// <summary>
        /// 节点类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 节点名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 节点权重
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weight")]
        public float? Weight{ get; set; }

        /// <summary>
        /// 节点颜色
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// 响应时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 吞吐量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Qps")]
        public float? Qps{ get; set; }

        /// <summary>
        /// 节点类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 节点大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// 节点是否为组件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsModule")]
        public bool? IsModule{ get; set; }

        /// <summary>
        /// 节点位置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Position")]
        public Position Position{ get; set; }

        /// <summary>
        /// 节点标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }

        /// <summary>
        /// 节点是否可以下钻
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CanDrillDown")]
        public bool? CanDrillDown{ get; set; }

        /// <summary>
        /// 资源层信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Resource")]
        public Resource Resource{ get; set; }

        /// <summary>
        /// 拓扑节点视图名字
        /// </summary>
        [JsonProperty("NodeView")]
        public string NodeView{ get; set; }

        /// <summary>
        /// MQ 消费者视角的响应时间 ms
        /// </summary>
        [JsonProperty("ConsumerDuration")]
        public float? ConsumerDuration{ get; set; }

        /// <summary>
        /// MQ 消费者视角的错误率 %
        /// </summary>
        [JsonProperty("ConsumerErrRate")]
        public float? ConsumerErrRate{ get; set; }

        /// <summary>
        /// MQ 消费者视角的吞吐量
        /// </summary>
        [JsonProperty("ConsumerQps")]
        public float? ConsumerQps{ get; set; }

        /// <summary>
        /// 应用 ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrRate", this.ErrRate);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "IsModule", this.IsModule);
            this.SetParamObj(map, prefix + "Position.", this.Position);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CanDrillDown", this.CanDrillDown);
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
            this.SetParamSimple(map, prefix + "NodeView", this.NodeView);
            this.SetParamSimple(map, prefix + "ConsumerDuration", this.ConsumerDuration);
            this.SetParamSimple(map, prefix + "ConsumerErrRate", this.ConsumerErrRate);
            this.SetParamSimple(map, prefix + "ConsumerQps", this.ConsumerQps);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
        }
    }
}

