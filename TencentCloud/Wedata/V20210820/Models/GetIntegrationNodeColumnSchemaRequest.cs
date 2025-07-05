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

    public class GetIntegrationNodeColumnSchemaRequest : AbstractModel
    {
        
        /// <summary>
        /// 字段示例（json格式）
        /// </summary>
        [JsonProperty("ColumnContent")]
        public string ColumnContent{ get; set; }

        /// <summary>
        /// 数据源类型 MYSQL|HIVE|KAFKA|ES|MONGODB|REST_API|SYBASE|TIDB|DORIS|DM|
        /// </summary>
        [JsonProperty("DatasourceType")]
        public string DatasourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ColumnContent", this.ColumnContent);
            this.SetParamSimple(map, prefix + "DatasourceType", this.DatasourceType);
        }
    }
}

