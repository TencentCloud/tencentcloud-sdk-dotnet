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

    public class DescribeEdgeClusterUpgradeInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 可升级的集群组件及其版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComponentVersion")]
        public string ComponentVersion{ get; set; }

        /// <summary>
        /// 边缘集群当前版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EdgeVersionCurrent")]
        public string EdgeVersionCurrent{ get; set; }

        /// <summary>
        /// 边缘组件镜像仓库地址前缀，包含域名和命名空间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegistryPrefix")]
        public string RegistryPrefix{ get; set; }

        /// <summary>
        /// 集群升级状态，可能值：running、updating、failed
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterUpgradeStatus")]
        public string ClusterUpgradeStatus{ get; set; }

        /// <summary>
        /// 集群升级中状态或者失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterUpgradeStatusReason")]
        public string ClusterUpgradeStatusReason{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentVersion", this.ComponentVersion);
            this.SetParamSimple(map, prefix + "EdgeVersionCurrent", this.EdgeVersionCurrent);
            this.SetParamSimple(map, prefix + "RegistryPrefix", this.RegistryPrefix);
            this.SetParamSimple(map, prefix + "ClusterUpgradeStatus", this.ClusterUpgradeStatus);
            this.SetParamSimple(map, prefix + "ClusterUpgradeStatusReason", this.ClusterUpgradeStatusReason);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

