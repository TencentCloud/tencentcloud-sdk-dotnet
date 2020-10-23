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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SentenceDetail : AbstractModel
    {
        
        /// <summary>
        /// 单句最终识别结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinalSentence")]
        public string FinalSentence{ get; set; }

        /// <summary>
        /// 单句中间识别结果，使用空格拆分为多个词
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SliceSentence")]
        public string SliceSentence{ get; set; }

        /// <summary>
        /// 单句开始时间（毫秒）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartMs")]
        public long? StartMs{ get; set; }

        /// <summary>
        /// 单句结束时间（毫秒）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndMs")]
        public long? EndMs{ get; set; }

        /// <summary>
        /// 单句中词个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WordsNum")]
        public long? WordsNum{ get; set; }

        /// <summary>
        /// 单句中词详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Words")]
        public SentenceWords[] Words{ get; set; }

        /// <summary>
        /// 单句语速，单位：字数/秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpeechSpeed")]
        public float? SpeechSpeed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinalSentence", this.FinalSentence);
            this.SetParamSimple(map, prefix + "SliceSentence", this.SliceSentence);
            this.SetParamSimple(map, prefix + "StartMs", this.StartMs);
            this.SetParamSimple(map, prefix + "EndMs", this.EndMs);
            this.SetParamSimple(map, prefix + "WordsNum", this.WordsNum);
            this.SetParamArrayObj(map, prefix + "Words.", this.Words);
            this.SetParamSimple(map, prefix + "SpeechSpeed", this.SpeechSpeed);
        }
    }
}

