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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IncreasePlanQuotaRequest : AbstractModel
    {
        
        /// <summary>
        /// 套餐 ID, 形如 edgeone-2unuvzjmmn2q。
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// 新增的套餐配额类型，取值有：<li> site：站点数；</li><li> precise_access_control_rule：Web 防护 - 自定义规则 - 精准匹配策略的规则配额；</li><li> rate_limiting_rule：Web 防护 - 速率限制 - 精准速率限制模块的规则配额。</li>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// 新增的配额个数。单次新增的配额个数上限为 100。
        /// </summary>
        [JsonProperty("QuotaNumber")]
        public long? QuotaNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "QuotaNumber", this.QuotaNumber);
        }
    }
}

