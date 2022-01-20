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

    public class ProxyGroups : AbstractModel
    {
        
        /// <summary>
        /// 代理基本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaseGroup")]
        public BaseGroupInfo BaseGroup{ get; set; }

        /// <summary>
        /// 代理地址信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Address")]
        public Address[] Address{ get; set; }

        /// <summary>
        /// 代理连接池信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectionPoolInfo")]
        public ConnectionPoolInfo ConnectionPoolInfo{ get; set; }

        /// <summary>
        /// 代理节点信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyNode")]
        public ProxyNodeInfo[] ProxyNode{ get; set; }

        /// <summary>
        /// 代理路由信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RWInstInfo")]
        public RWInfos RWInstInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BaseGroup.", this.BaseGroup);
            this.SetParamArrayObj(map, prefix + "Address.", this.Address);
            this.SetParamObj(map, prefix + "ConnectionPoolInfo.", this.ConnectionPoolInfo);
            this.SetParamArrayObj(map, prefix + "ProxyNode.", this.ProxyNode);
            this.SetParamObj(map, prefix + "RWInstInfo.", this.RWInstInfo);
        }
    }
}

