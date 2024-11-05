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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchInfo : AbstractModel
    {
        
        /// <summary>
        /// 搜索引文信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchResults")]
        public SearchResult[] SearchResults{ get; set; }

        /// <summary>
        /// 脑图（回复中不一定存在，流式协议中，仅在最后一条流式数据中返回）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mindmap")]
        public Mindmap Mindmap{ get; set; }

        /// <summary>
        /// 相关事件（回复中不一定存在，流式协议中，仅在最后一条流式数据中返回，深度模式下返回）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelevantEvents")]
        public RelevantEvent[] RelevantEvents{ get; set; }

        /// <summary>
        /// 相关组织及人物（回复中不一定存在，流式协议中，仅在最后一条流式数据中返回，深度模式下返回）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelevantEntities")]
        public RelevantEntity[] RelevantEntities{ get; set; }

        /// <summary>
        /// 时间线（回复中不一定存在，流式协议中，仅在最后一条流式数据中返回，深度模式下返回）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeline")]
        public Timeline[] Timeline{ get; set; }

        /// <summary>
        /// 是否命中搜索深度模式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportDeepSearch")]
        public bool? SupportDeepSearch{ get; set; }

        /// <summary>
        /// 搜索回复大纲（深度模式下返回）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Outline")]
        public string[] Outline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SearchResults.", this.SearchResults);
            this.SetParamObj(map, prefix + "Mindmap.", this.Mindmap);
            this.SetParamArrayObj(map, prefix + "RelevantEvents.", this.RelevantEvents);
            this.SetParamArrayObj(map, prefix + "RelevantEntities.", this.RelevantEntities);
            this.SetParamArrayObj(map, prefix + "Timeline.", this.Timeline);
            this.SetParamSimple(map, prefix + "SupportDeepSearch", this.SupportDeepSearch);
            this.SetParamArraySimple(map, prefix + "Outline.", this.Outline);
        }
    }
}

