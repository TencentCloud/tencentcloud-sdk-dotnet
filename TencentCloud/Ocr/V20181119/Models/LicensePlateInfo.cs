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

    public class LicensePlateInfo : AbstractModel
    {
        
        /// <summary>
        /// 识别出的车牌号码。
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 置信度，0 - 100 之间。
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 文本行在原图片中的像素坐标框。
        /// </summary>
        [JsonProperty("Rect")]
        public Rect Rect{ get; set; }

        /// <summary>
        /// 识别出的车牌颜色，目前支持颜色包括 “白”、“黑”、“蓝”、“绿“、“黄”、“黄绿”、“临牌”、“喷漆”、“其它”。
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamObj(map, prefix + "Rect.", this.Rect);
            this.SetParamSimple(map, prefix + "Color", this.Color);
        }
    }
}

