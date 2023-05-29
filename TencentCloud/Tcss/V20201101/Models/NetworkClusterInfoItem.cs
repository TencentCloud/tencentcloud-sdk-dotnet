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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkClusterInfoItem : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名字
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群版本
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// 集群操作系统
        /// </summary>
        [JsonProperty("ClusterOs")]
        public string ClusterOs{ get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 集群网络插件
        /// </summary>
        [JsonProperty("NetworkPolicyPlugin")]
        public string NetworkPolicyPlugin{ get; set; }

        /// <summary>
        /// 集群状态
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// 总策略数量
        /// </summary>
        [JsonProperty("TotalRuleCount")]
        public long? TotalRuleCount{ get; set; }

        /// <summary>
        /// 已开启策略数量
        /// </summary>
        [JsonProperty("EnableRuleCount")]
        public long? EnableRuleCount{ get; set; }

        /// <summary>
        /// 集群网络插件状态，正常：Running 不正常：Error
        /// </summary>
        [JsonProperty("NetworkPolicyPluginStatus")]
        public string NetworkPolicyPluginStatus{ get; set; }

        /// <summary>
        /// 集群网络插件错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkPolicyPluginError")]
        public string NetworkPolicyPluginError{ get; set; }

        /// <summary>
        /// 容器网络插件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterNetworkSettings")]
        public string ClusterNetworkSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "ClusterOs", this.ClusterOs);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "NetworkPolicyPlugin", this.NetworkPolicyPlugin);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "TotalRuleCount", this.TotalRuleCount);
            this.SetParamSimple(map, prefix + "EnableRuleCount", this.EnableRuleCount);
            this.SetParamSimple(map, prefix + "NetworkPolicyPluginStatus", this.NetworkPolicyPluginStatus);
            this.SetParamSimple(map, prefix + "NetworkPolicyPluginError", this.NetworkPolicyPluginError);
            this.SetParamSimple(map, prefix + "ClusterNetworkSettings", this.ClusterNetworkSettings);
        }
    }
}

