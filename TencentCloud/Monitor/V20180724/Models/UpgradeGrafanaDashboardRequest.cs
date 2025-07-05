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

    public class UpgradeGrafanaDashboardRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Prometheus 集成项 Code，升级对应的 Dashboard，取值如下：<li>qcloud</li><li>cvm_process_exporter</li><li>cvm_node_exporter</li><li>cvm</li><li>tps</li><li>nginx-ingress</li><li>nvidia-gpu</li><li>cdwch</li><li>emr</li><li>apache</li><li>rocketmq</li><li>rabbitmq</li><li>spring_mvc</li><li>mysql</li><li>mssql</li><li>go</li><li>redis</li><li>jvm</li><li>pgsql</li><li>ceph</li><li>docker</li><li>nginx</li><li>oracledb</li><li>mongo</li><li>kafka</li><li>es</li><li>flink</li><li>blackbox</li><li>consule</li><li>memcached</li><li>zk</li><li>tps</li><li>istio</li><li>etcd</li><li>pts</li><li>kong</li>
        /// </summary>
        [JsonProperty("IntegrationCodes")]
        public string[] IntegrationCodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "IntegrationCodes.", this.IntegrationCodes);
        }
    }
}

