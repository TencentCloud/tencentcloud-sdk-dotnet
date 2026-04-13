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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExecutePGSqlResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>影响行数</p>
        /// </summary>
        [JsonProperty("AffectedRows")]
        public long? AffectedRows{ get; set; }

        /// <summary>
        /// <p>字段名列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Columns")]
        public string[] Columns{ get; set; }

        /// <summary>
        /// <p>数据行。每一行数据都是一个JSON串，将JSON进行反序列化将得到了每列的值。值可能是 null 或者 字符串，如果是 null 说明该列的值为 &lt;null&gt;，如果是字符串则为该列的值的字符串表示形式。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rows")]
        public string[] Rows{ get; set; }

        /// <summary>
        /// <p>SQL执行耗时</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("ExecutionTimeMs")]
        public long? ExecutionTimeMs{ get; set; }

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
            this.SetParamSimple(map, prefix + "AffectedRows", this.AffectedRows);
            this.SetParamArraySimple(map, prefix + "Columns.", this.Columns);
            this.SetParamArraySimple(map, prefix + "Rows.", this.Rows);
            this.SetParamSimple(map, prefix + "ExecutionTimeMs", this.ExecutionTimeMs);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

