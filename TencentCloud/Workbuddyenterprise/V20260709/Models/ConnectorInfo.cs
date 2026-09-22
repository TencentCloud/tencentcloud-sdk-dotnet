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
        /// 连接器 ID
        /// </summary>
        [JsonProperty("ConnectorId")]
        public string ConnectorId{ get; set; }

        /// <summary>
        /// 连接器短标识（终身不变，跨版本稳定）
        /// </summary>
        [JsonProperty("ConnectorSlug")]
        public string ConnectorSlug{ get; set; }

        /// <summary>
        /// 版本级连接器密钥
        /// </summary>
        [JsonProperty("ConnectorKey")]
        public string ConnectorKey{ get; set; }

        /// <summary>
        /// 连接器名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 连接器描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 头像 URL
        /// </summary>
        [JsonProperty("AvatarUrl")]
        public string AvatarUrl{ get; set; }

        /// <summary>
        /// 连接器来源：ENTERPRISE_AGENT / ASSISTANT
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 归属企业 ID
        /// </summary>
        [JsonProperty("EnterpriseId")]
        public string EnterpriseId{ get; set; }

        /// <summary>
        /// 连接器类型：MCP_SERVER / A2A / API_SERVICE
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 上游服务地址
        /// </summary>
        [JsonProperty("ServiceUrl")]
        public string ServiceUrl{ get; set; }

        /// <summary>
        /// 授权方式列表：NONE / ONEID / OAUTH2_IDP
        /// </summary>
        [JsonProperty("AuthModes")]
        public string[] AuthModes{ get; set; }

        /// <summary>
        /// 最新版本号
        /// </summary>
        [JsonProperty("LatestVersionNo")]
        public long? LatestVersionNo{ get; set; }

        /// <summary>
        /// 连接器状态：ACTIVE / DISABLED
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建人 ID
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// 创建时间（ISO8601，UTC）
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 最后修改时间（ISO8601，UTC）
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }


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
        }
    }
}

