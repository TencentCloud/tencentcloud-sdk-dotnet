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

    public class CreateOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道编号。ZSB2B：招商银行B2B。
        /// </summary>
        [JsonProperty("ChannelCode")]
        public string ChannelCode{ get; set; }

        /// <summary>
        /// 进件成功后返给商户方的 AppId。
        /// </summary>
        [JsonProperty("MerchantAppId")]
        public string MerchantAppId{ get; set; }

        /// <summary>
        /// 交易金额。单位：元
        /// </summary>
        [JsonProperty("Amount")]
        public string Amount{ get; set; }

        /// <summary>
        /// 商户流水号。商户唯一订单号由字母或数字组成。
        /// </summary>
        [JsonProperty("TraceNo")]
        public string TraceNo{ get; set; }

        /// <summary>
        /// 通知地址。商户接收交易结果的通知地址。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 返回地址。支付成功后，页面将跳 转返回到商户的该地址。
        /// </summary>
        [JsonProperty("ReturnUrl")]
        public string ReturnUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelCode", this.ChannelCode);
            this.SetParamSimple(map, prefix + "MerchantAppId", this.MerchantAppId);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "TraceNo", this.TraceNo);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "ReturnUrl", this.ReturnUrl);
        }
    }
}

