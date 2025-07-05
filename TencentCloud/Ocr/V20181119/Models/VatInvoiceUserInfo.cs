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

    public class VatInvoiceUserInfo : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [JsonProperty("TaxId")]
        public string TaxId{ get; set; }

        /// <summary>
        /// 地 址、电 话
        /// </summary>
        [JsonProperty("AddrTel")]
        public string AddrTel{ get; set; }

        /// <summary>
        /// 开户行及账号
        /// </summary>
        [JsonProperty("FinancialAccount")]
        public string FinancialAccount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TaxId", this.TaxId);
            this.SetParamSimple(map, prefix + "AddrTel", this.AddrTel);
            this.SetParamSimple(map, prefix + "FinancialAccount", this.FinancialAccount);
        }
    }
}

