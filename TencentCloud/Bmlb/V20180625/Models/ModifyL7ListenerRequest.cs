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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyL7ListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例ID，可通过接口DescribeLoadBalancers查询。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 七层监听器实例ID，可通过接口DescribeL7Listeners查询。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 七层监听器名称。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 认证方式：0（不认证，用于http），1（单向认证，用于https），2（双向认证，用于https）。
        /// </summary>
        [JsonProperty("SslMode")]
        public long? SslMode{ get; set; }

        /// <summary>
        /// 服务端证书ID。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 服务端证书名称。
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// 服务端证书内容。
        /// </summary>
        [JsonProperty("CertContent")]
        public string CertContent{ get; set; }

        /// <summary>
        /// 服务端证书密钥。
        /// </summary>
        [JsonProperty("CertKey")]
        public string CertKey{ get; set; }

        /// <summary>
        /// 客户端证书ID。
        /// </summary>
        [JsonProperty("CertCaId")]
        public string CertCaId{ get; set; }

        /// <summary>
        /// 客户端证书名称。
        /// </summary>
        [JsonProperty("CertCaName")]
        public string CertCaName{ get; set; }

        /// <summary>
        /// 客户端证书内容。
        /// </summary>
        [JsonProperty("CertCaContent")]
        public string CertCaContent{ get; set; }

        /// <summary>
        /// 计费模式为按固定带宽方式时监听器的限速值，可选值：0-1000，单位：Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "SslMode", this.SslMode);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "CertContent", this.CertContent);
            this.SetParamSimple(map, prefix + "CertKey", this.CertKey);
            this.SetParamSimple(map, prefix + "CertCaId", this.CertCaId);
            this.SetParamSimple(map, prefix + "CertCaName", this.CertCaName);
            this.SetParamSimple(map, prefix + "CertCaContent", this.CertCaContent);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
        }
    }
}

