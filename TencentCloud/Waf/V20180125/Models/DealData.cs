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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DealData : AbstractModel
    {
        
        /// <summary>
        /// 订单号列表，元素个数与请求包的goods数组的元素个数一致，商品详情与订单按顺序对应
        /// </summary>
        [JsonProperty("DealNames")]
        public string[] DealNames{ get; set; }

        /// <summary>
        /// 大订单号，一个大订单号下可以有多个子订单，说明是同一次下单[{},{}]
        /// </summary>
        [JsonProperty("BigDealId")]
        public string BigDealId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DealNames.", this.DealNames);
            this.SetParamSimple(map, prefix + "BigDealId", this.BigDealId);
        }
    }
}

