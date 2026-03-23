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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentAppMcpServerDTO : AbstractModel
    {
        
        /// <summary>
        /// mcp server id
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 是否需要鉴权
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NeedAuth")]
        public bool? NeedAuth{ get; set; }

        /// <summary>
        /// 凭据代填的ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentCredentialID")]
        public string AgentCredentialID{ get; set; }

        /// <summary>
        /// 应用为OAuth2认证时，sse模式请求mcp时的资源标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SSEResourceIdentifier")]
        public string SSEResourceIdentifier{ get; set; }

        /// <summary>
        /// 应用为OAuth2认证时，streamable模式请求mcp时的资源标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StreamableResourceIdentifier")]
        public string StreamableResourceIdentifier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "NeedAuth", this.NeedAuth);
            this.SetParamSimple(map, prefix + "AgentCredentialID", this.AgentCredentialID);
            this.SetParamSimple(map, prefix + "SSEResourceIdentifier", this.SSEResourceIdentifier);
            this.SetParamSimple(map, prefix + "StreamableResourceIdentifier", this.StreamableResourceIdentifier);
        }
    }
}

