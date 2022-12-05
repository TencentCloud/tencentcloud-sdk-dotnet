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

    public class ApplyFlexPaymentResult : AbstractModel
    {
        
        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 税前金额
        /// </summary>
        [JsonProperty("AmountBeforeTax")]
        public string AmountBeforeTax{ get; set; }

        /// <summary>
        /// 税后金额
        /// </summary>
        [JsonProperty("AmountAfterTax")]
        public string AmountAfterTax{ get; set; }

        /// <summary>
        /// 税金
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// 增值税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vat")]
        public string Vat{ get; set; }

        /// <summary>
        /// 个人所得税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndividualIncomeTax")]
        public string IndividualIncomeTax{ get; set; }

        /// <summary>
        /// 附加税总税额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdditionalTaxSum")]
        public string AdditionalTaxSum{ get; set; }

        /// <summary>
        /// 附加税税项。格式为JSON格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdditionalTaxItem")]
        public string AdditionalTaxItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "AmountBeforeTax", this.AmountBeforeTax);
            this.SetParamSimple(map, prefix + "AmountAfterTax", this.AmountAfterTax);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "Vat", this.Vat);
            this.SetParamSimple(map, prefix + "IndividualIncomeTax", this.IndividualIncomeTax);
            this.SetParamSimple(map, prefix + "AdditionalTaxSum", this.AdditionalTaxSum);
            this.SetParamSimple(map, prefix + "AdditionalTaxItem", this.AdditionalTaxItem);
        }
    }
}

