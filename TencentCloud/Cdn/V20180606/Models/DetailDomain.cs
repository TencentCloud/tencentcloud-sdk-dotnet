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

    public class DetailDomain : AbstractModel
    {
        
        /// <summary>
        /// 域名ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 腾讯云账号ID。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 加速域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 域名CName。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 域名状态，pending，rejected，processing， online，offline，deleted分别表示审核中，审核未通过，审核通过部署中，已开启，已关闭，已删除。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 域名业务类型，web，download，media分别表示静态加速，下载加速和流媒体加速。
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 域名创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 域名更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 源站配置。
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

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
        /// 状态码缓存配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusCodeCache")]
        public StatusCodeCache StatusCodeCache{ get; set; }

        /// <summary>
        /// 智能压缩配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// 带宽封顶配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthAlert")]
        public BandwidthAlert BandwidthAlert{ get; set; }

        /// <summary>
        /// Range回源配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RangeOriginPull")]
        public RangeOriginPull RangeOriginPull{ get; set; }

        /// <summary>
        /// 301和302自动回源跟随配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public FollowRedirect FollowRedirect{ get; set; }

        /// <summary>
        /// 错误码重定向配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorPage")]
        public ErrorPage ErrorPage{ get; set; }

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
        /// 下载速度配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownstreamCapping")]
        public DownstreamCapping DownstreamCapping{ get; set; }

        /// <summary>
        /// 节点缓存配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// 遵循源站缓存头部配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseHeaderCache")]
        public ResponseHeaderCache ResponseHeaderCache{ get; set; }

        /// <summary>
        /// 视频拖拽配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoSeek")]
        public VideoSeek VideoSeek{ get; set; }

        /// <summary>
        /// 缓存规则配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cache")]
        public Cache Cache{ get; set; }

        /// <summary>
        /// 跨国优化配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginPullOptimization")]
        public OriginPullOptimization OriginPullOptimization{ get; set; }

        /// <summary>
        /// Https配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// 时间戳防盗链配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Authentication")]
        public Authentication Authentication{ get; set; }

        /// <summary>
        /// seo优化配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Seo")]
        public Seo Seo{ get; set; }

        /// <summary>
        /// 域名封禁状态，normal，overdue，quota，malicious，ddos，idle，unlicensed，capping分别表示。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Disable")]
        public string Disable{ get; set; }

        /// <summary>
        /// 访问协议强制跳转配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// 防盗链配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Referer")]
        public Referer Referer{ get; set; }

        /// <summary>
        /// 浏览器缓存规则配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// Ipv6配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// 是否兼容旧版本配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Compatibility")]
        public Compatibility Compatibility{ get; set; }

        /// <summary>
        /// 分地区特殊配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecificConfig")]
        public SpecificConfig SpecificConfig{ get; set; }

        /// <summary>
        /// 加速区域，mainland，overseas或global。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 域名锁定状态，normal，mainland，overseas或global，分别表示未被锁定，国内锁定，海外锁定或全球锁定。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Readonly")]
        public string Readonly{ get; set; }

        /// <summary>
        /// 回源超时配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginPullTimeout")]
        public OriginPullTimeout OriginPullTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "IpFilter.", this.IpFilter);
            this.SetParamObj(map, prefix + "IpFreqLimit.", this.IpFreqLimit);
            this.SetParamObj(map, prefix + "StatusCodeCache.", this.StatusCodeCache);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "BandwidthAlert.", this.BandwidthAlert);
            this.SetParamObj(map, prefix + "RangeOriginPull.", this.RangeOriginPull);
            this.SetParamObj(map, prefix + "FollowRedirect.", this.FollowRedirect);
            this.SetParamObj(map, prefix + "ErrorPage.", this.ErrorPage);
            this.SetParamObj(map, prefix + "RequestHeader.", this.RequestHeader);
            this.SetParamObj(map, prefix + "ResponseHeader.", this.ResponseHeader);
            this.SetParamObj(map, prefix + "DownstreamCapping.", this.DownstreamCapping);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "ResponseHeaderCache.", this.ResponseHeaderCache);
            this.SetParamObj(map, prefix + "VideoSeek.", this.VideoSeek);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "OriginPullOptimization.", this.OriginPullOptimization);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "Authentication.", this.Authentication);
            this.SetParamObj(map, prefix + "Seo.", this.Seo);
            this.SetParamSimple(map, prefix + "Disable", this.Disable);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "Referer.", this.Referer);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamObj(map, prefix + "Compatibility.", this.Compatibility);
            this.SetParamObj(map, prefix + "SpecificConfig.", this.SpecificConfig);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Readonly", this.Readonly);
            this.SetParamObj(map, prefix + "OriginPullTimeout.", this.OriginPullTimeout);
        }
    }
}

