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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCLSLogListV3Response : AbstractModel
    {
        
        /// <summary>
        /// <p>上下文</p>
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// <p>listover</p>
        /// </summary>
        [JsonProperty("ListOver")]
        public bool? ListOver{ get; set; }

        /// <summary>
        /// <p>是否采用分析</p>
        /// </summary>
        [JsonProperty("Analysis")]
        public bool? Analysis{ get; set; }

        /// <summary>
        /// <p>结果</p>
        /// </summary>
        [JsonProperty("Results")]
        public LogSearchResult[] Results{ get; set; }

        /// <summary>
        /// <p>列名</p>
        /// </summary>
        [JsonProperty("ColNames")]
        public string[] ColNames{ get; set; }

        /// <summary>
        /// <p>分析结果</p>
        /// </summary>
        [JsonProperty("AnalysisResults")]
        public LogItems[] AnalysisResults{ get; set; }

        /// <summary>
        /// <p>分析记录</p>
        /// </summary>
        [JsonProperty("AnalysisRecords")]
        public string[] AnalysisRecords{ get; set; }

        /// <summary>
        /// <p>列名</p>
        /// </summary>
        [JsonProperty("Columns")]
        public LogColumn[] Columns{ get; set; }

        /// <summary>
        /// <p>采样</p>
        /// </summary>
        [JsonProperty("SamplingRate")]
        public float? SamplingRate{ get; set; }

        /// <summary>
        /// <p>主题信息</p>
        /// </summary>
        [JsonProperty("Topics")]
        public LogSearchTopics Topics{ get; set; }

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
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "ListOver", this.ListOver);
            this.SetParamSimple(map, prefix + "Analysis", this.Analysis);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamArraySimple(map, prefix + "ColNames.", this.ColNames);
            this.SetParamArrayObj(map, prefix + "AnalysisResults.", this.AnalysisResults);
            this.SetParamArraySimple(map, prefix + "AnalysisRecords.", this.AnalysisRecords);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamSimple(map, prefix + "SamplingRate", this.SamplingRate);
            this.SetParamObj(map, prefix + "Topics.", this.Topics);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

