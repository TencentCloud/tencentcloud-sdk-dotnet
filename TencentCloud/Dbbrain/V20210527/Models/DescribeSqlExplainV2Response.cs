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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSqlExplainV2Response : AbstractModel
    {
        
        /// <summary>
        /// <p>数据库名，回显请求中的 Schema。</p>
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// <p>SQL 文本，回显请求中的 SqlText。</p>
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// <p>SQL 涉及的表名列表。</p>
        /// </summary>
        [JsonProperty("Tables")]
        public SqlExplainTableRefV2[] Tables{ get; set; }

        /// <summary>
        /// <p>执行计划详细信息。由数据库 EXPLAIN 输出透传，内容为 JSON 字符串，包含 Meta（列定义）与 Data（执行计划行）两部分；Format=JSON 时为 EXPLAIN FORMAT=JSON 的原始结果。</p>
        /// </summary>
        [JsonProperty("Explain")]
        public SqlExplainResultV2 Explain{ get; set; }

        /// <summary>
        /// <p>执行计划字段说明列表。仅当请求 Visual=true 或走 SqlTemplateKey 路径时返回，用于前端展示字段中文释义。</p>
        /// </summary>
        [JsonProperty("FieldDesc")]
        public SqlExplainFieldDescV2[] FieldDesc{ get; set; }

        /// <summary>
        /// <p>可视化执行计划树，当Visual=true时返回</p>
        /// </summary>
        [JsonProperty("VisualExplain")]
        public string VisualExplain{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
            this.SetParamObj(map, prefix + "Explain.", this.Explain);
            this.SetParamArrayObj(map, prefix + "FieldDesc.", this.FieldDesc);
            this.SetParamSimple(map, prefix + "VisualExplain", this.VisualExplain);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

