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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskMonitorInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 引擎名称
        /// </summary>
        [JsonProperty("HouseName")]
        public string HouseName{ get; set; }

        /// <summary>
        /// sql语句
        /// </summary>
        [JsonProperty("QuerySQL")]
        public string QuerySQL{ get; set; }

        /// <summary>
        /// 任务时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [JsonProperty("UsedTime")]
        public string UsedTime{ get; set; }

        /// <summary>
        /// 数据扫描量
        /// </summary>
        [JsonProperty("DataAmount")]
        public string DataAmount{ get; set; }

        /// <summary>
        /// 指标信息
        /// </summary>
        [JsonProperty("QueryStats")]
        public string QueryStats{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "HouseName", this.HouseName);
            this.SetParamSimple(map, prefix + "QuerySQL", this.QuerySQL);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UsedTime", this.UsedTime);
            this.SetParamSimple(map, prefix + "DataAmount", this.DataAmount);
            this.SetParamSimple(map, prefix + "QueryStats", this.QueryStats);
        }
    }
}

