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

    public class ClusterTopology : AbstractModel
    {
        
        /// <summary>
        /// RW 节点拓扑。
        /// 说明：NodeId 可通过 [DescribeDBInstances](https://cloud.tencent.com/document/product/236/15872) 获取。
        /// </summary>
        [JsonProperty("ReadWriteNode")]
        public ReadWriteNode ReadWriteNode{ get; set; }

        /// <summary>
        /// RO 节点拓扑。
        /// 说明：NodeId 可通过 [DescribeDBInstances](https://cloud.tencent.com/document/product/236/15872) 获取。
        /// </summary>
        [JsonProperty("ReadOnlyNodes")]
        public ReadonlyNode[] ReadOnlyNodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ReadWriteNode.", this.ReadWriteNode);
            this.SetParamArrayObj(map, prefix + "ReadOnlyNodes.", this.ReadOnlyNodes);
        }
    }
}

