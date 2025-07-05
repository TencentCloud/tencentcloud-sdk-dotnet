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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// 集群状态，0：运行中，1：不在运行
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 读写集群剩余内存容量，单位GB
        /// </summary>
        [JsonProperty("ReadWriteTotalLeaveMemory")]
        public float? ReadWriteTotalLeaveMemory{ get; set; }

        /// <summary>
        /// 读写集群剩余磁盘容量，单位GB
        /// </summary>
        [JsonProperty("ReadWriteTotalLeaveDisk")]
        public float? ReadWriteTotalLeaveDisk{ get; set; }

        /// <summary>
        /// 读写集群总内存容量，单位GB
        /// </summary>
        [JsonProperty("ReadWriteTotalMemory")]
        public float? ReadWriteTotalMemory{ get; set; }

        /// <summary>
        /// 读写集群总磁盘容量，单位GB
        /// </summary>
        [JsonProperty("ReadWriteTotalDisk")]
        public float? ReadWriteTotalDisk{ get; set; }

        /// <summary>
        /// 只读集群剩余内存容量，单位GB
        /// </summary>
        [JsonProperty("ReadOnlyTotalLeaveMemory")]
        public float? ReadOnlyTotalLeaveMemory{ get; set; }

        /// <summary>
        /// 只读集群剩余磁盘容量，单位GB
        /// </summary>
        [JsonProperty("ReadOnlyTotalLeaveDisk")]
        public float? ReadOnlyTotalLeaveDisk{ get; set; }

        /// <summary>
        /// 只读集群总内存容量，单位GB
        /// </summary>
        [JsonProperty("ReadOnlyTotalMemory")]
        public float? ReadOnlyTotalMemory{ get; set; }

        /// <summary>
        /// 只读集群总磁盘容量，单位GB
        /// </summary>
        [JsonProperty("ReadOnlyTotalDisk")]
        public float? ReadOnlyTotalDisk{ get; set; }

        /// <summary>
        /// 集群设备详情
        /// </summary>
        [JsonProperty("InstanceDeviceInfos")]
        public InstanceDeviceInfo[] InstanceDeviceInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ReadWriteTotalLeaveMemory", this.ReadWriteTotalLeaveMemory);
            this.SetParamSimple(map, prefix + "ReadWriteTotalLeaveDisk", this.ReadWriteTotalLeaveDisk);
            this.SetParamSimple(map, prefix + "ReadWriteTotalMemory", this.ReadWriteTotalMemory);
            this.SetParamSimple(map, prefix + "ReadWriteTotalDisk", this.ReadWriteTotalDisk);
            this.SetParamSimple(map, prefix + "ReadOnlyTotalLeaveMemory", this.ReadOnlyTotalLeaveMemory);
            this.SetParamSimple(map, prefix + "ReadOnlyTotalLeaveDisk", this.ReadOnlyTotalLeaveDisk);
            this.SetParamSimple(map, prefix + "ReadOnlyTotalMemory", this.ReadOnlyTotalMemory);
            this.SetParamSimple(map, prefix + "ReadOnlyTotalDisk", this.ReadOnlyTotalDisk);
            this.SetParamArrayObj(map, prefix + "InstanceDeviceInfos.", this.InstanceDeviceInfos);
        }
    }
}

