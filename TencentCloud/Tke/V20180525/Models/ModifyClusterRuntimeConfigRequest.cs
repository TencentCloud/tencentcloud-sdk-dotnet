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

    public class ModifyClusterRuntimeConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID，必填
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 运行时版本需依据指定的Kubernetes版本进行设置。典型情况为，在升级过程中因版本冲突而需要调整运行时版本时。
        /// </summary>
        [JsonProperty("DstK8SVersion")]
        public string DstK8SVersion{ get; set; }

        /// <summary>
        /// 需要修改集群运行时填写
        /// </summary>
        [JsonProperty("ClusterRuntimeConfig")]
        public RuntimeConfig ClusterRuntimeConfig{ get; set; }

        /// <summary>
        /// 需要修改节点池运行时，填需要修改的部分
        /// </summary>
        [JsonProperty("NodePoolRuntimeConfig")]
        public NodePoolRuntime[] NodePoolRuntimeConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "DstK8SVersion", this.DstK8SVersion);
            this.SetParamObj(map, prefix + "ClusterRuntimeConfig.", this.ClusterRuntimeConfig);
            this.SetParamArrayObj(map, prefix + "NodePoolRuntimeConfig.", this.NodePoolRuntimeConfig);
        }
    }
}

