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

    public class BillResourceSummary : AbstractModel
    {
        
        /// <summary>
        /// 产品名称：用户所采购的各类云产品，例如：云服务器 CVM
        /// </summary>
        [JsonProperty("BusinessCodeName")]
        public string BusinessCodeName{ get; set; }

        /// <summary>
        /// 子产品名称：用户采购的具体产品细分类型，例如：云服务器 CVM-标准型 S1
        /// </summary>
        [JsonProperty("ProductCodeName")]
        public string ProductCodeName{ get; set; }

        /// <summary>
        /// 计费模式：资源的计费模式，区分为包年包月和按量计费
        /// </summary>
        [JsonProperty("PayModeName")]
        public string PayModeName{ get; set; }

        /// <summary>
        /// 项目名称：资源归属的项目，用户在控制台给资源自主分配项目，未分配则是默认项目
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 地域：资源所属地域，如华南地区（广州）
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 可用区：资源所属可用区，如广州三区
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 资源 ID：账单中出账对象 ID，不同产品因资源形态不同，资源内容不完全相同，如云服务器 CVM 为对应的实例 ID	
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源别名：用户在控制台为资源设置的名称，如果未设置，则默认为空
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 交易类型：如包年包月新购、包年包月续费、按量计费扣费等类型
        /// </summary>
        [JsonProperty("ActionTypeName")]
        public string ActionTypeName{ get; set; }

        /// <summary>
        /// 订单ID：包年包月计费模式下订购的订单号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 扣费时间：结算扣费时间
        /// </summary>
        [JsonProperty("PayTime")]
        public string PayTime{ get; set; }

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
        /// 配置描述：该资源下的计费项名称和用量合并展示，仅在资源账单体现
        /// </summary>
        [JsonProperty("ConfigDesc")]
        public string ConfigDesc{ get; set; }

        /// <summary>
        /// 扩展字段1：产品对应的扩展属性信息，仅在资源账单体现
        /// </summary>
        [JsonProperty("ExtendField1")]
        public string ExtendField1{ get; set; }

        /// <summary>
        /// 扩展字段2：产品对应的扩展属性信息，仅在资源账单体现
        /// </summary>
        [JsonProperty("ExtendField2")]
        public string ExtendField2{ get; set; }

        /// <summary>
        /// 原价：原价 = 组件刊例价 * 组件用量 * 使用时长（如果客户享受一口价/合同价则默认不展示，退费类场景也默认不展示）
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }

        /// <summary>
        /// 折扣率：本资源享受的折扣率（如果客户享受一口价/合同价则默认不展示，退费场景也默认不展示）
        /// </summary>
        [JsonProperty("Discount")]
        public string Discount{ get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [JsonProperty("ReduceType")]
        public string ReduceType{ get; set; }

        /// <summary>
        /// 优惠后总价
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

        /// <summary>
        /// 优惠券支出：使用各类优惠券（如代金券、现金券等）支付的金额
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// 现金账户支出：通过现金账户支付的金额
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// 赠送账户支出：使用赠送金支付的金额
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// 分成金账户支出：通过分成金账户支付的金额
        /// </summary>
        [JsonProperty("TransferPayAmount")]
        public string TransferPayAmount{ get; set; }

        /// <summary>
        /// 扩展字段3：产品对应的扩展属性信息，仅在资源账单体现
        /// </summary>
        [JsonProperty("ExtendField3")]
        public string ExtendField3{ get; set; }

        /// <summary>
        /// 扩展字段4：产品对应的扩展属性信息，仅在资源账单体现
        /// </summary>
        [JsonProperty("ExtendField4")]
        public string ExtendField4{ get; set; }

        /// <summary>
        /// 扩展字段5：产品对应的扩展属性信息，仅在资源账单体现
        /// </summary>
        [JsonProperty("ExtendField5")]
        public string ExtendField5{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public BillTagInfo[] Tags{ get; set; }

        /// <summary>
        /// 支付者UIN：支付者的账号 ID，账号 ID 是用户在腾讯云的唯一账号标识
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// 使用者UIN：实际使用资源的账号 ID
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 操作者UIN：操作者账号 ID（预付费资源下单或后付费操作开通资源账号的 ID 或者角色 ID ）
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// 子产品编码
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// 实例类型：购买的产品服务对应的实例类型，包括资源包、RI、SP、竞价实例。正常的实例展示默认为不展示
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 预留实例抵扣组件原价：本产品或服务使用预留实例抵扣的组件原价金额	
        /// </summary>
        [JsonProperty("OriginalCostWithRI")]
        public string OriginalCostWithRI{ get; set; }

        /// <summary>
        /// 节省计划抵扣金额（已废弃）
        /// </summary>
        [JsonProperty("SPDeduction")]
        [System.Obsolete]
        public string SPDeduction{ get; set; }

        /// <summary>
        /// 节省计划抵扣组件原价：节省计划抵扣原价=节省计划包抵扣金额/节省计划抵扣率	
        /// </summary>
        [JsonProperty("OriginalCostWithSP")]
        public string OriginalCostWithSP{ get; set; }

        /// <summary>
        /// 账单归属月
        /// </summary>
        [JsonProperty("BillMonth")]
        public string BillMonth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "ProductCodeName", this.ProductCodeName);
            this.SetParamSimple(map, prefix + "PayModeName", this.PayModeName);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ActionTypeName", this.ActionTypeName);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "PayTime", this.PayTime);
            this.SetParamSimple(map, prefix + "FeeBeginTime", this.FeeBeginTime);
            this.SetParamSimple(map, prefix + "FeeEndTime", this.FeeEndTime);
            this.SetParamSimple(map, prefix + "ConfigDesc", this.ConfigDesc);
            this.SetParamSimple(map, prefix + "ExtendField1", this.ExtendField1);
            this.SetParamSimple(map, prefix + "ExtendField2", this.ExtendField2);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "ReduceType", this.ReduceType);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
            this.SetParamSimple(map, prefix + "ExtendField3", this.ExtendField3);
            this.SetParamSimple(map, prefix + "ExtendField4", this.ExtendField4);
            this.SetParamSimple(map, prefix + "ExtendField5", this.ExtendField5);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "OriginalCostWithRI", this.OriginalCostWithRI);
            this.SetParamSimple(map, prefix + "SPDeduction", this.SPDeduction);
            this.SetParamSimple(map, prefix + "OriginalCostWithSP", this.OriginalCostWithSP);
            this.SetParamSimple(map, prefix + "BillMonth", this.BillMonth);
        }
    }
}

