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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchRunSummary : AbstractModel
    {
        
        /// <summary>
        /// 	失败数量
        /// </summary>
        [JsonProperty("FailedCount")]
        public long? FailedCount{ get; set; }

        /// <summary>
        /// 	成功数量
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// 总批次
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 失败的下标
        /// </summary>
        [JsonProperty("FailedIndexList")]
        public long?[] FailedIndexList{ get; set; }

        /// <summary>
        /// 	上一轮完成的批次
        /// </summary>
        [JsonProperty("JustCompletedIndexList")]
        public long?[] JustCompletedIndexList{ get; set; }

        /// <summary>
        /// 运行中的下标
        /// </summary>
        [JsonProperty("RunningIndexList")]
        public long?[] RunningIndexList{ get; set; }

        /// <summary>
        /// 成功的下标
        /// </summary>
        [JsonProperty("SuccessIndexList")]
        public long?[] SuccessIndexList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FailedCount", this.FailedCount);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArraySimple(map, prefix + "FailedIndexList.", this.FailedIndexList);
            this.SetParamArraySimple(map, prefix + "JustCompletedIndexList.", this.JustCompletedIndexList);
            this.SetParamArraySimple(map, prefix + "RunningIndexList.", this.RunningIndexList);
            this.SetParamArraySimple(map, prefix + "SuccessIndexList.", this.SuccessIndexList);
        }
    }
}

