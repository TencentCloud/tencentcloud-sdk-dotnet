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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceGovernanceConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否开启服务注册治理
        /// </summary>
        [JsonProperty("EnableGovernance")]
        public bool? EnableGovernance{ get; set; }

        /// <summary>
        /// 服务治理类型（枚举：SHARE表示共享型、EXCLUSIVE表示独占型）
        /// </summary>
        [JsonProperty("GovernanceType")]
        public string GovernanceType{ get; set; }

        /// <summary>
        /// 独享实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExclusiveInstances")]
        public ExclusiveInstance[] ExclusiveInstances{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableGovernance", this.EnableGovernance);
            this.SetParamSimple(map, prefix + "GovernanceType", this.GovernanceType);
            this.SetParamArrayObj(map, prefix + "ExclusiveInstances.", this.ExclusiveInstances);
        }
    }
}

