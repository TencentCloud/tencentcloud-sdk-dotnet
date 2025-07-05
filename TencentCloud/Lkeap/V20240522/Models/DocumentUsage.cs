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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocumentUsage : AbstractModel
    {
        
        /// <summary>
        /// 文档拆分任务的页数
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 文档拆分任务消耗的总token数
        /// </summary>
        [JsonProperty("TotalToken")]
        [System.Obsolete]
        public long? TotalToken{ get; set; }

        /// <summary>
        /// 文档拆分任务消耗的总token数
        /// </summary>
        [JsonProperty("TotalTokens")]
        public long? TotalTokens{ get; set; }

        /// <summary>
        /// 拆分消耗的token数
        /// </summary>
        [JsonProperty("SplitTokens")]
        public long? SplitTokens{ get; set; }

        /// <summary>
        /// mllm消耗的token数
        /// </summary>
        [JsonProperty("MllmTokens")]
        public long? MllmTokens{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "TotalToken", this.TotalToken);
            this.SetParamSimple(map, prefix + "TotalTokens", this.TotalTokens);
            this.SetParamSimple(map, prefix + "SplitTokens", this.SplitTokens);
            this.SetParamSimple(map, prefix + "MllmTokens", this.MllmTokens);
        }
    }
}

