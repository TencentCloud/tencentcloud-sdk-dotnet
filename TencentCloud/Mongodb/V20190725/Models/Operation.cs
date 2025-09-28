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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Operation : AbstractModel
    {
        
        /// <summary>
        /// 操作所在的分片名称。请通过接口 [DescribeCurrentOp](https://cloud.tencent.com/document/product/240/48120) 查询分片名称。
        /// </summary>
        [JsonProperty("ReplicaSetName")]
        public string ReplicaSetName{ get; set; }

        /// <summary>
        /// 操作所在的节点名。请通过接口 [DescribeCurrentOp](https://cloud.tencent.com/document/product/240/48120) 查询节点名称。
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 操作序号。请通过接口 [DescribeCurrentOp](https://cloud.tencent.com/document/product/240/48120) 查询操作序号。
        /// </summary>
        [JsonProperty("OpId")]
        public long? OpId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReplicaSetName", this.ReplicaSetName);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "OpId", this.OpId);
        }
    }
}

