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

    public class QueryInvoiceResultData : AbstractModel
    {
        
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 业务开票号
        /// </summary>
        [JsonProperty("OrderSn")]
        public string OrderSn{ get; set; }

        /// <summary>
        /// 发票状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 开票描述
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonProperty("TicketDate")]
        public string TicketDate{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("TicketSn")]
        public string TicketSn{ get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("TicketCode")]
        public string TicketCode{ get; set; }

        /// <summary>
        /// 检验码
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// 含税金额(元)
        /// </summary>
        [JsonProperty("AmountWithTax")]
        public string AmountWithTax{ get; set; }

        /// <summary>
        /// 不含税金额(元)
        /// </summary>
        [JsonProperty("AmountWithoutTax")]
        public string AmountWithoutTax{ get; set; }

        /// <summary>
        /// 税额(元)
        /// </summary>
        [JsonProperty("TaxAmount")]
        public string TaxAmount{ get; set; }

        /// <summary>
        /// 是否被红冲
        /// </summary>
        [JsonProperty("IsRedWashed")]
        public long? IsRedWashed{ get; set; }

        /// <summary>
        /// pdf地址
        /// </summary>
        [JsonProperty("PdfUrl")]
        public string PdfUrl{ get; set; }

        /// <summary>
        /// png地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "OrderSn", this.OrderSn);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "TicketDate", this.TicketDate);
            this.SetParamSimple(map, prefix + "TicketSn", this.TicketSn);
            this.SetParamSimple(map, prefix + "TicketCode", this.TicketCode);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "AmountWithTax", this.AmountWithTax);
            this.SetParamSimple(map, prefix + "AmountWithoutTax", this.AmountWithoutTax);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
            this.SetParamSimple(map, prefix + "IsRedWashed", this.IsRedWashed);
            this.SetParamSimple(map, prefix + "PdfUrl", this.PdfUrl);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
        }
    }
}

