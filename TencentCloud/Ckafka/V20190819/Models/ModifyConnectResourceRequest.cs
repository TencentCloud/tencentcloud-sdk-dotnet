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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyConnectResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>连接源的Id</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>连接源名称，为空时不修改</p>
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// <p>连接源描述，为空时不修改</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>连接源类型，修改数据源参数时，需要与原Type相同，否则编辑数据源无效</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Dts配置，Type为DTS时必填</p>
        /// </summary>
        [JsonProperty("DtsConnectParam")]
        public DtsModifyConnectParam DtsConnectParam{ get; set; }

        /// <summary>
        /// <p>MongoDB配置，Type为MONGODB时必填</p>
        /// </summary>
        [JsonProperty("MongoDBConnectParam")]
        public MongoDBModifyConnectParam MongoDBConnectParam{ get; set; }

        /// <summary>
        /// <p>Es配置，Type为ES时必填</p>
        /// </summary>
        [JsonProperty("EsConnectParam")]
        public EsModifyConnectParam EsConnectParam{ get; set; }

        /// <summary>
        /// <p>ClickHouse配置，Type为CLICKHOUSE时必填</p>
        /// </summary>
        [JsonProperty("ClickHouseConnectParam")]
        public ClickHouseModifyConnectParam ClickHouseConnectParam{ get; set; }

        /// <summary>
        /// <p>MySQL配置，Type为MYSQL或TDSQL_C_MYSQL时必填</p>
        /// </summary>
        [JsonProperty("MySQLConnectParam")]
        public MySQLModifyConnectParam MySQLConnectParam{ get; set; }

        /// <summary>
        /// <p>PostgreSQL配置，Type为POSTGRESQL或TDSQL_C_POSTGRESQL时必填</p>
        /// </summary>
        [JsonProperty("PostgreSQLConnectParam")]
        public PostgreSQLModifyConnectParam PostgreSQLConnectParam{ get; set; }

        /// <summary>
        /// <p>MariaDB配置，Type为MARIADB时必填</p>
        /// </summary>
        [JsonProperty("MariaDBConnectParam")]
        public MariaDBModifyConnectParam MariaDBConnectParam{ get; set; }

        /// <summary>
        /// <p>SQLServer配置，Type为SQLSERVER时必填</p>
        /// </summary>
        [JsonProperty("SQLServerConnectParam")]
        public SQLServerModifyConnectParam SQLServerConnectParam{ get; set; }

        /// <summary>
        /// <p>Ctsdb配置，Type为CTSDB</p>
        /// </summary>
        [JsonProperty("CtsdbConnectParam")]
        public CtsdbModifyConnectParam CtsdbConnectParam{ get; set; }

        /// <summary>
        /// <p>Doris配置，Type为DORIS</p>
        /// </summary>
        [JsonProperty("DorisConnectParam")]
        public DorisModifyConnectParam DorisConnectParam{ get; set; }

        /// <summary>
        /// <p>Kafka配置，Type为 KAFKA 时必填</p>
        /// </summary>
        [JsonProperty("KafkaConnectParam")]
        public KafkaConnectParam KafkaConnectParam{ get; set; }

        /// <summary>
        /// <p>MQTT配置，Type为 MQTT 时必填</p>
        /// </summary>
        [JsonProperty("MqttConnectParam")]
        public MqttConnectParam MqttConnectParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "DtsConnectParam.", this.DtsConnectParam);
            this.SetParamObj(map, prefix + "MongoDBConnectParam.", this.MongoDBConnectParam);
            this.SetParamObj(map, prefix + "EsConnectParam.", this.EsConnectParam);
            this.SetParamObj(map, prefix + "ClickHouseConnectParam.", this.ClickHouseConnectParam);
            this.SetParamObj(map, prefix + "MySQLConnectParam.", this.MySQLConnectParam);
            this.SetParamObj(map, prefix + "PostgreSQLConnectParam.", this.PostgreSQLConnectParam);
            this.SetParamObj(map, prefix + "MariaDBConnectParam.", this.MariaDBConnectParam);
            this.SetParamObj(map, prefix + "SQLServerConnectParam.", this.SQLServerConnectParam);
            this.SetParamObj(map, prefix + "CtsdbConnectParam.", this.CtsdbConnectParam);
            this.SetParamObj(map, prefix + "DorisConnectParam.", this.DorisConnectParam);
            this.SetParamObj(map, prefix + "KafkaConnectParam.", this.KafkaConnectParam);
            this.SetParamObj(map, prefix + "MqttConnectParam.", this.MqttConnectParam);
        }
    }
}

