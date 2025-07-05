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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrainTicketOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("TicketNum")]
        public string TicketNum{ get; set; }

        /// <summary>
        /// 出发站
        /// </summary>
        [JsonProperty("StartStation")]
        public string StartStation{ get; set; }

        /// <summary>
        /// 到达站
        /// </summary>
        [JsonProperty("DestinationStation")]
        public string DestinationStation{ get; set; }

        /// <summary>
        /// 出发时间
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 车次
        /// </summary>
        [JsonProperty("TrainNum")]
        public string TrainNum{ get; set; }

        /// <summary>
        /// 座位号
        /// </summary>
        [JsonProperty("Seat")]
        public string Seat{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// 席别
        /// </summary>
        [JsonProperty("SeatCategory")]
        public string SeatCategory{ get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 发票消费类型：交通
        /// </summary>
        [JsonProperty("InvoiceType")]
        public string InvoiceType{ get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// 加收票价
        /// </summary>
        [JsonProperty("AdditionalCost")]
        public string AdditionalCost{ get; set; }

        /// <summary>
        /// 手续费
        /// </summary>
        [JsonProperty("HandlingFee")]
        public string HandlingFee{ get; set; }

        /// <summary>
        /// 大写金额（票面有大写金额该字段才有值）
        /// </summary>
        [JsonProperty("LegalAmount")]
        public string LegalAmount{ get; set; }

        /// <summary>
        /// 售票站
        /// </summary>
        [JsonProperty("TicketStation")]
        public string TicketStation{ get; set; }

        /// <summary>
        /// 原票价（一般有手续费的才有原始票价字段）
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public string OriginalPrice{ get; set; }

        /// <summary>
        /// 发票类型：火车票、火车票补票、火车票退票凭证
        /// </summary>
        [JsonProperty("InvoiceStyle")]
        public string InvoiceStyle{ get; set; }

        /// <summary>
        /// 收据号码
        /// </summary>
        [JsonProperty("ReceiptNumber")]
        public string ReceiptNumber{ get; set; }

        /// <summary>
        /// 仅供报销使用：1为是，0为否
        /// </summary>
        [JsonProperty("IsReceipt")]
        public string IsReceipt{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TicketNum", this.TicketNum);
            this.SetParamSimple(map, prefix + "StartStation", this.StartStation);
            this.SetParamSimple(map, prefix + "DestinationStation", this.DestinationStation);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "TrainNum", this.TrainNum);
            this.SetParamSimple(map, prefix + "Seat", this.Seat);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "SeatCategory", this.SeatCategory);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "InvoiceType", this.InvoiceType);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "AdditionalCost", this.AdditionalCost);
            this.SetParamSimple(map, prefix + "HandlingFee", this.HandlingFee);
            this.SetParamSimple(map, prefix + "LegalAmount", this.LegalAmount);
            this.SetParamSimple(map, prefix + "TicketStation", this.TicketStation);
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "InvoiceStyle", this.InvoiceStyle);
            this.SetParamSimple(map, prefix + "ReceiptNumber", this.ReceiptNumber);
            this.SetParamSimple(map, prefix + "IsReceipt", this.IsReceipt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

