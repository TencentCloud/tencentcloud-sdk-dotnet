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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PreviewPGUserMigrationsResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>将要执行的migration列表</p>
        /// </summary>
        [JsonProperty("Pending")]
        public MigrationPlanItem[] Pending{ get; set; }

        /// <summary>
        /// <p>已经应用的migration列表</p>
        /// </summary>
        [JsonProperty("Applied")]
        public MigrationPlanItem[] Applied{ get; set; }

        /// <summary>
        /// <p>版本相同但 checksum 不一致冲突的migration列表</p>
        /// </summary>
        [JsonProperty("Conflicts")]
        public MigrationConflict[] Conflicts{ get; set; }

        /// <summary>
        /// <p>是否可直接执行；当前仅表示没有 checksum 冲突</p>
        /// </summary>
        [JsonProperty("Executable")]
        public bool? Executable{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Pending.", this.Pending);
            this.SetParamArrayObj(map, prefix + "Applied.", this.Applied);
            this.SetParamArrayObj(map, prefix + "Conflicts.", this.Conflicts);
            this.SetParamSimple(map, prefix + "Executable", this.Executable);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

