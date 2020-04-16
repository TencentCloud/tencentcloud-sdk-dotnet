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

    public class QueryInvoiceForManagementRequest : AbstractModel
    {
        
        /// <summary>
        /// 开票平台ID
        /// </summary>
        [JsonProperty("InvoicePlatformId")]
        public long? InvoicePlatformId{ get; set; }

        /// <summary>
        /// 开票状态
        /// </summary>
        [JsonProperty("InvoiceStatus")]
        public long? InvoiceStatus{ get; set; }

        /// <summary>
        /// 红冲状态
        /// </summary>
        [JsonProperty("RedInvoiceStatus")]
        public long? RedInvoiceStatus{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 发票ID
        /// </summary>
        [JsonProperty("InvoiceId")]
        public string InvoiceId{ get; set; }

        /// <summary>
        /// 业务开票号
        /// </summary>
        [JsonProperty("OrderSn")]
        public string OrderSn{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("InvoiceSn")]
        public string InvoiceSn{ get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("InvoiceCode")]
        public string InvoiceCode{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填 sandbox。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvoicePlatformId", this.InvoicePlatformId);
            this.SetParamSimple(map, prefix + "InvoiceStatus", this.InvoiceStatus);
            this.SetParamSimple(map, prefix + "RedInvoiceStatus", this.RedInvoiceStatus);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "InvoiceId", this.InvoiceId);
            this.SetParamSimple(map, prefix + "OrderSn", this.OrderSn);
            this.SetParamSimple(map, prefix + "InvoiceSn", this.InvoiceSn);
            this.SetParamSimple(map, prefix + "InvoiceCode", this.InvoiceCode);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

