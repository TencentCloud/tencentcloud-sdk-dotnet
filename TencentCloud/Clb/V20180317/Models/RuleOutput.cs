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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleOutput : AbstractModel
    {
        
        /// <summary>
        /// 转发规则的 ID
        /// </summary>
        [JsonProperty("LocationId")]
        public string LocationId{ get; set; }

        /// <summary>
        /// 转发规则的域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 转发规则的路径。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 会话保持时间
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// 健康检查信息
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// 证书信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateOutput Certificate{ get; set; }

        /// <summary>
        /// 规则的请求转发方式。
        /// WRR、LEAST_CONN、IP_HASH分别表示按权重轮询、最小连接数、IP Hash。
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// 转发规则所属的监听器 ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 转发规则的重定向目标信息
        /// </summary>
        [JsonProperty("RewriteTarget")]
        public RewriteTarget RewriteTarget{ get; set; }

        /// <summary>
        /// 是否开启gzip
        /// </summary>
        [JsonProperty("HttpGzip")]
        public bool? HttpGzip{ get; set; }

        /// <summary>
        /// 转发规则是否为自动创建
        /// </summary>
        [JsonProperty("BeAutoCreated")]
        public bool? BeAutoCreated{ get; set; }

        /// <summary>
        /// 是否作为默认域名
        /// </summary>
        [JsonProperty("DefaultServer")]
        public bool? DefaultServer{ get; set; }

        /// <summary>
        /// 是否开启Http2
        /// </summary>
        [JsonProperty("Http2")]
        public bool? Http2{ get; set; }

        /// <summary>
        /// 负载均衡与后端服务之间的转发协议
        /// </summary>
        [JsonProperty("ForwardType")]
        public string ForwardType{ get; set; }

        /// <summary>
        /// 转发规则的创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 后端服务器类型。NODE表示绑定普通节点，TARGETGROUP表示绑定目标组。
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// 绑定的目标组基本信息；当规则绑定目标组时，会返回该字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetGroup")]
        public BasicTargetGroupInfo TargetGroup{ get; set; }

        /// <summary>
        /// WAF实例ID
        /// </summary>
        [JsonProperty("WafDomainId")]
        public string WafDomainId{ get; set; }

        /// <summary>
        /// TRPC被调服务器路由，ForwardType为TRPC时有效。目前暂未对外开放。
        /// </summary>
        [JsonProperty("TrpcCallee")]
        public string TrpcCallee{ get; set; }

        /// <summary>
        /// TRPC调用服务接口，ForwardType为TRPC时有效。目前暂未对外开放。
        /// </summary>
        [JsonProperty("TrpcFunc")]
        public string TrpcFunc{ get; set; }

        /// <summary>
        /// QUIC状态。QUIC_ACTIVE表示开启，QUIC_INACTIVE表示未开启。注意，只有HTTPS域名才能开启QUIC。
        /// </summary>
        [JsonProperty("QuicStatus")]
        public string QuicStatus{ get; set; }

        /// <summary>
        /// 转发规则的域名列表。
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 绑定的目标组列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetGroupList")]
        public BasicTargetGroupInfo[] TargetGroupList{ get; set; }

        /// <summary>
        /// OAuth配置状态信息。
        /// </summary>
        [JsonProperty("OAuth")]
        public OAuth OAuth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocationId", this.LocationId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamObj(map, prefix + "RewriteTarget.", this.RewriteTarget);
            this.SetParamSimple(map, prefix + "HttpGzip", this.HttpGzip);
            this.SetParamSimple(map, prefix + "BeAutoCreated", this.BeAutoCreated);
            this.SetParamSimple(map, prefix + "DefaultServer", this.DefaultServer);
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "ForwardType", this.ForwardType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamObj(map, prefix + "TargetGroup.", this.TargetGroup);
            this.SetParamSimple(map, prefix + "WafDomainId", this.WafDomainId);
            this.SetParamSimple(map, prefix + "TrpcCallee", this.TrpcCallee);
            this.SetParamSimple(map, prefix + "TrpcFunc", this.TrpcFunc);
            this.SetParamSimple(map, prefix + "QuicStatus", this.QuicStatus);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArrayObj(map, prefix + "TargetGroupList.", this.TargetGroupList);
            this.SetParamObj(map, prefix + "OAuth.", this.OAuth);
        }
    }
}

