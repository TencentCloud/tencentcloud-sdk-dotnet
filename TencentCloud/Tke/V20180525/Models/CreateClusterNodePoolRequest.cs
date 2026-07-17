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

    public class CreateClusterNodePoolRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>cluster id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>AutoScalingGroupPara AS组参数，参考 https://cloud.tencent.com/document/product/377/20440</p>
        /// </summary>
        [JsonProperty("AutoScalingGroupPara")]
        public string AutoScalingGroupPara{ get; set; }

        /// <summary>
        /// <p>LaunchConfigurePara 运行参数，参考 https://cloud.tencent.com/document/product/377/20447</p>
        /// </summary>
        [JsonProperty("LaunchConfigurePara")]
        public string LaunchConfigurePara{ get; set; }

        /// <summary>
        /// <p>InstanceAdvancedSettings</p>
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }

        /// <summary>
        /// <p>是否启用自动伸缩</p>
        /// </summary>
        [JsonProperty("EnableAutoscale")]
        public bool? EnableAutoscale{ get; set; }

        /// <summary>
        /// <p>节点池名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Labels标签</p>
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// <p>Taints互斥</p>
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// <p>节点Annotation 列表</p>
        /// </summary>
        [JsonProperty("Annotations")]
        public AnnotationValue[] Annotations{ get; set; }

        /// <summary>
        /// <p>节点池纬度运行时类型及版本</p>
        /// </summary>
        [JsonProperty("ContainerRuntime")]
        public string ContainerRuntime{ get; set; }

        /// <summary>
        /// <p>运行时版本</p>
        /// </summary>
        [JsonProperty("RuntimeVersion")]
        public string RuntimeVersion{ get; set; }

        /// <summary>
        /// <p>节点池os，当为自定义镜像时，传镜像id；否则为公共镜像的osName</p>
        /// </summary>
        [JsonProperty("NodePoolOs")]
        public string NodePoolOs{ get; set; }

        /// <summary>
        /// <p>容器的镜像版本，&quot;DOCKER_CUSTOMIZE&quot;(容器定制版),&quot;GENERAL&quot;(普通版本，默认值)</p>
        /// </summary>
        [JsonProperty("OsCustomizeType")]
        public string OsCustomizeType{ get; set; }

        /// <summary>
        /// <p>资源标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>删除保护开关</p>
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AutoScalingGroupPara", this.AutoScalingGroupPara);
            this.SetParamSimple(map, prefix + "LaunchConfigurePara", this.LaunchConfigurePara);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
            this.SetParamSimple(map, prefix + "EnableAutoscale", this.EnableAutoscale);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamArrayObj(map, prefix + "Annotations.", this.Annotations);
            this.SetParamSimple(map, prefix + "ContainerRuntime", this.ContainerRuntime);
            this.SetParamSimple(map, prefix + "RuntimeVersion", this.RuntimeVersion);
            this.SetParamSimple(map, prefix + "NodePoolOs", this.NodePoolOs);
            this.SetParamSimple(map, prefix + "OsCustomizeType", this.OsCustomizeType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
        }
    }
}

