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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstructionConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>角色定义</p>
        /// </summary>
        [JsonProperty("RolePosition")]
        public string RolePosition{ get; set; }

        /// <summary>
        /// <p>核心职责</p>
        /// </summary>
        [JsonProperty("CoreDuty")]
        public string CoreDuty{ get; set; }

        /// <summary>
        /// <p>核心原则</p>
        /// </summary>
        [JsonProperty("CoreTruths")]
        public string CoreTruths{ get; set; }

        /// <summary>
        /// <p>风格约束</p>
        /// </summary>
        [JsonProperty("Vibe")]
        public string Vibe{ get; set; }

        /// <summary>
        /// <p>注意事项</p>
        /// </summary>
        [JsonProperty("Boundaries")]
        public string Boundaries{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RolePosition", this.RolePosition);
            this.SetParamSimple(map, prefix + "CoreDuty", this.CoreDuty);
            this.SetParamSimple(map, prefix + "CoreTruths", this.CoreTruths);
            this.SetParamSimple(map, prefix + "Vibe", this.Vibe);
            this.SetParamSimple(map, prefix + "Boundaries", this.Boundaries);
        }
    }
}

