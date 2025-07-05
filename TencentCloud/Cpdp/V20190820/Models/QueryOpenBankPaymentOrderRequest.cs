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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryOpenBankPaymentOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户号。外部接入平台入驻云企付平台下发。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 外部商户订单号。与ChannelOrderId不能同时为空。若传空串即表示忽略该参数。
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 云平台订单号。与OutOrderId不能同时为空。若调用下单接口时，发生异常，无法取到ChannelOrderId，传空串即可
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填 sandbox。缺省默认调用生产环境。
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "OutOrderId", this.OutOrderId);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

