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

    public class CreateBudgetRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>预算配置数组。</p><p>数组长度最大为3，最多可同时配置1d、7d、30d三个刷新周期，且每种刷新周期只能出现一次。BudgetResetAt不支持作为入参设置，系统会按配置的刷新周期自动维护刷新时间。</p>
        /// </summary>
        [JsonProperty("BudgetConfigs")]
        public BudgetConfigInput[] BudgetConfigs{ get; set; }

        /// <summary>
        /// <p>Budget名称。</p><p>不传默认为 '-'。</p>
        /// </summary>
        [JsonProperty("BudgetName")]
        public string BudgetName{ get; set; }

        /// <summary>
        /// <p>Budget限速配置。</p>
        /// </summary>
        [JsonProperty("RateLimitConfig")]
        public RateLimitConfigForBudget RateLimitConfig{ get; set; }

        /// <summary>
        /// <p>创建Budget时同时关联的资源列表。</p><p>仅支持企业型模型路由实例和企业型实例下的Key。如果资源不存在或不可关联，创建请求失败；资源已关联其他Budget时将替换为新创建的Budget。</p>
        /// </summary>
        [JsonProperty("Resources")]
        public BudgetResource[] Resources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "BudgetConfigs.", this.BudgetConfigs);
            this.SetParamSimple(map, prefix + "BudgetName", this.BudgetName);
            this.SetParamObj(map, prefix + "RateLimitConfig.", this.RateLimitConfig);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
        }
    }
}

