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

    public class DeviceHistory : AbstractModel
    {
        
        /// <summary>
        /// 设备sn
        /// </summary>
        [JsonProperty("Sn")]
        public string Sn{ get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 机架名
        /// </summary>
        [JsonProperty("RackName")]
        public string RackName{ get; set; }

        /// <summary>
        /// 机位号
        /// </summary>
        [JsonProperty("PositionCode")]
        public ulong? PositionCode{ get; set; }

        /// <summary>
        /// 机房id
        /// </summary>
        [JsonProperty("IdcId")]
        public ulong? IdcId{ get; set; }

        /// <summary>
        /// 机房名称
        /// </summary>
        [JsonProperty("IdcName")]
        public string IdcName{ get; set; }

        /// <summary>
        /// 机房管理单元id
        /// </summary>
        [JsonProperty("IdcUnitId")]
        public ulong? IdcUnitId{ get; set; }

        /// <summary>
        /// 机房管理单元名称
        /// </summary>
        [JsonProperty("IdcUnitName")]
        public string IdcUnitName{ get; set; }

        /// <summary>
        /// 固资号
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 设备型号-版本，只有收货单详情返回
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// 设备高度，只有收货单详情返回
        /// </summary>
        [JsonProperty("DeviceHeight")]
        public string DeviceHeight{ get; set; }

        /// <summary>
        /// 需要万兆机位，只有收货单详情返回
        /// </summary>
        [JsonProperty("Need10GbSlot")]
        public string Need10GbSlot{ get; set; }

        /// <summary>
        /// 需要直流电，只有收货单详情返回
        /// </summary>
        [JsonProperty("NeedDCPower")]
        public string NeedDCPower{ get; set; }

        /// <summary>
        /// 需要外网，只有收货单详情返回
        /// </summary>
        [JsonProperty("NeedExtranet")]
        public string NeedExtranet{ get; set; }

        /// <summary>
        /// 需要虚拟化，只有收货单详情返回
        /// </summary>
        [JsonProperty("NeedVirtualization")]
        public string NeedVirtualization{ get; set; }

        /// <summary>
        /// 厂商,只有收货单详情返回
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// 硬件备注
        /// </summary>
        [JsonProperty("HardwareMemo")]
        public string HardwareMemo{ get; set; }

        /// <summary>
        /// 目标机架
        /// </summary>
        [JsonProperty("DstRackName")]
        public string DstRackName{ get; set; }

        /// <summary>
        /// 目标机位
        /// </summary>
        [JsonProperty("DstPositionCode")]
        public string DstPositionCode{ get; set; }

        /// <summary>
        /// 目标ip
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// 设备子类型, 其他设备/线材用
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 线材-数量，只有收货单详情返回
        /// </summary>
        [JsonProperty("Quantity")]
        public ulong? Quantity{ get; set; }

        /// <summary>
        /// 计量单位，，只有收货单详情返回，'箱', '卷', '套'
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 线材-收货凭证号，只有收货单详情返回
        /// </summary>
        [JsonProperty("ReceiptNumber")]
        public string ReceiptNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sn", this.Sn);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "RackName", this.RackName);
            this.SetParamSimple(map, prefix + "PositionCode", this.PositionCode);
            this.SetParamSimple(map, prefix + "IdcId", this.IdcId);
            this.SetParamSimple(map, prefix + "IdcName", this.IdcName);
            this.SetParamSimple(map, prefix + "IdcUnitId", this.IdcUnitId);
            this.SetParamSimple(map, prefix + "IdcUnitName", this.IdcUnitName);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "DeviceHeight", this.DeviceHeight);
            this.SetParamSimple(map, prefix + "Need10GbSlot", this.Need10GbSlot);
            this.SetParamSimple(map, prefix + "NeedDCPower", this.NeedDCPower);
            this.SetParamSimple(map, prefix + "NeedExtranet", this.NeedExtranet);
            this.SetParamSimple(map, prefix + "NeedVirtualization", this.NeedVirtualization);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "HardwareMemo", this.HardwareMemo);
            this.SetParamSimple(map, prefix + "DstRackName", this.DstRackName);
            this.SetParamSimple(map, prefix + "DstPositionCode", this.DstPositionCode);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "ReceiptNumber", this.ReceiptNumber);
        }
    }
}

