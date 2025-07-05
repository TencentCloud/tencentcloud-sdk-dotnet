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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUpdatableDataEnginesRequest : AbstractModel
    {
        
        /// <summary>
        /// 引擎配置操作命令，UpdateSparkSQLLakefsPath 更新托管表路径，UpdateSparkSQLResultPath 更新结果桶路径
        /// </summary>
        [JsonProperty("DataEngineConfigCommand")]
        public string DataEngineConfigCommand{ get; set; }

        /// <summary>
        /// 是否使用托管存储作为结果存储
        /// </summary>
        [JsonProperty("UseLakeFs")]
        public bool? UseLakeFs{ get; set; }

        /// <summary>
        /// 用户自定义结果存储路径
        /// </summary>
        [JsonProperty("CustomResultPath")]
        public string CustomResultPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataEngineConfigCommand", this.DataEngineConfigCommand);
            this.SetParamSimple(map, prefix + "UseLakeFs", this.UseLakeFs);
            this.SetParamSimple(map, prefix + "CustomResultPath", this.CustomResultPath);
        }
    }
}

