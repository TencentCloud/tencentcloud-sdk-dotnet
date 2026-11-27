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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDDoSProtectionPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>防护实例 ID。</p>
        /// </summary>
        [JsonProperty("ProtectionId")]
        public string ProtectionId{ get; set; }

        /// <summary>
        /// <p>防护策略。</p><p>支持部分修改：对于 <code>ProtectionPolicy</code> 下的各子策略，入参未传入的子策略保持原值不变。</p>
        /// </summary>
        [JsonProperty("ProtectionPolicy")]
        public ProtectionPolicy ProtectionPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectionId", this.ProtectionId);
            this.SetParamObj(map, prefix + "ProtectionPolicy.", this.ProtectionPolicy);
        }
    }
}

