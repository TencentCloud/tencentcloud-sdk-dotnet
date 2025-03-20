/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTokenUsageResponse : AbstractModel
    {
        
        /// <summary>
        /// 总token消耗量
        /// </summary>
        [JsonProperty("TotalTokenUsage")]
        public float? TotalTokenUsage{ get; set; }

        /// <summary>
        /// 输入token消耗
        /// </summary>
        [JsonProperty("InputTokenUsage")]
        public float? InputTokenUsage{ get; set; }

        /// <summary>
        /// 输出token消耗
        /// </summary>
        [JsonProperty("OutputTokenUsage")]
        public float? OutputTokenUsage{ get; set; }

        /// <summary>
        /// 接口调用次数
        /// </summary>
        [JsonProperty("ApiCallStats")]
        public ulong? ApiCallStats{ get; set; }

        /// <summary>
        /// 搜索服务调用次数
        /// </summary>
        [JsonProperty("SearchUsage")]
        public float? SearchUsage{ get; set; }

        /// <summary>
        /// 文档解析消耗页数
        /// </summary>
        [JsonProperty("PageUsage")]
        public ulong? PageUsage{ get; set; }

        /// <summary>
        /// 拆分token消耗量
        /// </summary>
        [JsonProperty("SplitTokenUsage")]
        public float? SplitTokenUsage{ get; set; }

        /// <summary>
        /// Rag检索次数
        /// </summary>
        [JsonProperty("RagSearchUsage")]
        public float? RagSearchUsage{ get; set; }

        /// <summary>
        /// 联网搜索次数
        /// </summary>
        [JsonProperty("InternetSearchUsage")]
        public float? InternetSearchUsage{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalTokenUsage", this.TotalTokenUsage);
            this.SetParamSimple(map, prefix + "InputTokenUsage", this.InputTokenUsage);
            this.SetParamSimple(map, prefix + "OutputTokenUsage", this.OutputTokenUsage);
            this.SetParamSimple(map, prefix + "ApiCallStats", this.ApiCallStats);
            this.SetParamSimple(map, prefix + "SearchUsage", this.SearchUsage);
            this.SetParamSimple(map, prefix + "PageUsage", this.PageUsage);
            this.SetParamSimple(map, prefix + "SplitTokenUsage", this.SplitTokenUsage);
            this.SetParamSimple(map, prefix + "RagSearchUsage", this.RagSearchUsage);
            this.SetParamSimple(map, prefix + "InternetSearchUsage", this.InternetSearchUsage);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

