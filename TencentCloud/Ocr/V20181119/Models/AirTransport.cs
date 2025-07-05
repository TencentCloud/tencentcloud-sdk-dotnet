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

    public class AirTransport : AbstractModel
    {
        
        /// <summary>
        /// 发票名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 电子客票号码
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// 印刷序号
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 销售单位代号
        /// </summary>
        [JsonProperty("AgentCode")]
        public string AgentCode{ get; set; }

        /// <summary>
        /// 销售单位代号第一行
        /// </summary>
        [JsonProperty("AgentCodeFirst")]
        public string AgentCodeFirst{ get; set; }

        /// <summary>
        /// 销售单位代号第二行
        /// </summary>
        [JsonProperty("AgentCodeSecond")]
        public string AgentCodeSecond{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("UserID")]
        public string UserID{ get; set; }

        /// <summary>
        /// 填开单位
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        [JsonProperty("Fare")]
        public string Fare{ get; set; }

        /// <summary>
        /// 合计税额
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// 燃油附加费
        /// </summary>
        [JsonProperty("FuelSurcharge")]
        public string FuelSurcharge{ get; set; }

        /// <summary>
        /// 民航发展基金
        /// </summary>
        [JsonProperty("AirDevelopmentFund")]
        public string AirDevelopmentFund{ get; set; }

        /// <summary>
        /// 保险费
        /// </summary>
        [JsonProperty("Insurance")]
        public string Insurance{ get; set; }

        /// <summary>
        /// 合计金额（小写）
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 发票消费类型
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 国内国际标签
        /// </summary>
        [JsonProperty("DomesticInternationalTag")]
        public string DomesticInternationalTag{ get; set; }

        /// <summary>
        /// 客票生效日期
        /// </summary>
        [JsonProperty("DateStart")]
        public string DateStart{ get; set; }

        /// <summary>
        /// 有效截止日期
        /// </summary>
        [JsonProperty("DateEnd")]
        public string DateEnd{ get; set; }

        /// <summary>
        /// 签注
        /// </summary>
        [JsonProperty("Endorsement")]
        public string Endorsement{ get; set; }

        /// <summary>
        /// 是否存在二维码（1：有，0：无）
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// 条目
        /// </summary>
        [JsonProperty("FlightItems")]
        public FlightItem[] FlightItems{ get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [JsonProperty("PromptInformation")]
        public string PromptInformation{ get; set; }

        /// <summary>
        /// 统一社会信用代码/纳税人识别号
        /// </summary>
        [JsonProperty("BuyerTaxID")]
        public string BuyerTaxID{ get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("ReceiptNumber")]
        public string ReceiptNumber{ get; set; }

        /// <summary>
        /// 开票状态
        /// </summary>
        [JsonProperty("InvoiceStatus")]
        public string InvoiceStatus{ get; set; }

        /// <summary>
        /// 增值税税率
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// 增值税税额
        /// </summary>
        [JsonProperty("TaxAmount")]
        public string TaxAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "AgentCode", this.AgentCode);
            this.SetParamSimple(map, prefix + "AgentCodeFirst", this.AgentCodeFirst);
            this.SetParamSimple(map, prefix + "AgentCodeSecond", this.AgentCodeSecond);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserID", this.UserID);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Fare", this.Fare);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "FuelSurcharge", this.FuelSurcharge);
            this.SetParamSimple(map, prefix + "AirDevelopmentFund", this.AirDevelopmentFund);
            this.SetParamSimple(map, prefix + "Insurance", this.Insurance);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "DomesticInternationalTag", this.DomesticInternationalTag);
            this.SetParamSimple(map, prefix + "DateStart", this.DateStart);
            this.SetParamSimple(map, prefix + "DateEnd", this.DateEnd);
            this.SetParamSimple(map, prefix + "Endorsement", this.Endorsement);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamArrayObj(map, prefix + "FlightItems.", this.FlightItems);
            this.SetParamSimple(map, prefix + "PromptInformation", this.PromptInformation);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "ReceiptNumber", this.ReceiptNumber);
            this.SetParamSimple(map, prefix + "InvoiceStatus", this.InvoiceStatus);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
        }
    }
}

