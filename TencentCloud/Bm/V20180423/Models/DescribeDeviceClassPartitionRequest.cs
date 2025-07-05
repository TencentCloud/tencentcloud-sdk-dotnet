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

    public class DescribeDeviceClassPartitionRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备类型代号。代号通过接口[查询设备型号(DescribeDeviceClass)](https://cloud.tencent.com/document/api/386/32911)查询。标准机型需要传入此参数。虽是可选参数，但DeviceClassCode和InstanceId参数，必须要填写一个。
        /// </summary>
        [JsonProperty("DeviceClassCode")]
        public string DeviceClassCode{ get; set; }

        /// <summary>
        /// 需要查询自定义机型RAID信息时，传入自定义机型实例ID。InstanceId存在时其余参数失效。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// CPU型号ID，查询自定义机型时需要传入
        /// </summary>
        [JsonProperty("CpuId")]
        public ulong? CpuId{ get; set; }

        /// <summary>
        /// 内存大小，单位为G，查询自定义机型时需要传入
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// 是否有RAID卡，取值：1(有) 0(无)。查询自定义机型时需要传入
        /// </summary>
        [JsonProperty("ContainRaidCard")]
        public ulong? ContainRaidCard{ get; set; }

        /// <summary>
        /// 系统盘类型ID，查询自定义机型时需要传入
        /// </summary>
        [JsonProperty("SystemDiskTypeId")]
        public ulong? SystemDiskTypeId{ get; set; }

        /// <summary>
        /// 系统盘数量，查询自定义机型时需要传入
        /// </summary>
        [JsonProperty("SystemDiskCount")]
        public ulong? SystemDiskCount{ get; set; }

        /// <summary>
        /// 数据盘类型ID，查询自定义机型时可传入
        /// </summary>
        [JsonProperty("DataDiskTypeId")]
        public ulong? DataDiskTypeId{ get; set; }

        /// <summary>
        /// 数据盘数量，查询自定义机型时可传入
        /// </summary>
        [JsonProperty("DataDiskCount")]
        public ulong? DataDiskCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceClassCode", this.DeviceClassCode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
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

