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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServiceDiscoveryRequest : AbstractModel
    {
        
        /// <summary>
        /// Prometheus 实例 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <li>类型是 TKE，为对应的腾讯云容器服务集群 ID</li>
        /// </summary>
        [JsonProperty("KubeClusterId")]
        public string KubeClusterId{ get; set; }

        /// <summary>
        /// 用户 Kubernetes 集群类型：
        /// <li> 1 = 容器服务集群(TKE) </li>
        /// </summary>
        [JsonProperty("KubeType")]
        public long? KubeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "KubeClusterId", this.KubeClusterId);
            this.SetParamSimple(map, prefix + "KubeType", this.KubeType);
        }
    }
}

