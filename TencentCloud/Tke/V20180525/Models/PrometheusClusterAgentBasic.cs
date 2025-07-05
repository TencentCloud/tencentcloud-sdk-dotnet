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

    public class PrometheusClusterAgentBasic : AbstractModel
    {
        
        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 是否开启公网CLB
        /// </summary>
        [JsonProperty("EnableExternal")]
        public bool? EnableExternal{ get; set; }

        /// <summary>
        /// 集群内部署组件的pod配置
        /// </summary>
        [JsonProperty("InClusterPodConfig")]
        public PrometheusClusterAgentPodConfig InClusterPodConfig{ get; set; }

        /// <summary>
        /// 该集群采集的所有指标都会带上这些labels
        /// </summary>
        [JsonProperty("ExternalLabels")]
        public Label[] ExternalLabels{ get; set; }

        /// <summary>
        /// 是否安装默认采集配置
        /// </summary>
        [JsonProperty("NotInstallBasicScrape")]
        public bool? NotInstallBasicScrape{ get; set; }

        /// <summary>
        /// 是否采集指标，true代表drop所有指标，false代表采集默认指标
        /// </summary>
        [JsonProperty("NotScrape")]
        public bool? NotScrape{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "EnableExternal", this.EnableExternal);
            this.SetParamObj(map, prefix + "InClusterPodConfig.", this.InClusterPodConfig);
            this.SetParamArrayObj(map, prefix + "ExternalLabels.", this.ExternalLabels);
            this.SetParamSimple(map, prefix + "NotInstallBasicScrape", this.NotInstallBasicScrape);
            this.SetParamSimple(map, prefix + "NotScrape", this.NotScrape);
        }
    }
}

