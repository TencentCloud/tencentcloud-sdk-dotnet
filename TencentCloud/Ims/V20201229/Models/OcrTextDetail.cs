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

namespace TencentCloud.Ims.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OcrTextDetail : AbstractModel
    {
        
        /// <summary>
        /// 该字段用于返回OCR识别出的文本内容。<br>备注：OCR文本识别上限在**5000字节内**。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 该字段用于返回检测结果所对应的恶意标签。<br>返回值：**Normal**：正常，**Porn**：色情，**Abuse**：谩骂，**Ad**：广告，**Custom**：自定义违规；以及其他令人反感、不安全或不适宜的内容类型。
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 该字段**仅当Label为Custom自定义关键词时有效**，用于返回自定义库的ID，以方便自定义库管理和配置。
        /// </summary>
        [JsonProperty("LibId")]
        public string LibId{ get; set; }

        /// <summary>
        /// 该字段**仅当Label为Custom自定义关键词时有效**，用于返回自定义库的名称，以方便自定义库管理和配置。
        /// </summary>
        [JsonProperty("LibName")]
        public string LibName{ get; set; }

        /// <summary>
        /// 该参数用于返回在当前label下命中的关键词。
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 该参数用于返回在当前恶意标签下模型命中的分值，取值为**0-100**；分数越高，代表当前场景越符合该恶意标签所对应的场景。
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// 该参数用于返回OCR检测框在图片中的位置（左上角xy坐标、长宽、旋转角度），以方便快速定位识别文字的相关信息。
        /// </summary>
        [JsonProperty("Location")]
        public Location Location{ get; set; }

        /// <summary>
        /// 该参数用于返回OCR文本识别结果的置信度，取值在**0**（**置信度最低**）-**100**（**置信度最高**），越高代表对应图像越有可能是识别出的文字；如：*你好 99*，则表明OCR识别框内的文字大概率是”你好“。
        /// </summary>
        [JsonProperty("Rate")]
        public ulong? Rate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "LibId", this.LibId);
            this.SetParamSimple(map, prefix + "LibName", this.LibName);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
        }
    }
}

