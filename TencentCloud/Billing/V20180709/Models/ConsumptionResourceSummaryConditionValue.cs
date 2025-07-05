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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsumptionResourceSummaryConditionValue : AbstractModel
    {
        
        /// <summary>
        /// 产品列表
        /// </summary>
        [JsonProperty("Business")]
        public ConditionBusiness[] Business{ get; set; }

        /// <summary>
        /// 项目列表
        /// </summary>
        [JsonProperty("Project")]
        public ConditionProject[] Project{ get; set; }

        /// <summary>
        /// 地域列表
        /// </summary>
        [JsonProperty("Region")]
        public ConditionRegion[] Region{ get; set; }

        /// <summary>
        /// 付费模式列表
        /// </summary>
        [JsonProperty("PayMode")]
        public ConditionPayMode[] PayMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Business.", this.Business);
            this.SetParamArrayObj(map, prefix + "Project.", this.Project);
            this.SetParamArrayObj(map, prefix + "Region.", this.Region);
            this.SetParamArrayObj(map, prefix + "PayMode.", this.PayMode);
        }
    }
}

