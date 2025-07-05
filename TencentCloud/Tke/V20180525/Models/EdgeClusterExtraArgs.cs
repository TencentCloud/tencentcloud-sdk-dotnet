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

    public class EdgeClusterExtraArgs : AbstractModel
    {
        
        /// <summary>
        /// kube-apiserver自定义参数，参数格式为["k1=v1", "k1=v2"]， 例如["max-requests-inflight=500","feature-gates=PodShareProcessNamespace=true,DynamicKubeletConfig=true"]
        /// </summary>
        [JsonProperty("KubeAPIServer")]
        public string[] KubeAPIServer{ get; set; }

        /// <summary>
        /// kube-controller-manager自定义参数
        /// </summary>
        [JsonProperty("KubeControllerManager")]
        public string[] KubeControllerManager{ get; set; }

        /// <summary>
        /// kube-scheduler自定义参数
        /// </summary>
        [JsonProperty("KubeScheduler")]
        public string[] KubeScheduler{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "KubeAPIServer.", this.KubeAPIServer);
            this.SetParamArraySimple(map, prefix + "KubeControllerManager.", this.KubeControllerManager);
            this.SetParamArraySimple(map, prefix + "KubeScheduler.", this.KubeScheduler);
        }
    }
}

