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

    public class DescribeDealsByCondRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>开始时间 2016-01-01 00:00:00</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间 2016-02-01 00:00:00 建议跨度不超过3个月</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>一页多少条数据，默认是20条，最大不超过1000</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>第多少页，从0开始，默认是0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>订单状态</p><p>枚举值：</p><ul><li>1：  待支付</li><li>2：  已支付</li><li>3：  发货中</li><li>4：  已发货</li><li>5：  发货失败</li><li>6：  已退款</li><li>7：  已取消</li><li>8：  订单过期</li><li>9 ：  订单已失效</li><li>10：  产品已失效</li><li>11：  代付拒绝</li><li>12：  支付中</li><li>13：  退款中</li><li>30：  服务市场订单待用户确认完成</li></ul><p>默认值：4（已发货，成功的订单）</p><p>其中，状态2、3、5、12、13、30 在<a href="https://console.cloud.tencent.com/expense/deal">控制台</a>统一显示“处理中”；<br>状态4 在<a href="https://console.cloud.tencent.com/expense/deal">控制台</a>中显示交易成功；<br>状态9、10 在<a href="https://console.cloud.tencent.com/expense/deal">控制台</a>中无对应状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>子订单号</p>
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// <p>大订单号</p>
        /// </summary>
        [JsonProperty("BigDealId")]
        public string BigDealId{ get; set; }

        /// <summary>
        /// <p>资源id</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>订单状态</p>
        /// </summary>
        [JsonProperty("StatusSet")]
        public long?[] StatusSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "BigDealId", this.BigDealId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamArraySimple(map, prefix + "StatusSet.", this.StatusSet);
        }
    }
}

