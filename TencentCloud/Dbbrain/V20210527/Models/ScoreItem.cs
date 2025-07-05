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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScoreItem : AbstractModel
    {
        
        /// <summary>
        /// 异常诊断项名称。
        /// </summary>
        [JsonProperty("DiagItem")]
        public string DiagItem{ get; set; }

        /// <summary>
        /// 诊断项分类，取值包括：可用性、可维护性、性能及可靠性。
        /// </summary>
        [JsonProperty("IssueType")]
        public string IssueType{ get; set; }

        /// <summary>
        /// 健康等级，取值包括：信息、提示、告警、严重、致命。
        /// </summary>
        [JsonProperty("TopSeverity")]
        public string TopSeverity{ get; set; }

        /// <summary>
        /// 该异常诊断项出现次数。
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 扣分分数。
        /// </summary>
        [JsonProperty("ScoreLost")]
        public long? ScoreLost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiagItem", this.DiagItem);
            this.SetParamSimple(map, prefix + "IssueType", this.IssueType);
            this.SetParamSimple(map, prefix + "TopSeverity", this.TopSeverity);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "ScoreLost", this.ScoreLost);
        }
    }
}

