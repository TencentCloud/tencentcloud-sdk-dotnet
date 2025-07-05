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

    public class CreateRedInvoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 开票平台ID
        /// 0 : 高灯
        /// 1 : 票易通
        /// </summary>
        [JsonProperty("InvoicePlatformId")]
        public long? InvoicePlatformId{ get; set; }

        /// <summary>
        /// 红冲明细
        /// </summary>
        [JsonProperty("Invoices")]
        public CreateRedInvoiceItem[] Invoices{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填 sandbox。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// 开票渠道。0：线上渠道，1：线下渠道。不填默认为线上渠道
        /// </summary>
        [JsonProperty("InvoiceChannel")]
        public long? InvoiceChannel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvoicePlatformId", this.InvoicePlatformId);
            this.SetParamArrayObj(map, prefix + "Invoices.", this.Invoices);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "InvoiceChannel", this.InvoiceChannel);
        }
    }
}

