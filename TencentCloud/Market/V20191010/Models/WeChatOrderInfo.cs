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

namespace TencentCloud.Market.V20191010.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WeChatOrderInfo : AbstractModel
    {
        
        /// <summary>
        /// 企业微信订单号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 订单状态。0-未⽀支付，1-已⽀支付，2-已关闭， 3-未⽀支付且已过期， 4-申请退款中， 5-申请退款成功， 6-退款被拒绝
        /// </summary>
        [JsonProperty("OrderStatus")]
        public long? OrderStatus{ get; set; }

        /// <summary>
        /// 订单类型。0-普通订单，1-扩容订单，2-续期，3-版本变更更
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 应⽤id
        /// </summary>
        [JsonProperty("SuiteId")]
        public string SuiteId{ get; set; }

        /// <summary>
        /// 购买版本ID
        /// </summary>
        [JsonProperty("EditionId")]
        public string EditionId{ get; set; }

        /// <summary>
        /// 购买版本名称
        /// </summary>
        [JsonProperty("EditionName")]
        public string EditionName{ get; set; }

        /// <summary>
        /// 实付款金额，单位分
        /// </summary>
        [JsonProperty("Price")]
        public long? Price{ get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [JsonProperty("OrderTime")]
        public long? OrderTime{ get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [JsonProperty("PaidTime")]
        public long? PaidTime{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 资源使用开始时间
        /// </summary>
        [JsonProperty("UseBeginTime")]
        public long? UseBeginTime{ get; set; }

        /// <summary>
        /// 资源使用结束时间
        /// </summary>
        [JsonProperty("UseEndTime")]
        public long? UseEndTime{ get; set; }

        /// <summary>
        /// 磐石详细的四层订单
        /// </summary>
        [JsonProperty("Deals")]
        public OfflineProductDeal Deals{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "SuiteId", this.SuiteId);
            this.SetParamSimple(map, prefix + "EditionId", this.EditionId);
            this.SetParamSimple(map, prefix + "EditionName", this.EditionName);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "OrderTime", this.OrderTime);
            this.SetParamSimple(map, prefix + "PaidTime", this.PaidTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "UseBeginTime", this.UseBeginTime);
            this.SetParamSimple(map, prefix + "UseEndTime", this.UseEndTime);
            this.SetParamObj(map, prefix + "Deals.", this.Deals);
        }
    }
}

