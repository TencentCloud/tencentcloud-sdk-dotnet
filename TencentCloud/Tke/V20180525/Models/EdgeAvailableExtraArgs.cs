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

    public class EdgeAvailableExtraArgs : AbstractModel
    {
        
        /// <summary>
        /// kube-apiserver可用的自定义参数
        /// </summary>
        [JsonProperty("KubeAPIServer")]
        public EdgeArgsFlag[] KubeAPIServer{ get; set; }

        /// <summary>
        /// kube-controller-manager可用的自定义参数
        /// </summary>
        [JsonProperty("KubeControllerManager")]
        public EdgeArgsFlag[] KubeControllerManager{ get; set; }

        /// <summary>
        /// kube-scheduler可用的自定义参数
        /// </summary>
        [JsonProperty("KubeScheduler")]
        public EdgeArgsFlag[] KubeScheduler{ get; set; }

        /// <summary>
        /// kubelet可用的自定义参数
        /// </summary>
        [JsonProperty("Kubelet")]
        public EdgeArgsFlag[] Kubelet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "KubeAPIServer.", this.KubeAPIServer);
            this.SetParamArrayObj(map, prefix + "KubeControllerManager.", this.KubeControllerManager);
            this.SetParamArrayObj(map, prefix + "KubeScheduler.", this.KubeScheduler);
            this.SetParamArrayObj(map, prefix + "Kubelet.", this.Kubelet);
        }
    }
}

