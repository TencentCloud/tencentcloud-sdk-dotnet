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
        /// 口语转书面语结果，开启改功能才有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WrittenText")]
        public string WrittenText{ get; set; }

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
        /// 声道或说话人 Id（请求中如果设置了 speaker_diarization或者ChannelNum为双声道，可区分说话人或声道）
        /// 单声道话者分离时不同的值代表不同的说话人； 8k双声道话者分离时speakerId的值为0代表左声道，值为1代表右声道。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpeakerId")]
        public long? SpeakerId{ get; set; }

        /// <summary>
        /// 情绪能量值，取值为音量分贝值/10。取值范围：[1,10]。值越高情绪越强烈。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EmotionalEnergy")]
        public float? EmotionalEnergy{ get; set; }

        /// <summary>
        /// 本句与上一句之间的静音时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SilenceTime")]
        public long? SilenceTime{ get; set; }

        /// <summary>
        /// 情绪类型（可能为空，有2种情况 1、没有对应资源包；2、情绪跟语音效果相关，如果情绪不够强烈时可能无法识别）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EmotionType")]
        public string[] EmotionType{ get; set; }

        /// <summary>
        /// 关键词识别结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyWordResults")]
        public KeyWordResult[] KeyWordResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinalSentence", this.FinalSentence);
            this.SetParamSimple(map, prefix + "SliceSentence", this.SliceSentence);
            this.SetParamSimple(map, prefix + "WrittenText", this.WrittenText);
            this.SetParamSimple(map, prefix + "StartMs", this.StartMs);
            this.SetParamSimple(map, prefix + "EndMs", this.EndMs);
            this.SetParamSimple(map, prefix + "WordsNum", this.WordsNum);
            this.SetParamArrayObj(map, prefix + "Words.", this.Words);
            this.SetParamSimple(map, prefix + "SpeechSpeed", this.SpeechSpeed);
            this.SetParamSimple(map, prefix + "SpeakerId", this.SpeakerId);
            this.SetParamSimple(map, prefix + "EmotionalEnergy", this.EmotionalEnergy);
            this.SetParamSimple(map, prefix + "SilenceTime", this.SilenceTime);
            this.SetParamArraySimple(map, prefix + "EmotionType.", this.EmotionType);
            this.SetParamArrayObj(map, prefix + "KeyWordResults.", this.KeyWordResults);
        }
    }
}

