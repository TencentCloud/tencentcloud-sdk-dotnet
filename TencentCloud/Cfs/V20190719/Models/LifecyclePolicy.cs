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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifecyclePolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>生命周期管理策略创建的时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>生命周期管理策略ID</p>
        /// </summary>
        [JsonProperty("LifecyclePolicyID")]
        public string LifecyclePolicyID{ get; set; }

        /// <summary>
        /// <p>生命周期管理策略名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LifecyclePolicyName")]
        public string LifecyclePolicyName{ get; set; }

        /// <summary>
        /// <p>生命周期管理策略关联的管理规则列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LifecycleRules")]
        public LifecycleRule[] LifecycleRules{ get; set; }

        /// <summary>
        /// <p>生命周期管理策略关联目录的绝对路径列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Paths")]
        public PathInfo[] Paths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LifecyclePolicyID", this.LifecyclePolicyID);
            this.SetParamSimple(map, prefix + "LifecyclePolicyName", this.LifecyclePolicyName);
            this.SetParamArrayObj(map, prefix + "LifecycleRules.", this.LifecycleRules);
            this.SetParamArrayObj(map, prefix + "Paths.", this.Paths);
        }
    }
}

