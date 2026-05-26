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

namespace TencentCloud.Tdai.V20250717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMemoryPlusRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>查询的 Memory 实例 ID。</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>查询列表的起始位置（偏移量）。用于分页查询，指明从符合条件的第几条数据开始返回。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>单次查询返回的记录数量上限（分页大小）。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>查询的记忆类型。</p><ul><li>conversation：L0 原始对话。</li><li>memory：L1 原子记忆。</li><li>scene：L2 场景记忆。</li><li>persona：L3 个性化画像。</li><li>memory/persona：L1 原子记忆-画像型。</li><li>memory/episodic：L1 原子记忆-事件型。</li><li>memory/instruction：L1 原子记忆-指令型。</li></ul>
        /// </summary>
        [JsonProperty("RecordType")]
        public string RecordType{ get; set; }

        /// <summary>
        /// <p>指定返回记录中的特定字段。</p>
        /// </summary>
        [JsonProperty("Output")]
        public string[] Output{ get; set; }

        /// <summary>
        /// <p>过滤条件，当前仅支持 <strong>RecordType</strong> 为 <strong>conversation</strong> 的 <strong>session_id</strong> 过滤。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public VDBFieldMap[] Filters{ get; set; }

        /// <summary>
        /// <p>查询结果列表的排序规则。</p><ul><li>ASC：升序。</li><li>DESC：降序。</li></ul>
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// <p>查询时间范围的起始时间点。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>查询时间范围的结束时间点。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "RecordType", this.RecordType);
            this.SetParamArraySimple(map, prefix + "Output.", this.Output);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

