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

    public class ResultList : AbstractModel
    {
        
        /// <summary>
        /// <p>题干</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Question")]
        public Element[] Question{ get; set; }

        /// <summary>
        /// <p>选项</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Option")]
        public Element[] Option{ get; set; }

        /// <summary>
        /// <p>插图</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Figure")]
        public Element[] Figure{ get; set; }

        /// <summary>
        /// <p>表格</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Table")]
        public Element[] Table{ get; set; }

        /// <summary>
        /// <p>答案</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Answer")]
        public Element[] Answer{ get; set; }

        /// <summary>
        /// <p>解析</p>
        /// </summary>
        [JsonProperty("Parse")]
        public Element[] Parse{ get; set; }

        /// <summary>
        /// <p>整题的坐标，多页单题跨页/单页单题跨栏场景下，存在一道题有多个坐标</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Coord")]
        public Polygon[] Coord{ get; set; }

        /// <summary>
        /// <p>多坐标返回，显示坐标所在页</p><p>默认值：[]</p>
        /// </summary>
        [JsonProperty("CoordPageIndex")]
        public long?[] CoordPageIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Question.", this.Question);
            this.SetParamArrayObj(map, prefix + "Option.", this.Option);
            this.SetParamArrayObj(map, prefix + "Figure.", this.Figure);
            this.SetParamArrayObj(map, prefix + "Table.", this.Table);
            this.SetParamArrayObj(map, prefix + "Answer.", this.Answer);
            this.SetParamArrayObj(map, prefix + "Parse.", this.Parse);
            this.SetParamArrayObj(map, prefix + "Coord.", this.Coord);
            this.SetParamArraySimple(map, prefix + "CoordPageIndex.", this.CoordPageIndex);
        }
    }
}

