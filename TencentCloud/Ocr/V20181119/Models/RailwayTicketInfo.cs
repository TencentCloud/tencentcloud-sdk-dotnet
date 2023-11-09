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

    public class RailwayTicketInfo : AbstractModel
    {
        
        /// <summary>
        /// 电子发票类型
        /// </summary>
        [JsonProperty("TypeOfVoucher")]
        public string TypeOfVoucher{ get; set; }

        /// <summary>
        /// 电子客票号
        /// </summary>
        [JsonProperty("ElectronicTicketNum")]
        public string ElectronicTicketNum{ get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonProperty("DateOfIssue")]
        public string DateOfIssue{ get; set; }

        /// <summary>
        /// 售票或退票类型
        /// </summary>
        [JsonProperty("TypeOfBusiness")]
        public string TypeOfBusiness{ get; set; }

        /// <summary>
        /// 始发站
        /// </summary>
        [JsonProperty("DepartureStation")]
        public string DepartureStation{ get; set; }

        /// <summary>
        /// 始发站英文
        /// </summary>
        [JsonProperty("PhonicsOfDepartureStation")]
        public string PhonicsOfDepartureStation{ get; set; }

        /// <summary>
        /// 到达站
        /// </summary>
        [JsonProperty("DestinationStation")]
        public string DestinationStation{ get; set; }

        /// <summary>
        /// 到达站英文
        /// </summary>
        [JsonProperty("PhonicsOfDestinationStation")]
        public string PhonicsOfDestinationStation{ get; set; }

        /// <summary>
        /// 火车号
        /// </summary>
        [JsonProperty("TrainNumber")]
        public string TrainNumber{ get; set; }

        /// <summary>
        /// 火车出发日期
        /// </summary>
        [JsonProperty("TravelDate")]
        public string TravelDate{ get; set; }

        /// <summary>
        /// 始发时间
        /// </summary>
        [JsonProperty("DepartureTime")]
        public string DepartureTime{ get; set; }

        /// <summary>
        /// 空调特点
        /// </summary>
        [JsonProperty("AirConditioningCharacteristics")]
        public string AirConditioningCharacteristics{ get; set; }

        /// <summary>
        /// 座位类型
        /// </summary>
        [JsonProperty("SeatLevel")]
        public string SeatLevel{ get; set; }

        /// <summary>
        /// 火车第几车
        /// </summary>
        [JsonProperty("Carriage")]
        public string Carriage{ get; set; }

        /// <summary>
        /// 座位号
        /// </summary>
        [JsonProperty("Seat")]
        public string Seat{ get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        [JsonProperty("Fare")]
        public string Fare{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("ElectronicInvoiceRailwayETicketNumber")]
        public string ElectronicInvoiceRailwayETicketNumber{ get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("IdNumber")]
        public string IdNumber{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonProperty("TotalAmountExcludingTax")]
        public string TotalAmountExcludingTax{ get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonProperty("TaxAmount")]
        public string TaxAmount{ get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [JsonProperty("NameOfPurchaser")]
        public string NameOfPurchaser{ get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonProperty("UnifiedSocialCreditCodeOfPurchaser")]
        public string UnifiedSocialCreditCodeOfPurchaser{ get; set; }

        /// <summary>
        /// 原发票号码
        /// </summary>
        [JsonProperty("NumberOfOriginalInvoice")]
        public string NumberOfOriginalInvoice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeOfVoucher", this.TypeOfVoucher);
            this.SetParamSimple(map, prefix + "ElectronicTicketNum", this.ElectronicTicketNum);
            this.SetParamSimple(map, prefix + "DateOfIssue", this.DateOfIssue);
            this.SetParamSimple(map, prefix + "TypeOfBusiness", this.TypeOfBusiness);
            this.SetParamSimple(map, prefix + "DepartureStation", this.DepartureStation);
            this.SetParamSimple(map, prefix + "PhonicsOfDepartureStation", this.PhonicsOfDepartureStation);
            this.SetParamSimple(map, prefix + "DestinationStation", this.DestinationStation);
            this.SetParamSimple(map, prefix + "PhonicsOfDestinationStation", this.PhonicsOfDestinationStation);
            this.SetParamSimple(map, prefix + "TrainNumber", this.TrainNumber);
            this.SetParamSimple(map, prefix + "TravelDate", this.TravelDate);
            this.SetParamSimple(map, prefix + "DepartureTime", this.DepartureTime);
            this.SetParamSimple(map, prefix + "AirConditioningCharacteristics", this.AirConditioningCharacteristics);
            this.SetParamSimple(map, prefix + "SeatLevel", this.SeatLevel);
            this.SetParamSimple(map, prefix + "Carriage", this.Carriage);
            this.SetParamSimple(map, prefix + "Seat", this.Seat);
            this.SetParamSimple(map, prefix + "Fare", this.Fare);
            this.SetParamSimple(map, prefix + "ElectronicInvoiceRailwayETicketNumber", this.ElectronicInvoiceRailwayETicketNumber);
            this.SetParamSimple(map, prefix + "IdNumber", this.IdNumber);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TotalAmountExcludingTax", this.TotalAmountExcludingTax);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
            this.SetParamSimple(map, prefix + "NameOfPurchaser", this.NameOfPurchaser);
            this.SetParamSimple(map, prefix + "UnifiedSocialCreditCodeOfPurchaser", this.UnifiedSocialCreditCodeOfPurchaser);
            this.SetParamSimple(map, prefix + "NumberOfOriginalInvoice", this.NumberOfOriginalInvoice);
        }
    }
}

