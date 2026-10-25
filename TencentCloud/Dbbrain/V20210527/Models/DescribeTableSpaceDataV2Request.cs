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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTableSpaceDataV2Request : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>服务产品类型（用于云 API 平台路由到对应产品后端）。取值：mysql / cynosdb / mariadb / postgres / mongodb / sqlserver 等。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>数据库名（PG 系产品的 schema 名；MongoDB 为 database 名；MySQL / CynosDB / SqlServer 为库名）。PostgreSQL / MySQL / CynosDB / SqlServer 必传；MongoDB 可不传（底层使用 optString(&quot;&quot;), 不传时按空库名查询）。</p>
        /// </summary>
        [JsonProperty("TableSchema")]
        public string TableSchema{ get; set; }

        /// <summary>
        /// <p>表名（MongoDB 场景下为 collection 名，如 oplog.rs）。PostgreSQL / MySQL / CynosDB / SqlServer 必传；MongoDB 可不传（底层对该字段为空时直接返回空列表而非报错）。</p>
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>表所在的 Catalog（数据库目录）名。PostgreSQL / TBase 等 PG 系产品必传（例如 postgres），用于唯一定位 (catalog, schema, name) 三元组；MySQL / CynosDB / MongoDB / SqlServer 等非 PG 系产品可不传。</p>
        /// </summary>
        [JsonProperty("TableCatalog")]
        public string TableCatalog{ get; set; }

        /// <summary>
        /// <p>查询日期，格式：yyyy-MM-dd。MySQL / CynosDB / PostgreSQL / SqlServer 可选（默认当天）；MongoDB 本接口不读取该字段（底层通过 dbbrain.collInfo 直接查询实时集合空间，不区分日期）。</p>
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// <p>排序字段。本接口（单表/单集合明细查询）均为可选：MySQL / CynosDB 可选，默认按 total_length 排序；PostgreSQL 可选，默认按 relation_size 排序；SqlServer 本接口不消费该字段的值；MongoDB 本接口完全不读取该字段。如需在 Top 表/库场景使用排序，请改用 DescribeTopSpaceTablesV2 / DescribeTopSpaceSchemasV2 接口。</p>
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// <p>返回条数上限，默认 20，最大 100。MySQL / CynosDB / PostgreSQL 本接口会读取该参数控制明细条数；MongoDB 本接口不读取该字段（底层按入参 TableName 精确匹配返回集合明细，不受 Limit 控制）；SqlServer 本接口会校验但不消费其值。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>MongoDB 专用——表名/集合名是否按正则模糊匹配。默认 true。其他产品忽略该字段。</p>
        /// </summary>
        [JsonProperty("Regex")]
        public bool? Regex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "TableSchema", this.TableSchema);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableCatalog", this.TableCatalog);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Regex", this.Regex);
        }
    }
}

