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

    public class PrometheusClusterAgentBasic : AbstractModel
    {
        
        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 集群类型。可填入tke、eks、tkeedge、tdcc，分别代表标准集群、弹性集群、边缘集群、注册集群
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群 ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 是否开启公网 CLB
        /// </summary>
        [JsonProperty("EnableExternal")]
        public bool? EnableExternal{ get; set; }

        /// <summary>
        /// 集群内部署组件的pod 配置
        /// </summary>
        [JsonProperty("InClusterPodConfig")]
        public PrometheusClusterAgentPodConfig InClusterPodConfig{ get; set; }

        /// <summary>
        /// 该集群采集的所有指标都会带上这些labels
        /// </summary>
        [JsonProperty("ExternalLabels")]
        public Label[] ExternalLabels{ get; set; }

        /// <summary>
        /// 是否安装默认采集 exporter 和采集配置
        /// </summary>
        [JsonProperty("NotInstallBasicScrape")]
        public bool? NotInstallBasicScrape{ get; set; }

        /// <summary>
        /// 是否安装采集配置，true 只安装采集 exporter 不会安装采集配置，false 会同时安装采集配置
        /// </summary>
        [JsonProperty("NotScrape")]
        public bool? NotScrape{ get; set; }

        /// <summary>
        /// 是否丢弃所有指标，true 代表丢弃所有指标，false 代表采集默认指标
        /// </summary>
        [JsonProperty("DropAll")]
        public bool? DropAll{ get; set; }

        /// <summary>
        /// 是否开启默认预聚合规则
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
            this.SetParamSimple(map, prefix + "OpenDefaultRecord", this.OpenDefaultRecord);
        }
    }
}

