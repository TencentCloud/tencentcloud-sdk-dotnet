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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBDiagEventResponse : AbstractModel
    {
        
        /// <summary>
        /// 诊断项。
        /// </summary>
        [JsonProperty("DiagItem")]
        public string DiagItem{ get; set; }

        /// <summary>
        /// 诊断类型。
        /// </summary>
        [JsonProperty("DiagType")]
        public string DiagType{ get; set; }

        /// <summary>
        /// 事件 ID 。
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// 事件详情。
        /// </summary>
        [JsonProperty("Explanation")]
        public string Explanation{ get; set; }

        /// <summary>
        /// 概要。
        /// </summary>
        [JsonProperty("Outline")]
        public string Outline{ get; set; }

        /// <summary>
        /// 诊断出的问题。
        /// </summary>
        [JsonProperty("Problem")]
        public string Problem{ get; set; }

        /// <summary>
        /// 严重程度。严重程度分为5级，按影响程度从高至低分别为：1：致命，2：严重，3：告警，4：提示，5：健康。
        /// </summary>
        [JsonProperty("Severity")]
        public long? Severity{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 建议。
        /// </summary>
        [JsonProperty("Suggestions")]
        public string Suggestions{ get; set; }

        /// <summary>
        /// 保留字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiagItem", this.DiagItem);
            this.SetParamSimple(map, prefix + "DiagType", this.DiagType);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Explanation", this.Explanation);
            this.SetParamSimple(map, prefix + "Outline", this.Outline);
            this.SetParamSimple(map, prefix + "Problem", this.Problem);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Suggestions", this.Suggestions);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

