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

    public class DomainDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>域名名称。</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>加速地区信息。</p>
        /// </summary>
        [JsonProperty("AccelerateAreaInfos")]
        public AccelerateAreaInfo[] AccelerateAreaInfos{ get; set; }

        /// <summary>
        /// <p>部署状态，取值有：</p><li>Online：上线；</li><li>Deploying：部署中；</li><li>Locked: 锁定中，出现该状态时，无法对该域名进行部署变更。</li>
        /// </summary>
        [JsonProperty("DeployStatus")]
        public string DeployStatus{ get; set; }

        /// <summary>
        /// <p>HTTPS 配置信息。</p>
        /// </summary>
        [JsonProperty("HTTPSConfig")]
        public DomainHTTPSConfig HTTPSConfig{ get; set; }

        /// <summary>
        /// <p><a href="https://cloud.tencent.com/document/product/266/14047">Key 防盗链</a>配置信息。</p>
        /// </summary>
        [JsonProperty("UrlSignatureAuthPolicy")]
        public UrlSignatureAuthPolicy UrlSignatureAuthPolicy{ get; set; }

        /// <summary>
        /// <p><a href="https://cloud.tencent.com/document/product/266/14046">Referer 防盗链</a>配置信息。</p>
        /// </summary>
        [JsonProperty("RefererAuthPolicy")]
        public RefererAuthPolicy RefererAuthPolicy{ get; set; }

        /// <summary>
        /// <p>域名添加到腾讯云点播系统中的时间。<li>格式按照 ISO 8601标准表示，详见 <a href="https://cloud.tencent.com/document/product/266/11732#I">ISO 日期格式说明</a>。</li></p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>域名 QUIC 配置信息。</p>
        /// </summary>
        [JsonProperty("QUICConfig")]
        public DomainQUICConfig QUICConfig{ get; set; }

        /// <summary>
        /// <p>IP 访问限制配置信息。</p>
        /// </summary>
        [JsonProperty("IPFilterPolicy")]
        public IPFilterPolicy IPFilterPolicy{ get; set; }

        /// <summary>
        /// <p>域名类型，取值有： <li>VOD：使用 VOD 产品分发的域名；</li> <li>EdgeOne：使用 EdgeOne 产品分发的域名。</li></p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArrayObj(map, prefix + "AccelerateAreaInfos.", this.AccelerateAreaInfos);
            this.SetParamSimple(map, prefix + "DeployStatus", this.DeployStatus);
            this.SetParamObj(map, prefix + "HTTPSConfig.", this.HTTPSConfig);
            this.SetParamObj(map, prefix + "UrlSignatureAuthPolicy.", this.UrlSignatureAuthPolicy);
            this.SetParamObj(map, prefix + "RefererAuthPolicy.", this.RefererAuthPolicy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "QUICConfig.", this.QUICConfig);
            this.SetParamObj(map, prefix + "IPFilterPolicy.", this.IPFilterPolicy);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

