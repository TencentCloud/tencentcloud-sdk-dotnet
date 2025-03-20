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

    public class Deal : AbstractModel
    {
        
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 订单的状态 1：未支付 2：已支付3：发货中 4：已发货 5：发货失败 6：已退款 7：已关单 8：订单过期 9：订单已失效 10：产品已失效 11：代付拒绝 12：支付中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 支付者
        /// </summary>
        [JsonProperty("Payer")]
        public string Payer{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 实际支付金额（分）
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public long? RealTotalCost{ get; set; }

        /// <summary>
        /// 代金券抵扣金额（分）
        /// </summary>
        [JsonProperty("VoucherDecline")]
        public long? VoucherDecline{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 产品分类ID
        /// </summary>
        [JsonProperty("GoodsCategoryId")]
        public long? GoodsCategoryId{ get; set; }

        /// <summary>
        /// 产品详情
        /// </summary>
        [JsonProperty("ProductInfo")]
        public ProductInfo[] ProductInfo{ get; set; }

        /// <summary>
        /// 时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public float? TimeSpan{ get; set; }

        /// <summary>
        /// 时间单位
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 货币单位
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 折扣率
        /// </summary>
        [JsonProperty("Policy")]
        public float? Policy{ get; set; }

        /// <summary>
        /// 单价（分）
        /// </summary>
        [JsonProperty("Price")]
        public float? Price{ get; set; }

        /// <summary>
        /// 原价（分）
        /// </summary>
        [JsonProperty("TotalCost")]
        public float? TotalCost{ get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 子产品编码
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// 大订单号
        /// </summary>
        [JsonProperty("BigDealId")]
        public string BigDealId{ get; set; }

        /// <summary>
        /// 退费公式
        /// </summary>
        [JsonProperty("Formula")]
        public string Formula{ get; set; }

        /// <summary>
        /// 退费涉及订单信息
        /// </summary>
        [JsonProperty("RefReturnDeals")]
        public string RefReturnDeals{ get; set; }

        /// <summary>
        /// 付费模式：prePay 预付费 postPay后付费 riPay预留实例
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 交易类型
        /// modifyNetworkMode 调整带宽模式
        /// modifyNetworkSize 调整带宽大小
        /// refund 退款
        /// downgrade 降配
        /// upgrade 升配
        /// renew 续费
        /// purchase 购买
        /// preMoveOut 包年包月迁出资源
        /// preMoveIn 包年包月迁入资源
        /// preToPost 预付费转后付费
        /// postMoveOut 按量计费迁出资源
        /// postMoveIn 按量计费迁入资源
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 产品编码中文名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 子产品编码中文名称
        /// </summary>
        [JsonProperty("SubProductName")]
        public string SubProductName{ get; set; }

        /// <summary>
        /// 订单对应的资源id, 查询参数Limit超过200，将返回null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string[] ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Payer", this.Payer);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "VoucherDecline", this.VoucherDecline);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "GoodsCategoryId", this.GoodsCategoryId);
            this.SetParamArrayObj(map, prefix + "ProductInfo.", this.ProductInfo);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "BigDealId", this.BigDealId);
            this.SetParamSimple(map, prefix + "Formula", this.Formula);
            this.SetParamSimple(map, prefix + "RefReturnDeals", this.RefReturnDeals);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "SubProductName", this.SubProductName);
            this.SetParamArraySimple(map, prefix + "ResourceId.", this.ResourceId);
        }
    }
}

