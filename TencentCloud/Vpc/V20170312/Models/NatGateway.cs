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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NatGateway : AbstractModel
    {
        
        /// <summary>
        /// NAT网关的ID。
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// NAT网关的名称。
        /// </summary>
        [JsonProperty("NatGatewayName")]
        public string NatGatewayName{ get; set; }

        /// <summary>
        /// NAT网关创建的时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// NAT网关的状态。
        ///  'PENDING'：生产中，'DELETING'：删除中/子实例关闭中，'AVAILABLE'：运行中，'UPDATING'：升级中，
        /// ‘PENDFAILURE’：创建失败，‘DELETEFAILURE：删除失败，‘DENIED’：子实例关闭中
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 网关最大外网出带宽(单位:Mbps)。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 网关并发连接上限。
        /// </summary>
        [JsonProperty("MaxConcurrentConnection")]
        public ulong? MaxConcurrentConnection{ get; set; }

        /// <summary>
        /// 绑定NAT网关的公网IP对象数组。
        /// </summary>
        [JsonProperty("PublicIpAddressSet")]
        public NatGatewayAddress[] PublicIpAddressSet{ get; set; }

        /// <summary>
        /// NAT网关网络状态。“AVAILABLE”:运行中, “UNAVAILABLE”:不可用, “INSUFFICIENT”:欠费停服。
        /// </summary>
        [JsonProperty("NetworkState")]
        public string NetworkState{ get; set; }

        /// <summary>
        /// NAT网关的端口转发规则。
        /// </summary>
        [JsonProperty("DestinationIpPortTranslationNatRuleSet")]
        public DestinationIpPortTranslationNatRule[] DestinationIpPortTranslationNatRuleSet{ get; set; }

        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// NAT网关所在的可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 绑定的专线网关ID。
        /// </summary>
        [JsonProperty("DirectConnectGatewayIds")]
        public string[] DirectConnectGatewayIds{ get; set; }

        /// <summary>
        /// 所属子网ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 标签键值对。
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// NAT网关绑定的安全组列表
        /// </summary>
        [JsonProperty("SecurityGroupSet")]
        public string[] SecurityGroupSet{ get; set; }

        /// <summary>
        /// NAT网关的SNAT转发规则。
        /// </summary>
        [JsonProperty("SourceIpTranslationNatRuleSet")]
        public SourceIpTranslationNatRule[] SourceIpTranslationNatRuleSet{ get; set; }

        /// <summary>
        /// 是否独享型NAT。
        /// </summary>
        [JsonProperty("IsExclusive")]
        public bool? IsExclusive{ get; set; }

        /// <summary>
        /// 独享型NAT所在的网关集群的带宽(单位:Mbps)，当IsExclusive为false时无此字段。
        /// </summary>
        [JsonProperty("ExclusiveGatewayBandwidth")]
        public ulong? ExclusiveGatewayBandwidth{ get; set; }

        /// <summary>
        /// NAT网关是否被封禁。“NORMAL”：未被封禁，“RESTRICTED”：已被封禁。
        /// </summary>
        [JsonProperty("RestrictState")]
        public string RestrictState{ get; set; }

        /// <summary>
        /// NAT网关类型，1表示传统型NAT网关，2表示标准型NAT网关
        /// </summary>
        [JsonProperty("NatProductVersion")]
        public ulong? NatProductVersion{ get; set; }

        /// <summary>
        /// 是否启用根据目的网段选择SNAT使用的EIP功能	
        /// </summary>
        [JsonProperty("SmartScheduleMode")]
        public bool? SmartScheduleMode{ get; set; }

        /// <summary>
        /// NAT实例归属的专属集群id
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// NAT实例是否开启删除保护
        /// </summary>
        [JsonProperty("DeletionProtectionEnabled")]
        public bool? DeletionProtectionEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "NatGatewayName", this.NatGatewayName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "MaxConcurrentConnection", this.MaxConcurrentConnection);
            this.SetParamArrayObj(map, prefix + "PublicIpAddressSet.", this.PublicIpAddressSet);
            this.SetParamSimple(map, prefix + "NetworkState", this.NetworkState);
            this.SetParamArrayObj(map, prefix + "DestinationIpPortTranslationNatRuleSet.", this.DestinationIpPortTranslationNatRuleSet);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "DirectConnectGatewayIds.", this.DirectConnectGatewayIds);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamArraySimple(map, prefix + "SecurityGroupSet.", this.SecurityGroupSet);
            this.SetParamArrayObj(map, prefix + "SourceIpTranslationNatRuleSet.", this.SourceIpTranslationNatRuleSet);
            this.SetParamSimple(map, prefix + "IsExclusive", this.IsExclusive);
            this.SetParamSimple(map, prefix + "ExclusiveGatewayBandwidth", this.ExclusiveGatewayBandwidth);
            this.SetParamSimple(map, prefix + "RestrictState", this.RestrictState);
            this.SetParamSimple(map, prefix + "NatProductVersion", this.NatProductVersion);
            this.SetParamSimple(map, prefix + "SmartScheduleMode", this.SmartScheduleMode);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamSimple(map, prefix + "DeletionProtectionEnabled", this.DeletionProtectionEnabled);
        }
    }
}

