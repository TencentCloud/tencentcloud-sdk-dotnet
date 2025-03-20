/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class AnalyseConditionDetail : AbstractModel
    {
        
        /// <summary>
        /// 产品
        /// </summary>
        [JsonProperty("Business")]
        public AnalyseBusinessDetail[] Business{ get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        [JsonProperty("Project")]
        public AnalyseProjectDetail[] Project{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public AnalyseRegionDetail[] Region{ get; set; }

        /// <summary>
        /// 计费模式
        /// </summary>
        [JsonProperty("PayMode")]
        public AnalysePayModeDetail[] PayMode{ get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonProperty("ActionType")]
        public AnalyseActionTypeDetail[] ActionType{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public AnalyseZoneDetail[] Zone{ get; set; }

        /// <summary>
        /// 资源所有者Uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public AnalyseOwnerUinDetail[] OwnerUin{ get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [JsonProperty("Amount")]
        public AnalyseAmountDetail[] Amount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Business.", this.Business);
            this.SetParamArrayObj(map, prefix + "Project.", this.Project);
            this.SetParamArrayObj(map, prefix + "Region.", this.Region);
            this.SetParamArrayObj(map, prefix + "PayMode.", this.PayMode);
            this.SetParamArrayObj(map, prefix + "ActionType.", this.ActionType);
            this.SetParamArrayObj(map, prefix + "Zone.", this.Zone);
            this.SetParamArrayObj(map, prefix + "OwnerUin.", this.OwnerUin);
            this.SetParamArrayObj(map, prefix + "Amount.", this.Amount);
        }
    }
}

