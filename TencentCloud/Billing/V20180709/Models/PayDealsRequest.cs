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

    public class PayDealsRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要支付的一个或者多个子订单号，与BigDealIds字段两者必须且仅传一个参数
        /// </summary>
        [JsonProperty("OrderIds")]
        public string[] OrderIds{ get; set; }

        /// <summary>
        /// 是否自动使用代金券,1:是,0否,默认0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// 代金券ID列表,目前仅支持指定一张代金券
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// 需要支付的一个或者多个大订单号，与OrderIds字段两者必须且仅传一个参数
        /// </summary>
        [JsonProperty("BigDealIds")]
        public string[] BigDealIds{ get; set; }

        /// <summary>
        /// 0非代理，1代理商代付，3集团代理，4代理商为代客下产品级代付单，默认0
        /// </summary>
        [JsonProperty("AgentPay")]
        public long? AgentPay{ get; set; }

        /// <summary>
        /// 推荐者，用于返利
        /// </summary>
        [JsonProperty("CpsUin")]
        public string CpsUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "OrderIds.", this.OrderIds);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamArraySimple(map, prefix + "BigDealIds.", this.BigDealIds);
            this.SetParamSimple(map, prefix + "AgentPay", this.AgentPay);
            this.SetParamSimple(map, prefix + "CpsUin", this.CpsUin);
        }
    }
}

