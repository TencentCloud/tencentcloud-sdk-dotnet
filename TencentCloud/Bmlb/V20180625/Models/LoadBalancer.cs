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

    public class LoadBalancer : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡器ID
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 项目ID，通过v2/DescribeProject 接口获得
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 负载均衡器名称
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 负载均衡的类型 : open表示公网负载均衡类型，internal表示内网负载均衡类型
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 是否筛选独占集群，0表示非独占集群，1表示四层独占集群，2表示七层独占集群，3表示四层和七层独占集群，4表示共享容灾
        /// </summary>
        [JsonProperty("Exclusive")]
        public ulong? Exclusive{ get; set; }

        /// <summary>
        /// 该负载均衡对应的tgw集群（fullnat,tunnel,dnat）
        /// </summary>
        [JsonProperty("TgwSetType")]
        public string TgwSetType{ get; set; }

        /// <summary>
        /// 负载均衡域名。规则：1-60个小写英文字母、数字、点号“.”或连接线“-”。内网类型的负载均衡不能配置该字段
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 该负载均衡对应的所在的VpcId
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 该负载均衡对应的所在的SubnetId
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("LatestPayMode")]
        public string LatestPayMode{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("StatusTime")]
        public string StatusTime{ get; set; }

        /// <summary>
        /// 私有网络名称。
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 私有网络Cidr。
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// 负载均衡获得的公网IP地址,支持多个
        /// </summary>
        [JsonProperty("LoadBalancerVips")]
        public string[] LoadBalancerVips{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("SupportListenerTypes")]
        public string[] SupportListenerTypes{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 负载均衡个性化配置ID
        /// </summary>
        [JsonProperty("ConfId")]
        public string ConfId{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("ConfName")]
        public string ConfName{ get; set; }

        /// <summary>
        /// 负载均衡的IPV6的VIP。
        /// </summary>
        [JsonProperty("LoadBalancerVipv6s")]
        public string[] LoadBalancerVipv6s{ get; set; }

        /// <summary>
        /// 负载均衡IP协议类型。ipv4或者ipv6。
        /// </summary>
        [JsonProperty("IpProtocolType")]
        public string IpProtocolType{ get; set; }

        /// <summary>
        /// 保障型网关计费形式
        /// </summary>
        [JsonProperty("BzPayMode")]
        public string BzPayMode{ get; set; }

        /// <summary>
        /// 保障型网关四层计费指标
        /// </summary>
        [JsonProperty("BzL4Metrics")]
        public string BzL4Metrics{ get; set; }

        /// <summary>
        /// 保障型网关七层计费指标
        /// </summary>
        [JsonProperty("BzL7Metrics")]
        public string BzL7Metrics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamSimple(map, prefix + "TgwSetType", this.TgwSetType);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "LatestPayMode", this.LatestPayMode);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StatusTime", this.StatusTime);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamArraySimple(map, prefix + "LoadBalancerVips.", this.LoadBalancerVips);
            this.SetParamArraySimple(map, prefix + "SupportListenerTypes.", this.SupportListenerTypes);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "ConfId", this.ConfId);
            this.SetParamSimple(map, prefix + "ConfName", this.ConfName);
            this.SetParamArraySimple(map, prefix + "LoadBalancerVipv6s.", this.LoadBalancerVipv6s);
            this.SetParamSimple(map, prefix + "IpProtocolType", this.IpProtocolType);
            this.SetParamSimple(map, prefix + "BzPayMode", this.BzPayMode);
            this.SetParamSimple(map, prefix + "BzL4Metrics", this.BzL4Metrics);
            this.SetParamSimple(map, prefix + "BzL7Metrics", this.BzL7Metrics);
        }
    }
}

