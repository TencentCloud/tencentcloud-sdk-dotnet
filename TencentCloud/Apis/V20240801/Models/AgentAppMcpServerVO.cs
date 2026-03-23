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
        /// 绑定ID
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 需要认证
        /// </summary>
        [JsonProperty("NeedAuth")]
        public bool? NeedAuth{ get; set; }

        /// <summary>
        /// 凭据ID
        /// </summary>
        [JsonProperty("AgentCredentialID")]
        public string AgentCredentialID{ get; set; }

        /// <summary>
        /// 凭据详情
        /// </summary>
        [JsonProperty("AgentCredentialVO")]
        public DescribeAgentCredentialResp AgentCredentialVO{ get; set; }

        /// <summary>
        /// mcp详情
        /// </summary>
        [JsonProperty("McpServerVO")]
        public DescribeMcpServerResponseVO McpServerVO{ get; set; }

        /// <summary>
        /// 关联时间
        /// </summary>
        [JsonProperty("RelateTime")]
        public string RelateTime{ get; set; }

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
        /// 应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentAppID")]
        public string AgentAppID{ get; set; }

        /// <summary>
        /// mcp ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("McpServerID")]
        public string McpServerID{ get; set; }


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
        }
    }
}

