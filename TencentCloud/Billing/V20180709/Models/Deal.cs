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
        /// 订单状态
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}

