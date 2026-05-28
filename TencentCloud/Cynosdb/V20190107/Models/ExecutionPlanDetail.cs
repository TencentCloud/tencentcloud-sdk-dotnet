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

    public class ExecutionPlanDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>模板ID</p>
        /// </summary>
        [JsonProperty("TemplateID")]
        public string TemplateID{ get; set; }

        /// <summary>
        /// <p>数据库名</p>
        /// </summary>
        [JsonProperty("Db")]
        public string Db{ get; set; }

        /// <summary>
        /// <p>原始SQL样例</p>
        /// </summary>
        [JsonProperty("SQLSample")]
        public string SQLSample{ get; set; }

        /// <summary>
        /// <p>改写后SQL样例</p>
        /// </summary>
        [JsonProperty("SQLSampleRewritten")]
        public string SQLSampleRewritten{ get; set; }

        /// <summary>
        /// <p>优化前执行计划- 列表</p>
        /// </summary>
        [JsonProperty("TablePlanBefore")]
        public ExplainRow[] TablePlanBefore{ get; set; }

        /// <summary>
        /// <p>优化后执行计划 - 列表</p>
        /// </summary>
        [JsonProperty("TablePlanAfter")]
        public ExplainRow[] TablePlanAfter{ get; set; }

        /// <summary>
        /// <p>优化前树形执行计划</p>
        /// </summary>
        [JsonProperty("TreePlanBefore")]
        public string TreePlanBefore{ get; set; }

        /// <summary>
        /// <p>优化后树形执行计划</p>
        /// </summary>
        [JsonProperty("TreePlanAfter")]
        public string TreePlanAfter{ get; set; }

        /// <summary>
        /// <p>优化前查询时间</p>
        /// </summary>
        [JsonProperty("QueryTimeBefore")]
        public float? QueryTimeBefore{ get; set; }

        /// <summary>
        /// <p>优化后查询时间</p>
        /// </summary>
        [JsonProperty("QueryTimeAfter")]
        public float? QueryTimeAfter{ get; set; }

        /// <summary>
        /// <p>优化前扫描行数</p>
        /// </summary>
        [JsonProperty("SQLScanRowsBefore")]
        public long? SQLScanRowsBefore{ get; set; }

        /// <summary>
        /// <p>优化后扫描行数</p>
        /// </summary>
        [JsonProperty("SQLScanRowsAfter")]
        public long? SQLScanRowsAfter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateID", this.TemplateID);
            this.SetParamSimple(map, prefix + "Db", this.Db);
            this.SetParamSimple(map, prefix + "SQLSample", this.SQLSample);
            this.SetParamSimple(map, prefix + "SQLSampleRewritten", this.SQLSampleRewritten);
            this.SetParamArrayObj(map, prefix + "TablePlanBefore.", this.TablePlanBefore);
            this.SetParamArrayObj(map, prefix + "TablePlanAfter.", this.TablePlanAfter);
            this.SetParamSimple(map, prefix + "TreePlanBefore", this.TreePlanBefore);
            this.SetParamSimple(map, prefix + "TreePlanAfter", this.TreePlanAfter);
            this.SetParamSimple(map, prefix + "QueryTimeBefore", this.QueryTimeBefore);
            this.SetParamSimple(map, prefix + "QueryTimeAfter", this.QueryTimeAfter);
            this.SetParamSimple(map, prefix + "SQLScanRowsBefore", this.SQLScanRowsBefore);
            this.SetParamSimple(map, prefix + "SQLScanRowsAfter", this.SQLScanRowsAfter);
        }
    }
}

