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

namespace TencentCloud.Gwlb.V20240906.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 目标组ID
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// 目标组的vpcid
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 目标组的名字
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// 目标组的默认端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 目标组的创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 目标组的修改时间
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 关联到的规则数组。在DescribeTargetGroupList接口调用时无法获取到该参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssociatedRule")]
        public AssociationItem[] AssociatedRule{ get; set; }

        /// <summary>
        /// 网关负载均衡目标组协议。
        /// - tencent_geneve ：GENEVE 标准协议
        /// - aws_geneve：GENEVE 兼容协议
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 均衡算法。
        /// - ip_hash_3_elastic：弹性哈希
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleAlgorithm")]
        public string ScheduleAlgorithm{ get; set; }

        /// <summary>
        /// 健康检查详情。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheck")]
        public TargetGroupHealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// 是否支持全死全活。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllDeadToAlive")]
        public bool? AllDeadToAlive{ get; set; }

        /// <summary>
        /// 目标组已关联的规则数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssociatedRuleCount")]
        public long? AssociatedRuleCount{ get; set; }

        /// <summary>
        /// 目标组内的实例数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegisteredInstancesCount")]
        public long? RegisteredInstancesCount{ get; set; }

        /// <summary>
        /// 目标组的标签。
        /// </summary>
        [JsonProperty("Tag")]
        public TagInfo[] Tag{ get; set; }

        /// <summary>
        /// 流量分发方式
        /// 
        /// - STATELESS：无状态
        /// - STATEFUL： 有状态
        /// </summary>
        [JsonProperty("ForwardingMode")]
        public string ForwardingMode{ get; set; }

        /// <summary>
        /// TCP协议连接空闲超时时间，可配置60s-6000s，默认350s。
        /// </summary>
        [JsonProperty("TcpIdleConnectTimeout")]
        public long? TcpIdleConnectTimeout{ get; set; }

        /// <summary>
        /// 其他协议连接空闲超时时间，可配置5s-180s，默认120s
        /// </summary>
        [JsonProperty("OthersIdleConnectTimeout")]
        public long? OthersIdleConnectTimeout{ get; set; }

        /// <summary>
        /// 重新调度功能内的解绑后端服务开关，开关打开后解绑后端服务会触发重新调度。
        /// </summary>
        [JsonProperty("RescheduleUnbindRs")]
        public bool? RescheduleUnbindRs{ get; set; }

        /// <summary>
        /// 解绑RS后开启重调度的时间，可配置0s-3600s，默认0s
        /// </summary>
        [JsonProperty("RescheduleUnbindRsStartTime")]
        public long? RescheduleUnbindRsStartTime{ get; set; }

        /// <summary>
        /// 重新调度功能内的后端服务健康探测异常开关，开关打开后后端服务健康检查异常会触发重新调度。
        /// </summary>
        [JsonProperty("RescheduleUnhealthy")]
        public bool? RescheduleUnhealthy{ get; set; }

        /// <summary>
        /// 后端服务健康探测异常后开启重调度的时间，可配置0s-3600s，默认0s
        /// </summary>
        [JsonProperty("RescheduleUnhealthyStartTime")]
        public long? RescheduleUnhealthyStartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamArrayObj(map, prefix + "AssociatedRule.", this.AssociatedRule);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ScheduleAlgorithm", this.ScheduleAlgorithm);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "AllDeadToAlive", this.AllDeadToAlive);
            this.SetParamSimple(map, prefix + "AssociatedRuleCount", this.AssociatedRuleCount);
            this.SetParamSimple(map, prefix + "RegisteredInstancesCount", this.RegisteredInstancesCount);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "ForwardingMode", this.ForwardingMode);
            this.SetParamSimple(map, prefix + "TcpIdleConnectTimeout", this.TcpIdleConnectTimeout);
            this.SetParamSimple(map, prefix + "OthersIdleConnectTimeout", this.OthersIdleConnectTimeout);
            this.SetParamSimple(map, prefix + "RescheduleUnbindRs", this.RescheduleUnbindRs);
            this.SetParamSimple(map, prefix + "RescheduleUnbindRsStartTime", this.RescheduleUnbindRsStartTime);
            this.SetParamSimple(map, prefix + "RescheduleUnhealthy", this.RescheduleUnhealthy);
            this.SetParamSimple(map, prefix + "RescheduleUnhealthyStartTime", this.RescheduleUnhealthyStartTime);
        }
    }
}

