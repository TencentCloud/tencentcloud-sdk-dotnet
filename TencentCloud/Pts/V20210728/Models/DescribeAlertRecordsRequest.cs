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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlertRecordsRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目 ID 列表
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string[] ProjectIds{ get; set; }

        /// <summary>
        /// 场景 ID 列表
        /// </summary>
        [JsonProperty("ScenarioIds")]
        public string[] ScenarioIds{ get; set; }

        /// <summary>
        /// 任务 ID 列表
        /// </summary>
        [JsonProperty("JobIds")]
        public string[] JobIds{ get; set; }

        /// <summary>
        /// 是否正序
        /// </summary>
        [JsonProperty("Ascend")]
        public bool? Ascend{ get; set; }

        /// <summary>
        /// 排序项
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 偏移量，默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 按场景名筛选
        /// </summary>
        [JsonProperty("ScenarioNames")]
        public string[] ScenarioNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "ScenarioIds.", this.ScenarioIds);
            this.SetParamArraySimple(map, prefix + "JobIds.", this.JobIds);
            this.SetParamSimple(map, prefix + "Ascend", this.Ascend);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "ScenarioNames.", this.ScenarioNames);
        }
    }
}

