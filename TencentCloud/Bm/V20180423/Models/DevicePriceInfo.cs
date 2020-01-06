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

    public class DevicePriceInfo : AbstractModel
    {
        
        /// <summary>
        /// 物理机ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("DeviceClassCode")]
        public string DeviceClassCode{ get; set; }

        /// <summary>
        /// 是否是弹性机型，1：是，0：否
        /// </summary>
        [JsonProperty("IsElastic")]
        public ulong? IsElastic{ get; set; }

        /// <summary>
        /// 付费模式ID, 1:预付费; 2:后付费; 3:预付费转后付费中
        /// </summary>
        [JsonProperty("CpmPayMode")]
        public ulong? CpmPayMode{ get; set; }

        /// <summary>
        /// Cpu信息描述
        /// </summary>
        [JsonProperty("CpuDescription")]
        public string CpuDescription{ get; set; }

        /// <summary>
        /// 内存信息描述
        /// </summary>
        [JsonProperty("MemDescription")]
        public string MemDescription{ get; set; }

        /// <summary>
        /// 硬盘信息描述
        /// </summary>
        [JsonProperty("DiskDescription")]
        public string DiskDescription{ get; set; }

        /// <summary>
        /// 网卡信息描述
        /// </summary>
        [JsonProperty("NicDescription")]
        public string NicDescription{ get; set; }

        /// <summary>
        /// Gpu信息描述
        /// </summary>
        [JsonProperty("GpuDescription")]
        public string GpuDescription{ get; set; }

        /// <summary>
        /// Raid信息描述
        /// </summary>
        [JsonProperty("RaidDescription")]
        public string RaidDescription{ get; set; }

        /// <summary>
        /// 客户的单价
        /// </summary>
        [JsonProperty("Price")]
        public ulong? Price{ get; set; }

        /// <summary>
        /// 刊例单价
        /// </summary>
        [JsonProperty("NormalPrice")]
        public ulong? NormalPrice{ get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [JsonProperty("TotalCost")]
        public ulong? TotalCost{ get; set; }

        /// <summary>
        /// 折扣价
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public ulong? RealTotalCost{ get; set; }

        /// <summary>
        /// 计费时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 计费时长单位, m:按月计费; d:按天计费
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("GoodsCount")]
        public ulong? GoodsCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DeviceClassCode", this.DeviceClassCode);
            this.SetParamSimple(map, prefix + "IsElastic", this.IsElastic);
            this.SetParamSimple(map, prefix + "CpmPayMode", this.CpmPayMode);
            this.SetParamSimple(map, prefix + "CpuDescription", this.CpuDescription);
            this.SetParamSimple(map, prefix + "MemDescription", this.MemDescription);
            this.SetParamSimple(map, prefix + "DiskDescription", this.DiskDescription);
            this.SetParamSimple(map, prefix + "NicDescription", this.NicDescription);
            this.SetParamSimple(map, prefix + "GpuDescription", this.GpuDescription);
            this.SetParamSimple(map, prefix + "RaidDescription", this.RaidDescription);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "NormalPrice", this.NormalPrice);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "GoodsCount", this.GoodsCount);
        }
    }
}

