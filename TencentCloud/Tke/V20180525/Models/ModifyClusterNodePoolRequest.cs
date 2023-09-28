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

    public class ModifyClusterNodePoolRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 节点池ID
        /// </summary>
        [JsonProperty("NodePoolId")]
        public string NodePoolId{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 最大节点数
        /// </summary>
        [JsonProperty("MaxNodesNum")]
        public long? MaxNodesNum{ get; set; }

        /// <summary>
        /// 最小节点数
        /// </summary>
        [JsonProperty("MinNodesNum")]
        public long? MinNodesNum{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// 污点
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// 是否开启伸缩
        /// </summary>
        [JsonProperty("EnableAutoscale")]
        public bool? EnableAutoscale{ get; set; }

        /// <summary>
        /// 操作系统名称
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// 镜像版本，"DOCKER_CUSTOMIZE"(容器定制版),"GENERAL"(普通版本，默认值)
        /// </summary>
        [JsonProperty("OsCustomizeType")]
        public string OsCustomizeType{ get; set; }

        /// <summary>
        /// GPU驱动版本，CUDA版本，cuDNN版本以及是否启用MIG特性
        /// </summary>
        [JsonProperty("GPUArgs")]
        public GPUArgs GPUArgs{ get; set; }

        /// <summary>
        /// base64编码后的自定义脚本
        /// </summary>
        [JsonProperty("UserScript")]
        public string UserScript{ get; set; }

        /// <summary>
        /// 更新label和taint时忽略存量节点
        /// </summary>
        [JsonProperty("IgnoreExistedNode")]
        public bool? IgnoreExistedNode{ get; set; }

        /// <summary>
        /// 节点自定义参数
        /// </summary>
        [JsonProperty("ExtraArgs")]
        public InstanceExtraArgs ExtraArgs{ get; set; }

        /// <summary>
        /// 资源标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 设置加入的节点是否参与调度，默认值为0，表示参与调度；非0表示不参与调度, 待节点初始化完成之后, 可执行kubectl uncordon nodename使node加入调度.
        /// </summary>
        [JsonProperty("Unschedulable")]
        public long? Unschedulable{ get; set; }

        /// <summary>
        /// 删除保护开关
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// dockerd --graph 指定值, 默认为 /var/lib/docker
        /// </summary>
        [JsonProperty("DockerGraphPath")]
        public string DockerGraphPath{ get; set; }

        /// <summary>
        /// base64编码后的自定义脚本
        /// </summary>
        [JsonProperty("PreStartUserScript")]
        public string PreStartUserScript{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NodePoolId", this.NodePoolId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MaxNodesNum", this.MaxNodesNum);
            this.SetParamSimple(map, prefix + "MinNodesNum", this.MinNodesNum);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamSimple(map, prefix + "EnableAutoscale", this.EnableAutoscale);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "OsCustomizeType", this.OsCustomizeType);
            this.SetParamObj(map, prefix + "GPUArgs.", this.GPUArgs);
            this.SetParamSimple(map, prefix + "UserScript", this.UserScript);
            this.SetParamSimple(map, prefix + "IgnoreExistedNode", this.IgnoreExistedNode);
            this.SetParamObj(map, prefix + "ExtraArgs.", this.ExtraArgs);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Unschedulable", this.Unschedulable);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "DockerGraphPath", this.DockerGraphPath);
            this.SetParamSimple(map, prefix + "PreStartUserScript", this.PreStartUserScript);
        }
    }
}

