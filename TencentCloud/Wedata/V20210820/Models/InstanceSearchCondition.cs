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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceSearchCondition : AbstractModel
    {
        
        /// <summary>
        /// 任务调度周期类型
        /// </summary>
        [JsonProperty("CycleList")]
        public string[] CycleList{ get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("DateFrom")]
        public string DateFrom{ get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [JsonProperty("DateTo")]
        public string DateTo{ get; set; }

        /// <summary>
        /// 实例过滤条件
        /// </summary>
        [JsonProperty("Instance")]
        public InstanceCondition Instance{ get; set; }

        /// <summary>
        /// 模糊查询关键字
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("SortCol")]
        public string SortCol{ get; set; }

        /// <summary>
        /// 实例状态类型
        /// </summary>
        [JsonProperty("StateList")]
        public string[] StateList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CycleList.", this.CycleList);
            this.SetParamSimple(map, prefix + "DateFrom", this.DateFrom);
            this.SetParamSimple(map, prefix + "DateTo", this.DateTo);
            this.SetParamObj(map, prefix + "Instance.", this.Instance);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "SortCol", this.SortCol);
            this.SetParamArraySimple(map, prefix + "StateList.", this.StateList);
        }
    }
}

