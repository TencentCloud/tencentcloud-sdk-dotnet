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

    public class CreateTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 计算任务，该参数中包含任务类型及其相关配置信息
        /// </summary>
        [JsonProperty("Task")]
        public Task Task{ get; set; }

        /// <summary>
        /// 数据库名称。任务在执行前均会USE该数据库， 除了首次建库时，其他情况建议均添加上。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 默认数据源名称。
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Task.", this.Task);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
        }
    }
}

