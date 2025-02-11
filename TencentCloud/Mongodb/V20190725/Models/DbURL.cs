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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DbURL : AbstractModel
    {
        
        /// <summary>
        /// 指 URI 类别，包括：，
        /// - CLUSTER_ALL：指通过该 URI 连接库实例的主节点，可读写。
        /// - CLUSTER_READ_READONLY：指通过该 URI 连接实例只读节点。
        /// - CLUSTER_READ_SECONDARY：指通过该 URI 连接实例从节点。
        /// - CLUSTER_READ_SECONDARY_AND_READONLY：指通过该 URI 连接实例只读从节点。
        /// - CLUSTER_PRIMARY_AND_SECONDARY：指通过该 URI 连接实例 主节点与从节点。
        /// - MONGOS_ALL：指通过该  URI 连接每个 Mongos 节点，可读写。
        /// - MONGOS_READ_READONLY：指通过该 URI 连接 Mongos 的只读节点。
        /// - MONGOS_READ_SECONDARY：指通过该 URI 连接 Mongos 的从节点。
        /// - MONGOS_READ_PRIMARY_AND_SECONDARY：指通过该URI 连接 Mongos 的主节点与从节点。
        /// - MONGOS_READ_SECONDARY_AND_READONLY：指通过该URI 连接 Mongos 的从节点与只读节点。
        /// </summary>
        [JsonProperty("URLType")]
        public string URLType{ get; set; }

        /// <summary>
        /// 实例 URI 形式的连接串访问地址示例。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "URLType", this.URLType);
            this.SetParamSimple(map, prefix + "Address", this.Address);
        }
    }
}

