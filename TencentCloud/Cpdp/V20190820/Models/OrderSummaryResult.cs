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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrderSummaryResult : AbstractModel
    {
        
        /// <summary>
        /// 汇总ID
        /// </summary>
        [JsonProperty("SummaryId")]
        public string SummaryId{ get; set; }

        /// <summary>
        /// 收款账户ID
        /// </summary>
        [JsonProperty("PayeeId")]
        public string PayeeId{ get; set; }

        /// <summary>
        /// 收款账户名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 收入类型
        /// </summary>
        [JsonProperty("IncomeType")]
        public string IncomeType{ get; set; }

        /// <summary>
        /// 汇总金额
        /// </summary>
        [JsonProperty("SummaryAmount")]
        public string SummaryAmount{ get; set; }

        /// <summary>
        /// 汇总日期
        /// </summary>
        [JsonProperty("SummaryTime")]
        public string SummaryTime{ get; set; }

        /// <summary>
        /// 汇总记录数量
        /// </summary>
        [JsonProperty("SummaryCount")]
        public long? SummaryCount{ get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [JsonProperty("OutUserId")]
        public string OutUserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SummaryId", this.SummaryId);
            this.SetParamSimple(map, prefix + "PayeeId", this.PayeeId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IncomeType", this.IncomeType);
            this.SetParamSimple(map, prefix + "SummaryAmount", this.SummaryAmount);
            this.SetParamSimple(map, prefix + "SummaryTime", this.SummaryTime);
            this.SetParamSimple(map, prefix + "SummaryCount", this.SummaryCount);
            this.SetParamSimple(map, prefix + "OutUserId", this.OutUserId);
        }
    }
}

