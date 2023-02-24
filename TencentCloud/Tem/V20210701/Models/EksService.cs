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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EksService : AbstractModel
    {
        
        /// <summary>
        /// service name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 可用端口
        /// </summary>
        [JsonProperty("Ports")]
        public long?[] Ports{ get; set; }

        /// <summary>
        /// yaml 内容
        /// </summary>
        [JsonProperty("Yaml")]
        public string Yaml{ get; set; }

        /// <summary>
        /// 服务名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 版本名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 内网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterIp")]
        public string[] ClusterIp{ get; set; }

        /// <summary>
        /// 外网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalIp")]
        public string ExternalIp{ get; set; }

        /// <summary>
        /// 访问类型，可选值：
        /// - EXTERNAL（公网访问）
        /// - VPC（vpc内访问）
        /// - CLUSTER（集群内访问）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 子网ID，只在类型为vpc访问时才有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 负载均衡ID，只在外网访问和vpc内访问才有值，默认自动创建
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalanceId")]
        public string LoadBalanceId{ get; set; }

        /// <summary>
        /// 端口映射
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PortMappings")]
        public PortMapping[] PortMappings{ get; set; }

        /// <summary>
        /// 每种类型访问配置详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServicePortMappingList")]
        public ServicePortMapping[] ServicePortMappingList{ get; set; }

        /// <summary>
        /// 刷新复写所有类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlushAll")]
        public bool? FlushAll{ get; set; }

        /// <summary>
        /// 1: 下次部署自动注入注册中心信息；0：不注入
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableRegistryNextDeploy")]
        public long? EnableRegistryNextDeploy{ get; set; }

        /// <summary>
        /// 返回应用id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 所有服务IP是否已经ready
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllIpDone")]
        public bool? AllIpDone{ get; set; }

        /// <summary>
        /// clb 域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalDomain")]
        public string ExternalDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "Yaml", this.Yaml);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamArraySimple(map, prefix + "ClusterIp.", this.ClusterIp);
            this.SetParamSimple(map, prefix + "ExternalIp", this.ExternalIp);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "LoadBalanceId", this.LoadBalanceId);
            this.SetParamArrayObj(map, prefix + "PortMappings.", this.PortMappings);
            this.SetParamArrayObj(map, prefix + "ServicePortMappingList.", this.ServicePortMappingList);
            this.SetParamSimple(map, prefix + "FlushAll", this.FlushAll);
            this.SetParamSimple(map, prefix + "EnableRegistryNextDeploy", this.EnableRegistryNextDeploy);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "AllIpDone", this.AllIpDone);
            this.SetParamSimple(map, prefix + "ExternalDomain", this.ExternalDomain);
        }
    }
}

