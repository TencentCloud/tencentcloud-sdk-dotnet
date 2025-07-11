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
        /// OPEN：公网属性， INTERNAL：内网属性；对于内网属性的负载均衡，可通过绑定EIP出公网，具体可参考EIP文档[绑定弹性公网IP](https://cloud.tencent.com/document/product/215/16700)。
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 负载均衡类型标识，1：负载均衡，0：传统型负载均衡。
        /// </summary>
        [JsonProperty("Forward")]
        public ulong? Forward{ get; set; }

        /// <summary>
        /// 负载均衡实例的域名，仅公网传统型和域名型负载均衡实例才提供该字段。逐步下线中，建议用LoadBalancerDomain替代。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 负载均衡实例的 VIP 列表。
        /// </summary>
        [JsonProperty("LoadBalancerVips")]
        public string[] LoadBalancerVips{ get; set; }

        /// <summary>
        /// 负载均衡实例的状态，包括
        /// 0：创建中，1：正常运行。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 负载均衡实例的创建时间。
        /// 格式：YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 负载均衡实例的上次状态转换时间。
        /// 格式：YYYY-MM-DD HH:mm:ss
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
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 高防 LB 的标识，1：高防负载均衡 0：非高防负载均衡。
        /// </summary>
        [JsonProperty("OpenBgp")]
        public ulong? OpenBgp{ get; set; }

        /// <summary>
        /// 是否开启 SNAT，在 2016 年 12 月份之前的传统型内网负载均衡都是开启了 SNAT 的。
        /// </summary>
        [JsonProperty("Snat")]
        public bool? Snat{ get; set; }

        /// <summary>
        /// 是否被隔离，0：表示未被隔离，1：表示被隔离。
        /// </summary>
        [JsonProperty("Isolation")]
        public ulong? Isolation{ get; set; }

        /// <summary>
        /// 用户开启日志的信息，日志只有公网属性创建了 HTTP 、HTTPS 监听器的负载均衡才会有日志。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Log")]
        [System.Obsolete]
        public string Log{ get; set; }

        /// <summary>
        /// 负载均衡实例所在的子网（仅对内网VPC型LB有意义）
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 负载均衡实例的标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 负载均衡实例的安全组
        /// </summary>
        [JsonProperty("SecureGroups")]
        public string[] SecureGroups{ get; set; }

        /// <summary>
        /// 负载均衡实例绑定的后端设备的基本信息
        /// </summary>
        [JsonProperty("TargetRegionInfo")]
        public TargetRegionInfo TargetRegionInfo{ get; set; }

        /// <summary>
        /// anycast负载均衡的发布域，对于非anycast的负载均衡，此字段返回为空字符串
        /// </summary>
        [JsonProperty("AnycastZone")]
        public string AnycastZone{ get; set; }

        /// <summary>
        /// IP版本，ipv4 | ipv6
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// 数值形式的私有网络 ID，可以通过[DescribeVpcs](https://cloud.tencent.com/document/product/215/15778)接口获取。
        /// </summary>
        [JsonProperty("NumericalVpcId")]
        public ulong? NumericalVpcId{ get; set; }

        /// <summary>
        /// 负载均衡IP地址所属的运营商。
        /// 
        /// - BGP :  BGP（多线）
        /// - CMCC：中国移动单线
        /// - CTCC：中国电信单线
        /// - CUCC：中国联通单线
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
        /// 负载均衡实例被隔离的时间。
        /// 格式：YYYY-MM-DD HH:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// 负载均衡实例的过期时间，仅对预付费负载均衡生效。
        /// 格式：YYYY-MM-DD HH:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 负载均衡实例的计费类型，PREPAID：包年包月，POSTPAID_BY_HOUR：按量计费
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
        /// 负载均衡实例的预付费相关属性，仅在 ChargeType=PREPAID 时显示。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrepaidAttributes")]
        public LBChargePrepaid PrepaidAttributes{ get; set; }

        /// <summary>
        /// 负载均衡日志服务(CLS)的日志集ID
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// 负载均衡日志服务(CLS)的日志主题ID
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
        /// </summary>
        [JsonProperty("IsDDos")]
        public bool? IsDDos{ get; set; }

        /// <summary>
        /// 负载均衡维度的个性化配置ID
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 后端服务是否放通来自LB的流量
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public bool? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// 内网独占集群
        /// </summary>
        [JsonProperty("ExclusiveCluster")]
        public ExclusiveCluster ExclusiveCluster{ get; set; }

        /// <summary>
        /// IP地址版本为ipv6时此字段有意义，IPv6Nat64 | IPv6FullChain。
        /// IPv6Nat64: 基于 NAT64 IPv6 过渡技术实现的负载均衡器。
        /// IPv6FullChain：基于 IPv6 单栈技术实现的负载均衡。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPv6Mode")]
        public string IPv6Mode{ get; set; }

        /// <summary>
        /// 是否开启SnatPro。
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// 开启SnatPro负载均衡后，SnatIp列表。
        /// </summary>
        [JsonProperty("SnatIps")]
        public SnatIp[] SnatIps{ get; set; }

        /// <summary>
        /// 性能容量型规格。<ul><li> clb.c1.small：简约型规格 </li><li> clb.c2.medium：标准型规格 </li><li> clb.c3.small：高阶型1规格 </li><li> clb.c3.medium：高阶型2规格 </li><li> clb.c4.small：超强型1规格 </li><li> clb.c4.medium：超强型2规格 </li><li> clb.c4.large：超强型3规格 </li><li> clb.c4.xlarge：超强型4规格 </li><li>""：非性能容量型实例</li></ul>
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// vip是否被封堵
        /// </summary>
        [JsonProperty("IsBlock")]
        public bool? IsBlock{ get; set; }

        /// <summary>
        /// 封堵或解封时间。
        /// 格式：YYYY-MM-DD HH:mm:ss。
        /// </summary>
        [JsonProperty("IsBlockTime")]
        public string IsBlockTime{ get; set; }

        /// <summary>
        /// IP类型是否是本地BGP
        /// </summary>
        [JsonProperty("LocalBgp")]
        public bool? LocalBgp{ get; set; }

        /// <summary>
        /// 7层独占标签。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterTag")]
        public string ClusterTag{ get; set; }

        /// <summary>
        /// 开启IPv6FullChain负载均衡7层监听器支持混绑IPv4/IPv6目标功能。
        /// </summary>
        [JsonProperty("MixIpTarget")]
        public bool? MixIpTarget{ get; set; }

        /// <summary>
        /// 私有网络内网负载均衡，就近接入模式下规则所落在的可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// CLB是否为NFV，空：不是，l7nfv：七层是NFV。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NfvInfo")]
        public string NfvInfo{ get; set; }

        /// <summary>
        /// 负载均衡日志服务(CLS)的健康检查日志集ID
        /// </summary>
        [JsonProperty("HealthLogSetId")]
        public string HealthLogSetId{ get; set; }

        /// <summary>
        /// 负载均衡日志服务(CLS)的健康检查日志主题ID
        /// </summary>
        [JsonProperty("HealthLogTopicId")]
        public string HealthLogTopicId{ get; set; }

        /// <summary>
        /// 集群ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// 负载均衡的属性，传入字符串数组来决定是否开启
        /// DeleteProtect: 删除保护，开启后防止负载均衡被误删除。 
        /// UserInVisible: 用户不可见，控制负载均衡对用户的可见性。 
        /// BlockStatus: 阻塞状态，用于限制负载均衡的某些操作或流量。 
        /// NoLBNat: 禁用负载均衡的NAT功能，用于特定场景下的流量直接转发。 
        /// BanStatus: 封禁状态，用于暂停负载均衡服务或限制访问。 
        /// ShiftupFlag: 升配标志，用于标识负载均衡需要升级配置或性能。 
        /// Stop: 停止状态，开启后负载均衡暂停服务。 
        /// NoVpcGw: 不使用VPC网关，用于绕过VPC网关直接处理流量。 
        /// SgInTgw: 安全组在TGW（Transit Gateway）中，涉及网络安全策略配置。 
        /// SharedLimitFlag: 共享限制标志，用于控制负载均衡的共享资源限制。 
        /// WafFlag: Web应用防火墙（WAF）标志，开启后启用WAF保护。 
        /// IsDomainCLB: 域名型负载均衡，标识负载均衡是否基于域名进行流量分发。 
        /// IPv6Snat: IPv6源地址转换（SNAT），用于IPv6网络的源地址处理。 
        /// HideDomain: 隐藏域名，用于隐私保护或特定场景下不暴露域名。 
        /// JumboFrame: 巨型帧支持，开启后支持更大的数据帧以提高网络效率。 
        /// NoLBNatL4IPdc: 四层IP直连无NAT，用于四层负载均衡直接转发IP流量。 
        /// VpcGwL3Service: VPC网关三层服务，涉及三层网络服务的网关功能。 
        /// Ipv62Flag: IPv6扩展标志，用于特定的IPv6功能支持。 
        /// Ipv62ExclusiveFlag: IPv6独占标志，用于专属IPv6流量处理。 
        /// BgpPro: BGP Pro 支持。 
        /// ToaClean: TOA（TCP Option Address）清理，清除TCP选项中的地址信息。 
        /// </summary>
        [JsonProperty("AttributeFlags")]
        public string[] AttributeFlags{ get; set; }

        /// <summary>
        /// 负载均衡实例的域名。
        /// </summary>
        [JsonProperty("LoadBalancerDomain")]
        public string LoadBalancerDomain{ get; set; }

        /// <summary>
        /// 网络出口
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }

        /// <summary>
        /// 实例类型是否为独占型。1：独占型实例。0：非独占型实例。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Exclusive")]
        public ulong? Exclusive{ get; set; }

        /// <summary>
        /// 已绑定的后端服务数量。
        /// </summary>
        [JsonProperty("TargetCount")]
        public ulong? TargetCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamSimple(map, prefix + "IsBlock", this.IsBlock);
            this.SetParamSimple(map, prefix + "IsBlockTime", this.IsBlockTime);
            this.SetParamSimple(map, prefix + "LocalBgp", this.LocalBgp);
            this.SetParamSimple(map, prefix + "ClusterTag", this.ClusterTag);
            this.SetParamSimple(map, prefix + "MixIpTarget", this.MixIpTarget);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "NfvInfo", this.NfvInfo);
            this.SetParamSimple(map, prefix + "HealthLogSetId", this.HealthLogSetId);
            this.SetParamSimple(map, prefix + "HealthLogTopicId", this.HealthLogTopicId);
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamArraySimple(map, prefix + "AttributeFlags.", this.AttributeFlags);
            this.SetParamSimple(map, prefix + "LoadBalancerDomain", this.LoadBalancerDomain);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamSimple(map, prefix + "TargetCount", this.TargetCount);
        }
    }
}

