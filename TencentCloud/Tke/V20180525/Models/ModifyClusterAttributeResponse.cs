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

    public class ModifyClusterAttributeResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群所属项目
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群描述
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// 集群等级
        /// </summary>
        [JsonProperty("ClusterLevel")]
        public string ClusterLevel{ get; set; }

        /// <summary>
        /// 自动变配集群等级
        /// </summary>
        [JsonProperty("AutoUpgradeClusterLevel")]
        public AutoUpgradeClusterLevel AutoUpgradeClusterLevel{ get; set; }

        /// <summary>
        /// 是否开启QGPU共享
        /// </summary>
        [JsonProperty("QGPUShareEnable")]
        public bool? QGPUShareEnable{ get; set; }

        /// <summary>
        /// 集群属性
        /// </summary>
        [JsonProperty("ClusterProperty")]
        public ClusterProperty ClusterProperty{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamSimple(map, prefix + "ClusterLevel", this.ClusterLevel);
            this.SetParamObj(map, prefix + "AutoUpgradeClusterLevel.", this.AutoUpgradeClusterLevel);
            this.SetParamSimple(map, prefix + "QGPUShareEnable", this.QGPUShareEnable);
            this.SetParamObj(map, prefix + "ClusterProperty.", this.ClusterProperty);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

