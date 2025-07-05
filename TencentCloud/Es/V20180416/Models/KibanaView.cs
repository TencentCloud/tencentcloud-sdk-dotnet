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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KibanaView : AbstractModel
    {
        
        /// <summary>
        /// Kibana节点IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 节点总磁盘大小
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 磁盘使用率
        /// </summary>
        [JsonProperty("DiskUsage")]
        public float? DiskUsage{ get; set; }

        /// <summary>
        /// 节点内存大小
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// 内存使用率
        /// </summary>
        [JsonProperty("MemUsage")]
        public float? MemUsage{ get; set; }

        /// <summary>
        /// 节点cpu个数
        /// </summary>
        [JsonProperty("CpuNum")]
        public long? CpuNum{ get; set; }

        /// <summary>
        /// cpu使用率
        /// </summary>
        [JsonProperty("CpuUsage")]
        public float? CpuUsage{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// ts-0noqayxu-az6-hot-03222010-0
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "MemUsage", this.MemUsage);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "CpuUsage", this.CpuUsage);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
        }
    }
}

