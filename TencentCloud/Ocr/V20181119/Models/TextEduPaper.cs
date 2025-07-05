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

    public class TextEduPaper : AbstractModel
    {
        
        /// <summary>
        /// 识别出的字段名称（关键字）
        /// </summary>
        [JsonProperty("Item")]
        public string Item{ get; set; }

        /// <summary>
        /// 识别出的字段名称对应的值，也就是字段Item对应的字符串结果
        /// </summary>
        [JsonProperty("DetectedText")]
        public string DetectedText{ get; set; }

        /// <summary>
        /// 文本行在旋转纠正之后的图像中的像素坐标，表示为（左上角x, 左上角y，宽width，高height）
        /// </summary>
        [JsonProperty("Itemcoord")]
        public ItemCoord Itemcoord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Item", this.Item);
            this.SetParamSimple(map, prefix + "DetectedText", this.DetectedText);
            this.SetParamObj(map, prefix + "Itemcoord.", this.Itemcoord);
        }
    }
}

