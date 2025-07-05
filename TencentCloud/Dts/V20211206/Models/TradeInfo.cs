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
        /// 交易订单号
        /// </summary>
        [JsonProperty("DealName")]
        public string DealName{ get; set; }

        /// <summary>
        /// 上一次交易订单号
        /// </summary>
        [JsonProperty("LastDealName")]
        public string LastDealName{ get; set; }

        /// <summary>
        /// 实例规格，包括：micro、small、medium、large、xlarge、2xlarge等
        /// </summary>
        [JsonProperty("InstanceClass")]
        public string InstanceClass{ get; set; }

        /// <summary>
        /// 计费任务状态， normal(计费或待计费)、resizing(变配中)、reversing(冲正中，比较短暂的状态)、isolating(隔离中，比较短暂的状态)、isolated(已隔离)、offlining(下线中)、offlined(已下线)、notBilled(未计费)
        /// </summary>
        [JsonProperty("TradeStatus")]
        public string TradeStatus{ get; set; }

        /// <summary>
        /// 到期时间，格式为"yyyy-mm-dd hh:mm:ss"
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 下线时间，格式为"yyyy-mm-dd hh:mm:ss"
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// 隔离时间，格式为"yyyy-mm-dd hh:mm:ss"
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// 下线原因
        /// </summary>
        [JsonProperty("OfflineReason")]
        public string OfflineReason{ get; set; }

        /// <summary>
        /// 隔离原因
        /// </summary>
        [JsonProperty("IsolateReason")]
        public string IsolateReason{ get; set; }

        /// <summary>
        /// 付费类型，包括：postpay(后付费)、prepay(预付费)
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 任务计费类型，包括：billing(计费)、notBilling(不计费)、 promotions(促销活动中)
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

