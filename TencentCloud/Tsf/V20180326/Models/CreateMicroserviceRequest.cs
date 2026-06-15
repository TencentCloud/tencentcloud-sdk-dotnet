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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMicroserviceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>命名空间ID。该参数可以通过调用 <a href="https://cloud.tencent.com/document/api/649/36096">DescribeSimpleNamespaces</a> 的返回值中的 NamespaceId 字段来获取或通过登录<a href="https://console.cloud.tencent.com/tsf/resource?tab=namespace">控制台</a>查看；也可以调用<a href="https://cloud.tencent.com/document/product/649/36098">CreateNamespace</a>创建新的命名空间。</p>
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// <p>微服务名称。该参数可以通过调用 <a href="https://cloud.tencent.com/document/product/649/36084">DescribeMicroservices</a> 的返回值中的 MicroserviceName 字段来获取或通过登录<a href="https://console.cloud.tencent.com/tse/tsf-consul?tab=service">控制台</a>查看；也可以调用<a href="https://cloud.tencent.com/document/product/649/85860">CreateMicroserviceWithDetailResp</a>创建新的微服务。</p>
        /// </summary>
        [JsonProperty("MicroserviceName")]
        public string MicroserviceName{ get; set; }

        /// <summary>
        /// <p>微服务备注信息，最多支持200个字符。</p>
        /// </summary>
        [JsonProperty("MicroserviceDesc")]
        public string MicroserviceDesc{ get; set; }

        /// <summary>
        /// <p>服务类型，默认SDK</p><p>枚举值：</p><ul><li>SDK： sdk服务</li><li>MESH_EXTERNAL： mesh外部服务</li></ul>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>域名+端口，或者是纯域名方式，其他的不允许配置，不支持 IP</p>
        /// </summary>
        [JsonProperty("ServiceUrl")]
        public string ServiceUrl{ get; set; }

        /// <summary>
        /// <p>协议类型</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>服务发现方式</p><p>枚举值：</p><ul><li>DNS： DNS方式</li></ul>
        /// </summary>
        [JsonProperty("ServiceDiscovery")]
        public string ServiceDiscovery{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "MicroserviceName", this.MicroserviceName);
            this.SetParamSimple(map, prefix + "MicroserviceDesc", this.MicroserviceDesc);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ServiceUrl", this.ServiceUrl);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ServiceDiscovery", this.ServiceDiscovery);
        }
    }
}

