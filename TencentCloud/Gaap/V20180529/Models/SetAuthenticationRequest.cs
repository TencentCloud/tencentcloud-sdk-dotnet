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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetAuthenticationRequest : AbstractModel
    {
        
        /// <summary>
        /// 监听器ID。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 需要进行高级配置的域名，该域名为监听器下的转发规则的域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 基础认证开关，其中：
        /// 0，关闭基础认证；
        /// 1，开启基础认证。
        /// 默认为0。
        /// </summary>
        [JsonProperty("BasicAuth")]
        public long? BasicAuth{ get; set; }

        /// <summary>
        /// 通道认证开关，用于源站对Gaap的认证，其中：
        /// 0，关闭通道认证；
        /// 1，开启通道认证。
        /// 默认为0。
        /// </summary>
        [JsonProperty("GaapAuth")]
        public long? GaapAuth{ get; set; }

        /// <summary>
        /// 源站认证开关，用于Gaap对服务器的认证，其中：
        /// 0，关闭源站认证；
        /// 1，开启源站认证。
        /// 默认为0。
        /// </summary>
        [JsonProperty("RealServerAuth")]
        public long? RealServerAuth{ get; set; }

        /// <summary>
        /// 基础认证配置ID，从证书管理页获取。
        /// </summary>
        [JsonProperty("BasicAuthConfId")]
        public string BasicAuthConfId{ get; set; }

        /// <summary>
        /// 通道SSL证书ID，从证书管理页获取。
        /// </summary>
        [JsonProperty("GaapCertificateId")]
        public string GaapCertificateId{ get; set; }

        /// <summary>
        /// 源站CA证书ID，从证书管理页获取。源站认证时，填写该参数或RealServerCertificateId参数
        /// </summary>
        [JsonProperty("RealServerCertificateId")]
        public string RealServerCertificateId{ get; set; }

        /// <summary>
        /// 源站证书域名。
        /// </summary>
        [JsonProperty("RealServerCertificateDomain")]
        public string RealServerCertificateDomain{ get; set; }

        /// <summary>
        /// 多源站CA证书ID，从证书管理页获取。源站认证时，填写该参数或RealServerCertificateId参数
        /// </summary>
        [JsonProperty("PolyRealServerCertificateIds")]
        public string[] PolyRealServerCertificateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "BasicAuth", this.BasicAuth);
            this.SetParamSimple(map, prefix + "GaapAuth", this.GaapAuth);
            this.SetParamSimple(map, prefix + "RealServerAuth", this.RealServerAuth);
            this.SetParamSimple(map, prefix + "BasicAuthConfId", this.BasicAuthConfId);
            this.SetParamSimple(map, prefix + "GaapCertificateId", this.GaapCertificateId);
            this.SetParamSimple(map, prefix + "RealServerCertificateId", this.RealServerCertificateId);
            this.SetParamSimple(map, prefix + "RealServerCertificateDomain", this.RealServerCertificateDomain);
            this.SetParamArraySimple(map, prefix + "PolyRealServerCertificateIds.", this.PolyRealServerCertificateIds);
        }
    }
}

