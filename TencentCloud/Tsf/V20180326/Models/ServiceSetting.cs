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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceSetting : AbstractModel
    {
        
        /// <summary>
        /// 0:公网, 1:集群内访问, 2：NodePort, 3: VPC 内网访问
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// 容器端口映射
        /// </summary>
        [JsonProperty("ProtocolPorts")]
        public ProtocolPort[] ProtocolPorts{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 是否创建 k8s service，默认为 false
        /// </summary>
        [JsonProperty("DisableService")]
        public bool? DisableService{ get; set; }

        /// <summary>
        /// service 是否为 headless 类型
        /// </summary>
        [JsonProperty("HeadlessService")]
        public bool? HeadlessService{ get; set; }

        /// <summary>
        /// 当为 true 且 DisableService 也为 true 时，会删除之前创建的 service，请小心使用
        /// </summary>
        [JsonProperty("AllowDeleteService")]
        public bool? AllowDeleteService{ get; set; }

        /// <summary>
        /// 开启SessionAffinity，true为开启，false为不开启，默认为false
        /// </summary>
        [JsonProperty("OpenSessionAffinity")]
        public bool? OpenSessionAffinity{ get; set; }

        /// <summary>
        /// SessionAffinity会话时间，默认10800
        /// </summary>
        [JsonProperty("SessionAffinityTimeoutSeconds")]
        public long? SessionAffinityTimeoutSeconds{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 外部流量策略
        /// </summary>
        [JsonProperty("ExternalTrafficStrategy")]
        public string ExternalTrafficStrategy{ get; set; }

        /// <summary>
        /// 外部流量策略
        /// </summary>
        [JsonProperty("ExternalTrafficPolicy")]
        public string ExternalTrafficPolicy{ get; set; }

        /// <summary>
        /// 负载均衡提供者
        /// </summary>
        [JsonProperty("LoadBalancerProvisioner")]
        public string LoadBalancerProvisioner{ get; set; }

        /// <summary>
        /// 负载均衡类型
        /// </summary>
        [JsonProperty("LoadBalancingType")]
        public string LoadBalancingType{ get; set; }

        /// <summary>
        /// k8s负载均衡内网vip
        /// </summary>
        [JsonProperty("ClusterIp")]
        public string ClusterIp{ get; set; }

        /// <summary>
        /// 禁用服务Int记录
        /// </summary>
        [JsonProperty("DisableServiceInt")]
        public ulong? DisableServiceInt{ get; set; }

        /// <summary>
        /// 开启SessionAffinity Int记录
        /// </summary>
        [JsonProperty("OpenSessionAffinityInt")]
        public ulong? OpenSessionAffinityInt{ get; set; }

        /// <summary>
        /// 开启HeadlessService int记录
        /// </summary>
        [JsonProperty("HeadlessServiceInt")]
        public ulong? HeadlessServiceInt{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// VPC网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 负载均衡VIP
        /// </summary>
        [JsonProperty("LoadBalancingIp")]
        public string LoadBalancingIp{ get; set; }

        /// <summary>
        /// 负载均衡id
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 已存在的负载均衡id
        /// </summary>
        [JsonProperty("ExistingLoadBalancerId")]
        public string ExistingLoadBalancerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArrayObj(map, prefix + "ProtocolPorts.", this.ProtocolPorts);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DisableService", this.DisableService);
            this.SetParamSimple(map, prefix + "HeadlessService", this.HeadlessService);
            this.SetParamSimple(map, prefix + "AllowDeleteService", this.AllowDeleteService);
            this.SetParamSimple(map, prefix + "OpenSessionAffinity", this.OpenSessionAffinity);
            this.SetParamSimple(map, prefix + "SessionAffinityTimeoutSeconds", this.SessionAffinityTimeoutSeconds);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ExternalTrafficStrategy", this.ExternalTrafficStrategy);
            this.SetParamSimple(map, prefix + "ExternalTrafficPolicy", this.ExternalTrafficPolicy);
            this.SetParamSimple(map, prefix + "LoadBalancerProvisioner", this.LoadBalancerProvisioner);
            this.SetParamSimple(map, prefix + "LoadBalancingType", this.LoadBalancingType);
            this.SetParamSimple(map, prefix + "ClusterIp", this.ClusterIp);
            this.SetParamSimple(map, prefix + "DisableServiceInt", this.DisableServiceInt);
            this.SetParamSimple(map, prefix + "OpenSessionAffinityInt", this.OpenSessionAffinityInt);
            this.SetParamSimple(map, prefix + "HeadlessServiceInt", this.HeadlessServiceInt);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "LoadBalancingIp", this.LoadBalancingIp);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ExistingLoadBalancerId", this.ExistingLoadBalancerId);
        }
    }
}

