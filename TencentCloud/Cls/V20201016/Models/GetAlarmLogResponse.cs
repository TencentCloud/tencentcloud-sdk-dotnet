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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetAlarmLogResponse : AbstractModel
    {
        
        /// <summary>
        /// 加载后续详情的Context
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 指定时间范围内的告警执行详情是否完整返回
        /// </summary>
        [JsonProperty("ListOver")]
        public bool? ListOver{ get; set; }

        /// <summary>
        /// 返回的结果是否为SQL分析结果
        /// </summary>
        [JsonProperty("Analysis")]
        public bool? Analysis{ get; set; }

        /// <summary>
        /// 分析结果的列名，如果Query语句有SQL查询，则返回查询字段的列名；
        /// 否则为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColNames")]
        public string[] ColNames{ get; set; }

        /// <summary>
        /// 执行详情查询结果。
        /// 
        /// 当Query字段无SQL语句时，返回查询结果。
        /// 当Query字段有SQL语句时，可能返回null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Results")]
        public LogInfo[] Results{ get; set; }

        /// <summary>
        /// 执行详情统计分析结果。当Query字段有SQL语句时，返回sql统计结果，否则可能返回null。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnalysisResults")]
        public LogItems[] AnalysisResults{ get; set; }

        /// <summary>
        /// 执行详情统计分析结果; UseNewAnalysis为true有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnalysisRecords")]
        public string[] AnalysisRecords{ get; set; }

        /// <summary>
        /// 分析结果的列名， UseNewAnalysis为true有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Columns")]
        public Column[] Columns{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
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
            this.SetParamArraySimple(map, prefix + "ColNames.", this.ColNames);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamArrayObj(map, prefix + "AnalysisResults.", this.AnalysisResults);
            this.SetParamArraySimple(map, prefix + "AnalysisRecords.", this.AnalysisRecords);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

