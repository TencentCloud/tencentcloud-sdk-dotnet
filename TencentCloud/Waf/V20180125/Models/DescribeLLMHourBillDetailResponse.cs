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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLLMHourBillDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 查询日期，归一化为YYYY-MM-DD格式
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 当日账单预估总额（元，扣减免费额度后的净费用）
        /// </summary>
        [JsonProperty("EstimatedTotalFee")]
        public string EstimatedTotalFee{ get; set; }

        /// <summary>
        /// 当日按计费项拆分的费用
        /// </summary>
        [JsonProperty("ItemFees")]
        public LLMBillItemFee ItemFees{ get; set; }

        /// <summary>
        /// 24小时账单趋势，固定24条，无数据补0
        /// </summary>
        [JsonProperty("HourlyTrend")]
        public LLMHourBillTrendItem[] HourlyTrend{ get; set; }

        /// <summary>
        /// 24小时账单明细，固定24条，无数据补0
        /// </summary>
        [JsonProperty("HourlyDetail")]
        public LLMHourBillDetailItem[] HourlyDetail{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "EstimatedTotalFee", this.EstimatedTotalFee);
            this.SetParamObj(map, prefix + "ItemFees.", this.ItemFees);
            this.SetParamArrayObj(map, prefix + "HourlyTrend.", this.HourlyTrend);
            this.SetParamArrayObj(map, prefix + "HourlyDetail.", this.HourlyDetail);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

