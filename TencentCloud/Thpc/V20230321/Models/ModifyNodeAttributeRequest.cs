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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNodeAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>节点ID，节点ID通过调用接口 <a href="https://cloud.tencent.com/document/api/1527/89569">DescribeNodes</a>获取。</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>节点别名</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>资源的分配状态:  - IDLE: 资源空闲 - ISOLATE: 资源隔离</p>
        /// </summary>
        [JsonProperty("NodeAllocateState")]
        public string NodeAllocateState{ get; set; }

        /// <summary>
        /// <p>目标队列名</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeAllocateState", this.NodeAllocateState);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
        }
    }
}

