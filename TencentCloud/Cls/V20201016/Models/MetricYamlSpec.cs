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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricYamlSpec : AbstractModel
    {
        
        /// <summary>
        /// yaml监控类型。
        /// 支持：
        /// - PodMonitor
        /// - ServiceMonitor
        /// - ScrapeConfig
        /// - ScrapeConfig-prometheus
        /// 
        /// `PodMonitor `,`ServiceMonitor `,`ScrapeConfig ` 属于prometheus-operator
        /// `ScrapeConfig-prometheus` 属于prometheus
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 配置yaml格式。
        /// 例如：Type: ServiceMonitor
        /// 
        /// 
        /// ```
        /// apiVersion: monitoring.coreos.com/v1
        /// kind: ServiceMonitor
        /// metadata:
        ///   name: test
        ///   namespace: test
        ///   labels:
        ///     k8s-app1: test
        ///     k8s-app2: test
        /// spec:
        ///   endpoints:
        ///     - interval: 15s
        ///       port: 8080-8080-tcp
        ///       path: /metrics
        ///       relabelings:
        ///         - action: replace
        ///           sourceLabels:
        ///             - __meta_kubernetes_pod_label_app
        ///           targetLabel: application
        ///   namespaceSelector:
        ///     matchNames:
        ///       - test
        ///   selector:
        ///     matchLabels:
        ///       app: test
        /// ```
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
        }
    }
}

