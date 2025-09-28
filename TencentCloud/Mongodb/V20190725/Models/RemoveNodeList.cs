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

    public class RemoveNodeList : AbstractModel
    {
        
        /// <summary>
        /// 需要删除的节点角色。
        /// - SECONDARY：Mongod 从节点。
        /// - READONLY：只读节点。
        /// - MONGOS：Mongos 节点。
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 要删除的节点 ID。分片集群须指定一组分片要删除的节点名称即可，其余分片对该组对齐。
        /// - 获取方式：登录 [MongoDB控制台](https://console.cloud.tencent.com/mongodb)，在**节点管理**页签，可获取**节点 ID**。
        /// - 特别说明：分片集群同一节点上的分片，仅需指定0分片节点 ID 即可。例如：cmgo-6hfk\*\*\*\*\_0-node-primary。
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 节点所对应的可用区。当前支持可用区信息，请参见[地域和可用区](https://cloud.tencent.com/document/product/240/3637)。
        /// - 单可用区，所有节点在同一可用区。
        /// - 多可用区：当前标准规格是三可用区分布，主从节点不在同一可用区，需注意配置所删除节点对应的可用区，且删除后必须满足任意2个可用区节点数大于第3个可用区原则。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
        }
    }
}

