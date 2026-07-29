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

    public class DescribeDBCustomClusterResourcesResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>参与汇总的工作节点总数（不含控制面节点）</p><p>单位：台</p>
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// <p>集群所有节点的资源物理总容量之和</p>
        /// </summary>
        [JsonProperty("Capacity")]
        public MetaResource Capacity{ get; set; }

        /// <summary>
        /// <p>集群所有节点的可分配容量之和（= Capacity - 系统预留）</p>
        /// </summary>
        [JsonProperty("Allocatable")]
        public MetaResource Allocatable{ get; set; }

        /// <summary>
        /// <p>集群所有非终态 Pod 的 requests 申请量之和（含系统 Pod）</p>
        /// </summary>
        [JsonProperty("Requests")]
        public MetaResource Requests{ get; set; }

        /// <summary>
        /// <p>集群所有非终态 Pod 的 limits 上限之和（含系统 Pod，Pods 字段无语义，固定为 0）</p>
        /// </summary>
        [JsonProperty("Limits")]
        public MetaResource Limits{ get; set; }

        /// <summary>
        /// <p>集群可再调度余量（所有节点 max(0, Allocatable - Requests) 累加求和）</p>
        /// </summary>
        [JsonProperty("Available")]
        public MetaResource Available{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamObj(map, prefix + "Capacity.", this.Capacity);
            this.SetParamObj(map, prefix + "Allocatable.", this.Allocatable);
            this.SetParamObj(map, prefix + "Requests.", this.Requests);
            this.SetParamObj(map, prefix + "Limits.", this.Limits);
            this.SetParamObj(map, prefix + "Available.", this.Available);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

