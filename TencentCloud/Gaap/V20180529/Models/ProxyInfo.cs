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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyInfo : AbstractModel
    {
        
        /// <summary>
        /// （旧参数，请使用ProxyId）通道实例ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 创建时间，采用Unix时间戳的方式，表示从1970年1月1日（UTC/GMT的午夜）开始所经过的秒数。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 通道名称。
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// 接入地域。
        /// </summary>
        [JsonProperty("AccessRegion")]
        public string AccessRegion{ get; set; }

        /// <summary>
        /// 源站地域。
        /// </summary>
        [JsonProperty("RealServerRegion")]
        public string RealServerRegion{ get; set; }

        /// <summary>
        /// 带宽，单位：Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 并发，单位：万个/秒。
        /// </summary>
        [JsonProperty("Concurrent")]
        public long? Concurrent{ get; set; }

        /// <summary>
        /// 通道状态。其中：
        /// RUNNING表示运行中；
        /// CREATING表示创建中；
        /// DESTROYING表示销毁中；
        /// OPENING表示开启中；
        /// CLOSING表示关闭中；
        /// CLOSED表示已关闭；
        /// ADJUSTING表示配置变更中；
        /// ISOLATING表示隔离中；
        /// ISOLATED表示已隔离；
        /// CLONING表示复制中；
        /// RECOVERING表示通道维护中；
        /// MOVING表示迁移中。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 接入域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 接入IP。
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// 通道版本号：1.0，2.0，3.0。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// （新参数）通道实例ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 1，该通道可缩扩容；0，该通道无法缩扩容。
        /// </summary>
        [JsonProperty("Scalarable")]
        public long? Scalarable{ get; set; }

        /// <summary>
        /// 支持的协议类型。
        /// </summary>
        [JsonProperty("SupportProtocols")]
        public string[] SupportProtocols{ get; set; }

        /// <summary>
        /// 通道组ID，当通道归属于某一通道组时，存在该字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 安全策略ID，当设置了安全策略时，存在该字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 接入地域详细信息，包括地域ID和地域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessRegionInfo")]
        public RegionDetail AccessRegionInfo{ get; set; }

        /// <summary>
        /// 源站地域详细信息，包括地域ID和地域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealServerRegionInfo")]
        public RegionDetail RealServerRegionInfo{ get; set; }

        /// <summary>
        /// 通道转发IP
        /// </summary>
        [JsonProperty("ForwardIP")]
        public string ForwardIP{ get; set; }

        /// <summary>
        /// 标签列表，不存在标签时，该字段为空列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSet")]
        public TagPair[] TagSet{ get; set; }

        /// <summary>
        /// 是否支持安全组配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportSecurity")]
        public long? SupportSecurity{ get; set; }

        /// <summary>
        /// 计费类型: 0表示按带宽计费  1表示按流量计费。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingType")]
        public long? BillingType{ get; set; }

        /// <summary>
        /// 关联了解析的域名列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelatedGlobalDomains")]
        public string[] RelatedGlobalDomains{ get; set; }

        /// <summary>
        /// 配置变更时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyConfigTime")]
        public ulong? ModifyConfigTime{ get; set; }

        /// <summary>
        /// 通道类型，100表示THUNDER通道，103表示微软合作通道
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyType")]
        public ulong? ProxyType{ get; set; }

        /// <summary>
        /// 通道获取客户端IP的方式，0表示TOA，1表示Proxy Protocol
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientIPMethod")]
        public long?[] ClientIPMethod{ get; set; }

        /// <summary>
        /// IP版本：IPv4、IPv6
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPAddressVersion")]
        public string IPAddressVersion{ get; set; }

        /// <summary>
        /// 网络类型：normal表示常规BGP，cn2表示精品BGP，triple表示三网，secure_eip表示定制安全EIP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 通道套餐类型：Thunder表示标准通道，Accelerator表示银牌加速通道，
        /// CrossBorder表示跨境通道。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 封禁解封状态：BANNED表示已封禁，RECOVER表示已解封或未封禁，BANNING表示封禁中，RECOVERING表示解封中，BAN_FAILED表示封禁失败，RECOVER_FAILED表示解封失败。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BanStatus")]
        public string BanStatus{ get; set; }

        /// <summary>
        /// IP列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPList")]
        public IPDetail[] IPList{ get; set; }

        /// <summary>
        /// 支持Http3协议的标识，其中：
        /// 0表示关闭；
        /// 1表示启用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Http3Supported")]
        public long? Http3Supported{ get; set; }

        /// <summary>
        /// 是否在封禁黑名单中，其中：0表示不在黑名单中，1表示在黑名单中。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InBanBlacklist")]
        public long? InBanBlacklist{ get; set; }

        /// <summary>
        /// 特性位图，每个bit位代表一种特性，其中：
        /// 0，表示不支持该特性；
        /// 1，表示支持该特性。
        /// 特性位图含义如下（从右往左）：
        /// 第1个bit，支持4层加速；
        /// 第2个bit，支持7层加速；
        /// 第3个bit，支持Http3接入；
        /// 第4个bit，支持IPv6；
        /// 第5个bit，支持精品BGP接入；
        /// 第6个bit，支持三网接入；
        /// 第7个bit，支持接入段Qos加速。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeatureBitmap")]
        public long? FeatureBitmap{ get; set; }

        /// <summary>
        /// 是否是开启了auto scale的通道，0表示否，1表示是。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAutoScaleProxy")]
        public long? IsAutoScaleProxy{ get; set; }

        /// <summary>
        /// 是否允许设置TLS配置
        /// 0表示不支持；
        /// 1表示支持。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSupportTLSChoice")]
        public long? IsSupportTLSChoice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "AccessRegion", this.AccessRegion);
            this.SetParamSimple(map, prefix + "RealServerRegion", this.RealServerRegion);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Concurrent", this.Concurrent);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "Scalarable", this.Scalarable);
            this.SetParamArraySimple(map, prefix + "SupportProtocols.", this.SupportProtocols);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamObj(map, prefix + "AccessRegionInfo.", this.AccessRegionInfo);
            this.SetParamObj(map, prefix + "RealServerRegionInfo.", this.RealServerRegionInfo);
            this.SetParamSimple(map, prefix + "ForwardIP", this.ForwardIP);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "SupportSecurity", this.SupportSecurity);
            this.SetParamSimple(map, prefix + "BillingType", this.BillingType);
            this.SetParamArraySimple(map, prefix + "RelatedGlobalDomains.", this.RelatedGlobalDomains);
            this.SetParamSimple(map, prefix + "ModifyConfigTime", this.ModifyConfigTime);
            this.SetParamSimple(map, prefix + "ProxyType", this.ProxyType);
            this.SetParamArraySimple(map, prefix + "ClientIPMethod.", this.ClientIPMethod);
            this.SetParamSimple(map, prefix + "IPAddressVersion", this.IPAddressVersion);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "BanStatus", this.BanStatus);
            this.SetParamArrayObj(map, prefix + "IPList.", this.IPList);
            this.SetParamSimple(map, prefix + "Http3Supported", this.Http3Supported);
            this.SetParamSimple(map, prefix + "InBanBlacklist", this.InBanBlacklist);
            this.SetParamSimple(map, prefix + "FeatureBitmap", this.FeatureBitmap);
            this.SetParamSimple(map, prefix + "IsAutoScaleProxy", this.IsAutoScaleProxy);
            this.SetParamSimple(map, prefix + "IsSupportTLSChoice", this.IsSupportTLSChoice);
        }
    }
}

