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

namespace TencentCloud.Edgezone.V20260401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceTypeQuota : AbstractModel
    {
        
        /// <summary>
        /// 可用区代码。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 机型规格。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 机型家族。
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// 机型族名称
        /// </summary>
        [JsonProperty("InstanceFamilyName")]
        public string InstanceFamilyName{ get; set; }

        /// <summary>
        /// CPU核数。
        /// </summary>
        [JsonProperty("CpuCores")]
        public long? CpuCores{ get; set; }

        /// <summary>
        /// CPU类型。
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// 内存大小（GB）。
        /// </summary>
        [JsonProperty("MemoryGb")]
        public long? MemoryGb{ get; set; }

        /// <summary>
        /// 系统盘类型。
        /// </summary>
        [JsonProperty("SystemDiskType")]
        public string SystemDiskType{ get; set; }

        /// <summary>
        /// 系统盘大小（GB）。
        /// </summary>
        [JsonProperty("SystemDiskSize")]
        public long? SystemDiskSize{ get; set; }

        /// <summary>
        /// 系统盘数量。
        /// </summary>
        [JsonProperty("SystemDiskCount")]
        public ulong? SystemDiskCount{ get; set; }

        /// <summary>
        /// 数据盘类型。
        /// </summary>
        [JsonProperty("DataDiskType")]
        public string DataDiskType{ get; set; }

        /// <summary>
        /// 数据盘大小（GB）。
        /// </summary>
        [JsonProperty("DataDiskSize")]
        public long? DataDiskSize{ get; set; }

        /// <summary>
        /// 数据盘数量。
        /// </summary>
        [JsonProperty("DataDiskCount")]
        public ulong? DataDiskCount{ get; set; }

        /// <summary>
        /// 第二组数据盘类型
        /// </summary>
        [JsonProperty("SecondaryDataDiskType")]
        public string SecondaryDataDiskType{ get; set; }

        /// <summary>
        /// 第二组数据盘大小(GB)
        /// </summary>
        [JsonProperty("SecondaryDataDiskSize")]
        public long? SecondaryDataDiskSize{ get; set; }

        /// <summary>
        /// 第二组数据盘数量
        /// </summary>
        [JsonProperty("SecondaryDataDiskCount")]
        public long? SecondaryDataDiskCount{ get; set; }

        /// <summary>
        /// 磁盘描述字符串（向后兼容）。
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 网络接口类型。
        /// </summary>
        [JsonProperty("NetworkInterfaceType")]
        public string NetworkInterfaceType{ get; set; }

        /// <summary>
        /// GPU类型，无GPU时为空字符串。
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// 配额数量
        /// </summary>
        [JsonProperty("Quota")]
        public ulong? Quota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "InstanceFamilyName", this.InstanceFamilyName);
            this.SetParamSimple(map, prefix + "CpuCores", this.CpuCores);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "MemoryGb", this.MemoryGb);
            this.SetParamSimple(map, prefix + "SystemDiskType", this.SystemDiskType);
            this.SetParamSimple(map, prefix + "SystemDiskSize", this.SystemDiskSize);
            this.SetParamSimple(map, prefix + "SystemDiskCount", this.SystemDiskCount);
            this.SetParamSimple(map, prefix + "DataDiskType", this.DataDiskType);
            this.SetParamSimple(map, prefix + "DataDiskSize", this.DataDiskSize);
            this.SetParamSimple(map, prefix + "DataDiskCount", this.DataDiskCount);
            this.SetParamSimple(map, prefix + "SecondaryDataDiskType", this.SecondaryDataDiskType);
            this.SetParamSimple(map, prefix + "SecondaryDataDiskSize", this.SecondaryDataDiskSize);
            this.SetParamSimple(map, prefix + "SecondaryDataDiskCount", this.SecondaryDataDiskCount);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "NetworkInterfaceType", this.NetworkInterfaceType);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "Quota", this.Quota);
        }
    }
}

