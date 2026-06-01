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

    public class DescribeAgentCredentialResp : AbstractModel
    {
        
        /// <summary>
        /// <p>租户应用ID</p>
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
        /// <p>凭据ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>凭据名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>关联应用数</p>
        /// </summary>
        [JsonProperty("RelateAgentAppNum")]
        [System.Obsolete]
        public long? RelateAgentAppNum{ get; set; }

        /// <summary>
        /// <p>关联mcp数</p>
        /// </summary>
        [JsonProperty("RelateMcpServerNum")]
        public long? RelateMcpServerNum{ get; set; }

        /// <summary>
        /// <p>关联模型数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelateModelNum")]
        public long? RelateModelNum{ get; set; }

        /// <summary>
        /// <p>关联服务数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelateServiceNum")]
        public long? RelateServiceNum{ get; set; }

        /// <summary>
        /// <p>凭据内容</p>
        /// </summary>
        [JsonProperty("Content")]
        public AgentCredentialContentDTO Content{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>修改时间</p>
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// <p>类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RelateAgentAppNum", this.RelateAgentAppNum);
            this.SetParamSimple(map, prefix + "RelateMcpServerNum", this.RelateMcpServerNum);
            this.SetParamSimple(map, prefix + "RelateModelNum", this.RelateModelNum);
            this.SetParamSimple(map, prefix + "RelateServiceNum", this.RelateServiceNum);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

