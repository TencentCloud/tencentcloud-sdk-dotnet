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

    public class ModelChargingInfo : AbstractModel
    {
        
        /// <summary>
        /// 计费类型。取值：Uniform（统一计费）、Tiered（阶梯计费）。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 计费名称，阶梯计费时表示区间标识，统一计费为空。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 计费场景，用于区分同一产品不同功能的计费。
        /// </summary>
        [JsonProperty("Scenario")]
        public string Scenario{ get; set; }

        /// <summary>
        /// 计费条目列表，顺序即前端展示顺序。
        /// </summary>
        [JsonProperty("ChargingItems")]
        public ModelChargingItem[] ChargingItems{ get; set; }

        /// <summary>
        /// 计费单位。取值：TOKEN（词元）、COUNT（次）、CREDIT（积分）、PICTURE（张）。
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }

        /// <summary>
        /// 计费参考链接。
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Scenario", this.Scenario);
            this.SetParamArrayObj(map, prefix + "ChargingItems.", this.ChargingItems);
            this.SetParamSimple(map, prefix + "ChargeUnit", this.ChargeUnit);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
        }
    }
}

