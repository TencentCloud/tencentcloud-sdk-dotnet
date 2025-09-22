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

    public class BudgetWarn : AbstractModel
    {
        
        /// <summary>
        /// ACTUAL 实际金额，
        /// FORECAST 预测金额
        /// </summary>
        [JsonProperty("WarnType")]
        public string WarnType{ get; set; }

        /// <summary>
        /// PERCENTAGE 预算金额的百分比，ABS 固定值
        /// </summary>
        [JsonProperty("CalType")]
        public string CalType{ get; set; }

        /// <summary>
        /// 阈值（大于等于0）
        /// </summary>
        [JsonProperty("ThresholdValue")]
        public string ThresholdValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WarnType", this.WarnType);
            this.SetParamSimple(map, prefix + "CalType", this.CalType);
            this.SetParamSimple(map, prefix + "ThresholdValue", this.ThresholdValue);
        }
    }
}

