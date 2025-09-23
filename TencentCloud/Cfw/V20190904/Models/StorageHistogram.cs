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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageHistogram : AbstractModel
    {
        
        /// <summary>
        /// 访问控制日志存储量，单位B
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AclSize")]
        public long? AclSize{ get; set; }

        /// <summary>
        /// 入侵防御日志存储量，单位B
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdsSize")]
        public long? IdsSize{ get; set; }

        /// <summary>
        /// 流量日志存储量，单位B
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetFlowSize")]
        public long? NetFlowSize{ get; set; }

        /// <summary>
        /// 操作日志存储量，单位B
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateSize")]
        public long? OperateSize{ get; set; }

        /// <summary>
        /// 统计时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// NDR流量日志存储量，单位B
        /// </summary>
        [JsonProperty("NDRNetflowSize")]
        public long? NDRNetflowSize{ get; set; }

        /// <summary>
        /// NDR风险日志存储量，单位B
        /// </summary>
        [JsonProperty("NDRRiskSize")]
        public long? NDRRiskSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AclSize", this.AclSize);
            this.SetParamSimple(map, prefix + "IdsSize", this.IdsSize);
            this.SetParamSimple(map, prefix + "NetFlowSize", this.NetFlowSize);
            this.SetParamSimple(map, prefix + "OperateSize", this.OperateSize);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "NDRNetflowSize", this.NDRNetflowSize);
            this.SetParamSimple(map, prefix + "NDRRiskSize", this.NDRRiskSize);
        }
    }
}

