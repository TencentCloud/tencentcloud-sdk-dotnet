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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Aggregation : AbstractModel
    {
        
        /// <summary>
        /// 平均执行时间（ms）。
        /// </summary>
        [JsonProperty("AvgExecTime")]
        public long? AvgExecTime{ get; set; }

        /// <summary>
        /// 平均扫描行数。
        /// </summary>
        [JsonProperty("AvgDocsExamined")]
        public long? AvgDocsExamined{ get; set; }

        /// <summary>
        /// 产生慢查次数（/天）。
        /// </summary>
        [JsonProperty("SlowLogCount")]
        public long? SlowLogCount{ get; set; }

        /// <summary>
        /// 内存排序次数。
        /// </summary>
        [JsonProperty("SortCount")]
        public long? SortCount{ get; set; }

        /// <summary>
        /// 慢查模板概览。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlowLogs")]
        public string[] SlowLogs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AvgExecTime", this.AvgExecTime);
            this.SetParamSimple(map, prefix + "AvgDocsExamined", this.AvgDocsExamined);
            this.SetParamSimple(map, prefix + "SlowLogCount", this.SlowLogCount);
            this.SetParamSimple(map, prefix + "SortCount", this.SortCount);
            this.SetParamArraySimple(map, prefix + "SlowLogs.", this.SlowLogs);
        }
    }
}

