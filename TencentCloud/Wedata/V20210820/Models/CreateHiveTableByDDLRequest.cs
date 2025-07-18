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

    public class CreateHiveTableByDDLRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据源ID
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// 数据库
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// 建hive表ddl的base64编码
        /// </summary>
        [JsonProperty("DDLSql")]
        public string DDLSql{ get; set; }

        /// <summary>
        /// 表权限 ，默认为0:项目共享;1:仅个人与管理员
        /// </summary>
        [JsonProperty("Privilege")]
        public long? Privilege{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 目标表类型(HIVE或GBASE)
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 责任人
        /// </summary>
        [JsonProperty("Incharge")]
        public string Incharge{ get; set; }

        /// <summary>
        /// schema名称
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// 是否异步建表
        /// </summary>
        [JsonProperty("Async")]
        public bool? Async{ get; set; }

        /// <summary>
        /// 数据优化使用的资源
        /// </summary>
        [JsonProperty("DataOptimizationResource")]
        public string DataOptimizationResource{ get; set; }

        /// <summary>
        /// 是否开启数据优化
        /// </summary>
        [JsonProperty("SmartOptimizerWritten")]
        public string SmartOptimizerWritten{ get; set; }

        /// <summary>
        /// 数据优化表名
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 数据优化资源组
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "DDLSql", this.DDLSql);
            this.SetParamSimple(map, prefix + "Privilege", this.Privilege);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Incharge", this.Incharge);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "Async", this.Async);
            this.SetParamSimple(map, prefix + "DataOptimizationResource", this.DataOptimizationResource);
            this.SetParamSimple(map, prefix + "SmartOptimizerWritten", this.SmartOptimizerWritten);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
        }
    }
}

