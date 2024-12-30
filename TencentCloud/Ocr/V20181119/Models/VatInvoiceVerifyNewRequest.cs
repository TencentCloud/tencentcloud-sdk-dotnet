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

    public class VatInvoiceVerifyNewRequest : AbstractModel
    {
        
        /// <summary>
        /// 发票号码，8位、20位（全电票）
        /// </summary>
        [JsonProperty("InvoiceNo")]
        public string InvoiceNo{ get; set; }

        /// <summary>
        /// 开票日期（不支持当天发票查询，支持五年以内开具的发票），格式：“YYYY-MM-DD”，如：2019-12-20。
        /// </summary>
        [JsonProperty("InvoiceDate")]
        public string InvoiceDate{ get; set; }

        /// <summary>
        /// 发票代码（10或12 位），全电发票为空。查验超过5次后当日无法再查。
        /// </summary>
        [JsonProperty("InvoiceCode")]
        public string InvoiceCode{ get; set; }

        /// <summary>
        /// 票种类型 01:增值税专用发票， 02:货运运输业增值税专用发 票， 03:机动车销售统一发票， 04:增值税普通发票， 08:增值税电子专用发票(含全电)， 10:增值税电子普通发票(含全电)， 11:增值税普通发票(卷式)， 14:增值税电子(通行费)发 票， 15:二手车销售统一发票，16:财务发票， 32:深圳区块链发票(云南区块链因业务调整现已下线)。
        /// </summary>
        [JsonProperty("InvoiceKind")]
        public string InvoiceKind{ get; set; }

        /// <summary>
        /// 校验码后 6 位，增值税普通发票、增值税电子普通发票、增值税普通发票(卷式)、增值税电子普通发票(通行费)、全电纸质发票（增值税普通发票）、财政票据时必填;
        /// 区块链为 5 位
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// 不含税金额，增值税专用发票、增值税电子专用发票、机动车销售统一发票、二手车销售统一发票、区块链发票、财政发票时必填; 全电发票为价税合计(含税金额)
        /// </summary>
        [JsonProperty("Amount")]
        public string Amount{ get; set; }

        /// <summary>
        /// 地区编码，通用机打电子发票时必填。
        /// 广东:4400，浙江:3300
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// 销方税号，通用机打电子发票必填，区块链发票时必填
        /// </summary>
        [JsonProperty("SellerTaxCode")]
        public string SellerTaxCode{ get; set; }

        /// <summary>
        /// 是否开启通用机打电子发票，默认为关闭。
        /// </summary>
        [JsonProperty("EnableCommonElectronic")]
        public bool? EnableCommonElectronic{ get; set; }

        /// <summary>
        /// 是否允许查验当日发票，默认值为false。请注意，发票从开具到录入税局需要一定的时间来更新和验证发票信息，打开后仅支持查验已成功录入到税局中的当日发票。
        /// </summary>
        [JsonProperty("EnableTodayInvoice")]
        public bool? EnableTodayInvoice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvoiceNo", this.InvoiceNo);
            this.SetParamSimple(map, prefix + "InvoiceDate", this.InvoiceDate);
            this.SetParamSimple(map, prefix + "InvoiceCode", this.InvoiceCode);
            this.SetParamSimple(map, prefix + "InvoiceKind", this.InvoiceKind);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "SellerTaxCode", this.SellerTaxCode);
            this.SetParamSimple(map, prefix + "EnableCommonElectronic", this.EnableCommonElectronic);
            this.SetParamSimple(map, prefix + "EnableTodayInvoice", this.EnableTodayInvoice);
        }
    }
}

