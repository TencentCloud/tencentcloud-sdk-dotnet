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

    public class CreateMetaDatabaseRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据源名称，默认DataLakeCatalog
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// 元数据库基本信息
        /// </summary>
        [JsonProperty("MetaDatabaseInfo")]
        public MetaDatabaseInfo MetaDatabaseInfo{ get; set; }

        /// <summary>
        /// 数据治理配置项
        /// </summary>
        [JsonProperty("GovernPolicy")]
        public DataGovernPolicy GovernPolicy{ get; set; }

        /// <summary>
        /// 智能数据治理配置
        /// </summary>
        [JsonProperty("SmartPolicy")]
        public SmartPolicy SmartPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamObj(map, prefix + "MetaDatabaseInfo.", this.MetaDatabaseInfo);
            this.SetParamObj(map, prefix + "GovernPolicy.", this.GovernPolicy);
            this.SetParamObj(map, prefix + "SmartPolicy.", this.SmartPolicy);
        }
    }
}

