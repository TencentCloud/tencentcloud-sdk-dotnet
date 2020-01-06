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

    public class ClusterAsGroupOption : AbstractModel
    {
        
        /// <summary>
        /// 是否开启缩容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsScaleDownEnabled")]
        public bool? IsScaleDownEnabled{ get; set; }

        /// <summary>
        /// 多伸缩组情况下扩容选择算法(random 随机选择，most-pods 最多类型的Pod least-waste 最少的资源浪费，默认为random)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Expander")]
        public string Expander{ get; set; }

        /// <summary>
        /// 最大并发缩容数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxEmptyBulkDelete")]
        public long? MaxEmptyBulkDelete{ get; set; }

        /// <summary>
        /// 集群扩容后多少分钟开始判断缩容（默认为10分钟）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScaleDownDelay")]
        public long? ScaleDownDelay{ get; set; }

        /// <summary>
        /// 节点连续空闲多少分钟后被缩容（默认为 10分钟）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScaleDownUnneededTime")]
        public long? ScaleDownUnneededTime{ get; set; }

        /// <summary>
        /// 节点资源使用量低于多少(百分比)时认为空闲(默认: 50(百分比))
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScaleDownUtilizationThreshold")]
        public long? ScaleDownUtilizationThreshold{ get; set; }

        /// <summary>
        /// 含有本地存储Pod的节点是否不缩容(默认： FALSE)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkipNodesWithLocalStorage")]
        public bool? SkipNodesWithLocalStorage{ get; set; }

        /// <summary>
        /// 含有kube-system namespace下非DaemonSet管理的Pod的节点是否不缩容 (默认： FALSE)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkipNodesWithSystemPods")]
        public bool? SkipNodesWithSystemPods{ get; set; }

        /// <summary>
        /// 计算资源使用量时是否默认忽略DaemonSet的实例(默认值: False，不忽略)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoreDaemonSetsUtilization")]
        public bool? IgnoreDaemonSetsUtilization{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsScaleDownEnabled", this.IsScaleDownEnabled);
            this.SetParamSimple(map, prefix + "Expander", this.Expander);
            this.SetParamSimple(map, prefix + "MaxEmptyBulkDelete", this.MaxEmptyBulkDelete);
            this.SetParamSimple(map, prefix + "ScaleDownDelay", this.ScaleDownDelay);
            this.SetParamSimple(map, prefix + "ScaleDownUnneededTime", this.ScaleDownUnneededTime);
            this.SetParamSimple(map, prefix + "ScaleDownUtilizationThreshold", this.ScaleDownUtilizationThreshold);
            this.SetParamSimple(map, prefix + "SkipNodesWithLocalStorage", this.SkipNodesWithLocalStorage);
            this.SetParamSimple(map, prefix + "SkipNodesWithSystemPods", this.SkipNodesWithSystemPods);
            this.SetParamSimple(map, prefix + "IgnoreDaemonSetsUtilization", this.IgnoreDaemonSetsUtilization);
        }
    }
}

