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

    public class ProxyNodeInfo : AbstractModel
    {
        
        /// <summary>
        /// 代理节点ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyNodeId")]
        public string ProxyNodeId{ get; set; }

        /// <summary>
        /// 节点当前连接数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyNodeConnections")]
        public ulong? ProxyNodeConnections{ get; set; }

        /// <summary>
        /// cup
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyNodeCpu")]
        public ulong? ProxyNodeCpu{ get; set; }

        /// <summary>
        /// 内存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyNodeMem")]
        public ulong? ProxyNodeMem{ get; set; }

        /// <summary>
        /// 节点状态：
        /// init（申请中）
        /// online（运行中）
        /// offline（离线中）
        /// destroy（已销毁）
        /// recovering（故障恢复中）
        /// error（节点故障）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyStatus")]
        public string ProxyStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyNodeId", this.ProxyNodeId);
            this.SetParamSimple(map, prefix + "ProxyNodeConnections", this.ProxyNodeConnections);
            this.SetParamSimple(map, prefix + "ProxyNodeCpu", this.ProxyNodeCpu);
            this.SetParamSimple(map, prefix + "ProxyNodeMem", this.ProxyNodeMem);
            this.SetParamSimple(map, prefix + "ProxyStatus", this.ProxyStatus);
        }
    }
}

