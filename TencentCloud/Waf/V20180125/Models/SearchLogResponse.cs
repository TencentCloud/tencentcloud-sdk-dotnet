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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchLogResponse : AbstractModel
    {
        
        /// <summary>
        /// 透传本次接口返回的Context值，可获取后续更多日志，过期时间1小时。
        /// 注意：
        /// * 仅适用于单日志主题检索，检索多个日志主题时，请使用Topics中的Context
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 符合检索条件的日志是否已全部返回，如未全部返回可使用Context参数获取后续更多日志
        /// 注意：仅当检索分析语句(Query)不包含SQL时有效
        /// </summary>
        [JsonProperty("ListOver")]
        public bool? ListOver{ get; set; }

        /// <summary>
        /// 返回的是否为统计分析（即SQL）结果
        /// </summary>
        [JsonProperty("Analysis")]
        public bool? Analysis{ get; set; }

        /// <summary>
        /// 匹配检索条件的原始日志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Results")]
        public LogInfo[] Results{ get; set; }

        /// <summary>
        /// 日志统计分析结果的列名
        /// 当UseNewAnalysis为false时生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColNames")]
        public string[] ColNames{ get; set; }

        /// <summary>
        /// 日志统计分析结果
        /// 当UseNewAnalysis为false时生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnalysisResults")]
        public LogItems[] AnalysisResults{ get; set; }

        /// <summary>
        /// 日志统计分析结果
        /// 当UseNewAnalysis为true时生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnalysisRecords")]
        public string[] AnalysisRecords{ get; set; }

        /// <summary>
        /// 日志统计分析结果的列属性
        /// 当UseNewAnalysis为true时生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Columns")]
        public Column[] Columns{ get; set; }

        /// <summary>
        /// 本次统计分析使用的采样率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SamplingRate")]
        public float? SamplingRate{ get; set; }

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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

