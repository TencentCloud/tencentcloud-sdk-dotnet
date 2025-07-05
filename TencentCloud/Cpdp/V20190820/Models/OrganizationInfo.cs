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

    public class OrganizationInfo : AbstractModel
    {
        
        /// <summary>
        /// 公司名称，个体工商户必输
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 公司证件类型，个体工商户必输，证件类型仅支持73
        /// </summary>
        [JsonProperty("OrganizationType")]
        public string OrganizationType{ get; set; }

        /// <summary>
        /// 公司证件号码，个体工商户必输
        /// </summary>
        [JsonProperty("OrganizationCode")]
        public string OrganizationCode{ get; set; }

        /// <summary>
        /// 法人名称，如果SubMchName不是法人，需要另外送入法人信息（企业必输）
        /// <敏感信息>加密详见<a href="https://cloud.tencent.com/document/product/1122/48979" target="_blank">《商户端接口敏感信息加密说明》</a>
        /// </summary>
        [JsonProperty("LegalPersonName")]
        public string LegalPersonName{ get; set; }

        /// <summary>
        /// 法人证件类型，如果SubMchName不是法人，需要另外送入法人信息（企业必输）
        /// </summary>
        [JsonProperty("LegalPersonIdType")]
        public string LegalPersonIdType{ get; set; }

        /// <summary>
        /// 法人证件号码，如果SubMchName不是法人，需要另外送入法人信息（企业必输）
        /// <敏感信息>加密详见<a href="https://cloud.tencent.com/document/product/1122/48979" target="_blank">《商户端接口敏感信息加密说明》</a>
        /// </summary>
        [JsonProperty("LegalPersonIdCode")]
        public string LegalPersonIdCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "OrganizationType", this.OrganizationType);
            this.SetParamSimple(map, prefix + "OrganizationCode", this.OrganizationCode);
            this.SetParamSimple(map, prefix + "LegalPersonName", this.LegalPersonName);
            this.SetParamSimple(map, prefix + "LegalPersonIdType", this.LegalPersonIdType);
            this.SetParamSimple(map, prefix + "LegalPersonIdCode", this.LegalPersonIdCode);
        }
    }
}

