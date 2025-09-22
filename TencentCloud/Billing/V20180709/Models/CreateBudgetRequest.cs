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

    public class CreateBudgetRequest : AbstractModel
    {
        
        /// <summary>
        /// 预算名称
        /// </summary>
        [JsonProperty("BudgetName")]
        public string BudgetName{ get; set; }

        /// <summary>
        /// DAY 天，MONTH 月度，QUARTER 季度 ，YEAR 年度
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// 有效期起始时间 2025-01-01(周期: 天) / 2025-01（周期: 月）
        /// </summary>
        [JsonProperty("PeriodBegin")]
        public string PeriodBegin{ get; set; }

        /// <summary>
        /// 有效期结束时间  2025-12-01(周期：天)  / 2025-12（周期：月）
        /// </summary>
        [JsonProperty("PeriodEnd")]
        public string PeriodEnd{ get; set; }

        /// <summary>
        /// FIX 固定预算，CYCLE 计划预算
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// 预算值额度
        /// 预算计划类型为FIX(固定预算)时传定值；
        /// 预算计划类型为CYCLE(计划预算)时传[{"dateDesc":"2025-07","quota":"1000"},{"dateDesc":"2025-08","quota":"2000"}]；
        /// </summary>
        [JsonProperty("BudgetQuota")]
        public string BudgetQuota{ get; set; }

        /// <summary>
        /// BILL  系统账单，CONSUMPTION  消耗账单
        /// </summary>
        [JsonProperty("BillType")]
        public string BillType{ get; set; }

        /// <summary>
        /// COST 原价，REAL_COST 实际费用，CASH 现金，INCENTIVE 赠送金，VOUCHER 代金券，TRANSFER 分成金，TAX 税，AMOUNT_BEFORE_TAX 现金支付(税前)
        /// </summary>
        [JsonProperty("FeeType")]
        public string FeeType{ get; set; }

        /// <summary>
        /// 阈值提醒
        /// </summary>
        [JsonProperty("WarnJson")]
        public BudgetWarn[] WarnJson{ get; set; }

        /// <summary>
        /// 预算备注
        /// </summary>
        [JsonProperty("BudgetNote")]
        public string BudgetNote{ get; set; }

        /// <summary>
        /// 预算维度范围条件
        /// </summary>
        [JsonProperty("DimensionsRange")]
        public BudgetConditionsForm DimensionsRange{ get; set; }

        /// <summary>
        /// 波动提醒
        /// </summary>
        [JsonProperty("WaveThresholdJson")]
        public WaveThresholdForm[] WaveThresholdJson{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BudgetName", this.BudgetName);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "PeriodBegin", this.PeriodBegin);
            this.SetParamSimple(map, prefix + "PeriodEnd", this.PeriodEnd);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "BudgetQuota", this.BudgetQuota);
            this.SetParamSimple(map, prefix + "BillType", this.BillType);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
            this.SetParamArrayObj(map, prefix + "WarnJson.", this.WarnJson);
            this.SetParamSimple(map, prefix + "BudgetNote", this.BudgetNote);
            this.SetParamObj(map, prefix + "DimensionsRange.", this.DimensionsRange);
            this.SetParamArrayObj(map, prefix + "WaveThresholdJson.", this.WaveThresholdJson);
        }
    }
}

