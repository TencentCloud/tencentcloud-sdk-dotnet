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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TradeInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>交易订单号</p>
        /// </summary>
        [JsonProperty("DealName")]
        public string DealName{ get; set; }

        /// <summary>
        /// <p>上一次交易订单号</p>
        /// </summary>
        [JsonProperty("LastDealName")]
        public string LastDealName{ get; set; }

        /// <summary>
        /// <p>实例规格，包括：micro、small、medium、large、xlarge、2xlarge等</p>
        /// </summary>
        [JsonProperty("InstanceClass")]
        public string InstanceClass{ get; set; }

        /// <summary>
        /// <p>计费任务状态， normal(计费或待计费)、resizing(变配中)、reversing(冲正中，比较短暂的状态)、isolating(隔离中，比较短暂的状态)、isolated(已隔离)、offlining(下线中)、offlined(已下线)、notBilled(未计费)</p>
        /// </summary>
        [JsonProperty("TradeStatus")]
        public string TradeStatus{ get; set; }

        /// <summary>
        /// <p>到期时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>下线时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// <p>隔离时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// <p>下线原因</p>
        /// </summary>
        [JsonProperty("OfflineReason")]
        public string OfflineReason{ get; set; }

        /// <summary>
        /// <p>隔离原因</p>
        /// </summary>
        [JsonProperty("IsolateReason")]
        public string IsolateReason{ get; set; }

        /// <summary>
        /// <p>付费类型，包括：postpay(后付费)、prepay(预付费)</p>
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// <p>任务计费类型，包括：billing(计费)、notBilling(不计费)、 promotions(促销活动中)</p>
        /// </summary>
        [JsonProperty("BillingType")]
        public string BillingType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DealName", this.DealName);
            this.SetParamSimple(map, prefix + "LastDealName", this.LastDealName);
            this.SetParamSimple(map, prefix + "InstanceClass", this.InstanceClass);
            this.SetParamSimple(map, prefix + "TradeStatus", this.TradeStatus);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "OfflineReason", this.OfflineReason);
            this.SetParamSimple(map, prefix + "IsolateReason", this.IsolateReason);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "BillingType", this.BillingType);
        }
    }
}

