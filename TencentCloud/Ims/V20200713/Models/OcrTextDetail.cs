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

namespace TencentCloud.Ims.V20200713.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OcrTextDetail : AbstractModel
    {
        
        /// <summary>
        /// OCR文本内容
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 恶意标签，Normal：正常，Porn：色情，Abuse：谩骂，Ad：广告，Custom：自定义词库。
        /// 以及令人反感、不安全或不适宜的内容类型。
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 仅当Label为Custom自定义关键词时有效，表示自定义库id
        /// </summary>
        [JsonProperty("LibId")]
        public string LibId{ get; set; }

        /// <summary>
        /// 仅当Label为Custom自定义关键词时有效，表示自定义库名称
        /// </summary>
        [JsonProperty("LibName")]
        public string LibName{ get; set; }

        /// <summary>
        /// 该标签下命中的关键词
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 该标签模型命中的分值
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// OCR位置
        /// </summary>
        [JsonProperty("Location")]
        public Location Location{ get; set; }

        /// <summary>
        /// OCR文本识别置信度
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

