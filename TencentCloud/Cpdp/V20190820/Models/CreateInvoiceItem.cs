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

    public class CreateInvoiceItem : AbstractModel
    {
        
        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 税收商品编码
        /// </summary>
        [JsonProperty("TaxCode")]
        public string TaxCode{ get; set; }

        /// <summary>
        /// 不含税商品总价（商品含税价总额/（1+税率））。InvoicePlatformId 为1时，该金额为含税总金额。单位为分。
        /// </summary>
        [JsonProperty("TotalPrice")]
        public long? TotalPrice{ get; set; }

        /// <summary>
        /// 商品税率
        /// </summary>
        [JsonProperty("TaxRate")]
        public long? TaxRate{ get; set; }

        /// <summary>
        /// 商品税额（不含税商品总价*税率）。单位为分
        /// </summary>
        [JsonProperty("TaxAmount")]
        public long? TaxAmount{ get; set; }

        /// <summary>
        /// 税收商品类别
        /// </summary>
        [JsonProperty("TaxType")]
        public string TaxType{ get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonProperty("Models")]
        public string Models{ get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 不含税商品单价。InvoicePlatformId 为1时，该金额为含税单价。
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// 含税折扣总额。单位为分
        /// </summary>
        [JsonProperty("Discount")]
        public long? Discount{ get; set; }

        /// <summary>
        /// 优惠政策标志。0：不使用优惠政策；1：使用优惠政策。
        /// </summary>
        [JsonProperty("PreferentialPolicyFlag")]
        public string PreferentialPolicyFlag{ get; set; }

        /// <summary>
        /// 零税率标识：
        /// 空：非零税率；
        /// 0：出口零税率；
        /// 1：免税；
        /// 2：不征税；
        /// 3：普通零税率。
        /// </summary>
        [JsonProperty("ZeroTaxFlag")]
        public string ZeroTaxFlag{ get; set; }

        /// <summary>
        /// 增值税特殊管理。PreferentialPolicyFlag字段为1时，必填。目前仅支持5%(3%，2%，1.5%)简易征税、免税、不征税。
        /// </summary>
        [JsonProperty("VatSpecialManagement")]
        public string VatSpecialManagement{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TaxCode", this.TaxCode);
            this.SetParamSimple(map, prefix + "TotalPrice", this.TotalPrice);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
            this.SetParamSimple(map, prefix + "TaxType", this.TaxType);
            this.SetParamSimple(map, prefix + "Models", this.Models);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "PreferentialPolicyFlag", this.PreferentialPolicyFlag);
            this.SetParamSimple(map, prefix + "ZeroTaxFlag", this.ZeroTaxFlag);
            this.SetParamSimple(map, prefix + "VatSpecialManagement", this.VatSpecialManagement);
        }
    }
}

