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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterStatus : AbstractModel
    {
        
        /// <summary>
        /// 集群Id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群状态
        /// </summary>
        [JsonProperty("ClusterState")]
        public string ClusterState{ get; set; }

        /// <summary>
        /// 集群下机器实例的状态
        /// </summary>
        [JsonProperty("ClusterInstanceState")]
        public string ClusterInstanceState{ get; set; }

        /// <summary>
        /// 集群是否开启监控
        /// </summary>
        [JsonProperty("ClusterBMonitor")]
        public bool? ClusterBMonitor{ get; set; }

        /// <summary>
        /// 集群创建中的节点数，-1表示获取节点状态超时，-2表示获取节点状态失败
        /// </summary>
        [JsonProperty("ClusterInitNodeNum")]
        public long? ClusterInitNodeNum{ get; set; }

        /// <summary>
        /// 集群运行中的节点数，-1表示获取节点状态超时，-2表示获取节点状态失败
        /// </summary>
        [JsonProperty("ClusterRunningNodeNum")]
        public long? ClusterRunningNodeNum{ get; set; }

        /// <summary>
        /// 集群异常的节点数，-1表示获取节点状态超时，-2表示获取节点状态失败
        /// </summary>
        [JsonProperty("ClusterFailedNodeNum")]
        public long? ClusterFailedNodeNum{ get; set; }

        /// <summary>
        /// 集群已关机的节点数，-1表示获取节点状态超时，-2表示获取节点状态失败
        /// </summary>
        [JsonProperty("ClusterClosedNodeNum")]
        public long? ClusterClosedNodeNum{ get; set; }

        /// <summary>
        /// 集群关机中的节点数，-1表示获取节点状态超时，-2表示获取节点状态失败
        /// </summary>
        [JsonProperty("ClusterClosingNodeNum")]
        public long? ClusterClosingNodeNum{ get; set; }

        /// <summary>
        /// 集群是否开启删除保护
        /// </summary>
        [JsonProperty("ClusterDeletionProtection")]
        public bool? ClusterDeletionProtection{ get; set; }

        /// <summary>
        /// 集群是否可审计
        /// </summary>
        [JsonProperty("ClusterAuditEnabled")]
        public bool? ClusterAuditEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterState", this.ClusterState);
            this.SetParamSimple(map, prefix + "ClusterInstanceState", this.ClusterInstanceState);
            this.SetParamSimple(map, prefix + "ClusterBMonitor", this.ClusterBMonitor);
            this.SetParamSimple(map, prefix + "ClusterInitNodeNum", this.ClusterInitNodeNum);
            this.SetParamSimple(map, prefix + "ClusterRunningNodeNum", this.ClusterRunningNodeNum);
            this.SetParamSimple(map, prefix + "ClusterFailedNodeNum", this.ClusterFailedNodeNum);
            this.SetParamSimple(map, prefix + "ClusterClosedNodeNum", this.ClusterClosedNodeNum);
            this.SetParamSimple(map, prefix + "ClusterClosingNodeNum", this.ClusterClosingNodeNum);
            this.SetParamSimple(map, prefix + "ClusterDeletionProtection", this.ClusterDeletionProtection);
            this.SetParamSimple(map, prefix + "ClusterAuditEnabled", this.ClusterAuditEnabled);
        }
    }
}

