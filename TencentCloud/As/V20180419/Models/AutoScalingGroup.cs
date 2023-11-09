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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScalingGroup : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 伸缩组名称
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// 伸缩组当前状态。取值范围：<br>
        /// <li>NORMAL：正常<br>
        /// <li>CVM_ABNORMAL：启动配置异常<br>
        /// <li>LB_ABNORMAL：负载均衡器异常<br>
        /// <li>LB_LISTENER_ABNORMAL：负载均衡器监听器异常<br>
        /// <li>LB_LOCATION_ABNORMAL：负载均衡器监听器转发配置异常<br>
        /// <li>VPC_ABNORMAL：VPC网络异常<br>
        /// <li>SUBNET_ABNORMAL：VPC子网异常<br>
        /// <li>INSUFFICIENT_BALANCE：余额不足<br>
        /// <li>LB_BACKEND_REGION_NOT_MATCH：CLB实例后端地域与AS服务所在地域不匹配<br>
        /// <li>LB_BACKEND_VPC_NOT_MATCH：CLB实例VPC与伸缩组VPC不匹配
        /// </summary>
        [JsonProperty("AutoScalingGroupStatus")]
        public string AutoScalingGroupStatus{ get; set; }

        /// <summary>
        /// 创建时间，采用UTC标准计时
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 默认冷却时间，单位秒
        /// </summary>
        [JsonProperty("DefaultCooldown")]
        public long? DefaultCooldown{ get; set; }

        /// <summary>
        /// 期望实例数
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public long? DesiredCapacity{ get; set; }

        /// <summary>
        /// 启用状态，取值包括`ENABLED`和`DISABLED`
        /// </summary>
        [JsonProperty("EnabledStatus")]
        public string EnabledStatus{ get; set; }

        /// <summary>
        /// 应用型负载均衡器列表
        /// </summary>
        [JsonProperty("ForwardLoadBalancerSet")]
        public ForwardLoadBalancer[] ForwardLoadBalancerSet{ get; set; }

        /// <summary>
        /// 实例数量
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// 状态为`IN_SERVICE`实例的数量
        /// </summary>
        [JsonProperty("InServiceInstanceCount")]
        public long? InServiceInstanceCount{ get; set; }

        /// <summary>
        /// 启动配置ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// 启动配置名称
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// 传统型负载均衡器ID列表
        /// </summary>
        [JsonProperty("LoadBalancerIdSet")]
        public string[] LoadBalancerIdSet{ get; set; }

        /// <summary>
        /// 最大实例数
        /// </summary>
        [JsonProperty("MaxSize")]
        public long? MaxSize{ get; set; }

        /// <summary>
        /// 最小实例数
        /// </summary>
        [JsonProperty("MinSize")]
        public long? MinSize{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 子网ID列表
        /// </summary>
        [JsonProperty("SubnetIdSet")]
        public string[] SubnetIdSet{ get; set; }

        /// <summary>
        /// 销毁策略
        /// </summary>
        [JsonProperty("TerminationPolicySet")]
        public string[] TerminationPolicySet{ get; set; }

        /// <summary>
        /// VPC标识
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 可用区列表
        /// </summary>
        [JsonProperty("ZoneSet")]
        public string[] ZoneSet{ get; set; }

        /// <summary>
        /// 重试策略
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public string RetryPolicy{ get; set; }

        /// <summary>
        /// 伸缩组是否处于伸缩活动中，`IN_ACTIVITY`表示处于伸缩活动中，`NOT_IN_ACTIVITY`表示不处于伸缩活动中。
        /// </summary>
        [JsonProperty("InActivityStatus")]
        public string InActivityStatus{ get; set; }

        /// <summary>
        /// 伸缩组标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 服务设置
        /// </summary>
        [JsonProperty("ServiceSettings")]
        public ServiceSettings ServiceSettings{ get; set; }

        /// <summary>
        /// 实例具有IPv6地址数量的配置
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public long? Ipv6AddressCount{ get; set; }

        /// <summary>
        /// 多可用区/子网策略。
        /// <br><li> PRIORITY，按照可用区/子网列表的顺序，作为优先级来尝试创建实例，如果优先级最高的可用区/子网可以创建成功，则总在该可用区/子网创建。
        /// <br><li> EQUALITY：每次选择当前实例数最少的可用区/子网进行扩容，使得每个可用区/子网都有机会发生扩容，多次扩容出的实例会打散到多个可用区/子网。
        /// </summary>
        [JsonProperty("MultiZoneSubnetPolicy")]
        public string MultiZoneSubnetPolicy{ get; set; }

        /// <summary>
        /// 伸缩组实例健康检查类型，取值如下：<br><li>CVM：根据实例网络状态判断实例是否处于不健康状态，不健康的网络状态即发生实例 PING 不可达事件，详细判断标准可参考[实例健康检查](https://cloud.tencent.com/document/product/377/8553)<br><li>CLB：根据 CLB 的健康检查状态判断实例是否处于不健康状态，CLB健康检查原理可参考[健康检查](https://cloud.tencent.com/document/product/214/6097)
        /// </summary>
        [JsonProperty("HealthCheckType")]
        public string HealthCheckType{ get; set; }

        /// <summary>
        /// CLB健康检查宽限期
        /// </summary>
        [JsonProperty("LoadBalancerHealthCheckGracePeriod")]
        public ulong? LoadBalancerHealthCheckGracePeriod{ get; set; }

        /// <summary>
        /// 实例分配策略，取值包括 LAUNCH_CONFIGURATION 和 SPOT_MIXED。
        /// <br><li> LAUNCH_CONFIGURATION，代表传统的按照启动配置模式。
        /// <br><li> SPOT_MIXED，代表竞价混合模式。目前仅支持启动配置为按量计费模式时使用混合模式，混合模式下，伸缩组将根据设定扩容按量或竞价机型。使用混合模式时，关联的启动配置的计费类型不可被修改。
        /// </summary>
        [JsonProperty("InstanceAllocationPolicy")]
        public string InstanceAllocationPolicy{ get; set; }

        /// <summary>
        /// 竞价混合模式下，各计费类型实例的分配策略。
        /// 仅当 InstanceAllocationPolicy 取 SPOT_MIXED 时才会返回有效值。
        /// </summary>
        [JsonProperty("SpotMixedAllocationPolicy")]
        public SpotMixedAllocationPolicy SpotMixedAllocationPolicy{ get; set; }

        /// <summary>
        /// 容量重平衡功能，仅对伸缩组内的竞价实例有效。取值范围：
        /// <br><li> TRUE，开启该功能，当伸缩组内的竞价实例即将被竞价实例服务自动回收前，AS 主动发起竞价实例销毁流程，如果有配置过缩容 hook，则销毁前 hook 会生效。销毁流程启动后，AS 会异步开启一个扩容活动，用于补齐期望实例数。
        /// <br><li> FALSE，不开启该功能，则 AS 等待竞价实例被销毁后才会去扩容补齐伸缩组期望实例数。
        /// </summary>
        [JsonProperty("CapacityRebalance")]
        public bool? CapacityRebalance{ get; set; }

        /// <summary>
        /// 实例名称序号相关设置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceNameIndexSettings")]
        public InstanceNameIndexSettings InstanceNameIndexSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "AutoScalingGroupName", this.AutoScalingGroupName);
            this.SetParamSimple(map, prefix + "AutoScalingGroupStatus", this.AutoScalingGroupStatus);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "DefaultCooldown", this.DefaultCooldown);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamSimple(map, prefix + "EnabledStatus", this.EnabledStatus);
            this.SetParamArrayObj(map, prefix + "ForwardLoadBalancerSet.", this.ForwardLoadBalancerSet);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "InServiceInstanceCount", this.InServiceInstanceCount);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamArraySimple(map, prefix + "LoadBalancerIdSet.", this.LoadBalancerIdSet);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "SubnetIdSet.", this.SubnetIdSet);
            this.SetParamArraySimple(map, prefix + "TerminationPolicySet.", this.TerminationPolicySet);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "ZoneSet.", this.ZoneSet);
            this.SetParamSimple(map, prefix + "RetryPolicy", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "InActivityStatus", this.InActivityStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "ServiceSettings.", this.ServiceSettings);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
            this.SetParamSimple(map, prefix + "MultiZoneSubnetPolicy", this.MultiZoneSubnetPolicy);
            this.SetParamSimple(map, prefix + "HealthCheckType", this.HealthCheckType);
            this.SetParamSimple(map, prefix + "LoadBalancerHealthCheckGracePeriod", this.LoadBalancerHealthCheckGracePeriod);
            this.SetParamSimple(map, prefix + "InstanceAllocationPolicy", this.InstanceAllocationPolicy);
            this.SetParamObj(map, prefix + "SpotMixedAllocationPolicy.", this.SpotMixedAllocationPolicy);
            this.SetParamSimple(map, prefix + "CapacityRebalance", this.CapacityRebalance);
            this.SetParamObj(map, prefix + "InstanceNameIndexSettings.", this.InstanceNameIndexSettings);
        }
    }
}

