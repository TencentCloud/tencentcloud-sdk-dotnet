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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExplainRow : AbstractModel
    {
        
        /// <summary>
        /// <p>查询的序列号</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>查询的类型，常见值：SIMPLE（简单查询，不含子查询或 UNION）、PRIMARY（最外层查询）、SUBQUERY（子查询中的第一个 SELECT）、DERIVED（派生表/FROM 子句中的子查询）、UNION（UNION 中第二个及之后的 SELECT）、UNION RESULT（UNION 的结果集）。</p>
        /// </summary>
        [JsonProperty("SelectType")]
        public string SelectType{ get; set; }

        /// <summary>
        /// <p>数据表名</p>
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// <p>查询匹配的分区</p>
        /// </summary>
        [JsonProperty("Partitions")]
        public string Partitions{ get; set; }

        /// <summary>
        /// <p>访问类型（非常重要，衡量查询效率的关键指标），从优到差排列：system &gt; const &gt; eq_ref &gt; ref &gt; fulltext &gt; ref_or_null &gt; index_merge &gt; unique_subquery &gt; index_subquery &gt; range &gt; index &gt; ALL。常见值说明： • system：表只有一行记录（系统表） • const：通过主键或唯一索引匹配一行，常见于 WHERE pk = 1 • eq_ref：连接时使用主键或唯一索引，每个索引值只匹配一行 • ref：使用非唯一索引查找，可能匹配多行 • range：索引范围扫描，如 BETWEEN、&gt;、&lt;、IN • index：全索引扫描（遍历整棵索引树） • ALL：全表扫描（最差，需优化）</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>查询中可能使用到的索引。为 NULL 表示没有可用索引。</p>
        /// </summary>
        [JsonProperty("PossibleKeys")]
        public string PossibleKeys{ get; set; }

        /// <summary>
        /// <p>实际使用的索引。为 NULL 表示未使用任何索引。</p>
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>实际使用的索引长度（字节数）。可用来判断联合索引中实际使用了哪几个列。值越短说明使用的索引列越少。</p>
        /// </summary>
        [JsonProperty("KeyLen")]
        public string KeyLen{ get; set; }

        /// <summary>
        /// <p>显示哪些列或常量与 key 列中的索引进行比较。常见值：const（常量）、某个列名、func（函数结果）。</p>
        /// </summary>
        [JsonProperty("Ref")]
        public string Ref{ get; set; }

        /// <summary>
        /// <p>预估要扫描的行数</p>
        /// </summary>
        [JsonProperty("Rows")]
        public long? Rows{ get; set; }

        /// <summary>
        /// <p>表示经过表条件过滤后，剩余行数占 rows 的百分比估算。100% 表示没有额外过滤，值越高越好。</p>
        /// </summary>
        [JsonProperty("Filtered")]
        public float? Filtered{ get; set; }

        /// <summary>
        /// <p>附加信息（非常重要），常见值： • Using index：覆盖索引，无需回表（好） • Using where：在存储引擎返回行后再用 WHERE 过滤 • Using temporary：使用了临时表（常见于 GROUP BY/ORDER BY，需优化） • Using filesort：使用了文件排序而非索引排序（需优化） • Using index condition：使用了索引下推（ICP）</p>
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SelectType", this.SelectType);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "Partitions", this.Partitions);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "PossibleKeys", this.PossibleKeys);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "KeyLen", this.KeyLen);
            this.SetParamSimple(map, prefix + "Ref", this.Ref);
            this.SetParamSimple(map, prefix + "Rows", this.Rows);
            this.SetParamSimple(map, prefix + "Filtered", this.Filtered);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

