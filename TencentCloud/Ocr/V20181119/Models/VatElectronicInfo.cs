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

    public class VatElectronicInfo : AbstractModel
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
        /// 开票日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 税前金额
        /// </summary>
        [JsonProperty("PretaxAmount")]
        public string PretaxAmount{ get; set; }

        /// <summary>
        /// 合计税额
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// 价税合计（小写）
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 价税合计（大写）
        /// </summary>
        [JsonProperty("TotalCn")]
        public string TotalCn{ get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// 销售方纳税人识别号
        /// </summary>
        [JsonProperty("SellerTaxID")]
        public string SellerTaxID{ get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// 购买方纳税人识别号
        /// </summary>
        [JsonProperty("BuyerTaxID")]
        public string BuyerTaxID{ get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 小计金额
        /// </summary>
        [JsonProperty("SubTotal")]
        public string SubTotal{ get; set; }

        /// <summary>
        /// 小计税额
        /// </summary>
        [JsonProperty("SubTax")]
        public string SubTax{ get; set; }

        /// <summary>
        /// 电子发票详细条目信息
        /// </summary>
        [JsonProperty("VatElectronicItems")]
        public VatElectronicItemInfo[] VatElectronicItems{ get; set; }

        /// <summary>
        /// 业务类型标志
        /// </summary>
        [JsonProperty("ServiceTypeLabel")]
        public string ServiceTypeLabel{ get; set; }

        /// <summary>
        /// 价税合计(大写)前符号
        /// </summary>
        [JsonProperty("TotalCnMark")]
        public string TotalCnMark{ get; set; }

        /// <summary>
        /// 价税合计(小写)前字样
        /// </summary>
        [JsonProperty("TotalMark")]
        public string TotalMark{ get; set; }

        /// <summary>
        /// 合计金额前字样
        /// </summary>
        [JsonProperty("PretaxAmountMark")]
        public string PretaxAmountMark{ get; set; }

        /// <summary>
        /// 合计税额前字样
        /// </summary>
        [JsonProperty("TaxMark")]
        public string TaxMark{ get; set; }

        /// <summary>
        /// 是否有公司印章（0：没有，1：有）
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public long? CompanySealMark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "PretaxAmount", this.PretaxAmount);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerTaxID", this.SellerTaxID);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SubTotal", this.SubTotal);
            this.SetParamSimple(map, prefix + "SubTax", this.SubTax);
            this.SetParamArrayObj(map, prefix + "VatElectronicItems.", this.VatElectronicItems);
            this.SetParamSimple(map, prefix + "ServiceTypeLabel", this.ServiceTypeLabel);
            this.SetParamSimple(map, prefix + "TotalCnMark", this.TotalCnMark);
            this.SetParamSimple(map, prefix + "TotalMark", this.TotalMark);
            this.SetParamSimple(map, prefix + "PretaxAmountMark", this.PretaxAmountMark);
            this.SetParamSimple(map, prefix + "TaxMark", this.TaxMark);
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
        }
    }
}

