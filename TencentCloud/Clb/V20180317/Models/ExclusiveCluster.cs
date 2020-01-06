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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExclusiveCluster : AbstractModel
    {
        
        /// <summary>
        /// 4层独占集群列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("L4Clusters")]
        public ClusterItem[] L4Clusters{ get; set; }

        /// <summary>
        /// 7层独占集群列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("L7Clusters")]
        public ClusterItem[] L7Clusters{ get; set; }

        /// <summary>
        /// vpcgw集群
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassicalCluster")]
        public ClusterItem ClassicalCluster{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "L4Clusters.", this.L4Clusters);
            this.SetParamArrayObj(map, prefix + "L7Clusters.", this.L7Clusters);
            this.SetParamObj(map, prefix + "ClassicalCluster.", this.ClassicalCluster);
        }
    }
}

