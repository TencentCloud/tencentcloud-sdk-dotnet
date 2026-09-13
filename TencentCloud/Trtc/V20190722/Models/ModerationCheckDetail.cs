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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModerationCheckDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>该字段在内容理解回调事件中可直接忽略，仅在第三方审核时存在，检出违规的模型场景，枚举值：Ad/Porn/Abuse/Illegal/Polity/Terror/Sexy/Moan/Custom</p>
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// <p>Normal：正常文本  Ad:广告 Porn：色情 Abuse：谩骂 Illegal: 违禁 Polity: 涉政 Terror: 暴恐 Sexy: 性感 Moan: 呻吟/娇喘 QRCode: 二维码 Custom: 自定义</p>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// <p>子标签</p>
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// <p>0：建议通过。 1 ：建议人工重新内容识别。 2：建议屏蔽。</p>
        /// </summary>
        [JsonProperty("Suggest")]
        public long? Suggest{ get; set; }

        /// <summary>
        /// <p>自定义词库名。</p>
        /// </summary>
        [JsonProperty("LibName")]
        public string LibName{ get; set; }

        /// <summary>
        /// <p>关键词。</p>
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// <p>中文二级标签。</p>
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// <p>置信度分数，取值范围：0（置信度最低）-100（置信度最高 ），越高代表越有可能属于当前返回的标签。 实例值：100</p>
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// <p>违规严重程度: 0-不区分 1-轻度 2-严重</p>
        /// </summary>
        [JsonProperty("Severity")]
        public long? Severity{ get; set; }

        /// <summary>
        /// <p>违规严重程度描述 仅名单内sdkappid返回 负面表达,正面或中性表达,语义模糊</p>
        /// </summary>
        [JsonProperty("SeverityDesc")]
        public string SeverityDesc{ get; set; }

        /// <summary>
        /// <p>音频切片位置信息。</p>
        /// </summary>
        [JsonProperty("AudioSegments")]
        public AudioSegments AudioSegments{ get; set; }

        /// <summary>
        /// <p>图片命中坐标信息。</p>
        /// </summary>
        [JsonProperty("ImageLocation")]
        public ImageLocation ImageLocation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
            this.SetParamSimple(map, prefix + "Suggest", this.Suggest);
            this.SetParamSimple(map, prefix + "LibName", this.LibName);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "SeverityDesc", this.SeverityDesc);
            this.SetParamObj(map, prefix + "AudioSegments.", this.AudioSegments);
            this.SetParamObj(map, prefix + "ImageLocation.", this.ImageLocation);
        }
    }
}

