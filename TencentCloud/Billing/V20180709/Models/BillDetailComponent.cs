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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}

