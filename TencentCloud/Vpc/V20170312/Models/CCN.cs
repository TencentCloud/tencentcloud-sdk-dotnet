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

    public class CCN : AbstractModel
    {
        
        /// <summary>
        /// 云联网唯一ID
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 云联网名称
        /// </summary>
        [JsonProperty("CcnName")]
        public string CcnName{ get; set; }

        /// <summary>
        /// 云联网描述信息
        /// </summary>
        [JsonProperty("CcnDescription")]
        public string CcnDescription{ get; set; }

        /// <summary>
        /// 关联实例数量
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例状态， 'ISOLATED': 隔离中（欠费停服），'AVAILABLE'：运行中。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 实例服务质量，’PT’：白金，'AU'：金，'AG'：银。
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }

        /// <summary>
        /// 付费类型，PREPAID为预付费，POSTPAID为后付费。
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 限速类型，`INTER_REGION_LIMIT` 为地域间限速；`OUTER_REGION_LIMIT` 为地域出口限速。
        /// </summary>
        [JsonProperty("BandwidthLimitType")]
        public string BandwidthLimitType{ get; set; }

        /// <summary>
        /// 标签键值对。
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 是否支持云联网路由优先级的功能。`False`：不支持，`True`：支持。
        /// </summary>
        [JsonProperty("RoutePriorityFlag")]
        public bool? RoutePriorityFlag{ get; set; }

        /// <summary>
        /// 实例关联的路由表个数。
        /// </summary>
        [JsonProperty("RouteTableCount")]
        public ulong? RouteTableCount{ get; set; }

        /// <summary>
        /// 是否开启云联网多路由表特性。`False`：未开启，`True`：开启。
        /// </summary>
        [JsonProperty("RouteTableFlag")]
        public bool? RouteTableFlag{ get; set; }

        /// <summary>
        /// `true`：实例已被封禁，流量不通，`false`:解封禁。
        /// </summary>
        [JsonProperty("IsSecurityLock")]
        public bool? IsSecurityLock{ get; set; }

        /// <summary>
        /// 是否开启云联网路由传播策略。`False` 未开启，`True` 开启。
        /// </summary>
        [JsonProperty("RouteBroadcastPolicyFlag")]
        public bool? RouteBroadcastPolicyFlag{ get; set; }

        /// <summary>
        /// 是否开启等价路由功能。`False` 未开启，`True` 开启。
        /// </summary>
        [JsonProperty("RouteECMPFlag")]
        public bool? RouteECMPFlag{ get; set; }

        /// <summary>
        /// 是否开启路由重叠功能。`False` 未开启，`True` 开启。
        /// </summary>
        [JsonProperty("RouteOverlapFlag")]
        public bool? RouteOverlapFlag{ get; set; }

        /// <summary>
        /// 是否开启QOS。
        /// </summary>
        [JsonProperty("TrafficMarkingPolicyFlag")]
        public bool? TrafficMarkingPolicyFlag{ get; set; }

        /// <summary>
        /// 是否开启路由表选择策略。
        /// </summary>
        [JsonProperty("RouteSelectPolicyFlag")]
        public bool? RouteSelectPolicyFlag{ get; set; }

        /// <summary>
        /// 是否开启二层云联网通道。
        /// </summary>
        [JsonProperty("DirectConnectAccelerateChannelFlag")]
        public bool? DirectConnectAccelerateChannelFlag{ get; set; }

        /// <summary>
        /// 是否支持ipv6路由表
        /// </summary>
        [JsonProperty("Ipv6Flag")]
        public bool? Ipv6Flag{ get; set; }

        /// <summary>
        /// 是否支持路由表聚合策略
        /// </summary>
        [JsonProperty("MrtbAggregatePolicyFlag")]
        public bool? MrtbAggregatePolicyFlag{ get; set; }

        /// <summary>
        /// 是否支持AsPath策略值
        /// </summary>
        [JsonProperty("MrtbPolicyValueFlag")]
        public bool? MrtbPolicyValueFlag{ get; set; }

        /// <summary>
        /// 是否支持Community策略值
        /// </summary>
        [JsonProperty("RouteTablePolicyValueCommunityFlag")]
        public bool? RouteTablePolicyValueCommunityFlag{ get; set; }

        /// <summary>
        /// 是否支持策略路由
        /// </summary>
        [JsonProperty("PolicyBasedRoutingFlag")]
        public bool? PolicyBasedRoutingFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CcnName", this.CcnName);
            this.SetParamSimple(map, prefix + "CcnDescription", this.CcnDescription);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "BandwidthLimitType", this.BandwidthLimitType);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "RoutePriorityFlag", this.RoutePriorityFlag);
            this.SetParamSimple(map, prefix + "RouteTableCount", this.RouteTableCount);
            this.SetParamSimple(map, prefix + "RouteTableFlag", this.RouteTableFlag);
            this.SetParamSimple(map, prefix + "IsSecurityLock", this.IsSecurityLock);
            this.SetParamSimple(map, prefix + "RouteBroadcastPolicyFlag", this.RouteBroadcastPolicyFlag);
            this.SetParamSimple(map, prefix + "RouteECMPFlag", this.RouteECMPFlag);
            this.SetParamSimple(map, prefix + "RouteOverlapFlag", this.RouteOverlapFlag);
            this.SetParamSimple(map, prefix + "TrafficMarkingPolicyFlag", this.TrafficMarkingPolicyFlag);
            this.SetParamSimple(map, prefix + "RouteSelectPolicyFlag", this.RouteSelectPolicyFlag);
            this.SetParamSimple(map, prefix + "DirectConnectAccelerateChannelFlag", this.DirectConnectAccelerateChannelFlag);
            this.SetParamSimple(map, prefix + "Ipv6Flag", this.Ipv6Flag);
            this.SetParamSimple(map, prefix + "MrtbAggregatePolicyFlag", this.MrtbAggregatePolicyFlag);
            this.SetParamSimple(map, prefix + "MrtbPolicyValueFlag", this.MrtbPolicyValueFlag);
            this.SetParamSimple(map, prefix + "RouteTablePolicyValueCommunityFlag", this.RouteTablePolicyValueCommunityFlag);
            this.SetParamSimple(map, prefix + "PolicyBasedRoutingFlag", this.PolicyBasedRoutingFlag);
        }
    }
}

