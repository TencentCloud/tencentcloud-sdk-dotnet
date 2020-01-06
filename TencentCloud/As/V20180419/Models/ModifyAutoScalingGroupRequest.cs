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

    public class ModifyAutoScalingGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 伸缩组名称，在您账号中必须唯一。名称仅支持中文、英文、数字、下划线、分隔符"-"、小数点，最大长度不能超55个字节。
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// 默认冷却时间，单位秒，默认值为300
        /// </summary>
        [JsonProperty("DefaultCooldown")]
        public ulong? DefaultCooldown{ get; set; }

        /// <summary>
        /// 期望实例数，大小介于最小实例数和最大实例数之间
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public ulong? DesiredCapacity{ get; set; }

        /// <summary>
        /// 启动配置ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// 最大实例数，取值范围为0-2000。
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// 最小实例数，取值范围为0-2000。
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 子网ID列表
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 销毁策略，目前长度上限为1。取值包括 OLDEST_INSTANCE 和 NEWEST_INSTANCE。
        /// <br><li> OLDEST_INSTANCE 优先销毁伸缩组中最旧的实例。
        /// <br><li> NEWEST_INSTANCE，优先销毁伸缩组中最新的实例。
        /// </summary>
        [JsonProperty("TerminationPolicies")]
        public string[] TerminationPolicies{ get; set; }

        /// <summary>
        /// VPC ID，基础网络则填空字符串。修改为具体VPC ID时，需指定相应的SubnetIds；修改为基础网络时，需指定相应的Zones。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 可用区列表
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 重试策略，取值包括 IMMEDIATE_RETRY、 INCREMENTAL_INTERVALS、NO_RETRY，默认取值为 IMMEDIATE_RETRY。
        /// <br><li> IMMEDIATE_RETRY，立即重试，在较短时间内快速重试，连续失败超过一定次数（5次）后不再重试。
        /// <br><li> INCREMENTAL_INTERVALS，间隔递增重试，随着连续失败次数的增加，重试间隔逐渐增大，重试间隔从秒级到1天不等。
        /// <br><li> NO_RETRY，不进行重试，直到再次收到用户调用或者告警信息后才会重试。
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public string RetryPolicy{ get; set; }

        /// <summary>
        /// 可用区校验策略，取值包括 ALL 和 ANY，默认取值为ANY。在伸缩组实际变更资源相关字段时（启动配置、可用区、子网）发挥作用。
        /// <br><li> ALL，所有可用区（Zone）或子网（SubnetId）都可用则通过校验，否则校验报错。
        /// <br><li> ANY，存在任何一个可用区（Zone）或子网（SubnetId）可用则通过校验，否则校验报错。
        /// 
        /// 可用区或子网不可用的常见原因包括该可用区CVM实例类型售罄、该可用区CBS云盘售罄、该可用区配额不足、该子网IP不足等。
        /// 如果 Zones/SubnetIds 中可用区或者子网不存在，则无论 ZonesCheckPolicy 采用何种取值，都会校验报错。
        /// </summary>
        [JsonProperty("ZonesCheckPolicy")]
        public string ZonesCheckPolicy{ get; set; }

        /// <summary>
        /// 服务设置，包括云监控不健康替换等服务设置。
        /// </summary>
        [JsonProperty("ServiceSettings")]
        public ServiceSettings ServiceSettings{ get; set; }

        /// <summary>
        /// 实例具有IPv6地址数量的配置，取值包括0、1。
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
            this.SetParamSimple(map, prefix + "DefaultCooldown", this.DefaultCooldown);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArraySimple(map, prefix + "TerminationPolicies.", this.TerminationPolicies);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "RetryPolicy", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "ZonesCheckPolicy", this.ZonesCheckPolicy);
            this.SetParamObj(map, prefix + "ServiceSettings.", this.ServiceSettings);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
        }
    }
}

