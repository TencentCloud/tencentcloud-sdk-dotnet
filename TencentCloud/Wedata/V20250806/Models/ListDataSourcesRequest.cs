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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListDataSourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 返回数量，默认10
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 页码，默认1
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数据源展示名
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 数据源类型:枚举值
        /// 
        /// - MYSQL
        /// - TENCENT_MYSQL
        /// - POSTGRE
        /// - ORACLE
        /// - SQLSERVER
        /// - FTP
        /// - HIVE
        /// - HUDI
        /// - HDFS
        /// - ICEBERG
        /// - KAFKA
        /// - HBASE
        /// - SPARK
        /// - VIRTUAL
        /// - TBASE
        /// - DB2
        /// - DM
        /// - GAUSSDB
        /// - GBASE
        /// - IMPALA
        /// - ES
        /// - TENCENT_ES
        /// - GREENPLUM
        /// - PHOENIX
        /// - SAP_HANA
        /// - SFTP
        /// - OCEANBASE
        /// - CLICKHOUSE
        /// - KUDU
        /// - VERTICA
        /// - REDIS
        /// - COS
        /// - DLC
        /// - DORIS
        /// - CKAFKA
        /// - S3
        /// - TDSQL
        /// - TDSQL_MYSQL
        /// - MONGODB
        /// - TENCENT_MONGODB
        /// - REST_API
        /// - SuperSQL
        /// - PRESTO
        /// - TiDB
        /// - StarRocks
        /// - Trino
        /// - Kyuubi
        /// - TCHOUSE_X
        /// - TCHOUSE_P
        /// - TCHOUSE_C
        /// - TCHOUSE_D
        /// - INFLUXDB
        /// - BIG_QUERY
        /// - SSH
        /// - BLOB
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
        }
    }
}

