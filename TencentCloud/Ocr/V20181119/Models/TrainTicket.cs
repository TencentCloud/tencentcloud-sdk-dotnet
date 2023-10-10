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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrainTicket : AbstractModel
    {
        
        /// <summary>
        /// 发票名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 乘车日期
        /// </summary>
        [JsonProperty("DateGetOn")]
        public string DateGetOn{ get; set; }

        /// <summary>
        /// 乘车时间
        /// </summary>
        [JsonProperty("TimeGetOn")]
        public string TimeGetOn{ get; set; }

        /// <summary>
        /// 乘车人姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 出发车站
        /// </summary>
        [JsonProperty("StationGetOn")]
        public string StationGetOn{ get; set; }

        /// <summary>
        /// 到达车站
        /// </summary>
        [JsonProperty("StationGetOff")]
        public string StationGetOff{ get; set; }

        /// <summary>
        /// 座位类型
        /// </summary>
        [JsonProperty("Seat")]
        public string Seat{ get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 发票消费类型
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("UserID")]
        public string UserID{ get; set; }

        /// <summary>
        /// 检票口
        /// </summary>
        [JsonProperty("GateNumber")]
        public string GateNumber{ get; set; }

        /// <summary>
        /// 车次
        /// </summary>
        [JsonProperty("TrainNumber")]
        public string TrainNumber{ get; set; }

        /// <summary>
        /// 手续费
        /// </summary>
        [JsonProperty("HandlingFee")]
        public string HandlingFee{ get; set; }

        /// <summary>
        /// 原票价
        /// </summary>
        [JsonProperty("OriginalFare")]
        public string OriginalFare{ get; set; }

        /// <summary>
        /// 大写金额
        /// </summary>
        [JsonProperty("TotalCn")]
        public string TotalCn{ get; set; }

        /// <summary>
        /// 座位号
        /// </summary>
        [JsonProperty("SeatNumber")]
        public string SeatNumber{ get; set; }

        /// <summary>
        /// 取票地址
        /// </summary>
        [JsonProperty("PickUpAddress")]
        public string PickUpAddress{ get; set; }

        /// <summary>
        /// 是否始发改签
        /// </summary>
        [JsonProperty("TicketChange")]
        public string TicketChange{ get; set; }

        /// <summary>
        /// 加收票价
        /// </summary>
        [JsonProperty("AdditionalFare")]
        public string AdditionalFare{ get; set; }

        /// <summary>
        /// 收据号码
        /// </summary>
        [JsonProperty("ReceiptNumber")]
        public string ReceiptNumber{ get; set; }

        /// <summary>
        /// 是否存在二维码（1：有，0：无）
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// 是否仅供报销使用（0：没有，1：有）
        /// </summary>
        [JsonProperty("ReimburseOnlyMark")]
        public long? ReimburseOnlyMark{ get; set; }

        /// <summary>
        /// 是否有退票费标识（0：没有，1：有）
        /// </summary>
        [JsonProperty("RefundMark")]
        public long? RefundMark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "DateGetOn", this.DateGetOn);
            this.SetParamSimple(map, prefix + "TimeGetOn", this.TimeGetOn);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StationGetOn", this.StationGetOn);
            this.SetParamSimple(map, prefix + "StationGetOff", this.StationGetOff);
            this.SetParamSimple(map, prefix + "Seat", this.Seat);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "UserID", this.UserID);
            this.SetParamSimple(map, prefix + "GateNumber", this.GateNumber);
            this.SetParamSimple(map, prefix + "TrainNumber", this.TrainNumber);
            this.SetParamSimple(map, prefix + "HandlingFee", this.HandlingFee);
            this.SetParamSimple(map, prefix + "OriginalFare", this.OriginalFare);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "SeatNumber", this.SeatNumber);
            this.SetParamSimple(map, prefix + "PickUpAddress", this.PickUpAddress);
            this.SetParamSimple(map, prefix + "TicketChange", this.TicketChange);
            this.SetParamSimple(map, prefix + "AdditionalFare", this.AdditionalFare);
            this.SetParamSimple(map, prefix + "ReceiptNumber", this.ReceiptNumber);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamSimple(map, prefix + "ReimburseOnlyMark", this.ReimburseOnlyMark);
            this.SetParamSimple(map, prefix + "RefundMark", this.RefundMark);
        }
    }
}

