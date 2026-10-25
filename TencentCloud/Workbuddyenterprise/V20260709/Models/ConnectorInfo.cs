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

namespace TencentCloud.Workbuddyenterprise.V20260709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConnectorInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>连接器 ID</p>
        /// </summary>
        [JsonProperty("ConnectorId")]
        public string ConnectorId{ get; set; }

        /// <summary>
        /// <p>连接器短标识（终身不变，跨版本稳定）</p>
        /// </summary>
        [JsonProperty("ConnectorSlug")]
        public string ConnectorSlug{ get; set; }

        /// <summary>
        /// <p>版本级连接器密钥</p>
        /// </summary>
        [JsonProperty("ConnectorKey")]
        public string ConnectorKey{ get; set; }

        /// <summary>
        /// <p>连接器名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>连接器描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>头像 URL</p>
        /// </summary>
        [JsonProperty("AvatarUrl")]
        public string AvatarUrl{ get; set; }

        /// <summary>
        /// <p>连接器来源：ENTERPRISE_AGENT / ASSISTANT</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>归属企业 ID</p>
        /// </summary>
        [JsonProperty("EnterpriseId")]
        public string EnterpriseId{ get; set; }

        /// <summary>
        /// <p>连接器类型：MCP_SERVER / A2A / API_SERVICE</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>上游服务地址</p>
        /// </summary>
        [JsonProperty("ServiceUrl")]
        public string ServiceUrl{ get; set; }

        /// <summary>
        /// <p>授权方式列表：NONE / ONEID / OAUTH2_IDP / API_KEY / DYNAMIC_API_KEY。DYNAMIC_API_KEY 表示按每轮请求提供的动态字段，通过 HeaderMappings 注入出站 HTTP Header。</p>
        /// </summary>
        [JsonProperty("AuthModes")]
        public string[] AuthModes{ get; set; }

        /// <summary>
        /// <p>最新版本号</p>
        /// </summary>
        [JsonProperty("LatestVersionNo")]
        public long? LatestVersionNo{ get; set; }

        /// <summary>
        /// <p>连接器状态：ACTIVE / DISABLED</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>创建人 ID</p>
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// <p>创建时间（ISO8601，UTC）</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>最后修改时间（ISO8601，UTC）</p>
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// <p>VPC 网络配置 ID。为空表示该连接器通过公网访问 ServiceUrl。仅绑定 VPC 网络配置时本字段有值。</p>
        /// </summary>
        [JsonProperty("VpcConfigId")]
        public string VpcConfigId{ get; set; }

        /// <summary>
        /// <p>展示名：console 老连接器目录（DescribeConsoleConnectorList）下发，取 registry data.display_name，老数据缺失时回落 Name；云上目录无独立展示名，省略不返回。Name 是存储名/选型回写键（含 scope 前缀），不承担展示职责。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConnectorId", this.ConnectorId);
            this.SetParamSimple(map, prefix + "ConnectorSlug", this.ConnectorSlug);
            this.SetParamSimple(map, prefix + "ConnectorKey", this.ConnectorKey);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AvatarUrl", this.AvatarUrl);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "EnterpriseId", this.EnterpriseId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ServiceUrl", this.ServiceUrl);
            this.SetParamArraySimple(map, prefix + "AuthModes.", this.AuthModes);
            this.SetParamSimple(map, prefix + "LatestVersionNo", this.LatestVersionNo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "VpcConfigId", this.VpcConfigId);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
        }
    }
}

