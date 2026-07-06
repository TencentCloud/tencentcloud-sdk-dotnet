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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountStatsGroup : AbstractModel
    {
        
        /// <summary>
        /// 成员账号信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Member")]
        public MemberInfo Member{ get; set; }

        /// <summary>
        /// 该账号下所有产品待整改风险数汇总
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UntreatedRiskCount")]
        public long? UntreatedRiskCount{ get; set; }

        /// <summary>
        /// 该账号下各产品维度的风险统计列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductStats")]
        public AccountProductDetailStats[] ProductStats{ get; set; }

        /// <summary>
        /// 整改率
        /// </summary>
        [JsonProperty("RectifyRate")]
        public string RectifyRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Member.", this.Member);
            this.SetParamSimple(map, prefix + "UntreatedRiskCount", this.UntreatedRiskCount);
            this.SetParamArrayObj(map, prefix + "ProductStats.", this.ProductStats);
            this.SetParamSimple(map, prefix + "RectifyRate", this.RectifyRate);
        }
    }
}

