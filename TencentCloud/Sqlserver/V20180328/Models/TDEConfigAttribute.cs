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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TDEConfigAttribute : AbstractModel
    {
        
        /// <summary>
        /// 是否已开通TDE加密，enable-已开通，disable-未开通
        /// </summary>
        [JsonProperty("Encryption")]
        public string Encryption{ get; set; }

        /// <summary>
        /// 证书归属。self-表示使用该账号自身的证书，others-表示引用其他账号的证书，none-表示没有证书
        /// </summary>
        [JsonProperty("CertificateAttribution")]
        public string CertificateAttribution{ get; set; }

        /// <summary>
        /// 开通TDE加密时引用的其他主账号ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuoteUin")]
        public string QuoteUin{ get; set; }

        /// <summary>
        /// KMS中购买的用户主密钥ID（CMK）
        /// </summary>
        [JsonProperty("CMKId")]
        public string CMKId{ get; set; }

        /// <summary>
        /// CMK所属的地域，不同地域的CMK不互通
        /// </summary>
        [JsonProperty("CMKRegion")]
        public string CMKRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
            this.SetParamSimple(map, prefix + "CertificateAttribution", this.CertificateAttribution);
            this.SetParamSimple(map, prefix + "QuoteUin", this.QuoteUin);
            this.SetParamSimple(map, prefix + "CMKId", this.CMKId);
            this.SetParamSimple(map, prefix + "CMKRegion", this.CMKRegion);
        }
    }
}

