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

    public class UserGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>用户组ID。「未分组」虚拟分组固定为 ugrp-ungrouped。</p>
        /// </summary>
        [JsonProperty("UserGroupId")]
        public string UserGroupId{ get; set; }

        /// <summary>
        /// <p>用户组名称。「未分组」虚拟分组固定为 ungrouped。</p>
        /// </summary>
        [JsonProperty("UserGroupName")]
        public string UserGroupName{ get; set; }

        /// <summary>
        /// <p>所属模型路由实例ID。</p>
        /// </summary>
        [JsonProperty("ModelRouterId")]
        public string ModelRouterId{ get; set; }

        /// <summary>
        /// <p>用户组状态。</p><p>枚举值：</p><ul><li>Creating：创建中</li><li>Active：正常</li><li>Configuring：配置中</li><li>Deleting：删除中</li></ul><p>「未分组」虚拟分组（ugrp-ungrouped）恒为 Active。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>用户组真实模型白名单。「未分组」虚拟分组为空数组。</p>
        /// </summary>
        [JsonProperty("Models")]
        public string[] Models{ get; set; }

        /// <summary>
        /// <p>用户组意图路由白名单（ir-xxx）。「未分组」虚拟分组为空数组。</p>
        /// </summary>
        [JsonProperty("IntentRouters")]
        public string[] IntentRouters{ get; set; }

        /// <summary>
        /// <p>关联的Budget ID。</p><p>未关联时为空；「未分组」虚拟分组恒为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BudgetId")]
        public string BudgetId{ get; set; }

        /// <summary>
        /// <p>关联的Budget名称。</p><p>未关联时为空；「未分组」虚拟分组恒为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BudgetName")]
        public string BudgetName{ get; set; }

        /// <summary>
        /// <p>用户组多刷新周期 Credit 使用情况。</p><p>无多周期预算时为空数组。</p>
        /// </summary>
        [JsonProperty("CreditUsageSet")]
        public CreditUsage[] CreditUsageSet{ get; set; }

        /// <summary>
        /// <p>用户组当前包含的 Key 数量。「未分组」虚拟分组（ugrp-ungrouped）返回该模型路由实例下未归属任何用户组的 Key 数量。</p>
        /// </summary>
        [JsonProperty("KeyCount")]
        public long? KeyCount{ get; set; }

        /// <summary>
        /// <p>标签列表。「未分组」虚拟分组为空数组。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>创建时间。「未分组」虚拟分组不返回此字段。</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>修改时间。「未分组」虚拟分组不返回此字段。</p>
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserGroupId", this.UserGroupId);
            this.SetParamSimple(map, prefix + "UserGroupName", this.UserGroupName);
            this.SetParamSimple(map, prefix + "ModelRouterId", this.ModelRouterId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Models.", this.Models);
            this.SetParamArraySimple(map, prefix + "IntentRouters.", this.IntentRouters);
            this.SetParamSimple(map, prefix + "BudgetId", this.BudgetId);
            this.SetParamSimple(map, prefix + "BudgetName", this.BudgetName);
            this.SetParamArrayObj(map, prefix + "CreditUsageSet.", this.CreditUsageSet);
            this.SetParamSimple(map, prefix + "KeyCount", this.KeyCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
        }
    }
}

