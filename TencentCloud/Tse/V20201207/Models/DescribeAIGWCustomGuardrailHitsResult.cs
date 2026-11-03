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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAIGWCustomGuardrailHitsResult : AbstractModel
    {
        
        /// <summary>
        /// <p>时间范围和过滤条件内匹配的审核日志总数，分页前统计；不再限定为最多 1000 条。日志异常条目可能无法解析为 Hits。</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>当前页审核记录，按时间倒序；同一业务请求的多次送审会产生多条记录，不能直接把条数当业务请求数。</p>
        /// </summary>
        [JsonProperty("Hits")]
        public CustomGuardrailHit[] Hits{ get; set; }

        /// <summary>
        /// <p>兼容字段，当前分页查询返回 false；用 Offset、Limit、TotalCount 翻页。1000 条限制只适用于导出接口。</p>
        /// </summary>
        [JsonProperty("Truncated")]
        public bool? Truncated{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "Hits.", this.Hits);
            this.SetParamSimple(map, prefix + "Truncated", this.Truncated);
        }
    }
}

