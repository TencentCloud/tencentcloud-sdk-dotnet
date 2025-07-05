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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceItemExtraInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否vip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// 4.x专享集群状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VipInstanceStatus")]
        public long? VipInstanceStatus{ get; set; }

        /// <summary>
        /// 专享集群峰值带宽
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public long? MaxBandWidth{ get; set; }

        /// <summary>
        /// 专享集群规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// 专享集群节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// 专享集群最大存储
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxStorage")]
        public long? MaxStorage{ get; set; }

        /// <summary>
        /// 专享集群最大保留时间，单位：小时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxRetention")]
        public long? MaxRetention{ get; set; }

        /// <summary>
        /// 专项集群最大保留时间，单位：小时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinRetention")]
        public long? MinRetention{ get; set; }

        /// <summary>
        /// 4.0共享集群状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public long? InstanceStatus{ get; set; }

        /// <summary>
        /// 是否已冻结
        /// </summary>
        [JsonProperty("IsFrozen")]
        public bool? IsFrozen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "VipInstanceStatus", this.VipInstanceStatus);
            this.SetParamSimple(map, prefix + "MaxBandWidth", this.MaxBandWidth);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "MaxRetention", this.MaxRetention);
            this.SetParamSimple(map, prefix + "MinRetention", this.MinRetention);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "IsFrozen", this.IsFrozen);
        }
    }
}

