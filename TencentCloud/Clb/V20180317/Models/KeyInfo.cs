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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KeyInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>是否禁用Key</p>
        /// </summary>
        [JsonProperty("Blocked")]
        public bool? Blocked{ get; set; }

        /// <summary>
        /// <p>Key关联的Budget ID。</p><p>未关联Budget时返回空字符串。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BudgetId")]
        public string BudgetId{ get; set; }

        /// <summary>
        /// <p>Key关联的Budget名称。</p><p>未关联Budget时返回空字符串。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BudgetName")]
        public string BudgetName{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>Key按Budget刷新周期划分的Credit使用情况。</p><p>当关联Budget配置多个刷新周期时，按1d、7d、30d顺序返回各周期用量；未关联Budget时返回空数组。</p>
        /// </summary>
        [JsonProperty("CreditUsageSet")]
        public CreditUsage[] CreditUsageSet{ get; set; }

        /// <summary>
        /// <p>Key的值</p>
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>Key的ID</p>
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// <p>Key名称</p>
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// <p>修改时间</p>
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// <p>限速信息</p>
        /// </summary>
        [JsonProperty("RateLimitConfig")]
        public RateLimitConfigForKey RateLimitConfig{ get; set; }

        /// <summary>
        /// <p>Key状态</p><p>枚举值：</p><ul><li>Active： 正常</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>所属的用户组ID</p>
        /// </summary>
        [JsonProperty("UserGroupId")]
        public string UserGroupId{ get; set; }

        /// <summary>
        /// <p>所属的用户组名称</p>
        /// </summary>
        [JsonProperty("UserGroupName")]
        public string UserGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Blocked", this.Blocked);
            this.SetParamSimple(map, prefix + "BudgetId", this.BudgetId);
            this.SetParamSimple(map, prefix + "BudgetName", this.BudgetName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "CreditUsageSet.", this.CreditUsageSet);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamObj(map, prefix + "RateLimitConfig.", this.RateLimitConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "UserGroupId", this.UserGroupId);
            this.SetParamSimple(map, prefix + "UserGroupName", this.UserGroupName);
        }
    }
}

