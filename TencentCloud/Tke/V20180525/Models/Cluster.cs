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

    public class Cluster : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群描述
        /// </summary>
        [JsonProperty("ClusterDescription")]
        public string ClusterDescription{ get; set; }

        /// <summary>
        /// 集群版本（默认值为1.10.5）
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// 集群系统。centos7.2x86_64 或者 ubuntu16.04.1 LTSx86_64，默认取值为ubuntu16.04.1 LTSx86_64
        /// </summary>
        [JsonProperty("ClusterOs")]
        public string ClusterOs{ get; set; }

        /// <summary>
        /// 集群类型，托管集群：MANAGED_CLUSTER，独立集群：INDEPENDENT_CLUSTER。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群网络相关参数
        /// </summary>
        [JsonProperty("ClusterNetworkSettings")]
        public ClusterNetworkSettings ClusterNetworkSettings{ get; set; }

        /// <summary>
        /// 集群当前node数量
        /// </summary>
        [JsonProperty("ClusterNodeNum")]
        public ulong? ClusterNodeNum{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterDescription", this.ClusterDescription);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "ClusterOs", this.ClusterOs);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamObj(map, prefix + "ClusterNetworkSettings.", this.ClusterNetworkSettings);
            this.SetParamSimple(map, prefix + "ClusterNodeNum", this.ClusterNodeNum);
        }
    }
}

