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

    public class DescribeTablesRequest : AbstractModel
    {
        
        /// <summary>
        /// 列出该数据库下所属数据表。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 返回数量，默认为10，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 数据偏移量，从0开始，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 过滤条件，如下支持的过滤类型，传参Name应为其一
        /// table-name - String - （过滤条件）数据表名称,形如：table-001。
        /// table-id - String - （过滤条件）table id形如：12342。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 指定查询的数据源名称，默认为DataLakeCatalog
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// 起始时间：用于对更新时间的筛选
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 终止时间：用于对更新时间的筛选
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 排序字段，支持：CreateTime、UpdateTime、StorageSize、RecordCount、Name（不传则默认按name升序）
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// 排序字段，false：降序（默认）；true：升序
        /// </summary>
        [JsonProperty("Asc")]
        public bool? Asc{ get; set; }

        /// <summary>
        /// table type，表类型查询,可用值:EXTERNAL_TABLE,INDEX_TABLE,MANAGED_TABLE,MATERIALIZED_VIEW,TABLE,VIEW,VIRTUAL_VIEW
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// 筛选字段-表格式：不传（默认）为查全部；LAKEFS：托管表；ICEBERG：非托管iceberg表；HIVE：非托管hive表；OTHER：非托管其它；
        /// </summary>
        [JsonProperty("TableFormat")]
        public string TableFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Asc", this.Asc);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "TableFormat", this.TableFormat);
        }
    }
}

