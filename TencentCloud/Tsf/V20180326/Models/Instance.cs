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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// 机器实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 机器名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 机器内网地址IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LanIp")]
        public string LanIp{ get; set; }

        /// <summary>
        /// 机器外网地址IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// 机器描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceDesc")]
        public string InstanceDesc{ get; set; }

        /// <summary>
        /// 集群ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// VM的状态 虚机：虚机的状态 容器：Pod所在虚机的状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// VM的可使用状态 虚机：虚机是否能够作为资源使用 容器：虚机是否能够作为资源部署POD
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceAvailableStatus")]
        public string InstanceAvailableStatus{ get; set; }

        /// <summary>
        /// 服务下的服务实例的状态 虚机：应用是否可用 + Agent状态 容器：Pod状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceInstanceStatus")]
        public string ServiceInstanceStatus{ get; set; }

        /// <summary>
        /// 标识此instance是否已添加在tsf中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CountInTsf")]
        public long? CountInTsf{ get; set; }

        /// <summary>
        /// 机器所属部署组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 机器所属应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 机器所属应用名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 机器实例在CVM的创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceCreatedTime")]
        public string InstanceCreatedTime{ get; set; }

        /// <summary>
        /// 机器实例在CVM的过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceExpiredTime")]
        public string InstanceExpiredTime{ get; set; }

        /// <summary>
        /// 机器实例在CVM的计费模式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 机器实例总CPU信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceTotalCpu")]
        public float? InstanceTotalCpu{ get; set; }

        /// <summary>
        /// 机器实例总内存信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceTotalMem")]
        public float? InstanceTotalMem{ get; set; }

        /// <summary>
        /// 机器实例使用的CPU信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceUsedCpu")]
        public float? InstanceUsedCpu{ get; set; }

        /// <summary>
        /// 机器实例使用的内存信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceUsedMem")]
        public float? InstanceUsedMem{ get; set; }

        /// <summary>
        /// 机器实例Limit CPU信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceLimitCpu")]
        public float? InstanceLimitCpu{ get; set; }

        /// <summary>
        /// 机器实例Limit 内存信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceLimitMem")]
        public float? InstanceLimitMem{ get; set; }

        /// <summary>
        /// 包版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstancePkgVersion")]
        public string InstancePkgVersion{ get; set; }

        /// <summary>
        /// 集群类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 机器实例业务状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RestrictState")]
        public string RestrictState{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 实例执行状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperationState")]
        public long? OperationState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "LanIp", this.LanIp);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "InstanceDesc", this.InstanceDesc);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "InstanceAvailableStatus", this.InstanceAvailableStatus);
            this.SetParamSimple(map, prefix + "ServiceInstanceStatus", this.ServiceInstanceStatus);
            this.SetParamSimple(map, prefix + "CountInTsf", this.CountInTsf);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "InstanceCreatedTime", this.InstanceCreatedTime);
            this.SetParamSimple(map, prefix + "InstanceExpiredTime", this.InstanceExpiredTime);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "InstanceTotalCpu", this.InstanceTotalCpu);
            this.SetParamSimple(map, prefix + "InstanceTotalMem", this.InstanceTotalMem);
            this.SetParamSimple(map, prefix + "InstanceUsedCpu", this.InstanceUsedCpu);
            this.SetParamSimple(map, prefix + "InstanceUsedMem", this.InstanceUsedMem);
            this.SetParamSimple(map, prefix + "InstanceLimitCpu", this.InstanceLimitCpu);
            this.SetParamSimple(map, prefix + "InstanceLimitMem", this.InstanceLimitMem);
            this.SetParamSimple(map, prefix + "InstancePkgVersion", this.InstancePkgVersion);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "RestrictState", this.RestrictState);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OperationState", this.OperationState);
        }
    }
}

