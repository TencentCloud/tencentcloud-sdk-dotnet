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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleEngineAction : AbstractModel
    {
        
        /// <summary>
        /// 操作名称。名称需要与参数结构体对应，例如 Name=Cache，则 CacheParameters 必填。
        /// <li>Cache：节点缓存 TTL；</li>
        /// <li>CacheKey：自定义 Cache Key；</li>
        /// <li>CachePrefresh：缓存预刷新；</li>
        /// <li>AccessURLRedirect：访问 URL 重定向；</li>
        /// <li>UpstreamURLRewrite：回源 URL 重写；</li>
        /// <li>QUIC：QUIC；</li>
        /// <li>WebSocket：WebSocket；</li>
        /// <li>Authentication：Token 鉴权；</li>
        /// <li>MaxAge：浏览器缓存 TTL；</li>
        /// <li>StatusCodeCache：状态码缓存 TTL；</li>
        /// <li>OfflineCache：离线缓存；</li>
        /// <li>SmartRouting：智能加速；</li>
        /// <li>RangeOriginPull：分片回源 ；</li>
        /// <li>UpstreamHTTP2：HTTP2 回源；</li>
        /// <li>HostHeader：Host Header 重写；</li>
        /// <li>ForceRedirectHTTPS：访问协议强制 HTTPS 跳转配置；</li>
        /// <li>OriginPullProtocol：回源 HTTPS；</li>
        /// <li>Compression：智能压缩配置；</li>
        /// <li>HSTS：HSTS；</li>
        /// <li>ClientIPHeader：存储客户端请求 IP 的头部信息配置；</li>
        /// <li>OCSPStapling：OCSP 装订；</li>
        /// <li>HTTP2：HTTP2 接入；</li>
        /// <li>PostMaxSize：POST 请求上传文件流式传输最大限制配置；</li>
        /// <li>ClientIPCountry：回源时携带客户端 IP 所属地域信息；</li>
        /// <li>UpstreamFollowRedirect：回源跟随重定向参数配置；</li>
        /// <li>UpstreamRequest：回源请求参数；</li>
        /// <li>TLSConfig：SSL/TLS 安全；</li>
        /// <li>ModifyOrigin：修改源站；</li>
        /// <li>HTTPUpstreamTimeout：七层回源超时配置；</li>
        /// <li>HttpResponse：HTTP 应答；</li>
        /// <li>ErrorPage：自定义错误页面；</li>
        /// <li>ModifyResponseHeader：修改 HTTP 节点响应头；</li>
        /// <li>ModifyRequestHeader：修改 HTTP 节点请求头；</li>
        /// <li>ResponseSpeedLimit：单连接下载限速；</li>
        /// <li>SetContentIdentifier：设置内容标识符；</li>
        /// <li>Vary：Vary 特性配置。</li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 节点缓存 TTL 配置参数，当 Name 取值为 Cache 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheParameters")]
        public CacheParameters CacheParameters{ get; set; }

        /// <summary>
        /// 自定义 Cache Key 配置参数，当 Name 取值为 CacheKey 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheKeyParameters")]
        public CacheKeyParameters CacheKeyParameters{ get; set; }

        /// <summary>
        /// 缓存预刷新配置参数，当 Name 取值为 CachePrefresh 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CachePrefreshParameters")]
        public CachePrefreshParameters CachePrefreshParameters{ get; set; }

        /// <summary>
        /// 访问 URL 重定向配置参数，当 Name 取值为 AccessURLRedirect 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessURLRedirectParameters")]
        public AccessURLRedirectParameters AccessURLRedirectParameters{ get; set; }

        /// <summary>
        /// 回源 URL 重写配置参数，当 Name 取值为 UpstreamURLRewrite 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamURLRewriteParameters")]
        public UpstreamURLRewriteParameters UpstreamURLRewriteParameters{ get; set; }

        /// <summary>
        /// QUIC 配置参数，当 Name 取值为 QUIC 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QUICParameters")]
        public QUICParameters QUICParameters{ get; set; }

        /// <summary>
        /// WebSocket 配置参数，当 Name 取值为 WebSocket 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebSocketParameters")]
        public WebSocketParameters WebSocketParameters{ get; set; }

        /// <summary>
        /// Token 鉴权配置参数，当 Name 取值为 Authentication 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthenticationParameters")]
        public AuthenticationParameters AuthenticationParameters{ get; set; }

        /// <summary>
        /// 浏览器缓存 TTL 配置参数，当 Name 取值为 MaxAge 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxAgeParameters")]
        public MaxAgeParameters MaxAgeParameters{ get; set; }

        /// <summary>
        /// 状态码缓存 TTL 配置参数，当 Name 取值为 StatusCodeCache 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusCodeCacheParameters")]
        public StatusCodeCacheParameters StatusCodeCacheParameters{ get; set; }

        /// <summary>
        /// 离线缓存配置参数，当 Name 取值为 OfflineCache 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineCacheParameters")]
        public OfflineCacheParameters OfflineCacheParameters{ get; set; }

        /// <summary>
        /// 智能加速配置参数，当 Name 取值为 SmartRouting 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmartRoutingParameters")]
        public SmartRoutingParameters SmartRoutingParameters{ get; set; }

        /// <summary>
        /// 分片回源配置参数，当 Name 取值为 RangeOriginPull 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RangeOriginPullParameters")]
        public RangeOriginPullParameters RangeOriginPullParameters{ get; set; }

        /// <summary>
        /// HTTP2 回源配置参数，当 Name 取值为 UpstreamHTTP2 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamHTTP2Parameters")]
        public UpstreamHTTP2Parameters UpstreamHTTP2Parameters{ get; set; }

        /// <summary>
        /// Host Header 重写配置参数，当 Name 取值为 HostHeader 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostHeaderParameters")]
        public HostHeaderParameters HostHeaderParameters{ get; set; }

        /// <summary>
        /// 访问协议强制 HTTPS 跳转配置，当 Name 取值为 ForceRedirectHTTPS 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForceRedirectHTTPSParameters")]
        public ForceRedirectHTTPSParameters ForceRedirectHTTPSParameters{ get; set; }

        /// <summary>
        /// 回源 HTTPS 配置参数，当 Name 取值为 OriginPullProtocol 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginPullProtocolParameters")]
        public OriginPullProtocolParameters OriginPullProtocolParameters{ get; set; }

        /// <summary>
        /// 智能压缩配置，当 Name 取值为 Compression 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompressionParameters")]
        public CompressionParameters CompressionParameters{ get; set; }

        /// <summary>
        /// HSTS 配置参数，当 Name 取值为 HSTS 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HSTSParameters")]
        public HSTSParameters HSTSParameters{ get; set; }

        /// <summary>
        /// 存储客户端请求 IP 的头部信息配置，当 Name 取值为 ClientIPHeader 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientIPHeaderParameters")]
        public ClientIPHeaderParameters ClientIPHeaderParameters{ get; set; }

        /// <summary>
        /// OCSP 装订配置参数，当 Name 取值为 OCSPStapling 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OCSPStaplingParameters")]
        public OCSPStaplingParameters OCSPStaplingParameters{ get; set; }

        /// <summary>
        /// HTTP2 接入配置参数，当 Name 取值为 HTTP2 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HTTP2Parameters")]
        public HTTP2Parameters HTTP2Parameters{ get; set; }

        /// <summary>
        /// POST 请求上传文件流式传输最大限制配置，当 Name 取值为 PostMaxSize 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostMaxSizeParameters")]
        public PostMaxSizeParameters PostMaxSizeParameters{ get; set; }

        /// <summary>
        /// 回源时携带客户端 IP 所属地域信息配置参数，当 Name 取值为 ClientIPCountry 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientIPCountryParameters")]
        public ClientIPCountryParameters ClientIPCountryParameters{ get; set; }

        /// <summary>
        /// 回源跟随重定向参数配置，当 Name 取值为 UpstreamFollowRedirect 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamFollowRedirectParameters")]
        public UpstreamFollowRedirectParameters UpstreamFollowRedirectParameters{ get; set; }

        /// <summary>
        /// 回源请求参数配置参数，当 Name 取值为 UpstreamRequest 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamRequestParameters")]
        public UpstreamRequestParameters UpstreamRequestParameters{ get; set; }

        /// <summary>
        /// SSL/TLS 安全配置参数，当 Name 取值为 TLSConfig 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TLSConfigParameters")]
        public TLSConfigParameters TLSConfigParameters{ get; set; }

        /// <summary>
        /// 修改源站配置参数，当 Name 取值为 ModifyOrigin 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyOriginParameters")]
        public ModifyOriginParameters ModifyOriginParameters{ get; set; }

        /// <summary>
        /// 七层回源超时配置，当 Name 取值为 HTTPUpstreamTimeout 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HTTPUpstreamTimeoutParameters")]
        public HTTPUpstreamTimeoutParameters HTTPUpstreamTimeoutParameters{ get; set; }

        /// <summary>
        /// HTTP 应答配置参数，当 Name 取值为 HttpResponse 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpResponseParameters")]
        public HTTPResponseParameters HttpResponseParameters{ get; set; }

        /// <summary>
        /// 自定义错误页面配置参数，当 Name 取值为 ErrorPage 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorPageParameters")]
        public ErrorPageParameters ErrorPageParameters{ get; set; }

        /// <summary>
        /// 修改 HTTP 节点响应头配置参数，当 Name 取值为 ModifyResponseHeader 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyResponseHeaderParameters")]
        public ModifyResponseHeaderParameters ModifyResponseHeaderParameters{ get; set; }

        /// <summary>
        /// 修改 HTTP 节点请求头配置参数，当 Name 取值为 ModifyRequestHeader 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyRequestHeaderParameters")]
        public ModifyRequestHeaderParameters ModifyRequestHeaderParameters{ get; set; }

        /// <summary>
        /// 单连接下载限速配置参数，当 Name 取值为 ResponseSpeedLimit 时，该参数必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseSpeedLimitParameters")]
        public ResponseSpeedLimitParameters ResponseSpeedLimitParameters{ get; set; }

        /// <summary>
        /// 内容标识配置参数，当 Name 取值为 SetContentIdentifier 时，该参数必填。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SetContentIdentifierParameters")]
        public SetContentIdentifierParameters SetContentIdentifierParameters{ get; set; }

        /// <summary>
        /// Vary 特性配置参数，当 Name 取值为 Vary 时，该参数必填。
        /// </summary>
        [JsonProperty("VaryParameters")]
        public VaryParameters VaryParameters{ get; set; }

        /// <summary>
        /// 内容压缩配置参数，当 Name 取值为 ContentCompression 时，该参数必填。该参数为白名单功能，如有需要，请联系腾讯云工程师处理。
        /// </summary>
        [JsonProperty("ContentCompressionParameters")]
        public ContentCompressionParameters ContentCompressionParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "CacheParameters.", this.CacheParameters);
            this.SetParamObj(map, prefix + "CacheKeyParameters.", this.CacheKeyParameters);
            this.SetParamObj(map, prefix + "CachePrefreshParameters.", this.CachePrefreshParameters);
            this.SetParamObj(map, prefix + "AccessURLRedirectParameters.", this.AccessURLRedirectParameters);
            this.SetParamObj(map, prefix + "UpstreamURLRewriteParameters.", this.UpstreamURLRewriteParameters);
            this.SetParamObj(map, prefix + "QUICParameters.", this.QUICParameters);
            this.SetParamObj(map, prefix + "WebSocketParameters.", this.WebSocketParameters);
            this.SetParamObj(map, prefix + "AuthenticationParameters.", this.AuthenticationParameters);
            this.SetParamObj(map, prefix + "MaxAgeParameters.", this.MaxAgeParameters);
            this.SetParamObj(map, prefix + "StatusCodeCacheParameters.", this.StatusCodeCacheParameters);
            this.SetParamObj(map, prefix + "OfflineCacheParameters.", this.OfflineCacheParameters);
            this.SetParamObj(map, prefix + "SmartRoutingParameters.", this.SmartRoutingParameters);
            this.SetParamObj(map, prefix + "RangeOriginPullParameters.", this.RangeOriginPullParameters);
            this.SetParamObj(map, prefix + "UpstreamHTTP2Parameters.", this.UpstreamHTTP2Parameters);
            this.SetParamObj(map, prefix + "HostHeaderParameters.", this.HostHeaderParameters);
            this.SetParamObj(map, prefix + "ForceRedirectHTTPSParameters.", this.ForceRedirectHTTPSParameters);
            this.SetParamObj(map, prefix + "OriginPullProtocolParameters.", this.OriginPullProtocolParameters);
            this.SetParamObj(map, prefix + "CompressionParameters.", this.CompressionParameters);
            this.SetParamObj(map, prefix + "HSTSParameters.", this.HSTSParameters);
            this.SetParamObj(map, prefix + "ClientIPHeaderParameters.", this.ClientIPHeaderParameters);
            this.SetParamObj(map, prefix + "OCSPStaplingParameters.", this.OCSPStaplingParameters);
            this.SetParamObj(map, prefix + "HTTP2Parameters.", this.HTTP2Parameters);
            this.SetParamObj(map, prefix + "PostMaxSizeParameters.", this.PostMaxSizeParameters);
            this.SetParamObj(map, prefix + "ClientIPCountryParameters.", this.ClientIPCountryParameters);
            this.SetParamObj(map, prefix + "UpstreamFollowRedirectParameters.", this.UpstreamFollowRedirectParameters);
            this.SetParamObj(map, prefix + "UpstreamRequestParameters.", this.UpstreamRequestParameters);
            this.SetParamObj(map, prefix + "TLSConfigParameters.", this.TLSConfigParameters);
            this.SetParamObj(map, prefix + "ModifyOriginParameters.", this.ModifyOriginParameters);
            this.SetParamObj(map, prefix + "HTTPUpstreamTimeoutParameters.", this.HTTPUpstreamTimeoutParameters);
            this.SetParamObj(map, prefix + "HttpResponseParameters.", this.HttpResponseParameters);
            this.SetParamObj(map, prefix + "ErrorPageParameters.", this.ErrorPageParameters);
            this.SetParamObj(map, prefix + "ModifyResponseHeaderParameters.", this.ModifyResponseHeaderParameters);
            this.SetParamObj(map, prefix + "ModifyRequestHeaderParameters.", this.ModifyRequestHeaderParameters);
            this.SetParamObj(map, prefix + "ResponseSpeedLimitParameters.", this.ResponseSpeedLimitParameters);
            this.SetParamObj(map, prefix + "SetContentIdentifierParameters.", this.SetContentIdentifierParameters);
            this.SetParamObj(map, prefix + "VaryParameters.", this.VaryParameters);
            this.SetParamObj(map, prefix + "ContentCompressionParameters.", this.ContentCompressionParameters);
        }
    }
}

