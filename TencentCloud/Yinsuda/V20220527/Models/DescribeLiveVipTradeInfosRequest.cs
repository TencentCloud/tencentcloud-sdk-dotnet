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

namespace TencentCloud.Yinsuda.V20220527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLiveVipTradeInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 直播会员充值下单起始时间，格式为 ISO。默认为当前时间前一天。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 直播会员充值下单截止时间，格式为 ISO。默认为当前时间。 EndTime不能小于StartTime
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 交易流水号集合，匹配集合指定所有流水号 。
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("TradeSerialNos")]
        public string[] TradeSerialNos{ get; set; }

        /// <summary>
        /// 用户标识集合，匹配集合指定所有用户标识 。
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 分页返回的起始偏移量，默认值：0。将返回第 Offset 到第 Offset+Limit-1 条。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页返回的记录条数，默认值：20，最大值：50。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "TradeSerialNos.", this.TradeSerialNos);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

