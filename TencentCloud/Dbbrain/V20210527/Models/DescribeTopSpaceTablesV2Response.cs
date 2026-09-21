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

    public class DescribeTopSpaceTablesV2Response : AbstractModel
    {
        
        /// <summary>
        /// <p>MySQL/PG/TDSQL 系列产品表级空间对象列表。当产品为 mysql/cynosdb/tdsql/dcdb/mariadb/postgres 时返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MysqlObjects")]
        public MysqlSpaceObjectItem[] MysqlObjects{ get; set; }

        /// <summary>
        /// <p>PostgreSQL 产品表级空间对象列表。当产品为 postgres 时返回。字段语义与 MySQL 不同：使用 RelationSize / TableSize / IndexSize / TotalRelationSize / TableBloat 等 PG 特有指标。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostgresObjects")]
        public PostgresSpaceObjectItem[] PostgresObjects{ get; set; }

        /// <summary>
        /// <p>MongoDB 产品表级（集合级）空间对象列表。当产品为 mongodb 时返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MongodbObjects")]
        public MongoDBTableSpaceItem[] MongodbObjects{ get; set; }

        /// <summary>
        /// <p>数据采集时间戳（秒）。</p>
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
            this.SetParamArrayObj(map, prefix + "MysqlObjects.", this.MysqlObjects);
            this.SetParamArrayObj(map, prefix + "PostgresObjects.", this.PostgresObjects);
            this.SetParamArrayObj(map, prefix + "MongodbObjects.", this.MongodbObjects);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

