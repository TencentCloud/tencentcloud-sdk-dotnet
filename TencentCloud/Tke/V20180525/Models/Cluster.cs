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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Cluster : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>集群描述</p>
        /// </summary>
        [JsonProperty("ClusterDescription")]
        public string ClusterDescription{ get; set; }

        /// <summary>
        /// <p>集群版本（默认值为1.10.5）</p>
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// <p>集群系统。centos7.2x86_64 或者 ubuntu16.04.1 LTSx86_64，默认取值为ubuntu16.04.1 LTSx86_64</p>
        /// </summary>
        [JsonProperty("ClusterOs")]
        public string ClusterOs{ get; set; }

        /// <summary>
        /// <p>集群类型，托管集群：MANAGED_CLUSTER，独立集群：INDEPENDENT_CLUSTER。</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>集群网络相关参数</p>
        /// </summary>
        [JsonProperty("ClusterNetworkSettings")]
        public ClusterNetworkSettings ClusterNetworkSettings{ get; set; }

        /// <summary>
        /// <p>集群当前node数量</p>
        /// </summary>
        [JsonProperty("ClusterNodeNum")]
        public ulong? ClusterNodeNum{ get; set; }

        /// <summary>
        /// <p>集群所属的项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// <p>标签描述列表。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }

        /// <summary>
        /// <p>集群状态 (Trading 集群开通中,Creating 创建中,Running 运行中,Deleting 删除中,Idling 闲置中,Recovering 唤醒中,Scaling 规模调整中,Upgrading 升级中,WaittingForConnect 等待注册,Trading 集群开通中,Isolated 欠费隔离中,Pause 集群升级暂停,NodeUpgrading 节点升级中,RuntimeUpgrading 节点运行时升级中,MasterScaling Master扩缩容中,ClusterLevelUpgrading 调整规格中,ResourceIsolate 隔离中,ResourceIsolated 已隔离,ResourceReverse 冲正中,Abnormal 异常)</p>
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// <p>集群属性(包括集群不同属性的MAP，属性字段包括NodeNameType (lan-ip模式和hostname 模式，默认无lan-ip模式))</p>
        /// </summary>
        [JsonProperty("Property")]
        public string Property{ get; set; }

        /// <summary>
        /// <p>集群当前master数量</p>
        /// </summary>
        [JsonProperty("ClusterMaterNodeNum")]
        public ulong? ClusterMaterNodeNum{ get; set; }

        /// <summary>
        /// <p>集群使用镜像id</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>OsCustomizeType 系统定制类型</p>
        /// </summary>
        [JsonProperty("OsCustomizeType")]
        public string OsCustomizeType{ get; set; }

        /// <summary>
        /// <p>集群运行环境docker或container</p>
        /// </summary>
        [JsonProperty("ContainerRuntime")]
        public string ContainerRuntime{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>集群删除保护开关，打开：true，关闭：false</p>
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// <p>集群是否开启第三方节点支持，开启：true，关闭：false</p>
        /// </summary>
        [JsonProperty("EnableExternalNode")]
        public bool? EnableExternalNode{ get; set; }

        /// <summary>
        /// <p>集群等级，针对托管集群生效</p>
        /// </summary>
        [JsonProperty("ClusterLevel")]
        public string ClusterLevel{ get; set; }

        /// <summary>
        /// <p>自动变配集群等级，针对托管集群生效。开启：true，关闭：false</p>
        /// </summary>
        [JsonProperty("AutoUpgradeClusterLevel")]
        public bool? AutoUpgradeClusterLevel{ get; set; }

        /// <summary>
        /// <p>是否开启QGPU共享，开启：true，关闭：false</p>
        /// </summary>
        [JsonProperty("QGPUShareEnable")]
        public bool? QGPUShareEnable{ get; set; }

        /// <summary>
        /// <p>运行时版本</p>
        /// </summary>
        [JsonProperty("RuntimeVersion")]
        public string RuntimeVersion{ get; set; }

        /// <summary>
        /// <p>集群当前etcd数量</p>
        /// </summary>
        [JsonProperty("ClusterEtcdNodeNum")]
        public ulong? ClusterEtcdNodeNum{ get; set; }

        /// <summary>
        /// <p>本地专用集群Id</p>
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// <p>集群是否启用高可用模式。用于指导跨可用区资源打散等高可用策略的执行</p>
        /// </summary>
        [JsonProperty("IsHighAvailability")]
        public bool? IsHighAvailability{ get; set; }

        /// <summary>
        /// <p>开启后会下发Gatekeeper和网络策略</p>
        /// </summary>
        [JsonProperty("SecurityModeConfig")]
        public SecurityModeConfig SecurityModeConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterDescription", this.ClusterDescription);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "ClusterOs", this.ClusterOs);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamObj(map, prefix + "ClusterNetworkSettings.", this.ClusterNetworkSettings);
            this.SetParamSimple(map, prefix + "ClusterNodeNum", this.ClusterNodeNum);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "Property", this.Property);
            this.SetParamSimple(map, prefix + "ClusterMaterNodeNum", this.ClusterMaterNodeNum);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "OsCustomizeType", this.OsCustomizeType);
            this.SetParamSimple(map, prefix + "ContainerRuntime", this.ContainerRuntime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "EnableExternalNode", this.EnableExternalNode);
            this.SetParamSimple(map, prefix + "ClusterLevel", this.ClusterLevel);
            this.SetParamSimple(map, prefix + "AutoUpgradeClusterLevel", this.AutoUpgradeClusterLevel);
            this.SetParamSimple(map, prefix + "QGPUShareEnable", this.QGPUShareEnable);
            this.SetParamSimple(map, prefix + "RuntimeVersion", this.RuntimeVersion);
            this.SetParamSimple(map, prefix + "ClusterEtcdNodeNum", this.ClusterEtcdNodeNum);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "IsHighAvailability", this.IsHighAvailability);
            this.SetParamObj(map, prefix + "SecurityModeConfig.", this.SecurityModeConfig);
        }
    }
}

