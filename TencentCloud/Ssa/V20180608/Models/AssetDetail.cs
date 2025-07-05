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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetDetail : AbstractModel
    {
        
        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 所属网络
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 主机类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 主机状态
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// 主机IP-公网
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// 引擎版本
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// 标识
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// 内网IP地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 负载均衡示例的vip列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerVips")]
        public string[] LoadBalancerVips{ get; set; }

        /// <summary>
        /// 账号ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public long? Uin{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreationDate")]
        public string CreationDate{ get; set; }

        /// <summary>
        /// 访问域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 资产唯一id
        /// </summary>
        [JsonProperty("AssetUniqid")]
        public string AssetUniqid{ get; set; }

        /// <summary>
        /// 关联实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 配置硬盘类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 配置硬盘大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 云硬盘/证书状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetStatus")]
        public string AssetStatus{ get; set; }

        /// <summary>
        /// 证书类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }

        /// <summary>
        /// 所属项目
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 到期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertEndTime")]
        public string CertEndTime{ get; set; }

        /// <summary>
        /// nosql引擎/版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductType")]
        public long? ProductType{ get; set; }

        /// <summary>
        /// 主机IP-内网
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// 证书有效期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public string ValidityPeriod{ get; set; }

        /// <summary>
        /// 分组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 端口服务数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Port")]
        public string[] Port{ get; set; }

        /// <summary>
        /// 配置风险数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskConfig")]
        public string[] RiskConfig{ get; set; }

        /// <summary>
        /// 相关待处理事件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Event")]
        public string Event{ get; set; }

        /// <summary>
        /// 相关待处理漏洞
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vul")]
        public string Vul{ get; set; }

        /// <summary>
        /// 资产发现时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaAssetDiscoverTime")]
        public string SsaAssetDiscoverTime{ get; set; }

        /// <summary>
        /// 所属子网
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetSubnetId")]
        public string AssetSubnetId{ get; set; }

        /// <summary>
        /// 子网名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetSubnetName")]
        public string AssetSubnetName{ get; set; }

        /// <summary>
        /// vpc名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetVpcName")]
        public string AssetVpcName{ get; set; }

        /// <summary>
        /// 集群类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// 命名空间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NameSpace")]
        public string NameSpace{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetCreateTime")]
        public string AssetCreateTime{ get; set; }

        /// <summary>
        /// 负载均衡网络类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// ipv6信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetIpv6")]
        public string[] AssetIpv6{ get; set; }

        /// <summary>
        /// ssh风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SSHRisk")]
        public string SSHRisk{ get; set; }

        /// <summary>
        /// rdp风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RDPRisk")]
        public string RDPRisk{ get; set; }

        /// <summary>
        /// 安全事件风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventRisk")]
        public string EventRisk{ get; set; }

        /// <summary>
        /// 漏洞数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetVulNum")]
        public long? AssetVulNum{ get; set; }

        /// <summary>
        /// 资产事件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetEventNum")]
        public long? AssetEventNum{ get; set; }

        /// <summary>
        /// cspm风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetCspmRiskNum")]
        public long? AssetCspmRiskNum{ get; set; }

        /// <summary>
        /// 资产删除时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaAssetDeleteTime")]
        public string SsaAssetDeleteTime{ get; set; }

        /// <summary>
        /// 费用类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetRegionName")]
        public string AssetRegionName{ get; set; }

        /// <summary>
        /// vpc信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetVpcid")]
        public string AssetVpcid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "LoadBalancerVips.", this.LoadBalancerVips);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "CreationDate", this.CreationDate);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AssetUniqid", this.AssetUniqid);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "AssetStatus", this.AssetStatus);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "CertEndTime", this.CertEndTime);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamArraySimple(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamSimple(map, prefix + "ValidityPeriod", this.ValidityPeriod);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamArraySimple(map, prefix + "Port.", this.Port);
            this.SetParamArraySimple(map, prefix + "RiskConfig.", this.RiskConfig);
            this.SetParamSimple(map, prefix + "Event", this.Event);
            this.SetParamSimple(map, prefix + "Vul", this.Vul);
            this.SetParamSimple(map, prefix + "SsaAssetDiscoverTime", this.SsaAssetDiscoverTime);
            this.SetParamSimple(map, prefix + "AssetSubnetId", this.AssetSubnetId);
            this.SetParamSimple(map, prefix + "AssetSubnetName", this.AssetSubnetName);
            this.SetParamSimple(map, prefix + "AssetVpcName", this.AssetVpcName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "NameSpace", this.NameSpace);
            this.SetParamSimple(map, prefix + "AssetCreateTime", this.AssetCreateTime);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamArraySimple(map, prefix + "AssetIpv6.", this.AssetIpv6);
            this.SetParamSimple(map, prefix + "SSHRisk", this.SSHRisk);
            this.SetParamSimple(map, prefix + "RDPRisk", this.RDPRisk);
            this.SetParamSimple(map, prefix + "EventRisk", this.EventRisk);
            this.SetParamSimple(map, prefix + "AssetVulNum", this.AssetVulNum);
            this.SetParamSimple(map, prefix + "AssetEventNum", this.AssetEventNum);
            this.SetParamSimple(map, prefix + "AssetCspmRiskNum", this.AssetCspmRiskNum);
            this.SetParamSimple(map, prefix + "SsaAssetDeleteTime", this.SsaAssetDeleteTime);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "AssetRegionName", this.AssetRegionName);
            this.SetParamSimple(map, prefix + "AssetVpcid", this.AssetVpcid);
        }
    }
}

