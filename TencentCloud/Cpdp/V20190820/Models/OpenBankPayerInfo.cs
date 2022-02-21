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

    public class OpenBankPayerInfo : AbstractModel
    {
        
        /// <summary>
        /// 付款方唯一标识。当TENPAY时，必填上送
        /// 付款方入驻云企付商户ID。
        /// </summary>
        [JsonProperty("PayerId")]
        public string PayerId{ get; set; }

        /// <summary>
        /// 付款方名称。当TENPAY上送付款方入驻云企付的商户名称。
        /// </summary>
        [JsonProperty("PayerName")]
        public string PayerName{ get; set; }

        /// <summary>
        /// 付款方付款账户标识，当付款方式为OPENBANK_PAYMENT时，必输表示企业账户ID。
        /// </summary>
        [JsonProperty("BindSerialNo")]
        public string BindSerialNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayerId", this.PayerId);
            this.SetParamSimple(map, prefix + "PayerName", this.PayerName);
            this.SetParamSimple(map, prefix + "BindSerialNo", this.BindSerialNo);
        }
    }
}

