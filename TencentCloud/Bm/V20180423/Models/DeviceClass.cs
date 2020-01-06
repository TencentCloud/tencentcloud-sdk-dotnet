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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceClass : AbstractModel
    {
        
        /// <summary>
        /// 机型ID
        /// </summary>
        [JsonProperty("DeviceClassCode")]
        public string DeviceClassCode{ get; set; }

        /// <summary>
        /// CPU描述
        /// </summary>
        [JsonProperty("CpuDescription")]
        public string CpuDescription{ get; set; }

        /// <summary>
        /// 内存描述
        /// </summary>
        [JsonProperty("MemDescription")]
        public string MemDescription{ get; set; }

        /// <summary>
        /// 硬盘描述
        /// </summary>
        [JsonProperty("DiskDescription")]
        public string DiskDescription{ get; set; }

        /// <summary>
        /// 是否支持RAID. 0:不支持; 1:支持
        /// </summary>
        [JsonProperty("HaveRaidCard")]
        public ulong? HaveRaidCard{ get; set; }

        /// <summary>
        /// 网卡描述
        /// </summary>
        [JsonProperty("NicDescription")]
        public string NicDescription{ get; set; }

        /// <summary>
        /// GPU描述
        /// </summary>
        [JsonProperty("GpuDescription")]
        public string GpuDescription{ get; set; }

        /// <summary>
        /// 单价折扣
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// 用户刊例价格
        /// </summary>
        [JsonProperty("UnitPrice")]
        public ulong? UnitPrice{ get; set; }

        /// <summary>
        /// 实际价格
        /// </summary>
        [JsonProperty("RealPrice")]
        public ulong? RealPrice{ get; set; }

        /// <summary>
        /// 官网刊例价格
        /// </summary>
        [JsonProperty("NormalPrice")]
        public ulong? NormalPrice{ get; set; }

        /// <summary>
        /// 设备使用场景类型
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 机型系列
        /// </summary>
        [JsonProperty("Series")]
        public ulong? Series{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceClassCode", this.DeviceClassCode);
            this.SetParamSimple(map, prefix + "CpuDescription", this.CpuDescription);
            this.SetParamSimple(map, prefix + "MemDescription", this.MemDescription);
            this.SetParamSimple(map, prefix + "DiskDescription", this.DiskDescription);
            this.SetParamSimple(map, prefix + "HaveRaidCard", this.HaveRaidCard);
            this.SetParamSimple(map, prefix + "NicDescription", this.NicDescription);
            this.SetParamSimple(map, prefix + "GpuDescription", this.GpuDescription);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "RealPrice", this.RealPrice);
            this.SetParamSimple(map, prefix + "NormalPrice", this.NormalPrice);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Series", this.Series);
        }
    }
}

