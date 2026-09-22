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

namespace TencentCloud.Workbuddyenterprise.V20260709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class A2AConfig : AbstractModel
    {
        
        /// <summary>
        /// Agent 级唯一 A2A 开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("A2AEnabled")]
        public bool? A2AEnabled{ get; set; }

        /// <summary>
        /// 对外 A2A handle（已注册时；仅 DescribeAgent / ModifyAgentA2AConfig 填充）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("A2APublicRef")]
        public string A2APublicRef{ get; set; }

        /// <summary>
        /// 对外 A2A card 发现地址（已注册时）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("A2AEndpoint")]
        public string A2AEndpoint{ get; set; }

        /// <summary>
        /// 注册状态：DRAFT / REGISTERED / DISABLED / NONE / UNKNOWN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("A2AStatus")]
        public string A2AStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "A2AEnabled", this.A2AEnabled);
            this.SetParamSimple(map, prefix + "A2APublicRef", this.A2APublicRef);
            this.SetParamSimple(map, prefix + "A2AEndpoint", this.A2AEndpoint);
            this.SetParamSimple(map, prefix + "A2AStatus", this.A2AStatus);
        }
    }
}

