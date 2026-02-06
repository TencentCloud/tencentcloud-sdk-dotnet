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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveSmartSubtitleResult : AbstractModel
    {
        
        /// <summary>
        /// 识别文本。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 翻译片段起始的 PTS 时间，单位：秒。
        /// </summary>
        [JsonProperty("StartPTSTime")]
        public float? StartPTSTime{ get; set; }

        /// <summary>
        /// 翻译片段终止的 PTS 时间，单位：秒。
        /// </summary>
        [JsonProperty("EndPTSTime")]
        public float? EndPTSTime{ get; set; }

        /// <summary>
        /// 翻译文本。
        /// </summary>
        [JsonProperty("Trans")]
        public string Trans{ get; set; }

        /// <summary>
        /// 翻译开始UTC时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 翻译结束UTC时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 稳态标记。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SteadyState")]
        public bool? SteadyState{ get; set; }

        /// <summary>
        /// websocket与trtc实时翻译的UserId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "StartPTSTime", this.StartPTSTime);
            this.SetParamSimple(map, prefix + "EndPTSTime", this.EndPTSTime);
            this.SetParamSimple(map, prefix + "Trans", this.Trans);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SteadyState", this.SteadyState);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

