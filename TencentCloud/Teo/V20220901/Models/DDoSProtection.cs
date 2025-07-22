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

    public class DDoSProtection : AbstractModel
    {
        
        /// <summary>
        /// 指定独立 DDoS 的防护范围。取值为：
        /// <li> protect_all_domains：独立 DDoS 防护对站点内全部域名生效，新接入域名自动开启独立 DDoS 防护，入参为 protect_all_domains 时，入参 DomainDDoSProtections 不作处理；</li>
        /// <li> protect_specified_domains：仅对指定域名生效，具体范围可通过 DomainDDoSProtection 参数指定。</li>
        /// </summary>
        [JsonProperty("ProtectionOption")]
        public string ProtectionOption{ get; set; }

        /// <summary>
        /// 域名的独立 DDoS 防护配置。在入参场景中：
        /// <li> 当 ProtectionOption 保持为 protect_specified_domains 时：未填写的域名维持原有独立 DDoS 防护配置不变，显式指定的域名​按传入参数更新；</li>
        /// <li> 当 ProtectionOption 由 protect_all_domains 切换为 protect_specified_domains 时：若 DomainDDoSProtections 传空，停用站点下全部域名的独立 DDoS 防护；若 DomainDDoSProtections 不为空，参数中指定的域名停用或保持独立 DDoS 防护，其余未列出的域名统一停用独立 DDoS 防护。</li>
        /// </summary>
        [JsonProperty("DomainDDoSProtections")]
        public DomainDDoSProtection[] DomainDDoSProtections{ get; set; }

        /// <summary>
        /// 共享 CNAME 的独立 DDoS 防护配置。仅作为出参使用。
        /// </summary>
        [JsonProperty("SharedCNAMEDDoSProtections")]
        public DomainDDoSProtection[] SharedCNAMEDDoSProtections{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectionOption", this.ProtectionOption);
            this.SetParamArrayObj(map, prefix + "DomainDDoSProtections.", this.DomainDDoSProtections);
            this.SetParamArrayObj(map, prefix + "SharedCNAMEDDoSProtections.", this.SharedCNAMEDDoSProtections);
        }
    }
}

