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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubtitleItem : AbstractModel
    {
        
        /// <summary>
        /// 语音识别结果
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 中文翻译结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zh")]
        public string Zh{ get; set; }

        /// <summary>
        /// 英文翻译结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("En")]
        public string En{ get; set; }

        /// <summary>
        /// 语句起始时间戳PTS(ms)
        /// </summary>
        [JsonProperty("StartPts")]
        public ulong? StartPts{ get; set; }

        /// <summary>
        /// 语句结束时间戳PTS(ms)
        /// </summary>
        [JsonProperty("EndPts")]
        public ulong? EndPts{ get; set; }

        /// <summary>
        /// 字符串形式的起始结束时间
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// 结果的置信度（百分制）
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 当前语句是否结束
        /// </summary>
        [JsonProperty("EndFlag")]
        public bool? EndFlag{ get; set; }

        /// <summary>
        /// 语句分割时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PuncEndTs")]
        public string PuncEndTs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Zh", this.Zh);
            this.SetParamSimple(map, prefix + "En", this.En);
            this.SetParamSimple(map, prefix + "StartPts", this.StartPts);
            this.SetParamSimple(map, prefix + "EndPts", this.EndPts);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "EndFlag", this.EndFlag);
            this.SetParamSimple(map, prefix + "PuncEndTs", this.PuncEndTs);
        }
    }
}

