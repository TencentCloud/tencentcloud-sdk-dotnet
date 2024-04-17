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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodePool : AbstractModel
    {
        
        /// <summary>
        /// NodePoolId 资源池id
        /// </summary>
        [JsonProperty("NodePoolId")]
        public string NodePoolId{ get; set; }

        /// <summary>
        /// Name 资源池名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// ClusterInstanceId 集群实例id
        /// </summary>
        [JsonProperty("ClusterInstanceId")]
        public string ClusterInstanceId{ get; set; }

        /// <summary>
        /// LifeState 状态，当前节点池生命周期状态包括：creating，normal，updating，deleting，deleted
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }

        /// <summary>
        /// LaunchConfigurationId 配置
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// AutoscalingGroupId 分组id
        /// </summary>
        [JsonProperty("AutoscalingGroupId")]
        public string AutoscalingGroupId{ get; set; }

        /// <summary>
        /// Labels 标签
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// Taints 污点标记
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// 节点 Annotation 列表
        /// </summary>
        [JsonProperty("Annotations")]
        public AnnotationValue[] Annotations{ get; set; }

        /// <summary>
        /// NodeCountSummary 节点列表
        /// </summary>
        [JsonProperty("NodeCountSummary")]
        public NodeCountSummary NodeCountSummary{ get; set; }

        /// <summary>
        /// 状态信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoscalingGroupStatus")]
        public string AutoscalingGroupStatus{ get; set; }

        /// <summary>
        /// 最大节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxNodesNum")]
        public long? MaxNodesNum{ get; set; }

        /// <summary>
        /// 最小节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinNodesNum")]
        public long? MinNodesNum{ get; set; }

        /// <summary>
        /// 期望的节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DesiredNodesNum")]
        public long? DesiredNodesNum{ get; set; }

        /// <summary>
        /// 运行时描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeConfig")]
        public RuntimeConfig RuntimeConfig{ get; set; }

        /// <summary>
        /// 节点池osName
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodePoolOs")]
        public string NodePoolOs{ get; set; }

        /// <summary>
        /// 容器的镜像版本，"DOCKER_CUSTOMIZE"(容器定制版),"GENERAL"(普通版本，默认值)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OsCustomizeType")]
        public string OsCustomizeType{ get; set; }

        /// <summary>
        /// 镜像id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 集群属于节点podCIDR大小自定义模式时，节点池需要带上pod数量属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DesiredPodNum")]
        public long? DesiredPodNum{ get; set; }

        /// <summary>
        /// 用户自定义脚本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserScript")]
        public string UserScript{ get; set; }

        /// <summary>
        /// 资源标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 删除保护开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// 节点配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraArgs")]
        public InstanceExtraArgs ExtraArgs{ get; set; }

        /// <summary>
        /// GPU驱动相关参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GPUArgs")]
        public GPUArgs GPUArgs{ get; set; }

        /// <summary>
        /// dockerd --graph 指定值, 默认为 /var/lib/docker
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DockerGraphPath")]
        public string DockerGraphPath{ get; set; }

        /// <summary>
        /// 多盘数据盘挂载信息：新建节点时请确保购买CVM的参数传递了购买多个数据盘的信息，如CreateClusterInstances API的RunInstancesPara下的DataDisks也需要设置购买多个数据盘, 具体可以参考CreateClusterInstances接口的添加集群节点(多块数据盘)样例；添加已有节点时，请确保填写的分区信息在节点上真实存在
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// 是否不可调度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Unschedulable")]
        public long? Unschedulable{ get; set; }

        /// <summary>
        /// 用户自定义脚本,在UserScript前执行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreStartUserScript")]
        public string PreStartUserScript{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodePoolId", this.NodePoolId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ClusterInstanceId", this.ClusterInstanceId);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "AutoscalingGroupId", this.AutoscalingGroupId);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamArrayObj(map, prefix + "Annotations.", this.Annotations);
            this.SetParamObj(map, prefix + "NodeCountSummary.", this.NodeCountSummary);
            this.SetParamSimple(map, prefix + "AutoscalingGroupStatus", this.AutoscalingGroupStatus);
            this.SetParamSimple(map, prefix + "MaxNodesNum", this.MaxNodesNum);
            this.SetParamSimple(map, prefix + "MinNodesNum", this.MinNodesNum);
            this.SetParamSimple(map, prefix + "DesiredNodesNum", this.DesiredNodesNum);
            this.SetParamObj(map, prefix + "RuntimeConfig.", this.RuntimeConfig);
            this.SetParamSimple(map, prefix + "NodePoolOs", this.NodePoolOs);
            this.SetParamSimple(map, prefix + "OsCustomizeType", this.OsCustomizeType);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "DesiredPodNum", this.DesiredPodNum);
            this.SetParamSimple(map, prefix + "UserScript", this.UserScript);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamObj(map, prefix + "ExtraArgs.", this.ExtraArgs);
            this.SetParamObj(map, prefix + "GPUArgs.", this.GPUArgs);
            this.SetParamSimple(map, prefix + "DockerGraphPath", this.DockerGraphPath);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamSimple(map, prefix + "Unschedulable", this.Unschedulable);
            this.SetParamSimple(map, prefix + "PreStartUserScript", this.PreStartUserScript);
        }
    }
}

