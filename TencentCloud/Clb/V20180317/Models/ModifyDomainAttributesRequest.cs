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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDomainAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例ID，可以通过 [DescribeLoadBalancers](https://cloud.tencent.com/document/product/214/30685) 接口查询。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 负载均衡监听器ID，可以通过 [DescribeListeners](https://cloud.tencent.com/document/product/214/30686) 接口查询。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 域名（必须是已经创建的转发规则下的域名），如果是多域名，可以指定多域名列表中的任意一个，可以通过[DescribeListeners](https://cloud.tencent.com/document/product/214/30686) 接口查询。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 要修改的新域名。NewDomain和NewDomains只能传一个。
        /// </summary>
        [JsonProperty("NewDomain")]
        public string NewDomain{ get; set; }

        /// <summary>
        /// 域名相关的证书信息，注意，仅对启用SNI的监听器适用，不可和MultiCertInfo 同时传入。
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateInput Certificate{ get; set; }

        /// <summary>
        /// 是否开启HTTP2，注意，只有HTTPS域名才能开启HTTP2。
        /// True: 开启HTTP2，Fasle: 不开启HTTP2。
        /// </summary>
        [JsonProperty("Http2")]
        public bool? Http2{ get; set; }

        /// <summary>
        /// 是否设为默认域名，注意，一个监听器下只能设置一个默认域名。
        /// True: 设为默认域名，Fasle: 不设置为默认域名。
        /// </summary>
        [JsonProperty("DefaultServer")]
        public bool? DefaultServer{ get; set; }

        /// <summary>
        /// 是否开启 QUIC，注意，只有 HTTPS 域名才能开启 QUIC。
        /// True: 开启 QUIC，False: 不开启QUIC。
        /// </summary>
        [JsonProperty("Quic")]
        public bool? Quic{ get; set; }

        /// <summary>
        /// 监听器下必须配置一个默认域名，若要关闭原默认域名，必须同时指定另一个域名作为新的默认域名，如果新的默认域名是多域名，可以指定多域名列表中的任意一个。
        /// </summary>
        [JsonProperty("NewDefaultServerDomain")]
        public string NewDefaultServerDomain{ get; set; }

        /// <summary>
        /// 要修改的新域名列表。NewDomain和NewDomains只能传一个。
        /// </summary>
        [JsonProperty("NewDomains")]
        public string[] NewDomains{ get; set; }

        /// <summary>
        /// 域名相关的证书信息，注意，仅对启用SNI的监听器适用；支持同时传入多本算法类型不同的服务器证书，不可和Certificate 同时传入。
        /// </summary>
        [JsonProperty("MultiCertInfo")]
        public MultiCertInfo MultiCertInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "NewDomain", this.NewDomain);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "DefaultServer", this.DefaultServer);
            this.SetParamSimple(map, prefix + "Quic", this.Quic);
            this.SetParamSimple(map, prefix + "NewDefaultServerDomain", this.NewDefaultServerDomain);
            this.SetParamArraySimple(map, prefix + "NewDomains.", this.NewDomains);
            this.SetParamObj(map, prefix + "MultiCertInfo.", this.MultiCertInfo);
        }
    }
}

