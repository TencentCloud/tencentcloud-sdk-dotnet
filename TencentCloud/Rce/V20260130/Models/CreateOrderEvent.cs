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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOrderEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>订单ID</p>
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// <p>订单金额</p>
        /// </summary>
        [JsonProperty("Amount")]
        public Amount Amount{ get; set; }

        /// <summary>
        /// <p>商家信息</p>
        /// </summary>
        [JsonProperty("Merchant")]
        public Merchant Merchant{ get; set; }

        /// <summary>
        /// <p>账单信息</p>
        /// </summary>
        [JsonProperty("Billing")]
        public Billing Billing{ get; set; }

        /// <summary>
        /// <p>商品信息</p>
        /// </summary>
        [JsonProperty("Items")]
        public Item[] Items{ get; set; }

        /// <summary>
        /// <p>物流信息</p>
        /// </summary>
        [JsonProperty("Delivery")]
        public Delivery Delivery{ get; set; }

        /// <summary>
        /// <p>营销活动信息</p>
        /// </summary>
        [JsonProperty("Promotions")]
        public Promotion[] Promotions{ get; set; }

        /// <summary>
        /// <p>与RCE约定的定制化信息，为K:V 格式的对象数组，示例：[{&quot;Key&quot;: &quot;ApproverName&quot;, &quot;Value&quot;: &quot;bob&quot;},{&quot;Key&quot;:&quot;ApproverPhone&quot;,&quot;Value&quot;: &quot;+86131****5678&quot;}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamObj(map, prefix + "Amount.", this.Amount);
            this.SetParamObj(map, prefix + "Merchant.", this.Merchant);
            this.SetParamObj(map, prefix + "Billing.", this.Billing);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamObj(map, prefix + "Delivery.", this.Delivery);
            this.SetParamArrayObj(map, prefix + "Promotions.", this.Promotions);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

