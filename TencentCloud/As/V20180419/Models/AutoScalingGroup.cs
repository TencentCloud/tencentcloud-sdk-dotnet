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
        /// 伸缩组当前状态。取值范围：<br><li>NORMAL：正常<br><li>CVM_ABNORMAL：启动配置异常<br><li>LB_ABNORMAL：负载均衡器异常<br><li>VPC_ABNORMAL：VPC网络异常<br><li>INSUFFICIENT_BALANCE：余额不足<br>
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}

