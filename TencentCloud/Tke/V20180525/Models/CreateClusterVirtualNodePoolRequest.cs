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

    public class CreateClusterVirtualNodePoolRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID，通过DescribeClusters接口获取</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>节点池名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>安全组ID列表</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>子网ID列表</p>
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// <p>虚拟节点label</p>
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// <p>虚拟节点taint</p>
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// <p>节点列表</p>
        /// </summary>
        [JsonProperty("VirtualNodes")]
        public VirtualNodeSpec[] VirtualNodes{ get; set; }

        /// <summary>
        /// <p>删除保护开关，默认关闭</p>
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// <p>节点池操作系统：</p><ul><li>linux（默认）</li><li>windows</li></ul>
        /// </summary>
        [JsonProperty("OS")]
        public string OS{ get; set; }

        /// <summary>
        /// <p>子网资源分配策略，精确控制各子网之间的资源分配比例。</p>
        /// </summary>
        [JsonProperty("SubnetAllocationPolicy")]
        public SubnetAllocationPolicy SubnetAllocationPolicy{ get; set; }

        /// <summary>
        /// <p>AgentPlugin 安装配置。传入即表示需要安装（即使是空对象 {}）</p>
        /// </summary>
        [JsonProperty("AgentPlugin")]
        public AgentPluginConfig AgentPlugin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamArrayObj(map, prefix + "VirtualNodes.", this.VirtualNodes);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "OS", this.OS);
            this.SetParamObj(map, prefix + "SubnetAllocationPolicy.", this.SubnetAllocationPolicy);
            this.SetParamObj(map, prefix + "AgentPlugin.", this.AgentPlugin);
        }
    }
}

