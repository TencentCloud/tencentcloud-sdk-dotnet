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

    public class DescribeAgentAppResp : AbstractModel
    {
        
        /// <summary>
        /// <p>租户appID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>租户ID</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>应用ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>修改时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>认证类型</p>
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// <p>apiKeys列表，脱敏</p>
        /// </summary>
        [JsonProperty("ApiKeys")]
        public string[] ApiKeys{ get; set; }

        /// <summary>
        /// <p>secretKey列表，脱敏</p>
        /// </summary>
        [JsonProperty("SecretKeys")]
        public AgentAppSecretKeyVO[] SecretKeys{ get; set; }

        /// <summary>
        /// <p>OAuth2 Resource Server ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OAuth2ResourceServerID")]
        public string OAuth2ResourceServerID{ get; set; }

        /// <summary>
        /// <p>绑定mcpServer数量</p>
        /// </summary>
        [JsonProperty("McpServersNum")]
        public long? McpServersNum{ get; set; }

        /// <summary>
        /// <p>绑定的模型服务数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelServicesNum")]
        public long? ModelServicesNum{ get; set; }

        /// <summary>
        /// <p>API认证列表</p>
        /// </summary>
        [JsonProperty("ConnectorIDs")]
        public string[] ConnectorIDs{ get; set; }

        /// <summary>
        /// <p>关联API数量</p>
        /// </summary>
        [JsonProperty("ServicesNum")]
        public long? ServicesNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamArraySimple(map, prefix + "ApiKeys.", this.ApiKeys);
            this.SetParamArrayObj(map, prefix + "SecretKeys.", this.SecretKeys);
            this.SetParamSimple(map, prefix + "OAuth2ResourceServerID", this.OAuth2ResourceServerID);
            this.SetParamSimple(map, prefix + "McpServersNum", this.McpServersNum);
            this.SetParamSimple(map, prefix + "ModelServicesNum", this.ModelServicesNum);
            this.SetParamArraySimple(map, prefix + "ConnectorIDs.", this.ConnectorIDs);
            this.SetParamSimple(map, prefix + "ServicesNum", this.ServicesNum);
        }
    }
}

