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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MeshConfig : AbstractModel
    {
        
        /// <summary>
        /// Istio配置
        /// </summary>
        [JsonProperty("Istio")]
        public IstioConfig Istio{ get; set; }

        /// <summary>
        /// AccessLog配置
        /// </summary>
        [JsonProperty("AccessLog")]
        public AccessLogConfig AccessLog{ get; set; }

        /// <summary>
        /// Prometheus配置
        /// </summary>
        [JsonProperty("Prometheus")]
        public PrometheusConfig Prometheus{ get; set; }

        /// <summary>
        /// 自动注入配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Inject")]
        public InjectConfig Inject{ get; set; }

        /// <summary>
        /// 调用跟踪配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tracing")]
        public TracingConfig Tracing{ get; set; }

        /// <summary>
        /// Sidecar自定义资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SidecarResources")]
        public ResourceRequirements SidecarResources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Istio.", this.Istio);
            this.SetParamObj(map, prefix + "AccessLog.", this.AccessLog);
            this.SetParamObj(map, prefix + "Prometheus.", this.Prometheus);
            this.SetParamObj(map, prefix + "Inject.", this.Inject);
            this.SetParamObj(map, prefix + "Tracing.", this.Tracing);
            this.SetParamObj(map, prefix + "SidecarResources.", this.SidecarResources);
        }
    }
}

