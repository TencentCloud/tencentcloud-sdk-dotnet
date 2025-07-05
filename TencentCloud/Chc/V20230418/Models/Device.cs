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

    public class Device : AbstractModel
    {
        
        /// <summary>
        /// 设备 SN 码
        /// </summary>
        [JsonProperty("Sn")]
        public string Sn{ get; set; }

        /// <summary>
        /// 设备型号版本
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// 设备固资号。只有设备类型为服务器时才返回
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 0 自有，1 租用。只有设备类型为服务器时才返回
        /// </summary>
        [JsonProperty("SvrIsSpecial")]
        public ulong? SvrIsSpecial{ get; set; }

        /// <summary>
        /// IP。
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 设备所属的机房名称
        /// </summary>
        [JsonProperty("IdcName")]
        public string IdcName{ get; set; }

        /// <summary>
        /// 设备所属的机房ID
        /// </summary>
        [JsonProperty("IdcId")]
        public ulong? IdcId{ get; set; }

        /// <summary>
        /// 设备所属的机房管理单元ID
        /// </summary>
        [JsonProperty("IdcUnitId")]
        public ulong? IdcUnitId{ get; set; }

        /// <summary>
        /// 设备所属的机房管理单元名称
        /// </summary>
        [JsonProperty("IdcUnitName")]
        public string IdcUnitName{ get; set; }

        /// <summary>
        /// 已上架设备所在的机架ID，未上架设备不返回
        /// </summary>
        [JsonProperty("RackId")]
        public ulong? RackId{ get; set; }

        /// <summary>
        /// 服务器类型， 1 代表服务器， 7 代表 2U4S。只有设备类型为服务器时才返回
        /// </summary>
        [JsonProperty("ServerTypeId")]
        public ulong? ServerTypeId{ get; set; }

        /// <summary>
        /// 已上架设备所在的机架名称，未上架设备不返回
        /// </summary>
        [JsonProperty("RackName")]
        public string RackName{ get; set; }

        /// <summary>
        /// 已上架设备所在的机位编号，未上架设备不返回。只有设备类型为服务器时才返回
        /// </summary>
        [JsonProperty("PositionCode")]
        public ulong? PositionCode{ get; set; }

        /// <summary>
        /// 设备状态：POWER_ON 已开电 POWER_OFF 未开电 RACK_OFF 未上架 MOVING 搬迁中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 设备最近一次的开电时间，YYYY-MM-DD 格式。
        /// </summary>
        [JsonProperty("PowerOnTime")]
        public string PowerOnTime{ get; set; }

        /// <summary>
        /// 设备最近一次的上架时间，YYYY-MM-DD 格式。
        /// </summary>
        [JsonProperty("OnshelfDate")]
        public string OnshelfDate{ get; set; }

        /// <summary>
        /// 设备类型 server 服务器，netDevice 网络设备
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// 其他设备-设备子类型
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 硬件备注
        /// </summary>
        [JsonProperty("HardwareMemo")]
        public string HardwareMemo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sn", this.Sn);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "SvrIsSpecial", this.SvrIsSpecial);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "IdcName", this.IdcName);
            this.SetParamSimple(map, prefix + "IdcId", this.IdcId);
            this.SetParamSimple(map, prefix + "IdcUnitId", this.IdcUnitId);
            this.SetParamSimple(map, prefix + "IdcUnitName", this.IdcUnitName);
            this.SetParamSimple(map, prefix + "RackId", this.RackId);
            this.SetParamSimple(map, prefix + "ServerTypeId", this.ServerTypeId);
            this.SetParamSimple(map, prefix + "RackName", this.RackName);
            this.SetParamSimple(map, prefix + "PositionCode", this.PositionCode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PowerOnTime", this.PowerOnTime);
            this.SetParamSimple(map, prefix + "OnshelfDate", this.OnshelfDate);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "HardwareMemo", this.HardwareMemo);
        }
    }
}

