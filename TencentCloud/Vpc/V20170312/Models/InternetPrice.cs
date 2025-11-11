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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternetPrice : AbstractModel
    {
        
        /// <summary>
        /// 公网IP网络费询价详细参数。
        /// </summary>
        [JsonProperty("AddressPrice")]
        public InternetPriceDetail AddressPrice{ get; set; }

        /// <summary>
        /// 公网IP资源费询价详细参数。仅原生IP价格查询返回。
        /// </summary>
        [JsonProperty("IPPrice")]
        public InternetPriceDetail IPPrice{ get; set; }

        /// <summary>
        /// 总原价，单位：元，仅预付费价格查询返回。
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public float? OriginalPrice{ get; set; }

        /// <summary>
        /// 折扣后的总价格，单位：元。仅预付费价格查询返回。
        /// </summary>
        [JsonProperty("DiscountPrice")]
        public float? DiscountPrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AddressPrice.", this.AddressPrice);
            this.SetParamObj(map, prefix + "IPPrice.", this.IPPrice);
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "DiscountPrice", this.DiscountPrice);
        }
    }
}

