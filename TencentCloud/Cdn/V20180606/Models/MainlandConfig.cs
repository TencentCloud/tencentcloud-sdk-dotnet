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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MainlandConfig : AbstractModel
    {
        
        /// <summary>
        /// 时间戳防盗链配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Authentication")]
        public Authentication Authentication{ get; set; }

        /// <summary>
        /// 带宽封顶配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthAlert")]
        public BandwidthAlert BandwidthAlert{ get; set; }

        /// <summary>
        /// 缓存规则配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cache")]
        public Cache Cache{ get; set; }

        /// <summary>
        /// 缓存相关配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// 智能压缩配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// 下载限速配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownstreamCapping")]
        public DownstreamCapping DownstreamCapping{ get; set; }

        /// <summary>
        /// 错误码重定向配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorPage")]
        public ErrorPage ErrorPage{ get; set; }

        /// <summary>
        /// 301和302自动回源跟随配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public FollowRedirect FollowRedirect{ get; set; }

        /// <summary>
        /// 访问协议强制跳转配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// Https配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// IP黑白名单配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpFilter")]
        public IpFilter IpFilter{ get; set; }

        /// <summary>
        /// IP限频配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpFreqLimit")]
        public IpFreqLimit IpFreqLimit{ get; set; }

        /// <summary>
        /// 浏览器缓存规则配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// 源站配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// 跨国优化配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginPullOptimization")]
        public OriginPullOptimization OriginPullOptimization{ get; set; }

        /// <summary>
        /// Range回源配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RangeOriginPull")]
        public RangeOriginPull RangeOriginPull{ get; set; }

        /// <summary>
        /// 防盗链配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Referer")]
        public Referer Referer{ get; set; }

        /// <summary>
        /// 回源请求头部配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestHeader")]
        public RequestHeader RequestHeader{ get; set; }

        /// <summary>
        /// 源站响应头部配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseHeader")]
        public ResponseHeader ResponseHeader{ get; set; }

        /// <summary>
        /// 遵循源站缓存头部配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseHeaderCache")]
        public ResponseHeaderCache ResponseHeaderCache{ get; set; }

        /// <summary>
        /// seo优化配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Seo")]
        public Seo Seo{ get; set; }

        /// <summary>
        /// 域名业务类型，web，download，media分别表示静态加速，下载加速和流媒体加速。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 状态码缓存配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusCodeCache")]
        public StatusCodeCache StatusCodeCache{ get; set; }

        /// <summary>
        /// 视频拖拽配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoSeek")]
        public VideoSeek VideoSeek{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Authentication.", this.Authentication);
            this.SetParamObj(map, prefix + "BandwidthAlert.", this.BandwidthAlert);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "DownstreamCapping.", this.DownstreamCapping);
            this.SetParamObj(map, prefix + "ErrorPage.", this.ErrorPage);
            this.SetParamObj(map, prefix + "FollowRedirect.", this.FollowRedirect);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "IpFilter.", this.IpFilter);
            this.SetParamObj(map, prefix + "IpFreqLimit.", this.IpFreqLimit);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "OriginPullOptimization.", this.OriginPullOptimization);
            this.SetParamObj(map, prefix + "RangeOriginPull.", this.RangeOriginPull);
            this.SetParamObj(map, prefix + "Referer.", this.Referer);
            this.SetParamObj(map, prefix + "RequestHeader.", this.RequestHeader);
            this.SetParamObj(map, prefix + "ResponseHeader.", this.ResponseHeader);
            this.SetParamObj(map, prefix + "ResponseHeaderCache.", this.ResponseHeaderCache);
            this.SetParamObj(map, prefix + "Seo.", this.Seo);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamObj(map, prefix + "StatusCodeCache.", this.StatusCodeCache);
            this.SetParamObj(map, prefix + "VideoSeek.", this.VideoSeek);
        }
    }
}

