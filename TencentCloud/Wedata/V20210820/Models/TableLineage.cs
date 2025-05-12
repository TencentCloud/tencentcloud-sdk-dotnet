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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableLineage : AbstractModel
    {
        
        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// 库名称
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 表名称
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// catalog值
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// schema名称
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("ExtParams")]
        public ExtParam[] ExtParams{ get; set; }

        /// <summary>
        /// table类型 TABLE｜VIEW
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamArrayObj(map, prefix + "ExtParams.", this.ExtParams);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
        }
    }
}

