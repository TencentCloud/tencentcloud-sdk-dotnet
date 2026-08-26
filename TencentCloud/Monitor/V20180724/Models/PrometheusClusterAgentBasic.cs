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

    public class PrometheusClusterAgentBasic : AbstractModel
    {
        
        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>集群类型。可填入tke、eks、tkeedge、tdcc、external，分别代表标准集群、弹性集群、边缘集群、注册集群 和外部集群</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>集群 ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>是否开启公网 CLB</p>
        /// </summary>
        [JsonProperty("EnableExternal")]
        public bool? EnableExternal{ get; set; }

        /// <summary>
        /// <p>集群内部署组件的pod 配置</p>
        /// </summary>
        [JsonProperty("InClusterPodConfig")]
        public PrometheusClusterAgentPodConfig InClusterPodConfig{ get; set; }

        /// <summary>
        /// <p>该集群采集的所有指标都会带上这些labels</p>
        /// </summary>
        [JsonProperty("ExternalLabels")]
        public Label[] ExternalLabels{ get; set; }

        /// <summary>
        /// <p>是否安装默认采集 exporter 和采集配置</p>
        /// </summary>
        [JsonProperty("NotInstallBasicScrape")]
        public bool? NotInstallBasicScrape{ get; set; }

        /// <summary>
        /// <p>是否安装采集配置，true 只安装采集 exporter 不会安装采集配置，false 会同时安装采集配置</p>
        /// </summary>
        [JsonProperty("NotScrape")]
        public bool? NotScrape{ get; set; }

        /// <summary>
        /// <p>是否丢弃所有指标，true 代表丢弃所有指标，false 代表采集默认指标</p>
        /// </summary>
        [JsonProperty("DropAll")]
        public bool? DropAll{ get; set; }

        /// <summary>
        /// <p>是否采集全部指标</p><p>枚举值：</p><ul><li>false： 不采集</li><li>true： 采集</li></ul><p>默认值：false</p>
        /// </summary>
        [JsonProperty("CollectAll")]
        public bool? CollectAll{ get; set; }

        /// <summary>
        /// <p>是否开启默认预聚合规则</p>
        /// </summary>
        [JsonProperty("OpenDefaultRecord")]
        public bool? OpenDefaultRecord{ get; set; }


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
            this.SetParamSimple(map, prefix + "DropAll", this.DropAll);
            this.SetParamSimple(map, prefix + "CollectAll", this.CollectAll);
            this.SetParamSimple(map, prefix + "OpenDefaultRecord", this.OpenDefaultRecord);
        }
    }
}

