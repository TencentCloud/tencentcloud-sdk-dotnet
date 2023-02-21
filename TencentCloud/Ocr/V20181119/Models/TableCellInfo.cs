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

    public class TableCellInfo : AbstractModel
    {
        
        /// <summary>
        /// 单元格左上角的列索引
        /// </summary>
        [JsonProperty("ColTl")]
        public long? ColTl{ get; set; }

        /// <summary>
        /// 单元格左上角的行索引
        /// </summary>
        [JsonProperty("RowTl")]
        public long? RowTl{ get; set; }

        /// <summary>
        /// 单元格右下角的列索引
        /// </summary>
        [JsonProperty("ColBr")]
        public long? ColBr{ get; set; }

        /// <summary>
        /// 单元格右下角的行索引
        /// </summary>
        [JsonProperty("RowBr")]
        public long? RowBr{ get; set; }

        /// <summary>
        /// 单元格内识别出的字符串文本，若文本存在多行，以换行符"\n"隔开
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 单元格类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 单元格置信度
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 单元格在图像中的四点坐标
        /// </summary>
        [JsonProperty("Polygon")]
        public Coord[] Polygon{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ColTl", this.ColTl);
            this.SetParamSimple(map, prefix + "RowTl", this.RowTl);
            this.SetParamSimple(map, prefix + "ColBr", this.ColBr);
            this.SetParamSimple(map, prefix + "RowBr", this.RowBr);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArrayObj(map, prefix + "Polygon.", this.Polygon);
        }
    }
}

