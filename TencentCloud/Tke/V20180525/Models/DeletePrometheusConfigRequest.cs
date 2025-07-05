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

    public class DeletePrometheusConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 要删除的ServiceMonitor名字列表
        /// </summary>
        [JsonProperty("ServiceMonitors")]
        public string[] ServiceMonitors{ get; set; }

        /// <summary>
        /// 要删除的PodMonitor名字列表
        /// </summary>
        [JsonProperty("PodMonitors")]
        public string[] PodMonitors{ get; set; }

        /// <summary>
        /// 要删除的RawJobs名字列表
        /// </summary>
        [JsonProperty("RawJobs")]
        public string[] RawJobs{ get; set; }

        /// <summary>
        /// 要删除的Probe名字列表
        /// </summary>
        [JsonProperty("Probes")]
        public string[] Probes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "ServiceMonitors.", this.ServiceMonitors);
            this.SetParamArraySimple(map, prefix + "PodMonitors.", this.PodMonitors);
            this.SetParamArraySimple(map, prefix + "RawJobs.", this.RawJobs);
            this.SetParamArraySimple(map, prefix + "Probes.", this.Probes);
        }
    }
}

