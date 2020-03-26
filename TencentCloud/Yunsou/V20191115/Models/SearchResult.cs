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

namespace TencentCloud.Yunsou.V20191115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchResult : AbstractModel
    {
        
        /// <summary>
        /// 检索耗时，单位ms
        /// </summary>
        [JsonProperty("CostTime")]
        public ulong? CostTime{ get; set; }

        /// <summary>
        /// 搜索最多可以展示的结果数，多页
        /// </summary>
        [JsonProperty("DisplayNum")]
        public ulong? DisplayNum{ get; set; }

        /// <summary>
        /// 和检索请求中的echo相对应
        /// </summary>
        [JsonProperty("Echo")]
        public string Echo{ get; set; }

        /// <summary>
        /// 检索结果的估算篇数，由索引平台估算
        /// </summary>
        [JsonProperty("EResultNum")]
        public ulong? EResultNum{ get; set; }

        /// <summary>
        /// 检索返回的当前页码结果数
        /// </summary>
        [JsonProperty("ResultNum")]
        public ulong? ResultNum{ get; set; }

        /// <summary>
        /// 检索结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultList")]
        public SearchResultItem[] ResultList{ get; set; }

        /// <summary>
        /// 检索的分词结果，array类型，可包含多个
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SegList")]
        public SearchResultSeg[] SegList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "DisplayNum", this.DisplayNum);
            this.SetParamSimple(map, prefix + "Echo", this.Echo);
            this.SetParamSimple(map, prefix + "EResultNum", this.EResultNum);
            this.SetParamSimple(map, prefix + "ResultNum", this.ResultNum);
            this.SetParamArrayObj(map, prefix + "ResultList.", this.ResultList);
            this.SetParamArrayObj(map, prefix + "SegList.", this.SegList);
        }
    }
}

