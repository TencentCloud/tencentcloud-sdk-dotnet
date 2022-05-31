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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceInfo : AbstractModel
    {
        
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public long? DeviceId{ get; set; }

        /// <summary>
        /// 设备No
        /// </summary>
        [JsonProperty("DeviceNo")]
        public string DeviceNo{ get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("DevClass")]
        public string DevClass{ get; set; }

        /// <summary>
        /// 设备总内存，单位GB
        /// </summary>
        [JsonProperty("MaxMemory")]
        public float? MaxMemory{ get; set; }

        /// <summary>
        /// 设备总磁盘，单位GB
        /// </summary>
        [JsonProperty("MaxDisk")]
        public float? MaxDisk{ get; set; }

        /// <summary>
        /// 设备剩余内存，单位GB
        /// </summary>
        [JsonProperty("RestMemory")]
        public float? RestMemory{ get; set; }

        /// <summary>
        /// 设备剩余磁盘，单位GB
        /// </summary>
        [JsonProperty("RestDisk")]
        public float? RestDisk{ get; set; }

        /// <summary>
        /// 设备机器个数
        /// </summary>
        [JsonProperty("RawDeviceNum")]
        public ulong? RawDeviceNum{ get; set; }

        /// <summary>
        /// 数据库实例个数
        /// </summary>
        [JsonProperty("InstanceNum")]
        public ulong? InstanceNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "DeviceNo", this.DeviceNo);
            this.SetParamSimple(map, prefix + "DevClass", this.DevClass);
            this.SetParamSimple(map, prefix + "MaxMemory", this.MaxMemory);
            this.SetParamSimple(map, prefix + "MaxDisk", this.MaxDisk);
            this.SetParamSimple(map, prefix + "RestMemory", this.RestMemory);
            this.SetParamSimple(map, prefix + "RestDisk", this.RestDisk);
            this.SetParamSimple(map, prefix + "RawDeviceNum", this.RawDeviceNum);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
        }
    }
}

