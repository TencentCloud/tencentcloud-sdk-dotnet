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

    public class CreateBatchPaymentRequest : AbstractModel
    {
        
        /// <summary>
        /// 1 微信企业付款 
        /// 2 支付宝转账 
        /// 3 平安银企直连代发转账
        /// </summary>
        [JsonProperty("TransferType")]
        public long? TransferType{ get; set; }

        /// <summary>
        /// 转账详情
        /// </summary>
        [JsonProperty("RecipientList")]
        public CreateBatchPaymentRecipient[] RecipientList{ get; set; }

        /// <summary>
        /// 请求预留字段
        /// </summary>
        [JsonProperty("ReqReserved")]
        public string ReqReserved{ get; set; }

        /// <summary>
        /// 回调Url
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransferType", this.TransferType);
            this.SetParamArrayObj(map, prefix + "RecipientList.", this.RecipientList);
            this.SetParamSimple(map, prefix + "ReqReserved", this.ReqReserved);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
        }
    }
}

