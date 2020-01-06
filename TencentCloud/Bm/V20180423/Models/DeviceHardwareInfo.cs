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

    public class DeviceHardwareInfo : AbstractModel
    {
        
        /// <summary>
        /// 设备实例 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 是否自定义机型
        /// </summary>
        [JsonProperty("IsElastic")]
        public ulong? IsElastic{ get; set; }

        /// <summary>
        /// 机型计费模式，1 为预付费，2 为后付费
        /// </summary>
        [JsonProperty("CpmPayMode")]
        public ulong? CpmPayMode{ get; set; }

        /// <summary>
        /// 自定义机型，CPU 型号 ID（非自定义机型返回0）
        /// </summary>
        [JsonProperty("CpuId")]
        public ulong? CpuId{ get; set; }

        /// <summary>
        /// 自定义机型，内存大小, 单位 GB（非自定义机型返回0）
        /// </summary>
        [JsonProperty("Mem")]
        public ulong? Mem{ get; set; }

        /// <summary>
        /// 是否有 RAID 卡，0：没有 RAID 卡； 1：有 RAID 卡
        /// </summary>
        [JsonProperty("ContainRaidCard")]
        public ulong? ContainRaidCard{ get; set; }

        /// <summary>
        /// 自定义机型系统盘类型ID（若没有则返回0）
        /// </summary>
        [JsonProperty("SystemDiskTypeId")]
        public ulong? SystemDiskTypeId{ get; set; }

        /// <summary>
        /// 自定义机型系统盘数量（若没有则返回0）
        /// </summary>
        [JsonProperty("SystemDiskCount")]
        public ulong? SystemDiskCount{ get; set; }

        /// <summary>
        /// 自定义机型数据盘类型 ID（若没有则返回0）
        /// </summary>
        [JsonProperty("DataDiskTypeId")]
        public ulong? DataDiskTypeId{ get; set; }

        /// <summary>
        /// 自定义机型数据盘数量（若没有则返回0）
        /// </summary>
        [JsonProperty("DataDiskCount")]
        public ulong? DataDiskCount{ get; set; }

        /// <summary>
        /// CPU 型号描述
        /// </summary>
        [JsonProperty("CpuDescription")]
        public string CpuDescription{ get; set; }

        /// <summary>
        /// 内存描述
        /// </summary>
        [JsonProperty("MemDescription")]
        public string MemDescription{ get; set; }

        /// <summary>
        /// 磁盘描述
        /// </summary>
        [JsonProperty("DiskDescription")]
        public string DiskDescription{ get; set; }

        /// <summary>
        /// 网卡描述
        /// </summary>
        [JsonProperty("NicDescription")]
        public string NicDescription{ get; set; }

        /// <summary>
        /// 是否支持 RAID 的描述
        /// </summary>
        [JsonProperty("RaidDescription")]
        public string RaidDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "IsElastic", this.IsElastic);
            this.SetParamSimple(map, prefix + "CpmPayMode", this.CpmPayMode);
            this.SetParamSimple(map, prefix + "CpuId", this.CpuId);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "ContainRaidCard", this.ContainRaidCard);
            this.SetParamSimple(map, prefix + "SystemDiskTypeId", this.SystemDiskTypeId);
            this.SetParamSimple(map, prefix + "SystemDiskCount", this.SystemDiskCount);
            this.SetParamSimple(map, prefix + "DataDiskTypeId", this.DataDiskTypeId);
            this.SetParamSimple(map, prefix + "DataDiskCount", this.DataDiskCount);
            this.SetParamSimple(map, prefix + "CpuDescription", this.CpuDescription);
            this.SetParamSimple(map, prefix + "MemDescription", this.MemDescription);
            this.SetParamSimple(map, prefix + "DiskDescription", this.DiskDescription);
            this.SetParamSimple(map, prefix + "NicDescription", this.NicDescription);
            this.SetParamSimple(map, prefix + "RaidDescription", this.RaidDescription);
        }
    }
}

