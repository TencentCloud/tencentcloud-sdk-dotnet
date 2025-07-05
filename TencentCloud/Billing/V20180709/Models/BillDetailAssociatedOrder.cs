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

    public class BillDetailAssociatedOrder : AbstractModel
    {
        
        /// <summary>
        /// 新购订单
        /// </summary>
        [JsonProperty("PrepayPurchase")]
        public string PrepayPurchase{ get; set; }

        /// <summary>
        /// 续费订单
        /// </summary>
        [JsonProperty("PrepayRenew")]
        public string PrepayRenew{ get; set; }

        /// <summary>
        /// 升配订单
        /// </summary>
        [JsonProperty("PrepayModifyUp")]
        public string PrepayModifyUp{ get; set; }

        /// <summary>
        /// 冲销订单
        /// </summary>
        [JsonProperty("ReverseOrder")]
        public string ReverseOrder{ get; set; }

        /// <summary>
        /// 优惠调整后订单
        /// </summary>
        [JsonProperty("NewOrder")]
        public string NewOrder{ get; set; }

        /// <summary>
        /// 优惠调整前订单
        /// </summary>
        [JsonProperty("Original")]
        public string Original{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrepayPurchase", this.PrepayPurchase);
            this.SetParamSimple(map, prefix + "PrepayRenew", this.PrepayRenew);
            this.SetParamSimple(map, prefix + "PrepayModifyUp", this.PrepayModifyUp);
            this.SetParamSimple(map, prefix + "ReverseOrder", this.ReverseOrder);
            this.SetParamSimple(map, prefix + "NewOrder", this.NewOrder);
            this.SetParamSimple(map, prefix + "Original", this.Original);
        }
    }
}

