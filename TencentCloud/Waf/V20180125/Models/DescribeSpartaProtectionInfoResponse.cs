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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSpartaProtectionInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 域名ID
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// cname取值
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 源IP地址列表
        /// </summary>
        [JsonProperty("SrcList")]
        public string[] SrcList{ get; set; }

        /// <summary>
        /// 证书类型
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }

        /// <summary>
        /// 证书
        /// </summary>
        [JsonProperty("Cert")]
        public string Cert{ get; set; }

        /// <summary>
        /// 私有密钥
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// ssl的id
        /// </summary>
        [JsonProperty("Sslid")]
        public string Sslid{ get; set; }

        /// <summary>
        /// 是否是cdn
        /// </summary>
        [JsonProperty("IsCdn")]
        public string IsCdn{ get; set; }

        /// <summary>
        /// 灰度区域列表
        /// </summary>
        [JsonProperty("GrayAreas")]
        public string[] GrayAreas{ get; set; }

        /// <summary>
        /// 引擎
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// HTTPS重写
        /// </summary>
        [JsonProperty("HttpsRewrite")]
        public string HttpsRewrite{ get; set; }

        /// <summary>
        /// upstreamType取值
        /// </summary>
        [JsonProperty("UpstreamType")]
        public string UpstreamType{ get; set; }

        /// <summary>
        /// upstreamDomain取值
        /// </summary>
        [JsonProperty("UpstreamDomain")]
        public string UpstreamDomain{ get; set; }

        /// <summary>
        /// upstreamScheme取值
        /// </summary>
        [JsonProperty("UpstreamScheme")]
        public string UpstreamScheme{ get; set; }

        /// <summary>
        /// 是否是HTTP2
        /// </summary>
        [JsonProperty("IsHttp2")]
        public string IsHttp2{ get; set; }

        /// <summary>
        /// 是否含有websocket
        /// </summary>
        [JsonProperty("IsWebsocket")]
        public string IsWebsocket{ get; set; }

        /// <summary>
        /// loadBalance信息
        /// </summary>
        [JsonProperty("LoadBalance")]
        public string LoadBalance{ get; set; }

        /// <summary>
        /// httpsUpstreamPort取值
        /// </summary>
        [JsonProperty("HttpsUpstreamPort")]
        public string HttpsUpstreamPort{ get; set; }

        /// <summary>
        /// port信息
        /// </summary>
        [JsonProperty("Ports")]
        public PortItem[] Ports{ get; set; }

        /// <summary>
        /// 是否灰度
        /// </summary>
        [JsonProperty("IsGray")]
        public string IsGray{ get; set; }

        /// <summary>
        /// 模式
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 防御等级,100,200,300
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 与源站是否保持长连接
        /// </summary>
        [JsonProperty("IsKeepAlive")]
        public string IsKeepAlive{ get; set; }

        /// <summary>
        /// 0：BGP 1：Anycast
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Anycast")]
        public string Anycast{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SrcList.", this.SrcList);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "Cert", this.Cert);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "Sslid", this.Sslid);
            this.SetParamSimple(map, prefix + "IsCdn", this.IsCdn);
            this.SetParamArraySimple(map, prefix + "GrayAreas.", this.GrayAreas);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "HttpsRewrite", this.HttpsRewrite);
            this.SetParamSimple(map, prefix + "UpstreamType", this.UpstreamType);
            this.SetParamSimple(map, prefix + "UpstreamDomain", this.UpstreamDomain);
            this.SetParamSimple(map, prefix + "UpstreamScheme", this.UpstreamScheme);
            this.SetParamSimple(map, prefix + "IsHttp2", this.IsHttp2);
            this.SetParamSimple(map, prefix + "IsWebsocket", this.IsWebsocket);
            this.SetParamSimple(map, prefix + "LoadBalance", this.LoadBalance);
            this.SetParamSimple(map, prefix + "HttpsUpstreamPort", this.HttpsUpstreamPort);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "IsGray", this.IsGray);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "IsKeepAlive", this.IsKeepAlive);
            this.SetParamSimple(map, prefix + "Anycast", this.Anycast);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

