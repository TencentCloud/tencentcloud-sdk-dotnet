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

    public class DatasourceConnectionConfig : AbstractModel
    {
        
        /// <summary>
        /// Mysql数据源连接的属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mysql")]
        public MysqlInfo Mysql{ get; set; }

        /// <summary>
        /// Hive数据源连接的属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hive")]
        public HiveInfo Hive{ get; set; }

        /// <summary>
        /// Kafka数据源连接的属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Kafka")]
        public KafkaInfo Kafka{ get; set; }

        /// <summary>
        /// 其他数据源连接的属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherDatasourceConnection")]
        public OtherDatasourceConnection OtherDatasourceConnection{ get; set; }

        /// <summary>
        /// PostgreSQL数据源连接的属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostgreSql")]
        public DataSourceInfo PostgreSql{ get; set; }

        /// <summary>
        /// SQLServer数据源连接的属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlServer")]
        public DataSourceInfo SqlServer{ get; set; }

        /// <summary>
        /// ClickHouse数据源连接的属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClickHouse")]
        public DataSourceInfo ClickHouse{ get; set; }

        /// <summary>
        /// Elasticsearch数据源连接的属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Elasticsearch")]
        public ElasticsearchInfo Elasticsearch{ get; set; }

        /// <summary>
        /// TDSQL-PostgreSQL数据源连接的属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TDSQLPostgreSql")]
        public DataSourceInfo TDSQLPostgreSql{ get; set; }

        /// <summary>
        /// Doris数据源连接的属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TCHouseD")]
        public TCHouseD TCHouseD{ get; set; }

        /// <summary>
        /// TccHive数据目录连接信息
        /// </summary>
        [JsonProperty("TccHive")]
        public TccHive TccHive{ get; set; }

        /// <summary>
        /// MongoDB 数据源
        /// </summary>
        [JsonProperty("MongoDB")]
        public DataSourceInfo MongoDB{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Mysql.", this.Mysql);
            this.SetParamObj(map, prefix + "Hive.", this.Hive);
            this.SetParamObj(map, prefix + "Kafka.", this.Kafka);
            this.SetParamObj(map, prefix + "OtherDatasourceConnection.", this.OtherDatasourceConnection);
            this.SetParamObj(map, prefix + "PostgreSql.", this.PostgreSql);
            this.SetParamObj(map, prefix + "SqlServer.", this.SqlServer);
            this.SetParamObj(map, prefix + "ClickHouse.", this.ClickHouse);
            this.SetParamObj(map, prefix + "Elasticsearch.", this.Elasticsearch);
            this.SetParamObj(map, prefix + "TDSQLPostgreSql.", this.TDSQLPostgreSql);
            this.SetParamObj(map, prefix + "TCHouseD.", this.TCHouseD);
            this.SetParamObj(map, prefix + "TccHive.", this.TccHive);
            this.SetParamObj(map, prefix + "MongoDB.", this.MongoDB);
        }
    }
}

