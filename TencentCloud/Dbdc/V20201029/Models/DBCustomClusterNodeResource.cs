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

    public class DBCustomClusterNodeResource : AbstractModel
    {
        
        /// <summary>
        /// <p>节点ID</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>节点物理资源总容量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Capacity")]
        public MetaResource Capacity{ get; set; }

        /// <summary>
        /// <p>节点可分配容量= Capacity - 系统预留</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Allocatable")]
        public MetaResource Allocatable{ get; set; }

        /// <summary>
        /// <p>节点上所有非终态 Pod 的 requests 申请量之和（含系统 Pod）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Requests")]
        public MetaResource Requests{ get; set; }

        /// <summary>
        /// <p>节点上所有非终态 Pod 的 limits 上限之和（含系统 Pod）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Limits")]
        public MetaResource Limits{ get; set; }

        /// <summary>
        /// <p>节点可再调度余量 = max(0, Allocatable - Requests)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Available")]
        public MetaResource Available{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamObj(map, prefix + "Capacity.", this.Capacity);
            this.SetParamObj(map, prefix + "Allocatable.", this.Allocatable);
            this.SetParamObj(map, prefix + "Requests.", this.Requests);
            this.SetParamObj(map, prefix + "Limits.", this.Limits);
            this.SetParamObj(map, prefix + "Available.", this.Available);
        }
    }
}

