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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewDomainBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名续费的年限。取值范围[1,9]
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 批量续费的域名。
        /// 一次提交不大于4000个
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 付费模式 0手动在线付费，1使用余额付费，2使用特惠包。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 自动续费开关。有三个可选值：
        /// 0 表示关闭，不自动续费
        /// 1 表示开启，将自动续费
        /// 2 表示不处理，保留域名原有状态（默认值）
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 特惠包ID
        /// </summary>
        [JsonProperty("PackageResourceId")]
        public string PackageResourceId{ get; set; }

        /// <summary>
        /// 渠道来源，pc/miniprogram/h5等
        /// </summary>
        [JsonProperty("ChannelFrom")]
        public string ChannelFrom{ get; set; }

        /// <summary>
        /// 订单来源，common正常/dianshi_active点石活动等
        /// </summary>
        [JsonProperty("OrderFrom")]
        public string OrderFrom{ get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PackageResourceId", this.PackageResourceId);
            this.SetParamSimple(map, prefix + "ChannelFrom", this.ChannelFrom);
            this.SetParamSimple(map, prefix + "OrderFrom", this.OrderFrom);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
        }
    }
}

