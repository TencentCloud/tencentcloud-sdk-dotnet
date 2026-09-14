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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDocSummaryListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>所属知识库 ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>过滤条件（多个 Filter 之间为 AND 关系，同一 Filter 的多个 Values 为 OR 关系）：Status-文档状态,枚举值,精确匹配; CategoryId-分类ID,精确匹配; SourceType-文档来源类型,枚举值,精确匹配; EffectiveDomain-生效作用域,精确匹配; CreateTime-创建时间,Unix秒,BETWEEN 传 [起始秒,结束秒]; UpdateTime-更新时间,Unix秒,BETWEEN 传 [起始秒,结束秒]</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// <p>分页页码，从 0 开始</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页数量，默认 10，最大 100</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// <p>查询条件（关键词 + 查询范围）</p>
        /// </summary>
        [JsonProperty("Query")]
        public DocQuery Query{ get; set; }

        /// <summary>
        /// <p>开关配置</p>
        /// </summary>
        [JsonProperty("SummaryListSwitch")]
        public SummaryListSwitch SummaryListSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamObj(map, prefix + "Query.", this.Query);
            this.SetParamObj(map, prefix + "SummaryListSwitch.", this.SummaryListSwitch);
        }
    }
}

