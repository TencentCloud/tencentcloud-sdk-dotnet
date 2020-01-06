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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceMonitorInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例CPU监控数据
        /// </summary>
        [JsonProperty("Cpu")]
        public DeviceCpuInfo Cpu{ get; set; }

        /// <summary>
        /// 实例内存监控数据
        /// </summary>
        [JsonProperty("Mem")]
        public DeviceMemInfo Mem{ get; set; }

        /// <summary>
        /// 实例网络监控数据
        /// </summary>
        [JsonProperty("Net")]
        public DeviceNetInfo Net{ get; set; }

        /// <summary>
        /// 实例磁盘监控数据
        /// </summary>
        [JsonProperty("Disk")]
        public DeviceDiskInfo Disk{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Cpu.", this.Cpu);
            this.SetParamObj(map, prefix + "Mem.", this.Mem);
            this.SetParamObj(map, prefix + "Net.", this.Net);
            this.SetParamObj(map, prefix + "Disk.", this.Disk);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

