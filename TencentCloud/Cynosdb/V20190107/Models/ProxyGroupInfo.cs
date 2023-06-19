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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据库代理组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyGroup")]
        public ProxyGroup ProxyGroup{ get; set; }

        /// <summary>
        /// 数据库代理组读写分离信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyGroupRwInfo")]
        public ProxyGroupRwInfo ProxyGroupRwInfo{ get; set; }

        /// <summary>
        /// 数据库代理节点信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyNodes")]
        public ProxyNodeInfo[] ProxyNodes{ get; set; }

        /// <summary>
        /// 数据库代理连接池信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public ProxyConnectionPoolInfo ConnectionPool{ get; set; }

        /// <summary>
        /// 数据库代理网络信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetAddrInfos")]
        public NetAddr[] NetAddrInfos{ get; set; }

        /// <summary>
        /// 数据库代理任务集
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tasks")]
        public ObjectTask[] Tasks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ProxyGroup.", this.ProxyGroup);
            this.SetParamObj(map, prefix + "ProxyGroupRwInfo.", this.ProxyGroupRwInfo);
            this.SetParamArrayObj(map, prefix + "ProxyNodes.", this.ProxyNodes);
            this.SetParamObj(map, prefix + "ConnectionPool.", this.ConnectionPool);
            this.SetParamArrayObj(map, prefix + "NetAddrInfos.", this.NetAddrInfos);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
        }
    }
}

