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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTokenPlanTeamOrderAndBuyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>套餐类型。取值：enterprise（企业版专业套餐）、enterprise-auto（企业版轻享套餐）。</p>
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// <p>套餐名称。只能包含中文、字母、数字、下划线、连字符，以中文或者字母开头，以中文或字母或数字结尾，2~50个字符</p>
        /// </summary>
        [JsonProperty("TeamName")]
        public string TeamName{ get; set; }

        /// <summary>
        /// <p>购买时长。单位：月。必须大于 0，支持1个月～12个月。</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// <p>购买的套餐规格。套餐类型为专业套餐（enterprise），单位取值为积分；轻享套餐（enterprise-auto），单位取值为 tokens。</p>
        /// </summary>
        [JsonProperty("CreditOrToken")]
        public long? CreditOrToken{ get; set; }

        /// <summary>
        /// <p>是否开启自动续费。默认不开启。</p>
        /// </summary>
        [JsonProperty("EnableAutoRenew")]
        public bool? EnableAutoRenew{ get; set; }

        /// <summary>
        /// <p>已有套餐 ID（非空时走过期续费，空时走新购）</p>
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "TeamName", this.TeamName);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "CreditOrToken", this.CreditOrToken);
            this.SetParamSimple(map, prefix + "EnableAutoRenew", this.EnableAutoRenew);
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
        }
    }
}

