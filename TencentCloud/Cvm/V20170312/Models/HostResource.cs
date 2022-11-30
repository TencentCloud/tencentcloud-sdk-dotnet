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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostResource : AbstractModel
    {
        
        /// <summary>
        /// 专用宿主机实例总CPU核数
        /// </summary>
        [JsonProperty("CpuTotal")]
        public ulong? CpuTotal{ get; set; }

        /// <summary>
        /// 专用宿主机实例可用CPU核数
        /// </summary>
        [JsonProperty("CpuAvailable")]
        public ulong? CpuAvailable{ get; set; }

        /// <summary>
        /// 专用宿主机实例总内存大小（单位为:GiB）
        /// </summary>
        [JsonProperty("MemTotal")]
        public float? MemTotal{ get; set; }

        /// <summary>
        /// 专用宿主机实例可用内存大小（单位为:GiB）
        /// </summary>
        [JsonProperty("MemAvailable")]
        public float? MemAvailable{ get; set; }

        /// <summary>
        /// 专用宿主机实例总磁盘大小（单位为:GiB）
        /// </summary>
        [JsonProperty("DiskTotal")]
        public ulong? DiskTotal{ get; set; }

        /// <summary>
        /// 专用宿主机实例可用磁盘大小（单位为:GiB）
        /// </summary>
        [JsonProperty("DiskAvailable")]
        public ulong? DiskAvailable{ get; set; }

        /// <summary>
        /// 专用宿主机实例磁盘类型
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 专用宿主机实例总GPU卡数
        /// </summary>
        [JsonProperty("GpuTotal")]
        public ulong? GpuTotal{ get; set; }

        /// <summary>
        /// 专用宿主机实例可用GPU卡数
        /// </summary>
        [JsonProperty("GpuAvailable")]
        public ulong? GpuAvailable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CpuTotal", this.CpuTotal);
            this.SetParamSimple(map, prefix + "CpuAvailable", this.CpuAvailable);
            this.SetParamSimple(map, prefix + "MemTotal", this.MemTotal);
            this.SetParamSimple(map, prefix + "MemAvailable", this.MemAvailable);
            this.SetParamSimple(map, prefix + "DiskTotal", this.DiskTotal);
            this.SetParamSimple(map, prefix + "DiskAvailable", this.DiskAvailable);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "GpuTotal", this.GpuTotal);
            this.SetParamSimple(map, prefix + "GpuAvailable", this.GpuAvailable);
        }
    }
}

