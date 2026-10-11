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

    public class ModifyPrometheusConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>集群类型</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>集群id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>ServiceMonitors配置</p>
        /// </summary>
        [JsonProperty("ServiceMonitors")]
        public PrometheusConfigItem[] ServiceMonitors{ get; set; }

        /// <summary>
        /// <p>PodMonitors配置</p>
        /// </summary>
        [JsonProperty("PodMonitors")]
        public PrometheusConfigItem[] PodMonitors{ get; set; }

        /// <summary>
        /// <p>prometheus原生Job配置</p>
        /// </summary>
        [JsonProperty("RawJobs")]
        public PrometheusConfigItem[] RawJobs{ get; set; }

        /// <summary>
        /// <p>0: 更新实例组件镜像版本；<br>1: 不更新实例组件镜像版本</p><p>取值范围：[0, 1]</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("UpdateImage")]
        [System.Obsolete]
        public long? UpdateImage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArrayObj(map, prefix + "ServiceMonitors.", this.ServiceMonitors);
            this.SetParamArrayObj(map, prefix + "PodMonitors.", this.PodMonitors);
            this.SetParamArrayObj(map, prefix + "RawJobs.", this.RawJobs);
            this.SetParamSimple(map, prefix + "UpdateImage", this.UpdateImage);
        }
    }
}

