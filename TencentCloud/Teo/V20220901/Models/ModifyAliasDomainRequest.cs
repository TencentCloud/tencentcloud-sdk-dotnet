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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAliasDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 别称域名名称。
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// 目标域名名称。
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// 证书配置，取值有：
        /// <li> none：不配置；</li>
        /// <li> hosting：SSL托管证书；</li>
        /// <li> apply：申请免费证书。</li>不填写保持原有配置。
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }

        /// <summary>
        /// 当 CertType 取值为 hosting 时填入相应证书 ID。
        /// </summary>
        [JsonProperty("CertId")]
        public string[] CertId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamArraySimple(map, prefix + "CertId.", this.CertId);
        }
    }
}

