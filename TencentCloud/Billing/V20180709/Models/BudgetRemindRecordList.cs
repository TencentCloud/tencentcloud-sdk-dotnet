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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BudgetRemindRecordList : AbstractModel
    {
        
        /// <summary>
        /// 自动优化 COUNT SQL 如果遇到 jSqlParser 无法解析情况，设置该参数为 false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OptimizeCountSql")]
        public bool? OptimizeCountSql{ get; set; }

        /// <summary>
        /// 分页
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pages")]
        public ulong? Pages{ get; set; }

        /// <summary>
        /// 排序字段信息，允许前端传入的时候，注意 SQL 注入问题，可以使用 SqlInjectionUtils.check(...) 检查文本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Orders")]
        public OrderDto[] Orders{ get; set; }

        /// <summary>
        /// xml 自定义 count 查询的 statementId 也可以不用指定在分页 statementId 后面加上 _mpCount 例如分页 selectPageById 指定 count 的查询 statementId 设置为 selectPageById_mpCount 即可默认找到该 SQL 执行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CountId")]
        public string CountId{ get; set; }

        /// <summary>
        /// 分页大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// 总量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 单页分页条数限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxLimit")]
        public string MaxLimit{ get; set; }

        /// <summary>
        /// 查询数据列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Records")]
        public BudgetRemindRecords[] Records{ get; set; }

        /// <summary>
        /// 当前页
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Current")]
        public ulong? Current{ get; set; }

        /// <summary>
        /// 是否进行 count 查询，如果只想查询到列表不要查询总记录数，设置该参数为 false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchCount")]
        public bool? SearchCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OptimizeCountSql", this.OptimizeCountSql);
            this.SetParamSimple(map, prefix + "Pages", this.Pages);
            this.SetParamArrayObj(map, prefix + "Orders.", this.Orders);
            this.SetParamSimple(map, prefix + "CountId", this.CountId);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "MaxLimit", this.MaxLimit);
            this.SetParamArrayObj(map, prefix + "Records.", this.Records);
            this.SetParamSimple(map, prefix + "Current", this.Current);
            this.SetParamSimple(map, prefix + "SearchCount", this.SearchCount);
        }
    }
}

