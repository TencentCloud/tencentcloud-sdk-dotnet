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

    public class BudgetExtend : AbstractModel
    {
        
        /// <summary>
        /// 预算名称
        /// </summary>
        [JsonProperty("BudgetName")]
        public string BudgetName{ get; set; }

        /// <summary>
        /// 预算额度
        /// </summary>
        [JsonProperty("BudgetQuota")]
        public string BudgetQuota{ get; set; }

        /// <summary>
        /// DAY 天，MONTH 月度，QUARTER 季度 ，YEAR 年度
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

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
        /// 有效期起始时间 2025-01-01
        /// </summary>
        [JsonProperty("PeriodBegin")]
        public string PeriodBegin{ get; set; }

        /// <summary>
        /// 有效期结束时间  2025-12-01
        /// </summary>
        [JsonProperty("PeriodEnd")]
        public string PeriodEnd{ get; set; }

        /// <summary>
        /// COST，USAGE，RI，SP
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// FIX 固定值，CYCLE 不同值
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// 阈值提醒
        /// </summary>
        [JsonProperty("WarnJson")]
        public BudgetWarn[] WarnJson{ get; set; }

        /// <summary>
        /// 用户Uin
        /// </summary>
        [JsonProperty("PayerUin")]
        public ulong? PayerUin{ get; set; }

        /// <summary>
        /// 波动提醒
        /// </summary>
        [JsonProperty("WaveThresholdJson")]
        public WaveThresholdForm[] WaveThresholdJson{ get; set; }

        /// <summary>
        /// 预算备注
        /// </summary>
        [JsonProperty("BudgetNote")]
        public string BudgetNote{ get; set; }

        /// <summary>
        /// 自定义发送对象信息
        /// </summary>
        [JsonProperty("SendDetail")]
        public string SendDetail{ get; set; }

        /// <summary>
        /// 0:默认uin发送
        /// </summary>
        [JsonProperty("DefaultMode")]
        public long? DefaultMode{ get; set; }

        /// <summary>
        /// CUS 自定义预算，ZERO_COST 零支出预算模板，BY_MONTH 按月费用预算模板
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// (1, "未超支"),
        /// (2, "超支")
        /// </summary>
        [JsonProperty("MoneyStatus")]
        public long? MoneyStatus{ get; set; }

        /// <summary>
        /// 提醒次数
        /// </summary>
        [JsonProperty("RemindTimes")]
        public long? RemindTimes{ get; set; }

        /// <summary>
        /// 创建预算时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新预算时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 预算关联Id
        /// </summary>
        [JsonProperty("BudgetId")]
        public string BudgetId{ get; set; }

        /// <summary>
        /// NO_FORECAST(没有设置预测),
        ///  FORECAST_NO_DATA(设置了预测,但是没有数据),
        /// FORECAST_HAS_DATA(设置了预测,且有预测数据)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasForecast")]
        public string HasForecast{ get; set; }

        /// <summary>
        /// 预测费用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForecastCost")]
        public string ForecastCost{ get; set; }

        /// <summary>
        /// 预测进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForecastProgress")]
        public string ForecastProgress{ get; set; }

        /// <summary>
        /// 实际费用
        /// </summary>
        [JsonProperty("RealCost")]
        public string RealCost{ get; set; }

        /// <summary>
        /// 自定义发送
        /// </summary>
        [JsonProperty("BudgetSendInfoForm")]
        public BudgetSendInfoDto[] BudgetSendInfoForm{ get; set; }

        /// <summary>
        /// 当前周期
        /// </summary>
        [JsonProperty("CurDateDesc")]
        public string CurDateDesc{ get; set; }

        /// <summary>
        ///  EXPIRED  已过期
        /// ACTIVE 生效中
        /// UNACTIVATED 已失效
        /// ACTIVATED 待生效
        /// </summary>
        [JsonProperty("BudgetStatus")]
        public string BudgetStatus{ get; set; }

        /// <summary>
        /// 预算维度范围条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DimensionsRange")]
        public BudgetConditionsForm DimensionsRange{ get; set; }

        /// <summary>
        /// 预算进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BudgetProgress")]
        public string BudgetProgress{ get; set; }

        /// <summary>
        /// 预算类型设置为计划预算时返回预算额度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BudgetQuotaJson")]
        public BudgetPlan[] BudgetQuotaJson{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BudgetName", this.BudgetName);
            this.SetParamSimple(map, prefix + "BudgetQuota", this.BudgetQuota);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "BillType", this.BillType);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
            this.SetParamSimple(map, prefix + "PeriodBegin", this.PeriodBegin);
            this.SetParamSimple(map, prefix + "PeriodEnd", this.PeriodEnd);
            this.SetParamSimple(map, prefix + "Dimensions", this.Dimensions);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamArrayObj(map, prefix + "WarnJson.", this.WarnJson);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamArrayObj(map, prefix + "WaveThresholdJson.", this.WaveThresholdJson);
            this.SetParamSimple(map, prefix + "BudgetNote", this.BudgetNote);
            this.SetParamSimple(map, prefix + "SendDetail", this.SendDetail);
            this.SetParamSimple(map, prefix + "DefaultMode", this.DefaultMode);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "MoneyStatus", this.MoneyStatus);
            this.SetParamSimple(map, prefix + "RemindTimes", this.RemindTimes);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "BudgetId", this.BudgetId);
            this.SetParamSimple(map, prefix + "HasForecast", this.HasForecast);
            this.SetParamSimple(map, prefix + "ForecastCost", this.ForecastCost);
            this.SetParamSimple(map, prefix + "ForecastProgress", this.ForecastProgress);
            this.SetParamSimple(map, prefix + "RealCost", this.RealCost);
            this.SetParamArrayObj(map, prefix + "BudgetSendInfoForm.", this.BudgetSendInfoForm);
            this.SetParamSimple(map, prefix + "CurDateDesc", this.CurDateDesc);
            this.SetParamSimple(map, prefix + "BudgetStatus", this.BudgetStatus);
            this.SetParamObj(map, prefix + "DimensionsRange.", this.DimensionsRange);
            this.SetParamSimple(map, prefix + "BudgetProgress", this.BudgetProgress);
            this.SetParamArrayObj(map, prefix + "BudgetQuotaJson.", this.BudgetQuotaJson);
        }
    }
}

