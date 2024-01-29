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

    public class AddSpartaProtectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要防护的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 证书类型。
        /// 0：仅配置HTTP监听端口，没有证书
        /// 1：证书来源为自有证书
        /// 2：证书来源为托管证书
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }

        /// <summary>
        /// waf前是否部署有七层代理服务。
        /// 0：没有部署代理服务
        /// 1：有部署代理服务，waf将使用XFF获取客户端IP
        /// 2：有部署代理服务，waf将使用remote_addr获取客户端IP
        /// 3：有部署代理服务，waf将使用ip_headers中的自定义header获取客户端IP
        /// </summary>
        [JsonProperty("IsCdn")]
        public long? IsCdn{ get; set; }

        /// <summary>
        /// 回源类型。
        /// 0：通过IP回源
        /// 1：通过域名回源
        /// </summary>
        [JsonProperty("UpstreamType")]
        public long? UpstreamType{ get; set; }

        /// <summary>
        /// 是否开启WebSocket支持。
        /// 0：关闭
        /// 1：开启
        /// </summary>
        [JsonProperty("IsWebsocket")]
        public long? IsWebsocket{ get; set; }

        /// <summary>
        /// 回源负载均衡策略。
        /// 0：轮询
        /// 1：IP hash
        /// 2：加权轮询
        /// </summary>
        [JsonProperty("LoadBalance")]
        public string LoadBalance{ get; set; }

        /// <summary>
        /// CertType为1时，需要填充此参数，表示自有证书的证书链
        /// </summary>
        [JsonProperty("Cert")]
        public string Cert{ get; set; }

        /// <summary>
        /// CertType为1时，需要填充此参数，表示自有证书的私钥
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// CertType为2时，需要填充此参数，表示腾讯云SSL平台托管的证书id
        /// </summary>
        [JsonProperty("SSLId")]
        public string SSLId{ get; set; }

        /// <summary>
        /// 待废弃，可不填。Waf的资源ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// IsCdn为3时，需要填此参数，表示自定义header
        /// </summary>
        [JsonProperty("IpHeaders")]
        public string[] IpHeaders{ get; set; }

        /// <summary>
        /// 服务配置有HTTPS端口时，HTTPS的回源协议。
        /// http：使用http协议回源，和HttpsUpstreamPort配合使用
        /// https：使用https协议回源
        /// </summary>
        [JsonProperty("UpstreamScheme")]
        public string UpstreamScheme{ get; set; }

        /// <summary>
        /// HTTPS回源端口,仅UpstreamScheme为http时需要填当前字段
        /// </summary>
        [JsonProperty("HttpsUpstreamPort")]
        public string HttpsUpstreamPort{ get; set; }

        /// <summary>
        /// 待废弃，可不填。是否开启灰度，0表示不开启灰度。
        /// </summary>
        [JsonProperty("IsGray")]
        public long? IsGray{ get; set; }

        /// <summary>
        /// 待废弃，可不填。灰度的地区
        /// </summary>
        [JsonProperty("GrayAreas")]
        public string[] GrayAreas{ get; set; }

        /// <summary>
        /// 必填项，是否开启HTTP强制跳转到HTTPS。
        /// 0：不强制跳转
        /// 1：开启强制跳转
        /// </summary>
        [JsonProperty("HttpsRewrite")]
        public long? HttpsRewrite{ get; set; }

        /// <summary>
        /// 域名回源时的回源域名。UpstreamType为1时，需要填充此字段
        /// </summary>
        [JsonProperty("UpstreamDomain")]
        public string UpstreamDomain{ get; set; }

        /// <summary>
        /// IP回源时的回源IP列表。UpstreamType为0时，需要填充此字段
        /// </summary>
        [JsonProperty("SrcList")]
        public string[] SrcList{ get; set; }

        /// <summary>
        /// 必填项，是否开启HTTP2，需要开启HTTPS协议支持。
        /// 0：关闭
        /// 1：开启
        /// </summary>
        [JsonProperty("IsHttp2")]
        public long? IsHttp2{ get; set; }

        /// <summary>
        /// 服务端口列表配置。
        /// NginxServerId：新增域名时填'0'
        /// Port：监听端口号
        /// Protocol：端口协议
        /// UpstreamPort：与Port相同
        /// UpstreamProtocol：与Protocol相同
        /// </summary>
        [JsonProperty("Ports")]
        public PortItem[] Ports{ get; set; }

        /// <summary>
        /// 待废弃，可不填。WAF实例类型。
        /// sparta-waf：SAAS型WAF
        /// clb-waf：负载均衡型WAF
        /// cdn-waf：CDN上的Web防护能力
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 必填项，是否开启长连接。
        /// 0： 短连接
        /// 1： 长连接
        /// </summary>
        [JsonProperty("IsKeepAlive")]
        public string IsKeepAlive{ get; set; }

        /// <summary>
        /// 必填项，域名所属实例id
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 待废弃，目前填0即可。anycast IP类型开关： 0 普通IP 1 Anycast IP
        /// </summary>
        [JsonProperty("Anycast")]
        public long? Anycast{ get; set; }

        /// <summary>
        /// 回源IP列表各IP的权重，和SrcList一一对应。当且仅当UpstreamType为0，并且SrcList有多个IP，并且LoadBalance为2时需要填写，否则填 []
        /// </summary>
        [JsonProperty("Weights")]
        public long?[] Weights{ get; set; }

        /// <summary>
        /// 必填项，是否开启主动健康检测。
        /// 0：不开启
        /// 1：开启
        /// </summary>
        [JsonProperty("ActiveCheck")]
        public long? ActiveCheck{ get; set; }

        /// <summary>
        /// TLS版本信息
        /// </summary>
        [JsonProperty("TLSVersion")]
        public long? TLSVersion{ get; set; }

        /// <summary>
        /// 必填项，加密套件模板。
        /// 0：不支持选择，使用默认模板  
        /// 1：通用型模板 
        /// 2：安全型模板
        /// 3：自定义模板
        /// </summary>
        [JsonProperty("CipherTemplate")]
        public long? CipherTemplate{ get; set; }

        /// <summary>
        /// 自定义的加密套件列表。CipherTemplate为3时需要填此字段，表示自定义的加密套件，值通过DescribeCiphersDetail接口获取。
        /// </summary>
        [JsonProperty("Ciphers")]
        public long?[] Ciphers{ get; set; }

        /// <summary>
        /// WAF与源站的读超时时间，默认300s。
        /// </summary>
        [JsonProperty("ProxyReadTimeout")]
        public long? ProxyReadTimeout{ get; set; }

        /// <summary>
        /// WAF与源站的写超时时间，默认300s。
        /// </summary>
        [JsonProperty("ProxySendTimeout")]
        public long? ProxySendTimeout{ get; set; }

        /// <summary>
        /// WAF回源时的SNI类型。
        /// 0：关闭SNI，不配置client_hello中的server_name
        /// 1：开启SNI，client_hello中的server_name为防护域名
        /// 2：开启SNI，SNI为域名回源时的源站域名
        /// 3：开启SNI，SNI为自定义域名
        /// </summary>
        [JsonProperty("SniType")]
        public long? SniType{ get; set; }

        /// <summary>
        /// SniType为3时，需要填此参数，表示自定义的SNI；
        /// </summary>
        [JsonProperty("SniHost")]
        public string SniHost{ get; set; }

        /// <summary>
        /// 是否开启XFF重置。
        /// 0：关闭
        /// 1：开启
        /// </summary>
        [JsonProperty("XFFReset")]
        public long? XFFReset{ get; set; }

        /// <summary>
        /// 域名备注信息
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 自定义回源Host。默认为空字符串，表示使用防护域名作为回源Host。
        /// </summary>
        [JsonProperty("UpstreamHost")]
        public string UpstreamHost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "IsCdn", this.IsCdn);
            this.SetParamSimple(map, prefix + "UpstreamType", this.UpstreamType);
            this.SetParamSimple(map, prefix + "IsWebsocket", this.IsWebsocket);
            this.SetParamSimple(map, prefix + "LoadBalance", this.LoadBalance);
            this.SetParamSimple(map, prefix + "Cert", this.Cert);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "SSLId", this.SSLId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamArraySimple(map, prefix + "IpHeaders.", this.IpHeaders);
            this.SetParamSimple(map, prefix + "UpstreamScheme", this.UpstreamScheme);
            this.SetParamSimple(map, prefix + "HttpsUpstreamPort", this.HttpsUpstreamPort);
            this.SetParamSimple(map, prefix + "IsGray", this.IsGray);
            this.SetParamArraySimple(map, prefix + "GrayAreas.", this.GrayAreas);
            this.SetParamSimple(map, prefix + "HttpsRewrite", this.HttpsRewrite);
            this.SetParamSimple(map, prefix + "UpstreamDomain", this.UpstreamDomain);
            this.SetParamArraySimple(map, prefix + "SrcList.", this.SrcList);
            this.SetParamSimple(map, prefix + "IsHttp2", this.IsHttp2);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "IsKeepAlive", this.IsKeepAlive);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Anycast", this.Anycast);
            this.SetParamArraySimple(map, prefix + "Weights.", this.Weights);
            this.SetParamSimple(map, prefix + "ActiveCheck", this.ActiveCheck);
            this.SetParamSimple(map, prefix + "TLSVersion", this.TLSVersion);
            this.SetParamSimple(map, prefix + "CipherTemplate", this.CipherTemplate);
            this.SetParamArraySimple(map, prefix + "Ciphers.", this.Ciphers);
            this.SetParamSimple(map, prefix + "ProxyReadTimeout", this.ProxyReadTimeout);
            this.SetParamSimple(map, prefix + "ProxySendTimeout", this.ProxySendTimeout);
            this.SetParamSimple(map, prefix + "SniType", this.SniType);
            this.SetParamSimple(map, prefix + "SniHost", this.SniHost);
            this.SetParamSimple(map, prefix + "XFFReset", this.XFFReset);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "UpstreamHost", this.UpstreamHost);
        }
    }
}

