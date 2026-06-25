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

    public class BudgetInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>关联的key数量</p>
        /// </summary>
        [JsonProperty("AssociationKeyCount")]
        public ulong? AssociationKeyCount{ get; set; }

        /// <summary>
        /// <p>关联的模型路由数量</p>
        /// </summary>
        [JsonProperty("AssociationModelRouterCount")]
        public ulong? AssociationModelRouterCount{ get; set; }

        /// <summary>
        /// <p>关联的用户组数量</p>
        /// </summary>
        [JsonProperty("AssociationUserGroupCount")]
        public ulong? AssociationUserGroupCount{ get; set; }

        /// <summary>
        /// <p>Budget预算配置数组。</p><p>最多返回3个元素，每种刷新周期（1d/7d/30d）各一个。</p>
        /// </summary>
        [JsonProperty("BudgetConfigs")]
        public BudgetConfig[] BudgetConfigs{ get; set; }

        /// <summary>
        /// <p>Budget ID。</p>
        /// </summary>
        [JsonProperty("BudgetId")]
        public string BudgetId{ get; set; }

        /// <summary>
        /// <p>Budget名称。</p>
        /// </summary>
        [JsonProperty("BudgetName")]
        public string BudgetName{ get; set; }

        /// <summary>
        /// <p>创建时间。</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>修改时间。</p>
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// <p>Budget限速信息。</p>
        /// </summary>
        [JsonProperty("RateLimitConfig")]
        public RateLimitConfigForBudget RateLimitConfig{ get; set; }

        /// <summary>
        /// <p>Budget状态。</p><p>枚举值：</p><ul><li>Provisioning：创建中</li><li>Active：运行中</li><li>Configuring：变配中</li><li>Deleting：删除中</li><li>ProvisionFailed：创建失败</li><li>ConfigureFailed：变配失败</li><li>DeletionFailed：删除失败</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssociationKeyCount", this.AssociationKeyCount);
            this.SetParamSimple(map, prefix + "AssociationModelRouterCount", this.AssociationModelRouterCount);
            this.SetParamSimple(map, prefix + "AssociationUserGroupCount", this.AssociationUserGroupCount);
            this.SetParamArrayObj(map, prefix + "BudgetConfigs.", this.BudgetConfigs);
            this.SetParamSimple(map, prefix + "BudgetId", this.BudgetId);
            this.SetParamSimple(map, prefix + "BudgetName", this.BudgetName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamObj(map, prefix + "RateLimitConfig.", this.RateLimitConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

