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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListAggregateConfigRuleEvaluationResultsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>规则ID</p>
        /// </summary>
        [JsonProperty("ConfigRuleId")]
        public string ConfigRuleId{ get; set; }

        /// <summary>
        /// <p>偏移量</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>当前页</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>账号组ID</p>
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public string AccountGroupId{ get; set; }

        /// <summary>
        /// <p>类型</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string[] ResourceType{ get; set; }

        /// <summary>
        /// <p>评估结果 COMPLIANT：合规   NON_COMPLIANT：不合规</p>
        /// </summary>
        [JsonProperty("ComplianceType")]
        public string[] ComplianceType{ get; set; }

        /// <summary>
        /// <p>资源所属用户ID</p>
        /// </summary>
        [JsonProperty("ResourceOwnerId")]
        public ulong? ResourceOwnerId{ get; set; }

        /// <summary>
        /// <p>筛选的资源拥有者uin集合</p>
        /// </summary>
        [JsonProperty("ResourceOwnerIds")]
        public ulong?[] ResourceOwnerIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigRuleId", this.ConfigRuleId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "AccountGroupId", this.AccountGroupId);
            this.SetParamArraySimple(map, prefix + "ResourceType.", this.ResourceType);
            this.SetParamArraySimple(map, prefix + "ComplianceType.", this.ComplianceType);
            this.SetParamSimple(map, prefix + "ResourceOwnerId", this.ResourceOwnerId);
            this.SetParamArraySimple(map, prefix + "ResourceOwnerIds.", this.ResourceOwnerIds);
        }
    }
}

