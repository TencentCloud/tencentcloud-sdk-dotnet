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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextDetection : AbstractModel
    {
        
        /// <summary>
        /// <p>识别出的文本行内容。</p>
        /// </summary>
        [JsonProperty("DetectedText")]
        public string DetectedText{ get; set; }

        /// <summary>
        /// <p>置信度 0 ~100。</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// <p>文本行坐标，以四个顶点坐标表示。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Polygon")]
        public Coord[] Polygon{ get; set; }

        /// <summary>
        /// <p>此字段为扩展字段。GeneralBasicOcr接口返回段落信息Parag，包含ParagNo。</p>
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        public string AdvancedInfo{ get; set; }

        /// <summary>
        /// <p>文本行在旋转纠正之后的图像中的像素坐标，表示为（左上角x, 左上角y，宽width，高height）。</p>
        /// </summary>
        [JsonProperty("ItemPolygon")]
        public ItemCoord ItemPolygon{ get; set; }

        /// <summary>
        /// <p>识别出来的单字信息包括单字（包括单字Character和单字置信度confidence）， 支持识别的接口：GeneralBasicOCR、GeneralAccurateOCR。</p>
        /// </summary>
        [JsonProperty("Words")]
        public DetectedWords[] Words{ get; set; }

        /// <summary>
        /// <p>单字在原图中的四点坐标， 支持识别的接口：GeneralBasicOCR、GeneralAccurateOCR。</p>
        /// </summary>
        [JsonProperty("WordCoordPoint")]
        public DetectedWordCoordPoint[] WordCoordPoint{ get; set; }

        /// <summary>
        /// <p>语种信息。注：仅ConfigID配置为MulOCR时支持。zh:中文; en:英文; tha:泰语; may:印尼语; jap:日语; kor:韩语; spa:西班牙语; fre:法语; ger:德语; por:葡萄牙语; vie:越南语; may:马来语; rus:俄语; ita:意大利语; hol:荷兰语; swe:瑞典语; fin:芬兰语; nor:挪威语; hun:匈牙利语; ara:阿拉伯语; hi:印地语。</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DetectedText", this.DetectedText);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArrayObj(map, prefix + "Polygon.", this.Polygon);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
            this.SetParamObj(map, prefix + "ItemPolygon.", this.ItemPolygon);
            this.SetParamArrayObj(map, prefix + "Words.", this.Words);
            this.SetParamArrayObj(map, prefix + "WordCoordPoint.", this.WordCoordPoint);
            this.SetParamSimple(map, prefix + "Language", this.Language);
        }
    }
}

