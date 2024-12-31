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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceNodeDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 进程所在节点IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 进程类型
        /// </summary>
        [JsonProperty("NodeType")]
        public long? NodeType{ get; set; }

        /// <summary>
        /// 进程名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 服务组件状态
        /// </summary>
        [JsonProperty("ServiceStatus")]
        public long? ServiceStatus{ get; set; }

        /// <summary>
        /// 进程监控状态
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public long? MonitorStatus{ get; set; }

        /// <summary>
        /// 服务组件状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 进程端口信息
        /// </summary>
        [JsonProperty("PortsInfo")]
        public string PortsInfo{ get; set; }

        /// <summary>
        /// 最近重启时间
        /// </summary>
        [JsonProperty("LastRestartTime")]
        public string LastRestartTime{ get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("Flag")]
        public long? Flag{ get; set; }

        /// <summary>
        /// 配置组ID
        /// </summary>
        [JsonProperty("ConfGroupId")]
        public long? ConfGroupId{ get; set; }

        /// <summary>
        /// 配置组名称
        /// </summary>
        [JsonProperty("ConfGroupName")]
        public string ConfGroupName{ get; set; }

        /// <summary>
        /// 节点是否需要重启
        /// </summary>
        [JsonProperty("ConfStatus")]
        public long? ConfStatus{ get; set; }

        /// <summary>
        /// 进程探测信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceDetectionInfo")]
        public ServiceProcessFunctionInfo[] ServiceDetectionInfo{ get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("NodeFlagFilter")]
        public string NodeFlagFilter{ get; set; }

        /// <summary>
        /// 进程健康状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthStatus")]
        public HealthStatus HealthStatus{ get; set; }

        /// <summary>
        /// 角色是否支持监控
        /// </summary>
        [JsonProperty("IsSupportRoleMonitor")]
        public bool? IsSupportRoleMonitor{ get; set; }

        /// <summary>
        /// 暂停策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StopPolicies")]
        public RestartPolicy[] StopPolicies{ get; set; }

        /// <summary>
        /// 测试环境api强校验，现网没有，emrcc接口返回有。不加会报错
        /// </summary>
        [JsonProperty("HAState")]
        public string HAState{ get; set; }

        /// <summary>
        /// NameService名称
        /// </summary>
        [JsonProperty("NameService")]
        public string NameService{ get; set; }

        /// <summary>
        /// 是否支持联邦
        /// </summary>
        [JsonProperty("IsFederation")]
        public bool? IsFederation{ get; set; }

        /// <summary>
        /// datanode是否是维护状态
        /// </summary>
        [JsonProperty("DataNodeMaintenanceState")]
        public long? DataNodeMaintenanceState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "ServiceStatus", this.ServiceStatus);
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PortsInfo", this.PortsInfo);
            this.SetParamSimple(map, prefix + "LastRestartTime", this.LastRestartTime);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "ConfGroupId", this.ConfGroupId);
            this.SetParamSimple(map, prefix + "ConfGroupName", this.ConfGroupName);
            this.SetParamSimple(map, prefix + "ConfStatus", this.ConfStatus);
            this.SetParamArrayObj(map, prefix + "ServiceDetectionInfo.", this.ServiceDetectionInfo);
            this.SetParamSimple(map, prefix + "NodeFlagFilter", this.NodeFlagFilter);
            this.SetParamObj(map, prefix + "HealthStatus.", this.HealthStatus);
            this.SetParamSimple(map, prefix + "IsSupportRoleMonitor", this.IsSupportRoleMonitor);
            this.SetParamArrayObj(map, prefix + "StopPolicies.", this.StopPolicies);
            this.SetParamSimple(map, prefix + "HAState", this.HAState);
            this.SetParamSimple(map, prefix + "NameService", this.NameService);
            this.SetParamSimple(map, prefix + "IsFederation", this.IsFederation);
            this.SetParamSimple(map, prefix + "DataNodeMaintenanceState", this.DataNodeMaintenanceState);
        }
    }
}

