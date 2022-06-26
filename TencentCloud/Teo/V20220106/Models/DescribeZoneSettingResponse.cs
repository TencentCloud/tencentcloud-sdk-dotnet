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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeZoneSettingResponse : AbstractModel
    {
        
        /// <summary>
        /// 缓存过期时间配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cache")]
        public CacheConfig Cache{ get; set; }

        /// <summary>
        /// 节点缓存键配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// 浏览器缓存配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// 离线缓存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineCache")]
        public OfflineCache OfflineCache{ get; set; }

        /// <summary>
        /// Quic访问
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Quic")]
        public Quic Quic{ get; set; }

        /// <summary>
        /// POST请求传输配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostMaxSize")]
        public PostMaxSize PostMaxSize{ get; set; }

        /// <summary>
        /// 智能压缩配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// http2回源配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamHttp2")]
        public UpstreamHttp2 UpstreamHttp2{ get; set; }

        /// <summary>
        /// 访问协议强制https跳转配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// Https 加速配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// 源站配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// 动态加速配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmartRouting")]
        public SmartRouting SmartRouting{ get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 站点域名
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// WebSocket配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebSocket")]
        public WebSocket WebSocket{ get; set; }

        /// <summary>
        /// 客户端IP回源请求头配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientIpHeader")]
        public ClientIp ClientIpHeader{ get; set; }

        /// <summary>
        /// 缓存预刷新配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CachePrefresh")]
        public CachePrefresh CachePrefresh{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "OfflineCache.", this.OfflineCache);
            this.SetParamObj(map, prefix + "Quic.", this.Quic);
            this.SetParamObj(map, prefix + "PostMaxSize.", this.PostMaxSize);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "UpstreamHttp2.", this.UpstreamHttp2);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "SmartRouting.", this.SmartRouting);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamObj(map, prefix + "WebSocket.", this.WebSocket);
            this.SetParamObj(map, prefix + "ClientIpHeader.", this.ClientIpHeader);
            this.SetParamObj(map, prefix + "CachePrefresh.", this.CachePrefresh);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

