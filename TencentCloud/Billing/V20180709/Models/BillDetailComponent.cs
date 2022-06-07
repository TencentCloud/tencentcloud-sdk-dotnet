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

    public class BillDetailComponent : AbstractModel
    {
        
        /// <summary>
        /// 组件类型:资源组件类型的名称，如内存、硬盘等
        /// </summary>
        [JsonProperty("ComponentCodeName")]
        public string ComponentCodeName{ get; set; }

        /// <summary>
        /// 组件名称:资源组件的名称，如云数据库MySQL-内存等
        /// </summary>
        [JsonProperty("ItemCodeName")]
        public string ItemCodeName{ get; set; }

        /// <summary>
        /// 组件刊例价:资源组件的原始价格，保持原始粒度
        /// </summary>
        [JsonProperty("SinglePrice")]
        public string SinglePrice{ get; set; }

        /// <summary>
        /// 组件指定价
        /// </summary>
        [JsonProperty("SpecifiedPrice")]
        public string SpecifiedPrice{ get; set; }

        /// <summary>
        /// 价格单位
        /// </summary>
        [JsonProperty("PriceUnit")]
        public string PriceUnit{ get; set; }

        /// <summary>
        /// 组件用量
        /// </summary>
        [JsonProperty("UsedAmount")]
        public string UsedAmount{ get; set; }

        /// <summary>
        /// 组件用量单位
        /// </summary>
        [JsonProperty("UsedAmountUnit")]
        public string UsedAmountUnit{ get; set; }

        /// <summary>
        /// 使用时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public string TimeSpan{ get; set; }

        /// <summary>
        /// 时长单位
        /// </summary>
        [JsonProperty("TimeUnitName")]
        public string TimeUnitName{ get; set; }

        /// <summary>
        /// 组件原价
        /// </summary>
        [JsonProperty("Cost")]
        public string Cost{ get; set; }

        /// <summary>
        /// 折扣率
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
        [JsonProperty("RealCost")]
        public string RealCost{ get; set; }

        /// <summary>
        /// 代金券支付金额
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// 现金支付金额
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// 赠送账户支付金额
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// 组件类型代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ItemCode")]
        public string ItemCode{ get; set; }

        /// <summary>
        /// 组件名称代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// 合同价
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractPrice")]
        public string ContractPrice{ get; set; }

        /// <summary>
        /// 资源包、预留实例、节省计划、竞价实例这四类特殊实例本身的扣费行为，此字段体现对应的实例类型。枚举值如下：
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 预留实例抵扣的使用时长，时长单位与被抵扣的时长单位保持一致
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiTimeSpan")]
        public string RiTimeSpan{ get; set; }

        /// <summary>
        /// 按组件原价的口径换算的预留实例抵扣金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalCostWithRI")]
        public string OriginalCostWithRI{ get; set; }

        /// <summary>
        /// 节省计划可用余额额度范围内，节省计划对于此组件打的折扣率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SPDeductionRate")]
        public string SPDeductionRate{ get; set; }

        /// <summary>
        /// 节省计划抵扣的SP包面值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SPDeduction")]
        public string SPDeduction{ get; set; }

        /// <summary>
        /// 按组件原价的口径换算的节省计划抵扣金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalCostWithSP")]
        public string OriginalCostWithSP{ get; set; }

        /// <summary>
        /// 综合了官网折扣、预留实例抵扣、节省计划抵扣的混合折扣率。若没有预留实例抵扣、节省计划抵扣,混合折扣率等于折扣率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlendedDiscount")]
        public string BlendedDiscount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentCodeName", this.ComponentCodeName);
            this.SetParamSimple(map, prefix + "ItemCodeName", this.ItemCodeName);
            this.SetParamSimple(map, prefix + "SinglePrice", this.SinglePrice);
            this.SetParamSimple(map, prefix + "SpecifiedPrice", this.SpecifiedPrice);
            this.SetParamSimple(map, prefix + "PriceUnit", this.PriceUnit);
            this.SetParamSimple(map, prefix + "UsedAmount", this.UsedAmount);
            this.SetParamSimple(map, prefix + "UsedAmountUnit", this.UsedAmountUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnitName", this.TimeUnitName);
            this.SetParamSimple(map, prefix + "Cost", this.Cost);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "ReduceType", this.ReduceType);
            this.SetParamSimple(map, prefix + "RealCost", this.RealCost);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "ItemCode", this.ItemCode);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ContractPrice", this.ContractPrice);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "RiTimeSpan", this.RiTimeSpan);
            this.SetParamSimple(map, prefix + "OriginalCostWithRI", this.OriginalCostWithRI);
            this.SetParamSimple(map, prefix + "SPDeductionRate", this.SPDeductionRate);
            this.SetParamSimple(map, prefix + "SPDeduction", this.SPDeduction);
            this.SetParamSimple(map, prefix + "OriginalCostWithSP", this.OriginalCostWithSP);
            this.SetParamSimple(map, prefix + "BlendedDiscount", this.BlendedDiscount);
        }
    }
}

