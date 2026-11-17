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

    public class AgentAppMcpServerVO : AbstractModel
    {
        
        /// <summary>
        /// <p>绑定ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>需要认证</p>
        /// </summary>
        [JsonProperty("NeedAuth")]
        public bool? NeedAuth{ get; set; }

        /// <summary>
        /// <p>凭据ID</p>
        /// </summary>
        [JsonProperty("AgentCredentialID")]
        public string AgentCredentialID{ get; set; }

        /// <summary>
        /// <p>凭据详情</p>
        /// </summary>
        [JsonProperty("AgentCredentialVO")]
        public DescribeAgentCredentialResp AgentCredentialVO{ get; set; }

        /// <summary>
        /// <p>mcp详情</p>
        /// </summary>
        [JsonProperty("McpServerVO")]
        public DescribeMcpServerResponseVO McpServerVO{ get; set; }

        /// <summary>
        /// <p>关联时间</p>
        /// </summary>
        [JsonProperty("RelateTime")]
        public string RelateTime{ get; set; }

        /// <summary>
        /// <p>应用为OAuth2认证时，sse模式请求mcp时的资源标识</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SSEResourceIdentifier")]
        public string SSEResourceIdentifier{ get; set; }

        /// <summary>
        /// <p>应用为OAuth2认证时，streamable模式请求mcp时的资源标识</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StreamableResourceIdentifier")]
        public string StreamableResourceIdentifier{ get; set; }

        /// <summary>
        /// <p>应用ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentAppID")]
        public string AgentAppID{ get; set; }

        /// <summary>
        /// <p>mcp ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("McpServerID")]
        public string McpServerID{ get; set; }

        /// <summary>
        /// <p>应用</p>
        /// </summary>
        [JsonProperty("AgentAppVO")]
        public DescribeAgentAppResp AgentAppVO{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "NeedAuth", this.NeedAuth);
            this.SetParamSimple(map, prefix + "AgentCredentialID", this.AgentCredentialID);
            this.SetParamObj(map, prefix + "AgentCredentialVO.", this.AgentCredentialVO);
            this.SetParamObj(map, prefix + "McpServerVO.", this.McpServerVO);
            this.SetParamSimple(map, prefix + "RelateTime", this.RelateTime);
            this.SetParamSimple(map, prefix + "SSEResourceIdentifier", this.SSEResourceIdentifier);
            this.SetParamSimple(map, prefix + "StreamableResourceIdentifier", this.StreamableResourceIdentifier);
            this.SetParamSimple(map, prefix + "AgentAppID", this.AgentAppID);
            this.SetParamSimple(map, prefix + "McpServerID", this.McpServerID);
            this.SetParamObj(map, prefix + "AgentAppVO.", this.AgentAppVO);
        }
    }
}

