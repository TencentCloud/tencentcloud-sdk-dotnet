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

    public class GPUResourceGroupStatistics : AbstractModel
    {
        
        /// <summary>
        /// <p>组内当前资源总数，单位台；不含已销毁和补偿完成的失败资源。</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>Active、无占用且物理状态当前可领取的资源数量，单位台。</p>
        /// </summary>
        [JsonProperty("AvailableCount")]
        public long? AvailableCount{ get; set; }

        /// <summary>
        /// <p>仍被占用或绑定的资源数量，含领取中、使用中及归还未完成，单位台。</p>
        /// </summary>
        [JsonProperty("AllocatedCount")]
        public long? AllocatedCount{ get; set; }

        /// <summary>
        /// <p>资源状态计数，四项之和等于本组 TotalCount。</p>
        /// </summary>
        [JsonProperty("StateCounts")]
        public GPUResourceStateCount StateCounts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "AvailableCount", this.AvailableCount);
            this.SetParamSimple(map, prefix + "AllocatedCount", this.AllocatedCount);
            this.SetParamObj(map, prefix + "StateCounts.", this.StateCounts);
        }
    }
}

