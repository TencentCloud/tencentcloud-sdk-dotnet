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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Asset : AbstractModel
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
        [JsonProperty("AssetRegionName")]
        public string AssetRegionName{ get; set; }

        /// <summary>
        /// 所属网络
        /// </summary>
        [JsonProperty("AssetVpcid")]
        public string AssetVpcid{ get; set; }

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
        /// 引擎版本
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// 数据库标识
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// 配置风险统计数
        /// </summary>
        [JsonProperty("AssetCspmRiskNum")]
        public long? AssetCspmRiskNum{ get; set; }

        /// <summary>
        /// 主机IP
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// 资产唯一标识
        /// </summary>
        [JsonProperty("AssetUniqid")]
        public string AssetUniqid{ get; set; }

        /// <summary>
        /// 付费类型
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 安全事件统计数
        /// </summary>
        [JsonProperty("AssetEventNum")]
        public long? AssetEventNum{ get; set; }

        /// <summary>
        /// 漏洞统计数
        /// </summary>
        [JsonProperty("AssetVulNum")]
        public long? AssetVulNum{ get; set; }

        /// <summary>
        /// 主机IP内网
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// 所属分组
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 发现时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaAssetDiscoverTime")]
        public string SsaAssetDiscoverTime{ get; set; }

        /// <summary>
        /// 下线时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaAssetDeleteTime")]
        public string SsaAssetDeleteTime{ get; set; }

        /// <summary>
        /// 是否是新增资产
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsNew")]
        public bool? IsNew{ get; set; }

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
        /// 负载均衡实例的网络类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 负载均衡实例的vip列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancerVips")]
        public string[] LoadBalancerVips{ get; set; }

        /// <summary>
        /// ipv6信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetIpv6")]
        public string[] AssetIpv6{ get; set; }

        /// <summary>
        /// ssh端口暴露风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SSHRisk")]
        public string SSHRisk{ get; set; }

        /// <summary>
        /// rdp端口暴露风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RDPRisk")]
        public string RDPRisk{ get; set; }

        /// <summary>
        /// 资产失陷事件风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventRisk")]
        public string EventRisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AssetRegionName", this.AssetRegionName);
            this.SetParamSimple(map, prefix + "AssetVpcid", this.AssetVpcid);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "AssetCspmRiskNum", this.AssetCspmRiskNum);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamSimple(map, prefix + "AssetUniqid", this.AssetUniqid);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "AssetEventNum", this.AssetEventNum);
            this.SetParamSimple(map, prefix + "AssetVulNum", this.AssetVulNum);
            this.SetParamArraySimple(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "SsaAssetDiscoverTime", this.SsaAssetDiscoverTime);
            this.SetParamSimple(map, prefix + "SsaAssetDeleteTime", this.SsaAssetDeleteTime);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamSimple(map, prefix + "AssetSubnetId", this.AssetSubnetId);
            this.SetParamSimple(map, prefix + "AssetSubnetName", this.AssetSubnetName);
            this.SetParamSimple(map, prefix + "AssetVpcName", this.AssetVpcName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "NameSpace", this.NameSpace);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamArraySimple(map, prefix + "LoadBalancerVips.", this.LoadBalancerVips);
            this.SetParamArraySimple(map, prefix + "AssetIpv6.", this.AssetIpv6);
            this.SetParamSimple(map, prefix + "SSHRisk", this.SSHRisk);
            this.SetParamSimple(map, prefix + "RDPRisk", this.RDPRisk);
            this.SetParamSimple(map, prefix + "EventRisk", this.EventRisk);
        }
    }
}

