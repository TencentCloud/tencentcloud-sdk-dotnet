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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchAccessLogResponse : AbstractModel
    {
        
        /// <summary>
        /// 新接口此字段失效，默认返回空字符串
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 日志查询结果是否全部返回，其中，“true”表示结果返回，“false”表示结果为返回
        /// </summary>
        [JsonProperty("ListOver")]
        public bool? ListOver{ get; set; }

        /// <summary>
        /// 返回的是否为分析结果，其中，“true”表示返回分析结果，“false”表示未返回分析结果
        /// </summary>
        [JsonProperty("Analysis")]
        public bool? Analysis{ get; set; }

        /// <summary>
        /// 如果Analysis为True，则返回分析结果的列名，否则为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColNames")]
        [System.Obsolete]
        public string[] ColNames{ get; set; }

        /// <summary>
        /// 日志查询结果；当Analysis为True时，可能返回为null
        /// 注意：此字段可能返回 null，表示取不到有效值
        /// </summary>
        [JsonProperty("Results")]
        public AccessLogInfo[] Results{ get; set; }

        /// <summary>
        /// 日志分析结果；当Analysis为False时，可能返回为null
        /// 注意：此字段可能返回 null，表示取不到有效值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnalysisResults")]
        [System.Obsolete]
        public AccessLogItems[] AnalysisResults{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "ColNames.", this.ColNames);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamArrayObj(map, prefix + "AnalysisResults.", this.AnalysisResults);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

