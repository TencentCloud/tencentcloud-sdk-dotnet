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

    public class Element : AbstractModel
    {
        
        /// <summary>
        /// 元素内容，当type为figure时该字段内容为图片的位置
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 元素坐标
        /// </summary>
        [JsonProperty("Coord")]
        public Polygon Coord{ get; set; }

        /// <summary>
        /// 元素group类型，包括multiple-choice(选择题)、fill-in-the-blank(填空题)、problem-solving(解答题)、arithmetic(算术题)
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// 结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultList")]
        public ResultList[] ResultList{ get; set; }

        /// <summary>
        /// 元素索引
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamObj(map, prefix + "Coord.", this.Coord);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamArrayObj(map, prefix + "ResultList.", this.ResultList);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

