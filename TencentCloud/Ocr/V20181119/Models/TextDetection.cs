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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextDetection : AbstractModel
    {
        
        /// <summary>
        /// 识别出的文本行内容
        /// </summary>
        [JsonProperty("DetectedText")]
        public string DetectedText{ get; set; }

        /// <summary>
        /// 置信度 0 ~100
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 文本行坐标，以四个顶点坐标表示
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Polygon")]
        public Coord[] Polygon{ get; set; }

        /// <summary>
        /// 此字段为扩展字段。
        /// GeneralBasicOcr接口返回段落信息Parag，包含ParagNo。
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        public string AdvancedInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DetectedText", this.DetectedText);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArrayObj(map, prefix + "Polygon.", this.Polygon);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
        }
    }
}

