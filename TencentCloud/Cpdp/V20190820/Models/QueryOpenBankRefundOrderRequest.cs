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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryOpenBankRefundOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户号。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 外部商户退单号，与渠道退款单号二者选填其一。
        /// </summary>
        [JsonProperty("OutRefundId")]
        public string OutRefundId{ get; set; }

        /// <summary>
        /// 渠道退款订单号，与外部商户退款单号二者选填其一。
        /// </summary>
        [JsonProperty("ChannelRefundId")]
        public string ChannelRefundId{ get; set; }

        /// <summary>
        /// 环境类型。
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// _不填默认为生产环境_
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "OutRefundId", this.OutRefundId);
            this.SetParamSimple(map, prefix + "ChannelRefundId", this.ChannelRefundId);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

