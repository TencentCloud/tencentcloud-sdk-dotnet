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

    public class DescribeTableSpaceDataV2Response : AbstractModel
    {
        
        /// <summary>
        /// <p>MySQL 系列产品表空间数据。当产品为 mysql/cynosdb/tdsql/dcdb/mariadb 时返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MysqlTableSpaceData")]
        public MysqlSpaceObjectItem MysqlTableSpaceData{ get; set; }

        /// <summary>
        /// <p>PostgreSQL 产品表空间数据。当产品为 postgres 时返回。字段语义与 MySQL 不同：使用 RelationSize / TableSize / IndexSize / TotalRelationSize / TableBloat 等 PG 特有指标。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostgresTableSpaceData")]
        public PostgresSpaceObjectItem PostgresTableSpaceData{ get; set; }

        /// <summary>
        /// <p>MongoDB 产品表空间数据。当产品为 mongodb 时返回。包含集合级明细数组 SpaceSchemas 以及外层采集时间戳 Timestamp（秒级）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MongodbTableSpaceData")]
        public MongodbSpaceObjectItem MongodbTableSpaceData{ get; set; }

        /// <summary>
        /// <p>SQL Server 产品表空间数据。当产品为 sqlserver 时返回。字段结构与 MysqlSpaceObjectItem 同构，无 FragRatio / PhysicalFileSize。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlServerTableSpaceData")]
        public SqlServerSpaceObjectItem SqlServerTableSpaceData{ get; set; }

        /// <summary>
        /// <p>数据采集时间戳（秒）。可能为空（部分产品分支/异常场景下不保证返回），调用方请做空值兼容。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MysqlTableSpaceData.", this.MysqlTableSpaceData);
            this.SetParamObj(map, prefix + "PostgresTableSpaceData.", this.PostgresTableSpaceData);
            this.SetParamObj(map, prefix + "MongodbTableSpaceData.", this.MongodbTableSpaceData);
            this.SetParamObj(map, prefix + "SqlServerTableSpaceData.", this.SqlServerTableSpaceData);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

