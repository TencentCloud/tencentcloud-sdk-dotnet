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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadBalancerDetail : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例 ID。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 负载均衡实例的名称。
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 负载均衡实例的网络类型：
        /// Public：公网属性， Private：内网属性。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 负载均衡实例的状态，包括
        /// 0：创建中，1：正常运行。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 负载均衡实例的 VIP 。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 负载均衡实例 VIP 的IPv6地址。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressIPv6")]
        public string AddressIPv6{ get; set; }

        /// <summary>
        /// 负载均衡实例IP版本，IPv4 | IPv6。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// 负载均衡实例IPv6地址类型，IPv6Nat64 | IPv6FullChain。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPv6Mode")]
        public string IPv6Mode{ get; set; }

        /// <summary>
        /// 负载均衡实例所在可用区。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 负载均衡实例IP地址所属的ISP。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressIsp")]
        public string AddressIsp{ get; set; }

        /// <summary>
        /// 负载均衡实例所属私有网络的 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 负载均衡实例所属的项目 ID， 0 表示默认项目。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 负载均衡实例的创建时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 负载均衡实例的计费类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 负载均衡实例的网络属性。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkAttributes")]
        public InternetAccessible NetworkAttributes{ get; set; }

        /// <summary>
        /// 负载均衡实例的预付费相关属性。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrepaidAttributes")]
        public LBChargePrepaid PrepaidAttributes{ get; set; }

        /// <summary>
        /// 暂做保留，一般用户无需关注。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public ExtraInfo ExtraInfo{ get; set; }

        /// <summary>
        /// 负载均衡维度的个性化配置ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 负载均衡实例的标签信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 负载均衡监听器 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 监听器协议。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 监听器端口。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 转发规则的 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocationId")]
        public string LocationId{ get; set; }

        /// <summary>
        /// 转发规则的域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 转发规则的路径。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 后端目标ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetId")]
        public string TargetId{ get; set; }

        /// <summary>
        /// 后端目标的IP地址。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetAddress")]
        public string TargetAddress{ get; set; }

        /// <summary>
        /// 后端目标监听端口。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetPort")]
        public ulong? TargetPort{ get; set; }

        /// <summary>
        /// 后端目标转发权重。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetWeight")]
        public ulong? TargetWeight{ get; set; }

        /// <summary>
        /// 0：表示未被隔离，1：表示被隔离。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Isolation")]
        public ulong? Isolation{ get; set; }

        /// <summary>
        /// 负载均衡绑定的安全组列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// 负载均衡安全组上移特性是否开启标识。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public ulong? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// 后端目标健康状态。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetHealth")]
        public string TargetHealth{ get; set; }

        /// <summary>
        /// 转发规则的域名列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domains")]
        public string Domains{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "AddressIPv6", this.AddressIPv6);
            this.SetParamSimple(map, prefix + "AddressIPVersion", this.AddressIPVersion);
            this.SetParamSimple(map, prefix + "IPv6Mode", this.IPv6Mode);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "AddressIsp", this.AddressIsp);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamObj(map, prefix + "NetworkAttributes.", this.NetworkAttributes);
            this.SetParamObj(map, prefix + "PrepaidAttributes.", this.PrepaidAttributes);
            this.SetParamObj(map, prefix + "ExtraInfo.", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "LocationId", this.LocationId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "TargetAddress", this.TargetAddress);
            this.SetParamSimple(map, prefix + "TargetPort", this.TargetPort);
            this.SetParamSimple(map, prefix + "TargetWeight", this.TargetWeight);
            this.SetParamSimple(map, prefix + "Isolation", this.Isolation);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "LoadBalancerPassToTarget", this.LoadBalancerPassToTarget);
            this.SetParamSimple(map, prefix + "TargetHealth", this.TargetHealth);
            this.SetParamSimple(map, prefix + "Domains", this.Domains);
        }
    }
}

