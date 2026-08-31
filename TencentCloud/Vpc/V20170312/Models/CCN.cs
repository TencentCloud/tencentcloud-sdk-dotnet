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
        /// <p>云联网唯一ID</p>
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// <p>云联网名称</p>
        /// </summary>
        [JsonProperty("CcnName")]
        public string CcnName{ get; set; }

        /// <summary>
        /// <p>云联网描述信息</p>
        /// </summary>
        [JsonProperty("CcnDescription")]
        public string CcnDescription{ get; set; }

        /// <summary>
        /// <p>关联实例数量</p>
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>实例状态， &#39;ISOLATED&#39;: 隔离中（欠费停服），&#39;AVAILABLE&#39;：运行中。</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>实例服务质量，’PT’：白金，&#39;AU&#39;：金，&#39;AG&#39;：银。</p>
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }

        /// <summary>
        /// <p>付费类型，PREPAID为预付费，POSTPAID为后付费。</p>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>计量类型</p>
        /// </summary>
        [JsonProperty("InstanceMeteringType")]
        public string InstanceMeteringType{ get; set; }

        /// <summary>
        /// <p>限速类型，<code>INTER_REGION_LIMIT</code> 为地域间限速；<code>OUTER_REGION_LIMIT</code> 为地域出口限速。</p>
        /// </summary>
        [JsonProperty("BandwidthLimitType")]
        public string BandwidthLimitType{ get; set; }

        /// <summary>
        /// <p>标签键值对。</p>
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// <p>是否支持云联网路由优先级的功能。<code>False</code>：不支持，<code>True</code>：支持。</p>
        /// </summary>
        [JsonProperty("RoutePriorityFlag")]
        public bool? RoutePriorityFlag{ get; set; }

        /// <summary>
        /// <p>实例关联的路由表个数。</p>
        /// </summary>
        [JsonProperty("RouteTableCount")]
        public ulong? RouteTableCount{ get; set; }

        /// <summary>
        /// <p>是否开启云联网多路由表特性。<code>False</code>：未开启，<code>True</code>：开启。</p>
        /// </summary>
        [JsonProperty("RouteTableFlag")]
        public bool? RouteTableFlag{ get; set; }

        /// <summary>
        /// <p><code>true</code>：实例已被封禁，流量不通，<code>false</code>:解封禁。</p>
        /// </summary>
        [JsonProperty("IsSecurityLock")]
        public bool? IsSecurityLock{ get; set; }

        /// <summary>
        /// <p>是否开启云联网路由传播策略。<code>False</code> 未开启，<code>True</code> 开启。</p>
        /// </summary>
        [JsonProperty("RouteBroadcastPolicyFlag")]
        public bool? RouteBroadcastPolicyFlag{ get; set; }

        /// <summary>
        /// <p>是否开启等价路由功能。<code>False</code> 未开启，<code>True</code> 开启。</p>
        /// </summary>
        [JsonProperty("RouteECMPFlag")]
        public bool? RouteECMPFlag{ get; set; }

        /// <summary>
        /// <p>是否开启路由重叠功能。<code>False</code> 未开启，<code>True</code> 开启。</p>
        /// </summary>
        [JsonProperty("RouteOverlapFlag")]
        public bool? RouteOverlapFlag{ get; set; }

        /// <summary>
        /// <p>是否开启QOS。</p>
        /// </summary>
        [JsonProperty("TrafficMarkingPolicyFlag")]
        public bool? TrafficMarkingPolicyFlag{ get; set; }

        /// <summary>
        /// <p>是否开启路由表选择策略。</p>
        /// </summary>
        [JsonProperty("RouteSelectPolicyFlag")]
        public bool? RouteSelectPolicyFlag{ get; set; }

        /// <summary>
        /// <p>是否开启二层云联网通道。</p>
        /// </summary>
        [JsonProperty("DirectConnectAccelerateChannelFlag")]
        public bool? DirectConnectAccelerateChannelFlag{ get; set; }

        /// <summary>
        /// <p>是否支持ipv6路由表</p>
        /// </summary>
        [JsonProperty("Ipv6Flag")]
        public bool? Ipv6Flag{ get; set; }

        /// <summary>
        /// <p>是否支持路由表聚合策略</p>
        /// </summary>
        [JsonProperty("MrtbAggregatePolicyFlag")]
        public bool? MrtbAggregatePolicyFlag{ get; set; }

        /// <summary>
        /// <p>是否支持AsPath策略值</p>
        /// </summary>
        [JsonProperty("MrtbPolicyValueFlag")]
        public bool? MrtbPolicyValueFlag{ get; set; }

        /// <summary>
        /// <p>是否支持Community策略值</p>
        /// </summary>
        [JsonProperty("RouteTablePolicyValueCommunityFlag")]
        public bool? RouteTablePolicyValueCommunityFlag{ get; set; }

        /// <summary>
        /// <p>是否支持策略路由</p>
        /// </summary>
        [JsonProperty("PolicyBasedRoutingFlag")]
        public bool? PolicyBasedRoutingFlag{ get; set; }

        /// <summary>
        /// <p>服务等级模式</p><p>枚举值：</p><ul><li>0： 云联网模式</li><li>1： 地域间模式</li></ul>
        /// </summary>
        [JsonProperty("ServiceLevelMode")]
        public ulong? ServiceLevelMode{ get; set; }


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
            this.SetParamSimple(map, prefix + "InstanceMeteringType", this.InstanceMeteringType);
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
            this.SetParamSimple(map, prefix + "ServiceLevelMode", this.ServiceLevelMode);
        }
    }
}

