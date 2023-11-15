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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceStatusStatRes : AbstractModel
    {
        
        /// <summary>
        /// 工作空间Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public long? WorkspaceId{ get; set; }

        /// <summary>
        /// 汇总数。在线（正常+故障） + 离线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 正常数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NormalSum")]
        public long? NormalSum{ get; set; }

        /// <summary>
        /// 离线数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineSum")]
        public long? OfflineSum{ get; set; }

        /// <summary>
        /// 故障数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FaultSum")]
        public long? FaultSum{ get; set; }

        /// <summary>
        /// 设备类型概览列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceTypeOverviewSet")]
        public DeviceTypeOverview[] DeviceTypeOverviewSet{ get; set; }

        /// <summary>
        /// 设备类型统计列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatLevelSet")]
        public StatLevel[] StatLevelSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "NormalSum", this.NormalSum);
            this.SetParamSimple(map, prefix + "OfflineSum", this.OfflineSum);
            this.SetParamSimple(map, prefix + "FaultSum", this.FaultSum);
            this.SetParamArrayObj(map, prefix + "DeviceTypeOverviewSet.", this.DeviceTypeOverviewSet);
            this.SetParamArrayObj(map, prefix + "StatLevelSet.", this.StatLevelSet);
        }
    }
}

