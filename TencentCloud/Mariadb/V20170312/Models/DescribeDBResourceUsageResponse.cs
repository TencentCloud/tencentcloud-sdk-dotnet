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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBResourceUsageResponse : AbstractModel
    {
        
        /// <summary>
        /// binlog日志磁盘可用空间,单位GB
        /// </summary>
        [JsonProperty("BinlogDiskAvailable")]
        public MonitorData BinlogDiskAvailable{ get; set; }

        /// <summary>
        /// 磁盘可用空间,单位GB
        /// </summary>
        [JsonProperty("DataDiskAvailable")]
        public MonitorData DataDiskAvailable{ get; set; }

        /// <summary>
        /// CPU利用率
        /// </summary>
        [JsonProperty("CpuUsageRate")]
        public MonitorData CpuUsageRate{ get; set; }

        /// <summary>
        /// 内存可用空间,单位GB
        /// </summary>
        [JsonProperty("MemAvailable")]
        public MonitorData MemAvailable{ get; set; }

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
            this.SetParamObj(map, prefix + "BinlogDiskAvailable.", this.BinlogDiskAvailable);
            this.SetParamObj(map, prefix + "DataDiskAvailable.", this.DataDiskAvailable);
            this.SetParamObj(map, prefix + "CpuUsageRate.", this.CpuUsageRate);
            this.SetParamObj(map, prefix + "MemAvailable.", this.MemAvailable);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

