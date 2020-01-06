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

    public class LoadBalancer : AbstractModel
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
        /// OPEN：公网属性， INTERNAL：内网属性。
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 负载均衡类型标识，1：负载均衡，0：传统型负载均衡。
        /// </summary>
        [JsonProperty("Forward")]
        public ulong? Forward{ get; set; }

        /// <summary>
        /// 负载均衡实例的域名，仅公网传统型负载均衡实例才提供该字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 负载均衡实例的 VIP 列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerVips")]
        public string[] LoadBalancerVips{ get; set; }

        /// <summary>
        /// 负载均衡实例的状态，包括
        /// 0：创建中，1：正常运行。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 负载均衡实例的创建时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 负载均衡实例的上次状态转换时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusTime")]
        public string StatusTime{ get; set; }

        /// <summary>
        /// 负载均衡实例所属的项目 ID， 0 表示默认项目。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 私有网络的 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 高防 LB 的标识，1：高防负载均衡 0：非高防负载均衡。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpenBgp")]
        public ulong? OpenBgp{ get; set; }

        /// <summary>
        /// 在 2016 年 12 月份之前的传统型内网负载均衡都是开启了 snat 的。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Snat")]
        public bool? Snat{ get; set; }

        /// <summary>
        /// 0：表示未被隔离，1：表示被隔离。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Isolation")]
        public ulong? Isolation{ get; set; }

        /// <summary>
        /// 用户开启日志的信息，日志只有公网属性创建了 HTTP 、HTTPS 监听器的负载均衡才会有日志。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Log")]
        public string Log{ get; set; }

        /// <summary>
        /// 负载均衡实例所在的子网（仅对内网VPC型LB有意义）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 负载均衡实例的标签信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 负载均衡实例的安全组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecureGroups")]
        public string[] SecureGroups{ get; set; }

        /// <summary>
        /// 负载均衡实例绑定的后端设备的基本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetRegionInfo")]
        public TargetRegionInfo TargetRegionInfo{ get; set; }

        /// <summary>
        /// anycast负载均衡的发布域，对于非anycast的负载均衡，此字段返回为空字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnycastZone")]
        public string AnycastZone{ get; set; }

        /// <summary>
        /// IP版本，ipv4 | ipv6
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// 数值形式的私有网络 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumericalVpcId")]
        public ulong? NumericalVpcId{ get; set; }

        /// <summary>
        /// 负载均衡IP地址所属的ISP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VipIsp")]
        public string VipIsp{ get; set; }

        /// <summary>
        /// 主可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MasterZone")]
        public ZoneInfo MasterZone{ get; set; }

        /// <summary>
        /// 备可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupZoneSet")]
        public ZoneInfo[] BackupZoneSet{ get; set; }

        /// <summary>
        /// 负载均衡实例被隔离的时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// 负载均衡实例的过期时间，仅对预付费负载均衡生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 负载均衡实例的计费类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 负载均衡实例的网络属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkAttributes")]
        public InternetAccessible NetworkAttributes{ get; set; }

        /// <summary>
        /// 负载均衡实例的预付费相关属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrepaidAttributes")]
        public LBChargePrepaid PrepaidAttributes{ get; set; }

        /// <summary>
        /// 负载均衡日志服务(CLS)的日志集ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// 负载均衡日志服务(CLS)的日志主题ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogTopicId")]
        public string LogTopicId{ get; set; }

        /// <summary>
        /// 负载均衡实例的IPv6地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressIPv6")]
        public string AddressIPv6{ get; set; }

        /// <summary>
        /// 暂做保留，一般用户无需关注。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public ExtraInfo ExtraInfo{ get; set; }

        /// <summary>
        /// 是否可绑定高防包
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDDos")]
        public bool? IsDDos{ get; set; }

        /// <summary>
        /// 负载均衡维度的个性化配置ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 后端服务是否放通来自LB的流量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public bool? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// 内网独占集群
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExclusiveCluster")]
        public ExclusiveCluster ExclusiveCluster{ get; set; }

        /// <summary>
        /// IP地址版本为ipv6时此字段有意义， IPv6Nat64 | IPv6FullChain
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPv6Mode")]
        public string IPv6Mode{ get; set; }

        /// <summary>
        /// 是否开启SnatPro
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// 开启SnatPro负载均衡后，SnatIp列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnatIps")]
        public SnatIp[] SnatIps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "Forward", this.Forward);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "LoadBalancerVips.", this.LoadBalancerVips);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StatusTime", this.StatusTime);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "OpenBgp", this.OpenBgp);
            this.SetParamSimple(map, prefix + "Snat", this.Snat);
            this.SetParamSimple(map, prefix + "Isolation", this.Isolation);
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "SecureGroups.", this.SecureGroups);
            this.SetParamObj(map, prefix + "TargetRegionInfo.", this.TargetRegionInfo);
            this.SetParamSimple(map, prefix + "AnycastZone", this.AnycastZone);
            this.SetParamSimple(map, prefix + "AddressIPVersion", this.AddressIPVersion);
            this.SetParamSimple(map, prefix + "NumericalVpcId", this.NumericalVpcId);
            this.SetParamSimple(map, prefix + "VipIsp", this.VipIsp);
            this.SetParamObj(map, prefix + "MasterZone.", this.MasterZone);
            this.SetParamArrayObj(map, prefix + "BackupZoneSet.", this.BackupZoneSet);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamObj(map, prefix + "NetworkAttributes.", this.NetworkAttributes);
            this.SetParamObj(map, prefix + "PrepaidAttributes.", this.PrepaidAttributes);
            this.SetParamSimple(map, prefix + "LogSetId", this.LogSetId);
            this.SetParamSimple(map, prefix + "LogTopicId", this.LogTopicId);
            this.SetParamSimple(map, prefix + "AddressIPv6", this.AddressIPv6);
            this.SetParamObj(map, prefix + "ExtraInfo.", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "IsDDos", this.IsDDos);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "LoadBalancerPassToTarget", this.LoadBalancerPassToTarget);
            this.SetParamObj(map, prefix + "ExclusiveCluster.", this.ExclusiveCluster);
            this.SetParamSimple(map, prefix + "IPv6Mode", this.IPv6Mode);
            this.SetParamSimple(map, prefix + "SnatPro", this.SnatPro);
            this.SetParamArrayObj(map, prefix + "SnatIps.", this.SnatIps);
        }
    }
}

