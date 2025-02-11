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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainValidationResult : AbstractModel
    {
        
        /// <summary>
        /// 证书绑定的域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 域名验证类型。 取值为：DNS、FILE、DNS_AUTO、DNS_PROXY、FILE_PROXY
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// 腾讯云检测结果，取值：1（验证通过）； -1（被限频或者 txt record not found）；-2（txt record not match）；-3（ns record not found）；-4（file not found）；-5（file not match）；-6（cname record not found）；-7（cname record not match）；-8（ns record not found）-9（file not found）；-10（file not match）
        /// </summary>
        [JsonProperty("LocalCheck")]
        public long? LocalCheck{ get; set; }

        /// <summary>
        /// CA检查结果。取值： -1（未检测通过）；2（检测通过）
        /// </summary>
        [JsonProperty("CaCheck")]
        public long? CaCheck{ get; set; }

        /// <summary>
        /// 检查失败原因。状态LocalCheck的具体描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalCheckFailReason")]
        public string LocalCheckFailReason{ get; set; }

        /// <summary>
        /// 检查到的值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckValue")]
        public string[] CheckValue{ get; set; }

        /// <summary>
        /// 是否被限频拦截， 取值：false（未被限频）；true（被限频）
        /// </summary>
        [JsonProperty("Frequently")]
        public bool? Frequently{ get; set; }

        /// <summary>
        /// 证书是否已经签发。取值： false（未签发）；true（已签发）
        /// </summary>
        [JsonProperty("Issued")]
        public bool? Issued{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "LocalCheck", this.LocalCheck);
            this.SetParamSimple(map, prefix + "CaCheck", this.CaCheck);
            this.SetParamSimple(map, prefix + "LocalCheckFailReason", this.LocalCheckFailReason);
            this.SetParamArraySimple(map, prefix + "CheckValue.", this.CheckValue);
            this.SetParamSimple(map, prefix + "Frequently", this.Frequently);
            this.SetParamSimple(map, prefix + "Issued", this.Issued);
        }
    }
}

