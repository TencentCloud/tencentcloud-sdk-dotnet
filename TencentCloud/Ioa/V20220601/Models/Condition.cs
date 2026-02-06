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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Condition : AbstractModel
    {
        
        /// <summary>
        /// Filters 条件过滤
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// FilterGroups 条件过滤组
        /// </summary>
        [JsonProperty("FilterGroups")]
        public FilterGroup[] FilterGroups{ get; set; }

        /// <summary>
        /// Sort 排序字段
        /// </summary>
        [JsonProperty("Sort")]
        public Sort Sort{ get; set; }

        /// <summary>
        /// PageSize 每页获取数(只支持32位)
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// PageNum 获取第几页(只支持32位)
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// 复杂查询规则条件查询项（支持任意层级AND/OR组合）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RulePayload")]
        public RulePayload RulePayload{ get; set; }

        /// <summary>
        /// 规则模式：0-使用旧的FilterGroups，1-使用新的RulePayload
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RulePayloadMode")]
        public long? RulePayloadMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "FilterGroups.", this.FilterGroups);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamObj(map, prefix + "RulePayload.", this.RulePayload);
            this.SetParamSimple(map, prefix + "RulePayloadMode", this.RulePayloadMode);
        }
    }
}

