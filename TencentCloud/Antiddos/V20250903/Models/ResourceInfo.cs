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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>防护资源的资源六段式标识。</p>
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// <p>防护资源类型。</p><p>枚举值：</p><ul><li>cvm： 云服务器</li><li>lighthouse： 轻量应用服务器</li><li>clb： 负载均衡</li><li>eip： 弹性公网 IP</li><li>waf： Web 应用防火墙</li><li>teo_l7_domain： EdgeOne 域名</li><li>teo_l4_proxy： EdgeOne 四层代理</li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>防护资源的防护状态。</p><p>枚举值：</p><ul><li>protecting： 防护中</li><li>processing： 防护变更中</li><li>disabling： 防护停用中</li><li>disabled： 防护已停用</li><li>process_failed： 防护变更失败</li><li>disabled_failed： 防护停用失败</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>防护资源所属地域，例如 <code>ap-beijing</code>。</p><p>资源类型为 EdgeOne 时，Region 取以下枚举值：</p><ul><li>global：全球可用区。</li><li>mainland：中国大陆可用区。</li><li>overseas：全球可用区（中国大陆除外）。</li></ul>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>公网访问地址。</p><ul><li>资源类型是以公网 IP 提供接入的云资产时，返回对应的公网 IP。</li><li>资源类型是以域名提供接入的云资产时，返回对应域名，例如 <a href="https://cloud.tencent.com/document/product/214/86948">域名化负载均衡实例</a>。</li><li>资源类型为 EdgeOne 四层代理或七层域名时，不返回该字段。</li></ul>
        /// </summary>
        [JsonProperty("PublicAddresses")]
        public string[] PublicAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArraySimple(map, prefix + "PublicAddresses.", this.PublicAddresses);
        }
    }
}

