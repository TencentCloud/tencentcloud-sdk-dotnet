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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVodDomainConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// [Referer 防盗链](/document/product/266/14046)规则。
        /// </summary>
        [JsonProperty("RefererAuthPolicy")]
        public RefererAuthPolicy RefererAuthPolicy{ get; set; }

        /// <summary>
        /// [Key 防盗链](/document/product/266/14047)规则。
        /// </summary>
        [JsonProperty("UrlSignatureAuthPolicy")]
        public UrlSignatureAuthPolicy UrlSignatureAuthPolicy{ get; set; }

        /// <summary>
        /// QUIC 配置。
        /// </summary>
        [JsonProperty("QUICConfig")]
        public DomainQUICConfig QUICConfig{ get; set; }

        /// <summary>
        /// IP 访问限制规则。
        /// </summary>
        [JsonProperty("IPFilterPolicy")]
        public IPFilterPolicy IPFilterPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "RefererAuthPolicy.", this.RefererAuthPolicy);
            this.SetParamObj(map, prefix + "UrlSignatureAuthPolicy.", this.UrlSignatureAuthPolicy);
            this.SetParamObj(map, prefix + "QUICConfig.", this.QUICConfig);
            this.SetParamObj(map, prefix + "IPFilterPolicy.", this.IPFilterPolicy);
        }
    }
}

