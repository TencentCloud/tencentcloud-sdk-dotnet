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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserVpcConnectionInfo : AbstractModel
    {
        
        /// <summary>
        /// 引擎网络ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineNetworkId")]
        public string EngineNetworkId{ get; set; }

        /// <summary>
        /// 用户vpcid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserVpcId")]
        public string UserVpcId{ get; set; }

        /// <summary>
        /// 用户终端节点ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserVpcEndpointId")]
        public string UserVpcEndpointId{ get; set; }

        /// <summary>
        /// 用户终端节点名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserVpcEndpointName")]
        public string UserVpcEndpointName{ get; set; }

        /// <summary>
        /// 接入点信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessConnectionInfos")]
        public string[] AccessConnectionInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineNetworkId", this.EngineNetworkId);
            this.SetParamSimple(map, prefix + "UserVpcId", this.UserVpcId);
            this.SetParamSimple(map, prefix + "UserVpcEndpointId", this.UserVpcEndpointId);
            this.SetParamSimple(map, prefix + "UserVpcEndpointName", this.UserVpcEndpointName);
            this.SetParamArraySimple(map, prefix + "AccessConnectionInfos.", this.AccessConnectionInfos);
        }
    }
}

