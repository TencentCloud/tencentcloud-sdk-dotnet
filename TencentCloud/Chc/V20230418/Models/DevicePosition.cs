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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DevicePosition : AbstractModel
    {
        
        /// <summary>
        /// 设备SN
        /// </summary>
        [JsonProperty("Sn")]
        public string Sn{ get; set; }

        /// <summary>
        /// 机架名称
        /// </summary>
        [JsonProperty("RackName")]
        public string RackName{ get; set; }

        /// <summary>
        /// 机房管理单元ID
        /// </summary>
        [JsonProperty("IdcUnitId")]
        public ulong? IdcUnitId{ get; set; }

        /// <summary>
        /// 机房名称
        /// </summary>
        [JsonProperty("IdcName")]
        public string IdcName{ get; set; }

        /// <summary>
        /// 机房管理单元名称
        /// </summary>
        [JsonProperty("IdcUnitName")]
        public string IdcUnitName{ get; set; }

        /// <summary>
        /// 设备固资。只有服务器设备才需要这个值
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 机位编号，只有服务器设备才需要传这个值
        /// </summary>
        [JsonProperty("PositionCode")]
        public ulong? PositionCode{ get; set; }

        /// <summary>
        /// server 代表服务器，netDevice 代表网络设备
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sn", this.Sn);
            this.SetParamSimple(map, prefix + "RackName", this.RackName);
            this.SetParamSimple(map, prefix + "IdcUnitId", this.IdcUnitId);
            this.SetParamSimple(map, prefix + "IdcName", this.IdcName);
            this.SetParamSimple(map, prefix + "IdcUnitName", this.IdcUnitName);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "PositionCode", this.PositionCode);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
        }
    }
}

