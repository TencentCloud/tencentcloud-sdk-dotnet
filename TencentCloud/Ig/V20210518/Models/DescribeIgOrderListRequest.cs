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

namespace TencentCloud.Ig.V20210518.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIgOrderListRequest : AbstractModel
    {
        
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页数目
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonProperty("OrderStatus")]
        public long? OrderStatus{ get; set; }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        [JsonProperty("KeyWord")]
        public string KeyWord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "KeyWord", this.KeyWord);
        }
    }
}

