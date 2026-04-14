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

    public class ModifyClusterAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p><p>取值参考：<a href="https://cloud.tencent.com/document/api/457/31862">DescribeClusters</a></p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群所属项目</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>集群名称,字符长度50</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>集群描述</p>
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// <p>集群等级，等级类型：L20、L50、L100、L200、L500、L1000、L3000、L5000</p>
        /// </summary>
        [JsonProperty("ClusterLevel")]
        public string ClusterLevel{ get; set; }

        /// <summary>
        /// <p>自动变配集群等级</p>
        /// </summary>
        [JsonProperty("AutoUpgradeClusterLevel")]
        public AutoUpgradeClusterLevel AutoUpgradeClusterLevel{ get; set; }

        /// <summary>
        /// <p>是否开启QGPU共享</p>
        /// </summary>
        [JsonProperty("QGPUShareEnable")]
        public bool? QGPUShareEnable{ get; set; }

        /// <summary>
        /// <p>集群属性</p>
        /// </summary>
        [JsonProperty("ClusterProperty")]
        public ClusterProperty ClusterProperty{ get; set; }

        /// <summary>
        /// <p>集群是否启用高可用模式。用于指导跨可用区资源打散等高可用策略的执行</p>
        /// </summary>
        [JsonProperty("IsHighAvailability")]
        public bool? IsHighAvailability{ get; set; }

        /// <summary>
        /// <p>集群安全模式配置</p>
        /// </summary>
        [JsonProperty("SecurityModeConfig")]
        public SecurityModeConfig SecurityModeConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamSimple(map, prefix + "ClusterLevel", this.ClusterLevel);
            this.SetParamObj(map, prefix + "AutoUpgradeClusterLevel.", this.AutoUpgradeClusterLevel);
            this.SetParamSimple(map, prefix + "QGPUShareEnable", this.QGPUShareEnable);
            this.SetParamObj(map, prefix + "ClusterProperty.", this.ClusterProperty);
            this.SetParamSimple(map, prefix + "IsHighAvailability", this.IsHighAvailability);
            this.SetParamObj(map, prefix + "SecurityModeConfig.", this.SecurityModeConfig);
        }
    }
}

