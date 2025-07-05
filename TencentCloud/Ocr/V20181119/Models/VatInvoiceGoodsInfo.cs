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

    public class VatInvoiceGoodsInfo : AbstractModel
    {
        
        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("Item")]
        public string Item{ get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [JsonProperty("Specification")]
        public string Specification{ get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("MeasurementDimension")]
        public string MeasurementDimension{ get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Quantity")]
        public string Quantity{ get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonProperty("Amount")]
        public string Amount{ get; set; }

        /// <summary>
        /// 税率(如6%、免税)
        /// </summary>
        [JsonProperty("TaxScheme")]
        public string TaxScheme{ get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonProperty("TaxAmount")]
        public string TaxAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Item", this.Item);
            this.SetParamSimple(map, prefix + "Specification", this.Specification);
            this.SetParamSimple(map, prefix + "MeasurementDimension", this.MeasurementDimension);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "TaxScheme", this.TaxScheme);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
        }
    }
}

