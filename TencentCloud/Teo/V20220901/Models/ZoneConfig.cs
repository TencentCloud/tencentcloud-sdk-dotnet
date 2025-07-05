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

    public class ZoneConfig : AbstractModel
    {
        
        /// <summary>
        /// 智能加速配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmartRouting")]
        public SmartRoutingParameters SmartRouting{ get; set; }

        /// <summary>
        /// 缓存过期时间配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cache")]
        public CacheConfigParameters Cache{ get; set; }

        /// <summary>
        /// 浏览器缓存配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAgeParameters MaxAge{ get; set; }

        /// <summary>
        /// 节点缓存键配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKeyConfigParameters CacheKey{ get; set; }

        /// <summary>
        /// 缓存预刷新配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CachePrefresh")]
        public CachePrefreshParameters CachePrefresh{ get; set; }

        /// <summary>
        /// 离线缓存配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineCache")]
        public OfflineCacheParameters OfflineCache{ get; set; }

        /// <summary>
        /// 智能压缩配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Compression")]
        public CompressionParameters Compression{ get; set; }

        /// <summary>
        /// 访问协议强制 HTTPS 跳转配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForceRedirectHTTPS")]
        public ForceRedirectHTTPSParameters ForceRedirectHTTPS{ get; set; }

        /// <summary>
        /// HSTS 相关配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HSTS")]
        public HSTSParameters HSTS{ get; set; }

        /// <summary>
        /// TLS 相关配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TLSConfig")]
        public TLSConfigParameters TLSConfig{ get; set; }

        /// <summary>
        /// OCSP 装订配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OCSPStapling")]
        public OCSPStaplingParameters OCSPStapling{ get; set; }

        /// <summary>
        /// HTTP2 相关配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HTTP2")]
        public HTTP2Parameters HTTP2{ get; set; }

        /// <summary>
        /// QUIC 访问配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QUIC")]
        public QUICParameters QUIC{ get; set; }

        /// <summary>
        /// HTTP2 回源配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamHTTP2")]
        public UpstreamHTTP2Parameters UpstreamHTTP2{ get; set; }

        /// <summary>
        /// IPv6 访问配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPv6")]
        public IPv6Parameters IPv6{ get; set; }

        /// <summary>
        /// WebSocket 配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebSocket")]
        public WebSocketParameters WebSocket{ get; set; }

        /// <summary>
        /// POST 请求传输配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostMaxSize")]
        public PostMaxSizeParameters PostMaxSize{ get; set; }

        /// <summary>
        /// 客户端 IP 回源请求头配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientIPHeader")]
        public ClientIPHeaderParameters ClientIPHeader{ get; set; }

        /// <summary>
        /// 回源时是否携带客户端 IP 所属地域信息的配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientIPCountry")]
        public ClientIPCountryParameters ClientIPCountry{ get; set; }

        /// <summary>
        /// gRPC 协议支持配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Grpc")]
        public GrpcParameters Grpc{ get; set; }

        /// <summary>
        /// 中国大陆加速优化配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public AccelerateMainlandParameters AccelerateMainland{ get; set; }

        /// <summary>
        /// 标准 Debug 配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StandardDebug")]
        public StandardDebugParameters StandardDebug{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SmartRouting.", this.SmartRouting);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "CachePrefresh.", this.CachePrefresh);
            this.SetParamObj(map, prefix + "OfflineCache.", this.OfflineCache);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "ForceRedirectHTTPS.", this.ForceRedirectHTTPS);
            this.SetParamObj(map, prefix + "HSTS.", this.HSTS);
            this.SetParamObj(map, prefix + "TLSConfig.", this.TLSConfig);
            this.SetParamObj(map, prefix + "OCSPStapling.", this.OCSPStapling);
            this.SetParamObj(map, prefix + "HTTP2.", this.HTTP2);
            this.SetParamObj(map, prefix + "QUIC.", this.QUIC);
            this.SetParamObj(map, prefix + "UpstreamHTTP2.", this.UpstreamHTTP2);
            this.SetParamObj(map, prefix + "IPv6.", this.IPv6);
            this.SetParamObj(map, prefix + "WebSocket.", this.WebSocket);
            this.SetParamObj(map, prefix + "PostMaxSize.", this.PostMaxSize);
            this.SetParamObj(map, prefix + "ClientIPHeader.", this.ClientIPHeader);
            this.SetParamObj(map, prefix + "ClientIPCountry.", this.ClientIPCountry);
            this.SetParamObj(map, prefix + "Grpc.", this.Grpc);
            this.SetParamObj(map, prefix + "AccelerateMainland.", this.AccelerateMainland);
            this.SetParamObj(map, prefix + "StandardDebug.", this.StandardDebug);
        }
    }
}

