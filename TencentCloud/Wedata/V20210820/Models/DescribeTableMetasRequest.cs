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

    public class DescribeTableMetasRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 过滤字段:
        /// dbName-数据库名称
        /// bizCatalogIds-资产目录ID
        /// DataLayerUuid-数仓分层ID
        /// ownerAccount-负责人ID
        /// assetStatus-资产状态：1-已上架 0-未上架
        /// assetLevel-资产等级：40-核心30-重要 20-一般 10-临时 
        /// msTypes-数据源类型：例如TENCENT_MYSQL-腾讯云MySQL，数据源类型ID可参考
        /// [
        ///   {
        ///     "DisplayName": "TCHouse-P",
        ///     "Id": "TCHOUSE_P"
        ///   },
        ///   {
        ///     "DisplayName": "Iceberg",
        ///     "Id": "ICEBERG"
        ///   },
        ///   {
        ///     "DisplayName": "Hive",
        ///     "Id": "HIVE"
        ///   },
        ///   {
        ///     "DisplayName": "HBase",
        ///     "Id": "HBASE"
        ///   },
        ///   {
        ///     "DisplayName": "DLC",
        ///     "Id": "DLC"
        ///   },
        ///   {
        ///     "DisplayName": "腾讯云MySQL",
        ///     "Id": "TENCENT_MYSQL"
        ///   },
        ///   {
        ///     "DisplayName": "TCHouse-D",
        ///     "Id": "TCHOUSE_D"
        ///   },
        ///   {
        ///     "DisplayName": "TCHouse-C",
        ///     "Id": "TCHOUSE_C"
        ///   },
        ///   {
        ///     "DisplayName": "EMR StarRocks",
        ///     "Id": "EMR_STARROCKS"
        ///   },
        ///   {
        ///     "DisplayName": "Doris",
        ///     "Id": "DORIS"
        ///   },
        ///   {
        ///     "DisplayName": "MySQL",
        ///     "Id": "MYSQL"
        ///   },
        ///   {
        ///     "DisplayName": "Oracle",
        ///     "Id": "ORACLE"
        ///   },
        ///   {
        ///     "DisplayName": "PostgreSQL",
        ///     "Id": "POSTGRE"
        ///   },
        ///   {
        ///     "DisplayName": "SQL Server",
        ///     "Id": "SQLSERVER"
        ///   },
        ///   {
        ///     "DisplayName": "TDSQL PostgreSQL",
        ///     "Id": "TDSQL_POSTGRE"
        ///   },
        ///   {
        ///     "DisplayName": "Greenplum",
        ///     "Id": "GREENPLUM"
        ///   },
        ///   {
        ///     "DisplayName": "StarRocks",
        ///     "Id": "STARROCKS"
        ///   },
        ///   {
        ///     "DisplayName": "ClickHouse",
        ///     "Id": "CLICKHOUSE"
        ///   },
        ///   {
        ///     "DisplayName": "INFLUXDB",
        ///     "Id": "INFLUXDB"
        ///   },
        ///   {
        ///     "DisplayName": "达梦DM",
        ///     "Id": "DM"
        ///   },
        ///   {
        ///     "DisplayName": "OceanBase",
        ///     "Id": "OCEANBASE"
        ///   },
        ///   {
        ///     "DisplayName": "TDSQL MySQL",
        ///     "Id": "TDSQL_MYSQL"
        ///   },
        ///   {
        ///     "DisplayName": "GaussDB",
        ///     "Id": "GAUSSDB"
        ///   }
        /// ]
        /// projectIds-归属项目ID
        /// keyword-关键字，支持表名/表中文名/数据库名
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField[] OrderFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
        }
    }
}

