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

    public class AllocationSummaryByItem : AbstractModel
    {
        
        /// <summary>
        /// 分账单元唯一标识
        /// </summary>
        [JsonProperty("TreeNodeUniqKey")]
        public string TreeNodeUniqKey{ get; set; }

        /// <summary>
        /// 分账单元名称
        /// </summary>
        [JsonProperty("TreeNodeUniqKeyName")]
        public string TreeNodeUniqKeyName{ get; set; }

        /// <summary>
        /// 日期：结算日期
        /// </summary>
        [JsonProperty("BillDate")]
        public string BillDate{ get; set; }

        /// <summary>
        /// 支付者 UIN：支付者的账号 ID，账号 ID 是用户在腾讯云的唯一账号标识
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// 使用者 UIN：实际使用资源的账号 ID
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 操作者 UIN：操作者账号 ID（预付费资源下单或后付费操作开通资源账号的ID或者角色 ID）
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// 计费模式编码
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 计费模式：资源的计费模式，区分为包年包月和按量计费
        /// </summary>
        [JsonProperty("PayModeName")]
        public string PayModeName{ get; set; }

        /// <summary>
        /// 交易类型编码
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 交易类型：明细交易类型
        /// </summary>
        [JsonProperty("ActionTypeName")]
        public string ActionTypeName{ get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// 产品名称：用户所采购的各类云产品
        /// </summary>
        [JsonProperty("BusinessCodeName")]
        public string BusinessCodeName{ get; set; }

        /// <summary>
        /// 子产品编码
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 子产品名称：用户采购的具体产品细分类型
        /// </summary>
        [JsonProperty("ProductCodeName")]
        public string ProductCodeName{ get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// 地域名称：资源所属地域
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 可用区ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 可用区：资源所属可用区
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 实例类型编码
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例类型：购买的产品服务对应的实例类型，包括资源包、RI、SP、竞价实例。常规实例默认展示“-”
        /// </summary>
        [JsonProperty("InstanceTypeName")]
        public string InstanceTypeName{ get; set; }

        /// <summary>
        /// 资源ID：不同产品因资源形态不同，资源内容不完全相同，如云服务器 CVM 为对应的实例 ID； 若该产品被分拆，则展示产品分拆后的分拆项 ID，如 COS 桶 ID，CDN 域名
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 实例名称：用户在控制台为资源设置的名称，如未设置默认为空；若该产品被分拆，则展示分拆产品分拆后的分拆项资源别名
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 分账标签：资源绑定的标签
        /// </summary>
        [JsonProperty("Tag")]
        public BillTag[] Tag{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 项目名称：资源归属的项目，用户在控制台给资源自主分配项目，未分配则是默认项目
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 费用归集类型：费用来源类型，分摊、归集、未分配
        /// 0 - 分摊
        /// 1 - 归集
        /// -1 - 未分配
        /// </summary>
        [JsonProperty("AllocationType")]
        public long? AllocationType{ get; set; }

        /// <summary>
        /// 组件原价：原价 = 组件刊例价 * 组件用量 * 使用时长（如客户享受一口价/合同价则默认不展示，退费类场景也默认不展示），指定价模式
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }

        /// <summary>
        /// 预留实例抵扣时长：本产品或服务使用预留实例抵扣的使用时长
        /// </summary>
        [JsonProperty("RiTimeSpan")]
        public string RiTimeSpan{ get; set; }

        /// <summary>
        /// 预留实例抵扣原价：本产品或服务使用预留实例抵扣的组件原价金额
        /// </summary>
        [JsonProperty("RiCost")]
        public string RiCost{ get; set; }

        /// <summary>
        /// 优惠后总价：优惠后总价 =（原价 - 预留实例抵扣原价 - 节省计划抵扣原价）* 折扣率
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

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
        /// 组件名称编码
        /// </summary>
        [JsonProperty("ItemCode")]
        public string ItemCode{ get; set; }

        /// <summary>
        /// 组件名称：用户购买的产品或服务，所包含的具体组件
        /// </summary>
        [JsonProperty("ItemCodeName")]
        public string ItemCodeName{ get; set; }

        /// <summary>
        /// 组件类型编码
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// 组件类型：用户购买的产品或服务对应的组件大类
        /// </summary>
        [JsonProperty("ComponentCodeName")]
        public string ComponentCodeName{ get; set; }

        /// <summary>
        /// 分拆项 ID：涉及分拆产品的分拆后的分拆项 ID，如 COS 桶 ID，CDN 域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SplitItemId")]
        [System.Obsolete]
        public string SplitItemId{ get; set; }

        /// <summary>
        /// 分拆项名称：涉及分拆产品的分拆后的分拆项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SplitItemName")]
        [System.Obsolete]
        public string SplitItemName{ get; set; }

        /// <summary>
        /// 开始使用时间：产品服务开始使用时间
        /// </summary>
        [JsonProperty("FeeBeginTime")]
        public string FeeBeginTime{ get; set; }

        /// <summary>
        /// 结束使用时间：产品服务结束使用时间
        /// </summary>
        [JsonProperty("FeeEndTime")]
        public string FeeEndTime{ get; set; }

        /// <summary>
        /// 节省计划抵扣原价：节省计划抵扣原价 = 节省计划包抵扣面值 / 节省计划抵扣率
        /// </summary>
        [JsonProperty("SPCost")]
        public string SPCost{ get; set; }

        /// <summary>
        /// 国内国际编码
        /// </summary>
        [JsonProperty("RegionType")]
        public string RegionType{ get; set; }

        /// <summary>
        /// 国内国际：资源所属区域类型（国内、国际）
        /// </summary>
        [JsonProperty("RegionTypeName")]
        public string RegionTypeName{ get; set; }

        /// <summary>
        /// 组件刊例价：组件的官网原始单价（如客户享受一口价/合同价则默认不展示）
        /// </summary>
        [JsonProperty("SinglePrice")]
        public string SinglePrice{ get; set; }

        /// <summary>
        /// 组件单价：组件的折后单价，组件单价 = 刊例价 * 折扣
        /// </summary>
        [JsonProperty("ContractPrice")]
        public string ContractPrice{ get; set; }

        /// <summary>
        /// 组件价格单位：组件价格的单位，单位构成：元/用量单位/时长单位
        /// </summary>
        [JsonProperty("SinglePriceUnit")]
        public string SinglePriceUnit{ get; set; }

        /// <summary>
        /// 组件用量：该组件实际结算用量，组件用量=组件原始用量-抵扣用量（含资源包）
        /// </summary>
        [JsonProperty("UsedAmount")]
        public string UsedAmount{ get; set; }

        /// <summary>
        /// 组件用量单位：组件用量对应的单位
        /// </summary>
        [JsonProperty("UsedAmountUnit")]
        public string UsedAmountUnit{ get; set; }

        /// <summary>
        /// 使用时长：资源使用的时长，组件用量=组件原始使用时长-抵扣时长（含资源包）
        /// </summary>
        [JsonProperty("TimeSpan")]
        public string TimeSpan{ get; set; }

        /// <summary>
        /// 时长单位：资源使用时长的单位
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 备注属性（实例配置）：其他备注信息，如预留实例的预留实例类型和交易类型、CCN 产品的两端地域信息
        /// </summary>
        [JsonProperty("ReserveDetail")]
        public string ReserveDetail{ get; set; }

        /// <summary>
        /// 原始用量/时长：组件被资源包抵扣前的原始用量
        /// （目前仅实时音视频、弹性微服务、云呼叫中心及专属可用区产品支持该信息外显，其他产品尚在接入中）
        /// </summary>
        [JsonProperty("RealTotalMeasure")]
        public string RealTotalMeasure{ get; set; }

        /// <summary>
        /// 抵扣用量/时长（含资源包）：组件被资源包抵扣的用量
        /// （目前仅实时音视频、弹性微服务、云呼叫中心及专属可用区产品支持该信息外显，其他产品尚在接入中）
        /// </summary>
        [JsonProperty("DeductedMeasure")]
        public string DeductedMeasure{ get; set; }

        /// <summary>
        /// 折扣率：本资源享受的折扣率（如客户享受一口价/合同价则默认不展示，退费场景也默认不展示）
        /// </summary>
        [JsonProperty("Discount")]
        public string Discount{ get; set; }

        /// <summary>
        /// 混合折扣率：综合各类折扣抵扣信息后的最终折扣率，混合折扣率=优惠后总价/原价
        /// </summary>
        [JsonProperty("BlendedDiscount")]
        public string BlendedDiscount{ get; set; }

        /// <summary>
        /// 价格属性：该组件除单价、时长外的其他影响折扣定价的属性信息
        /// </summary>
        [JsonProperty("PriceInfo")]
        public string[] PriceInfo{ get; set; }

        /// <summary>
        /// 计算规则说明：特殊交易类型计费结算的详细计算说明，如退费及变配
        /// </summary>
        [JsonProperty("Formula")]
        public string Formula{ get; set; }

        /// <summary>
        /// 计费规则：各产品详细的计费规则官网说明链接
        /// </summary>
        [JsonProperty("FormulaUrl")]
        public string FormulaUrl{ get; set; }

        /// <summary>
        /// 配置描述：资源配置规格信息
        /// </summary>
        [JsonProperty("ComponentConfig")]
        public string ComponentConfig{ get; set; }

        /// <summary>
        /// SPDeduction
        /// </summary>
        [JsonProperty("SPDeduction")]
        public string SPDeduction{ get; set; }

        /// <summary>
        /// 节省计划抵扣率：节省计划可用余额额度范围内，节省计划对于此组件打的折扣率
        /// </summary>
        [JsonProperty("SPDeductionRate")]
        public string SPDeductionRate{ get; set; }

        /// <summary>
        /// AssociatedOrder
        /// </summary>
        [JsonProperty("AssociatedOrder")]
        public string AssociatedOrder{ get; set; }

        /// <summary>
        /// 当前消费项的优惠对象，例如：官网折扣、用户折扣、活动折扣。
        /// </summary>
        [JsonProperty("DiscountObject")]
        public string DiscountObject{ get; set; }

        /// <summary>
        /// 当前消费项的优惠类型，例如：折扣、合同价。
        /// </summary>
        [JsonProperty("DiscountType")]
        public string DiscountType{ get; set; }

        /// <summary>
        /// 对优惠类型的补充描述，例如：商务折扣8折，则优惠类型为“折扣”，优惠内容为“0.8”。
        /// </summary>
        [JsonProperty("DiscountContent")]
        public string DiscountContent{ get; set; }

        /// <summary>
        /// 账单月
        /// </summary>
        [JsonProperty("BillMonth")]
        public string BillMonth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TreeNodeUniqKey", this.TreeNodeUniqKey);
            this.SetParamSimple(map, prefix + "TreeNodeUniqKeyName", this.TreeNodeUniqKeyName);
            this.SetParamSimple(map, prefix + "BillDate", this.BillDate);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayModeName", this.PayModeName);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ActionTypeName", this.ActionTypeName);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ProductCodeName", this.ProductCodeName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceTypeName", this.InstanceTypeName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "AllocationType", this.AllocationType);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "RiTimeSpan", this.RiTimeSpan);
            this.SetParamSimple(map, prefix + "RiCost", this.RiCost);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
            this.SetParamSimple(map, prefix + "ItemCode", this.ItemCode);
            this.SetParamSimple(map, prefix + "ItemCodeName", this.ItemCodeName);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ComponentCodeName", this.ComponentCodeName);
            this.SetParamSimple(map, prefix + "SplitItemId", this.SplitItemId);
            this.SetParamSimple(map, prefix + "SplitItemName", this.SplitItemName);
            this.SetParamSimple(map, prefix + "FeeBeginTime", this.FeeBeginTime);
            this.SetParamSimple(map, prefix + "FeeEndTime", this.FeeEndTime);
            this.SetParamSimple(map, prefix + "SPCost", this.SPCost);
            this.SetParamSimple(map, prefix + "RegionType", this.RegionType);
            this.SetParamSimple(map, prefix + "RegionTypeName", this.RegionTypeName);
            this.SetParamSimple(map, prefix + "SinglePrice", this.SinglePrice);
            this.SetParamSimple(map, prefix + "ContractPrice", this.ContractPrice);
            this.SetParamSimple(map, prefix + "SinglePriceUnit", this.SinglePriceUnit);
            this.SetParamSimple(map, prefix + "UsedAmount", this.UsedAmount);
            this.SetParamSimple(map, prefix + "UsedAmountUnit", this.UsedAmountUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "ReserveDetail", this.ReserveDetail);
            this.SetParamSimple(map, prefix + "RealTotalMeasure", this.RealTotalMeasure);
            this.SetParamSimple(map, prefix + "DeductedMeasure", this.DeductedMeasure);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "BlendedDiscount", this.BlendedDiscount);
            this.SetParamArraySimple(map, prefix + "PriceInfo.", this.PriceInfo);
            this.SetParamSimple(map, prefix + "Formula", this.Formula);
            this.SetParamSimple(map, prefix + "FormulaUrl", this.FormulaUrl);
            this.SetParamSimple(map, prefix + "ComponentConfig", this.ComponentConfig);
            this.SetParamSimple(map, prefix + "SPDeduction", this.SPDeduction);
            this.SetParamSimple(map, prefix + "SPDeductionRate", this.SPDeductionRate);
            this.SetParamSimple(map, prefix + "AssociatedOrder", this.AssociatedOrder);
            this.SetParamSimple(map, prefix + "DiscountObject", this.DiscountObject);
            this.SetParamSimple(map, prefix + "DiscountType", this.DiscountType);
            this.SetParamSimple(map, prefix + "DiscountContent", this.DiscountContent);
            this.SetParamSimple(map, prefix + "BillMonth", this.BillMonth);
        }
    }
}

