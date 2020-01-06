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

    public class CreateL7Listener : AbstractModel
    {
        
        /// <summary>
        /// 七层监听器端口，可选值1~65535。
        /// </summary>
        [JsonProperty("LoadBalancerPort")]
        public long? LoadBalancerPort{ get; set; }

        /// <summary>
        /// 七层监听器协议类型，可选值：http,https。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 七层监听器名称。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 认证方式：0（不认证，用于http），1（单向认证，用于https），2（双向认证，用于https）。当创建的是https类型的监听器时，此值必选。
        /// </summary>
        [JsonProperty("SslMode")]
        public long? SslMode{ get; set; }

        /// <summary>
        /// 服务端证书ID。当创建的是https类型的监听器时，此值必选。
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
        /// 用于计费模式为固定带宽计费，指定监听器最大带宽值，可选值：0-1000，单位：Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerPort", this.LoadBalancerPort);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
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

