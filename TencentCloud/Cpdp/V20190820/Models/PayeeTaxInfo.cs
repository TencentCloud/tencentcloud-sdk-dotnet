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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PayeeTaxInfo : AbstractModel
    {
        
        /// <summary>
        /// 计税模板列表
        /// </summary>
        [JsonProperty("TaxTemplateInfoList")]
        public PayeeTaxTemplateInfo[] TaxTemplateInfoList{ get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [JsonProperty("TaxpayerIdNo")]
        public string TaxpayerIdNo{ get; set; }

        /// <summary>
        /// 纳税主体类型
        /// NATURAL:自然人
        /// NON_NATURAL:非自然人
        /// </summary>
        [JsonProperty("TaxEntityType")]
        public string TaxEntityType{ get; set; }

        /// <summary>
        /// 财税服务商ID
        /// </summary>
        [JsonProperty("TaxServiceProviderId")]
        public string TaxServiceProviderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TaxTemplateInfoList.", this.TaxTemplateInfoList);
            this.SetParamSimple(map, prefix + "TaxpayerIdNo", this.TaxpayerIdNo);
            this.SetParamSimple(map, prefix + "TaxEntityType", this.TaxEntityType);
            this.SetParamSimple(map, prefix + "TaxServiceProviderId", this.TaxServiceProviderId);
        }
    }
}

