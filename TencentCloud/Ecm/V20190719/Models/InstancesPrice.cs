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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstancesPrice : AbstractModel
    {
        
        /// <summary>
        /// 分部描述实例子维度的价格
        /// </summary>
        [JsonProperty("InstancePricesPartDetail")]
        public InstancePricesPartDetail InstancePricesPartDetail{ get; set; }

        /// <summary>
        /// 实例总价折扣
        /// </summary>
        [JsonProperty("Discount")]
        public ulong? Discount{ get; set; }

        /// <summary>
        /// 折扣后价格
        /// </summary>
        [JsonProperty("DiscountPrice")]
        public ulong? DiscountPrice{ get; set; }

        /// <summary>
        /// 折扣前价格，原始总价
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public ulong? OriginalPrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InstancePricesPartDetail.", this.InstancePricesPartDetail);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "DiscountPrice", this.DiscountPrice);
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
        }
    }
}

