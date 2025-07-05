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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusEndpointInfo : AbstractModel
    {
        
        /// <summary>
        /// Prometheus开关的状态。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrometheusEndpointStatus")]
        public string PrometheusEndpointStatus{ get; set; }

        /// <summary>
        /// prometheus信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcPrometheusEndpoint")]
        public string[] VpcPrometheusEndpoint{ get; set; }

        /// <summary>
        /// 节点信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodePrometheusAddress")]
        public string[] NodePrometheusAddress{ get; set; }

        /// <summary>
        /// vpc信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcEndpointInfo")]
        public VpcEndpointInfo VpcEndpointInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrometheusEndpointStatus", this.PrometheusEndpointStatus);
            this.SetParamArraySimple(map, prefix + "VpcPrometheusEndpoint.", this.VpcPrometheusEndpoint);
            this.SetParamArraySimple(map, prefix + "NodePrometheusAddress.", this.NodePrometheusAddress);
            this.SetParamObj(map, prefix + "VpcEndpointInfo.", this.VpcEndpointInfo);
        }
    }
}

