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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IngressGateway : AbstractModel
    {
        
        /// <summary>
        /// IngressGateway 实例名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 集群 ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Service 配置
        /// </summary>
        [JsonProperty("Service")]
        public Service Service{ get; set; }

        /// <summary>
        /// Workload 配置
        /// </summary>
        [JsonProperty("Workload")]
        public WorkloadConfig Workload{ get; set; }

        /// <summary>
        /// 负载均衡配置，自动创建 CLB 时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalancer")]
        public LoadBalancer LoadBalancer{ get; set; }

        /// <summary>
        /// IngressGateway 状态信息，只读
        /// </summary>
        [JsonProperty("Status")]
        public IngressGatewayStatus Status{ get; set; }

        /// <summary>
        /// 负载均衡实例ID，使用已有 CLB 时返回
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamObj(map, prefix + "Service.", this.Service);
            this.SetParamObj(map, prefix + "Workload.", this.Workload);
            this.SetParamObj(map, prefix + "LoadBalancer.", this.LoadBalancer);
            this.SetParamObj(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
        }
    }
}

