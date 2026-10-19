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

    public class OverviewBlockListQuotaDetail : AbstractModel
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
        /// <p>封禁列表剩余配额数量。</p>
        /// </summary>
        [JsonProperty("RemainCnt")]
        public long? RemainCnt{ get; set; }

        /// <summary>
        /// <p>基础配额总数量。</p>
        /// </summary>
        [JsonProperty("BaseTotalCnt")]
        public long? BaseTotalCnt{ get; set; }

        /// <summary>
        /// <p>基础配额已使用数量。</p>
        /// </summary>
        [JsonProperty("BaseUsedCnt")]
        public long? BaseUsedCnt{ get; set; }

        /// <summary>
        /// <p>基础配额剩余数量。</p>
        /// </summary>
        [JsonProperty("BaseRemainCnt")]
        public long? BaseRemainCnt{ get; set; }

        /// <summary>
        /// <p>扩容配额总数量。</p>
        /// </summary>
        [JsonProperty("ExtensionTotalCnt")]
        public long? ExtensionTotalCnt{ get; set; }

        /// <summary>
        /// <p>扩容配额已使用数量。</p>
        /// </summary>
        [JsonProperty("ExtensionUsedCnt")]
        public long? ExtensionUsedCnt{ get; set; }

        /// <summary>
        /// <p>扩容配额剩余数量。</p>
        /// </summary>
        [JsonProperty("ExtensionRemainCnt")]
        public long? ExtensionRemainCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCnt", this.TotalCnt);
            this.SetParamSimple(map, prefix + "UsedCnt", this.UsedCnt);
            this.SetParamSimple(map, prefix + "RemainCnt", this.RemainCnt);
            this.SetParamSimple(map, prefix + "BaseTotalCnt", this.BaseTotalCnt);
            this.SetParamSimple(map, prefix + "BaseUsedCnt", this.BaseUsedCnt);
            this.SetParamSimple(map, prefix + "BaseRemainCnt", this.BaseRemainCnt);
            this.SetParamSimple(map, prefix + "ExtensionTotalCnt", this.ExtensionTotalCnt);
            this.SetParamSimple(map, prefix + "ExtensionUsedCnt", this.ExtensionUsedCnt);
            this.SetParamSimple(map, prefix + "ExtensionRemainCnt", this.ExtensionRemainCnt);
        }
    }
}

