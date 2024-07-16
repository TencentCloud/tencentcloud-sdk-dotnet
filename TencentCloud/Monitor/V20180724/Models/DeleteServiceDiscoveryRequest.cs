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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteServiceDiscoveryRequest : AbstractModel
    {
        
        /// <summary>
        /// Prometheus 实例 ID，例如：prom-sdfk2342a
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
        /// 服务发现类型，取值如下：
        /// <li> 1 = ServiceMonitor</li>
        /// <li> 2 = PodMonitor</li>
        /// <li> 3 = PodMonitor</li>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 服务发现配置信息，YAML 格式
        /// 
        /// 示例值：
        /// 
        /// ```
        /// apiVersion: monitoring.coreos.com/v1
        /// kind: ServiceMonitor
        /// metadata:
        ///   name: go-demo    # 填写一个唯一名称
        ///   namespace: cm-prometheus  # namespace固定，不要修改
        /// spec:
        ///   endpoints:
        ///   - interval: 30s
        ///     # 填写service yaml中Prometheus Exporter对应的Port的Name
        ///     port: 2112
        ///     # 填写Prometheus Exporter对应的Path的值，不填默认/metrics
        ///     path: /metrics
        ///     relabelings:
        ///     # ** 必须要有一个 label 为 application，这里假设 k8s 有一个 label 为 app，
        ///     # 我们通过 relabel 的 replace 动作把它替换成了 application
        ///     - action: replace
        ///       sourceLabels:  [__meta_kubernetes_pod_label_app]
        ///       targetLabel: application
        ///   # 选择要监控service所在的namespace
        ///   namespaceSelector:
        ///     matchNames:
        ///     - golang-demo
        ///     # 填写要监控service的Label值，以定位目标service
        ///   selector:
        ///     matchLabels:
        ///       app: golang-app-demo
        /// ```
        /// </summary>
        [JsonProperty("Yaml")]
        public string Yaml{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "KubeClusterId", this.KubeClusterId);
            this.SetParamSimple(map, prefix + "KubeType", this.KubeType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Yaml", this.Yaml);
        }
    }
}

