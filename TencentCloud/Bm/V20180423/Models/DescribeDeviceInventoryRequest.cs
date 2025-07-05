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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceInventoryRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("DeviceClassCode")]
        public string DeviceClassCode{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// CPU型号ID，查询自定义机型时必填
        /// </summary>
        [JsonProperty("CpuId")]
        public ulong? CpuId{ get; set; }

        /// <summary>
        /// 内存大小，单位为G，查询自定义机型时必填
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// 是否有RAID卡，取值：1(有) 0(无)，查询自定义机型时必填
        /// </summary>
        [JsonProperty("ContainRaidCard")]
        public ulong? ContainRaidCard{ get; set; }

        /// <summary>
        /// 系统盘类型ID，查询自定义机型时必填
        /// </summary>
        [JsonProperty("SystemDiskTypeId")]
        public ulong? SystemDiskTypeId{ get; set; }

        /// <summary>
        /// 系统盘数量，查询自定义机型时必填
        /// </summary>
        [JsonProperty("SystemDiskCount")]
        public ulong? SystemDiskCount{ get; set; }

        /// <summary>
        /// 数据盘类型ID，查询自定义机型时可填
        /// </summary>
        [JsonProperty("DataDiskTypeId")]
        public ulong? DataDiskTypeId{ get; set; }

        /// <summary>
        /// 数据盘数量，查询自定义机型时可填
        /// </summary>
        [JsonProperty("DataDiskCount")]
        public ulong? DataDiskCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "DeviceClassCode", this.DeviceClassCode);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CpuId", this.CpuId);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "ContainRaidCard", this.ContainRaidCard);
            this.SetParamSimple(map, prefix + "SystemDiskTypeId", this.SystemDiskTypeId);
            this.SetParamSimple(map, prefix + "SystemDiskCount", this.SystemDiskCount);
            this.SetParamSimple(map, prefix + "DataDiskTypeId", this.DataDiskTypeId);
            this.SetParamSimple(map, prefix + "DataDiskCount", this.DataDiskCount);
        }
    }
}

