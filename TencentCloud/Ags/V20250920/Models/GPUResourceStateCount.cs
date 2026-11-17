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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GPUResourceStateCount : AbstractModel
    {
        
        /// <summary>
        /// <p>准备中的资源数量，单位台。</p>
        /// </summary>
        [JsonProperty("Delivering")]
        public long? Delivering{ get; set; }

        /// <summary>
        /// <p>已生效的资源数量，单位台；不等于当前可领取数量。</p>
        /// </summary>
        [JsonProperty("Active")]
        public long? Active{ get; set; }

        /// <summary>
        /// <p>已隔离的资源数量，单位台。</p>
        /// </summary>
        [JsonProperty("Isolated")]
        public long? Isolated{ get; set; }

        /// <summary>
        /// <p>正在释放的资源数量，单位台。</p>
        /// </summary>
        [JsonProperty("Destroying")]
        public long? Destroying{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Delivering", this.Delivering);
            this.SetParamSimple(map, prefix + "Active", this.Active);
            this.SetParamSimple(map, prefix + "Isolated", this.Isolated);
            this.SetParamSimple(map, prefix + "Destroying", this.Destroying);
        }
    }
}

