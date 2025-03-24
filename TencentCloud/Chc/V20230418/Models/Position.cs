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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Position : AbstractModel
    {
        
        /// <summary>
        /// 机位ID
        /// </summary>
        [JsonProperty("PositionId")]
        public ulong? PositionId{ get; set; }

        /// <summary>
        /// 机位高度
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 机位编号
        /// </summary>
        [JsonProperty("PositionCode")]
        public string PositionCode{ get; set; }

        /// <summary>
        /// 机位状态,0 空闲,1 已用,2 不可用,3 预占用,4 预留
        /// </summary>
        [JsonProperty("PositionStatus")]
        public ulong? PositionStatus{ get; set; }

        /// <summary>
        /// 设备规划类型ID
        /// </summary>
        [JsonProperty("PlanDeviceType")]
        public long? PlanDeviceType{ get; set; }

        /// <summary>
        /// 机位所属的机房管理单元ID
        /// </summary>
        [JsonProperty("IdcUnitId")]
        public ulong? IdcUnitId{ get; set; }

        /// <summary>
        /// 机位所属的机架ID
        /// </summary>
        [JsonProperty("RackId")]
        public ulong? RackId{ get; set; }

        /// <summary>
        /// 机位所属的机架名称
        /// </summary>
        [JsonProperty("RackName")]
        public string RackName{ get; set; }

        /// <summary>
        /// 机位所属的机房管理单元名称
        /// </summary>
        [JsonProperty("IdcUnitName")]
        public string IdcUnitName{ get; set; }

        /// <summary>
        /// 机位所属的机房名称
        /// </summary>
        [JsonProperty("IdcName")]
        public string IdcName{ get; set; }

        /// <summary>
        /// 机位所属的机房ID
        /// </summary>
        [JsonProperty("IdcId")]
        public ulong? IdcId{ get; set; }

        /// <summary>
        /// 机位上如果有设备，该字段代表设备的 SN 码，如果是空闲机位，不返回该字段。
        /// </summary>
        [JsonProperty("Sn")]
        public string Sn{ get; set; }

        /// <summary>
        /// 机位上如果有设备，该字段代表设备的固资号，如果是空闲机位，不返回该字段。
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 机位上如果有设备，该字段代表设备的设备型号加版本号，如果是空闲机位，不返回该字段。
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PositionId", this.PositionId);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "PositionCode", this.PositionCode);
            this.SetParamSimple(map, prefix + "PositionStatus", this.PositionStatus);
            this.SetParamSimple(map, prefix + "PlanDeviceType", this.PlanDeviceType);
            this.SetParamSimple(map, prefix + "IdcUnitId", this.IdcUnitId);
            this.SetParamSimple(map, prefix + "RackId", this.RackId);
            this.SetParamSimple(map, prefix + "RackName", this.RackName);
            this.SetParamSimple(map, prefix + "IdcUnitName", this.IdcUnitName);
            this.SetParamSimple(map, prefix + "IdcName", this.IdcName);
            this.SetParamSimple(map, prefix + "IdcId", this.IdcId);
            this.SetParamSimple(map, prefix + "Sn", this.Sn);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
        }
    }
}

