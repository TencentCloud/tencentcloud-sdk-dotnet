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
        /// 数据库名称。如果SQL语句中有数据库名称，优先使用SQL语句中的数据库，否则使用该参数指定的数据库（注：当提交建库sql时，该字段传空字符串）。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 默认数据源名称。
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// 数据引擎名称，不填提交到默认集群
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// 标准spark执行任务resourceGroupName
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Task.", this.Task);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
        }
    }
}

