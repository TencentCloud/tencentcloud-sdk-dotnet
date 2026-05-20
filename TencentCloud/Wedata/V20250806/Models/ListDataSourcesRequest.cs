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
        /// <p>项目id</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>返回数量，默认10</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// <p>页码，默认1</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// <p>数据源名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>数据源展示名</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>数据源类型:枚举值</p><ul><li>MYSQL</li><li>TENCENT_MYSQL</li><li>POSTGRE</li><li>ORACLE</li><li>SQLSERVER</li><li>FTP</li><li>HIVE</li><li>HUDI</li><li>HDFS</li><li>ICEBERG</li><li>KAFKA</li><li>HBASE</li><li>SPARK</li><li>VIRTUAL</li><li>TBASE</li><li>DB2</li><li>DM</li><li>GAUSSDB</li><li>GBASE</li><li>IMPALA</li><li>ES</li><li>TENCENT_ES</li><li>GREENPLUM</li><li>PHOENIX</li><li>SAP_HANA</li><li>SFTP</li><li>OCEANBASE</li><li>CLICKHOUSE</li><li>KUDU</li><li>VERTICA</li><li>REDIS</li><li>COS</li><li>DLC</li><li>DORIS</li><li>CKAFKA</li><li>S3</li><li>TDSQL</li><li>TDSQL_MYSQL</li><li>MONGODB</li><li>TENCENT_MONGODB</li><li>REST_API</li><li>SuperSQL</li><li>PRESTO</li><li>TiDB</li><li>StarRocks</li><li>Trino</li><li>Kyuubi</li><li>TCHOUSE_X</li><li>TCHOUSE_P</li><li>TCHOUSE_C</li><li>TCHOUSE_D</li><li>INFLUXDB</li><li>BIG_QUERY</li><li>SSH</li><li>BLOB</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// <p>创建人</p>
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

