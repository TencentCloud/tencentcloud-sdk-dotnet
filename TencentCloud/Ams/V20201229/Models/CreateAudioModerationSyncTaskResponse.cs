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

namespace TencentCloud.Ams.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAudioModerationSyncTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 请求接口时传入的数据标识
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// 文件名称，可以由英文字母、数字、下划线、-、@#组成，不超过64个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Biztype为策略的具体的编号，用于接口调度，在内容安全控制台中可配置。不同Biztype关联不同的业务场景与识别能力策略，调用前请确认正确的Biztype。Biztype仅为数字、字母与下划线的组合，长度为3-32个字符；调用时不传入Biztype代表采用默认的识别策略。
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 智能审核服务对于内容违规类型的等级，可选值：
        /// Pass 建议通过；
        /// Reveiw 建议复审；
        /// Block 建议屏蔽；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 智能审核服务对于内容违规类型的判断，详见返回值列表
        /// 如：Label：Porn（色情）；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 音频文本，备注：这里的文本最大只返回前1000个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrText")]
        public string AsrText{ get; set; }

        /// <summary>
        /// 音频中对话内容审核结果；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextResults")]
        public TextResult[] TextResults{ get; set; }

        /// <summary>
        /// 音频中低俗内容审核结果；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MoanResults")]
        public MoanResult[] MoanResults{ get; set; }

        /// <summary>
        /// 该字段用于返回当前标签（Lable）下的二级标签。
        /// 注意：此字段可能返回null，表示取不到有效值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// 该字段用于返回音频小语种检测的详细审核结果。具体结果内容请参见AudioResultDetailLanguageResult数据结构的细节描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LanguageResults")]
        public AudioResultDetailLanguageResult[] LanguageResults{ get; set; }

        /// <summary>
        /// 音频中说话人识别返回结果；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpeakerResults")]
        public AudioResultDetailSpeakerResult[] SpeakerResults{ get; set; }

        /// <summary>
        /// 识别类标签结果信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecognitionResults")]
        public RecognitionResult[] RecognitionResults{ get; set; }

        /// <summary>
        /// 识别音频时长，单位为毫秒；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

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
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "AsrText", this.AsrText);
            this.SetParamArrayObj(map, prefix + "TextResults.", this.TextResults);
            this.SetParamArrayObj(map, prefix + "MoanResults.", this.MoanResults);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
            this.SetParamArrayObj(map, prefix + "LanguageResults.", this.LanguageResults);
            this.SetParamArrayObj(map, prefix + "SpeakerResults.", this.SpeakerResults);
            this.SetParamArrayObj(map, prefix + "RecognitionResults.", this.RecognitionResults);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

