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

namespace TencentCloud.Vm.V20210922.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioResult : AbstractModel
    {
        
        /// <summary>
        /// 该字段用于返回审核内容是否命中审核模型；取值：0（**未命中**）、1（**命中**）。
        /// </summary>
        [JsonProperty("HitFlag")]
        public long? HitFlag{ get; set; }

        /// <summary>
        /// 该字段用于返回检测结果所对应的恶意标签。<br>返回值：**Normal**：正常，**Porn**：色情，**Abuse**：谩骂，**Ad**：广告，**Custom**：自定义违规；以及其他令人反感、不安全或不适宜的内容类型。
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 该字段用于返回后续操作建议。当您获取到判定结果后，返回值表示具体的后续建议操作。<br>
        /// 返回值：**Block**：建议屏蔽，**Review** ：建议人工复审，**Pass**：建议通过
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 该字段用于返回当前标签下的置信度，取值范围：0（**置信度最低**）-100（**置信度最高** ），越高代表文本越有可能属于当前返回的标签；如：*色情 99*，则表明该文本非常有可能属于色情内容。
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 该字段用于返回音频文件经ASR识别后的文本信息。最长可识别**5小时**的音频文件，若超出时长限制，接口将会报错。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 该字段用于返回审核结果的访问链接（URL）。<br>备注：链接默认有效期为12小时。如果您需要更长时效的链接，请使用[COS预签名](https://cloud.tencent.com/document/product/1265/104001)功能更新签名时效。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 该字段用于返回音频文件的时长，单位为毫秒。
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// 该字段用于返回输入参数中的额外附加信息（Extra），如未配置则默认返回值为空。<br>备注：不同客户或Biztype下返回信息不同，如需配置该字段请提交工单咨询或联系售后专员处理。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 该字段用于返回音频文件经ASR识别后产生的文本的详细审核结果。具体结果内容请参见AudioResultDetailLanguageResult数据结构的细节描述。
        /// </summary>
        [JsonProperty("TextResults")]
        public AudioResultDetailTextResult[] TextResults{ get; set; }

        /// <summary>
        /// 该字段用于返回音频文件呻吟检测的详细审核结果。具体结果内容请参见AudioResultDetailMoanResult数据结构的细节描述。
        /// </summary>
        [JsonProperty("MoanResults")]
        public AudioResultDetailMoanResult[] MoanResults{ get; set; }

        /// <summary>
        /// 该字段用于返回音频小语种检测的详细审核结果。具体结果内容请参见AudioResultDetailLanguageResult数据结构的细节描述。
        /// </summary>
        [JsonProperty("LanguageResults")]
        public AudioResultDetailLanguageResult[] LanguageResults{ get; set; }

        /// <summary>
        /// 该字段用于返回当前标签（Lable）下的二级标签。
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// 识别类标签结果信息列表
        /// </summary>
        [JsonProperty("RecognitionResults")]
        public RecognitionResult[] RecognitionResults{ get; set; }

        /// <summary>
        /// 该字段用于返回音频文件说话人检测的详细审核结果
        /// </summary>
        [JsonProperty("SpeakerResults")]
        public SpeakerResult[] SpeakerResults{ get; set; }

        /// <summary>
        /// 该字段用于返回音频文件出行检测的详细审核结果
        /// </summary>
        [JsonProperty("TravelResults")]
        public TravelResult[] TravelResults{ get; set; }

        /// <summary>
        /// 该字段用于返回音频文件的三级标签
        /// </summary>
        [JsonProperty("SubTag")]
        public string SubTag{ get; set; }

        /// <summary>
        /// 该字段用于返回音频文件的三级标签码
        /// </summary>
        [JsonProperty("SubTagCode")]
        public string SubTagCode{ get; set; }

        /// <summary>
        /// 该字段用于返回音频文件歌曲识别的详细审核结果
        /// </summary>
        [JsonProperty("LabelResults")]
        public LabelResult[] LabelResults{ get; set; }

        /// <summary>
        /// 审核命中类型
        /// </summary>
        [JsonProperty("HitType")]
        public string HitType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HitFlag", this.HitFlag);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamArrayObj(map, prefix + "TextResults.", this.TextResults);
            this.SetParamArrayObj(map, prefix + "MoanResults.", this.MoanResults);
            this.SetParamArrayObj(map, prefix + "LanguageResults.", this.LanguageResults);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
            this.SetParamArrayObj(map, prefix + "RecognitionResults.", this.RecognitionResults);
            this.SetParamArrayObj(map, prefix + "SpeakerResults.", this.SpeakerResults);
            this.SetParamArrayObj(map, prefix + "TravelResults.", this.TravelResults);
            this.SetParamSimple(map, prefix + "SubTag", this.SubTag);
            this.SetParamSimple(map, prefix + "SubTagCode", this.SubTagCode);
            this.SetParamArrayObj(map, prefix + "LabelResults.", this.LabelResults);
            this.SetParamSimple(map, prefix + "HitType", this.HitType);
        }
    }
}

