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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAgentPayDealsRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 限制数目
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 下单时间范围起始点(不传时会默认查15天内订单，传值时需要传15天内的起始时间)
        /// </summary>
        [JsonProperty("CreatTimeRangeStart")]
        public string CreatTimeRangeStart{ get; set; }

        /// <summary>
        /// 下单时间范围终止点
        /// </summary>
        [JsonProperty("CreatTimeRangeEnd")]
        public string CreatTimeRangeEnd{ get; set; }

        /// <summary>
        /// 0:下单时间降序；其他：下单时间升序
        /// </summary>
        [JsonProperty("Order")]
        public ulong? Order{ get; set; }

        /// <summary>
        /// 订单的状态(1：未支付;2：已支付;3：发货中;4：已发货;5：发货失败;6：已退款;7：已关单;8：订单过期;9：订单已失效;10：产品已失效;11：代付拒绝;12：支付中)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 下单人账号ID列表
        /// </summary>
        [JsonProperty("OwnerUins")]
        public string[] OwnerUins{ get; set; }

        /// <summary>
        /// 订单号列表
        /// </summary>
        [JsonProperty("DealNames")]
        public string[] DealNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "CreatTimeRangeStart", this.CreatTimeRangeStart);
            this.SetParamSimple(map, prefix + "CreatTimeRangeEnd", this.CreatTimeRangeEnd);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "OwnerUins.", this.OwnerUins);
            this.SetParamArraySimple(map, prefix + "DealNames.", this.DealNames);
        }
    }
}

