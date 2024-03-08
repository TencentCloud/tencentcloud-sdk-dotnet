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

    public class AllocationSummaryByBusiness : AbstractModel
    {
        
        /// <summary>
        /// 分账单元唯一标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TreeNodeUniqKey")]
        public string TreeNodeUniqKey{ get; set; }

        /// <summary>
        /// 分账单元名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TreeNodeUniqKeyName")]
        public string TreeNodeUniqKeyName{ get; set; }

        /// <summary>
        /// 日期：结算日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillDate")]
        public string BillDate{ get; set; }

        /// <summary>
        /// 归集费用(现金)：基于归集规则直接归集到分账单元的现金
        /// </summary>
        [JsonProperty("GatherCashPayAmount")]
        public string GatherCashPayAmount{ get; set; }

        /// <summary>
        /// 归集费用(优惠券)：基于归集规则直接归集到分账单元的资源优惠券
        /// </summary>
        [JsonProperty("GatherVoucherPayAmount")]
        public string GatherVoucherPayAmount{ get; set; }

        /// <summary>
        /// 归集费用(赠送金)：基于归集规则直接归集到分账单元的资源赠送金
        /// </summary>
        [JsonProperty("GatherIncentivePayAmount")]
        public string GatherIncentivePayAmount{ get; set; }

        /// <summary>
        /// 归集费用(分成金)：基于归集规则直接归集到分账单元的资源分成金
        /// </summary>
        [JsonProperty("GatherTransferPayAmount")]
        public string GatherTransferPayAmount{ get; set; }

        /// <summary>
        /// 分摊费用(现金)：基于分摊规则分摊到分账单元的资源现金
        /// </summary>
        [JsonProperty("AllocateCashPayAmount")]
        public string AllocateCashPayAmount{ get; set; }

        /// <summary>
        /// 分摊费用(优惠券)：基于分摊规则分摊到分账单元的资源优惠券
        /// </summary>
        [JsonProperty("AllocateVoucherPayAmount")]
        public string AllocateVoucherPayAmount{ get; set; }

        /// <summary>
        /// 分摊费用(赠送金)：基于分摊规则分摊到分账单元的资源赠送金
        /// </summary>
        [JsonProperty("AllocateIncentivePayAmount")]
        public string AllocateIncentivePayAmount{ get; set; }

        /// <summary>
        /// 分摊费用(分成金)：基于分摊规则分摊到分账单元的资源分成金
        /// </summary>
        [JsonProperty("AllocateTransferPayAmount")]
        public string AllocateTransferPayAmount{ get; set; }

        /// <summary>
        /// 合计费用(现金)：分账单元总费用，归集费用(现金) + 分摊费用(现金)
        /// </summary>
        [JsonProperty("TotalCashPayAmount")]
        public string TotalCashPayAmount{ get; set; }

        /// <summary>
        /// 合计费用(优惠券)：分账单元总费用，归集费用(优惠券) + 分摊费用(优惠券)
        /// </summary>
        [JsonProperty("TotalVoucherPayAmount")]
        public string TotalVoucherPayAmount{ get; set; }

        /// <summary>
        /// 合计费用(赠送金)：分账单元总费用，归集费用(赠送金) + 分摊费用(赠送金)
        /// </summary>
        [JsonProperty("TotalIncentivePayAmount")]
        public string TotalIncentivePayAmount{ get; set; }

        /// <summary>
        /// 合计费用(分成金)：分账单元总费用，归集费用(分成金)+分摊费用(分成金)
        /// </summary>
        [JsonProperty("TotalTransferPayAmount")]
        public string TotalTransferPayAmount{ get; set; }

        /// <summary>
        /// 归集费用(折后总额)：基于归集规则直接归集到分账单元的资源优惠后总价
        /// </summary>
        [JsonProperty("GatherRealCost")]
        public string GatherRealCost{ get; set; }

        /// <summary>
        /// 分摊费用(折后总额)：基于分摊规则分摊到分账单元的资源优惠后总价
        /// </summary>
        [JsonProperty("AllocateRealCost")]
        public string AllocateRealCost{ get; set; }

        /// <summary>
        /// 合计费用(折后总额)：分账单元总费用，归集费用(折后总额) + 分摊费用(折后总额)
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

        /// <summary>
        /// 占比(折后总额)：本分账单元合计费用(折后总额)/合计费用(折后总额)*100%
        /// </summary>
        [JsonProperty("Ratio")]
        public string Ratio{ get; set; }

        /// <summary>
        /// 环比(折后总额)：[本月分账单元合计费用(折后总额) - 上月分账单元合计费用(折后总额)] / 上月分账单元合计费用(折后总额) * 100%
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Trend")]
        public string Trend{ get; set; }

        /// <summary>
        /// 环比箭头
        /// upward -上升
        /// downward - 下降
        /// none - 平稳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrendType")]
        public string TrendType{ get; set; }

        /// <summary>
        /// 产品编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// 产品名称：用户所采购的各类云产品
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessCodeName")]
        public string BusinessCodeName{ get; set; }

        /// <summary>
        /// 组件原价：原价 = 组件刊例价 * 组件用量 * 使用时长（如客户享受一口价/合同价则默认不展示，退费类场景也默认不展示），指定价模式
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }

        /// <summary>
        /// 预留实例抵扣原价：本产品或服务使用预留实例抵扣的组件原价金额
        /// </summary>
        [JsonProperty("RICost")]
        public string RICost{ get; set; }

        /// <summary>
        /// 节省计划抵扣原价：节省计划抵扣原价 = 节省计划包抵扣面值 / 节省计划抵扣率
        /// </summary>
        [JsonProperty("SPCost")]
        public string SPCost{ get; set; }

        /// <summary>
        /// 现金账户支出(元)：通过现金账户支付的金额
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// 代金券支出(元)：使用各类优惠券（如代金券、现金券等）支付的金额
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// 赠送账户支出(元)：使用赠送金支付的金额
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// 分成账户支出(元)：通过分成金账户支付的金额
        /// </summary>
        [JsonProperty("TransferPayAmount")]
        public string TransferPayAmount{ get; set; }

        /// <summary>
        /// 优惠后总价：优惠后总价 =（原价 - 预留实例抵扣原价 - 节省计划抵扣原价）* 折扣率
        /// </summary>
        [JsonProperty("AllocationRealTotalCost")]
        public string AllocationRealTotalCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TreeNodeUniqKey", this.TreeNodeUniqKey);
            this.SetParamSimple(map, prefix + "TreeNodeUniqKeyName", this.TreeNodeUniqKeyName);
            this.SetParamSimple(map, prefix + "BillDate", this.BillDate);
            this.SetParamSimple(map, prefix + "GatherCashPayAmount", this.GatherCashPayAmount);
            this.SetParamSimple(map, prefix + "GatherVoucherPayAmount", this.GatherVoucherPayAmount);
            this.SetParamSimple(map, prefix + "GatherIncentivePayAmount", this.GatherIncentivePayAmount);
            this.SetParamSimple(map, prefix + "GatherTransferPayAmount", this.GatherTransferPayAmount);
            this.SetParamSimple(map, prefix + "AllocateCashPayAmount", this.AllocateCashPayAmount);
            this.SetParamSimple(map, prefix + "AllocateVoucherPayAmount", this.AllocateVoucherPayAmount);
            this.SetParamSimple(map, prefix + "AllocateIncentivePayAmount", this.AllocateIncentivePayAmount);
            this.SetParamSimple(map, prefix + "AllocateTransferPayAmount", this.AllocateTransferPayAmount);
            this.SetParamSimple(map, prefix + "TotalCashPayAmount", this.TotalCashPayAmount);
            this.SetParamSimple(map, prefix + "TotalVoucherPayAmount", this.TotalVoucherPayAmount);
            this.SetParamSimple(map, prefix + "TotalIncentivePayAmount", this.TotalIncentivePayAmount);
            this.SetParamSimple(map, prefix + "TotalTransferPayAmount", this.TotalTransferPayAmount);
            this.SetParamSimple(map, prefix + "GatherRealCost", this.GatherRealCost);
            this.SetParamSimple(map, prefix + "AllocateRealCost", this.AllocateRealCost);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "Trend", this.Trend);
            this.SetParamSimple(map, prefix + "TrendType", this.TrendType);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "RICost", this.RICost);
            this.SetParamSimple(map, prefix + "SPCost", this.SPCost);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
            this.SetParamSimple(map, prefix + "AllocationRealTotalCost", this.AllocationRealTotalCost);
        }
    }
}

