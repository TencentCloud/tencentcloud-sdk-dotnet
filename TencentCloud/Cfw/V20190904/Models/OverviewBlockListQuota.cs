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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OverviewBlockListQuota : AbstractModel
    {
        
        /// <summary>
        /// <p>封禁列表总配额数量。</p>
        /// </summary>
        [JsonProperty("TotalCnt")]
        public long? TotalCnt{ get; set; }

        /// <summary>
        /// <p>封禁列表已使用数量。</p>
        /// </summary>
        [JsonProperty("UsedCnt")]
        public long? UsedCnt{ get; set; }

        /// <summary>
        /// <p>入站方向已使用的封禁列表记录。</p>
        /// </summary>
        [JsonProperty("InUsedCnt")]
        public long? InUsedCnt{ get; set; }

        /// <summary>
        /// <p>出方向封禁列表已使用数量。</p>
        /// </summary>
        [JsonProperty("OutUsedCnt")]
        public long? OutUsedCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCnt", this.TotalCnt);
            this.SetParamSimple(map, prefix + "UsedCnt", this.UsedCnt);
            this.SetParamSimple(map, prefix + "InUsedCnt", this.InUsedCnt);
            this.SetParamSimple(map, prefix + "OutUsedCnt", this.OutUsedCnt);
        }
    }
}

