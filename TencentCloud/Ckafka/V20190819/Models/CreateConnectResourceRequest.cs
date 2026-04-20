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

    public class CreateConnectResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>连接源名称</p>
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// <p>连接源类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>连接源描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Dts配置，Type为DTS时必填</p>
        /// </summary>
        [JsonProperty("DtsConnectParam")]
        public DtsConnectParam DtsConnectParam{ get; set; }

        /// <summary>
        /// <p>MongoDB配置，Type为MONGODB时必填</p>
        /// </summary>
        [JsonProperty("MongoDBConnectParam")]
        public MongoDBConnectParam MongoDBConnectParam{ get; set; }

        /// <summary>
        /// <p>Es配置，Type为ES时必填</p>
        /// </summary>
        [JsonProperty("EsConnectParam")]
        public EsConnectParam EsConnectParam{ get; set; }

        /// <summary>
        /// <p>ClickHouse配置，Type为CLICKHOUSE时必填</p>
        /// </summary>
        [JsonProperty("ClickHouseConnectParam")]
        public ClickHouseConnectParam ClickHouseConnectParam{ get; set; }

        /// <summary>
        /// <p>MySQL配置，Type为MYSQL或TDSQL_C_MYSQL时必填</p>
        /// </summary>
        [JsonProperty("MySQLConnectParam")]
        public MySQLConnectParam MySQLConnectParam{ get; set; }

        /// <summary>
        /// <p>PostgreSQL配置，Type为POSTGRESQL或TDSQL_C_POSTGRESQL时必填</p>
        /// </summary>
        [JsonProperty("PostgreSQLConnectParam")]
        public PostgreSQLConnectParam PostgreSQLConnectParam{ get; set; }

        /// <summary>
        /// <p>MariaDB配置，Type为MARIADB时必填</p>
        /// </summary>
        [JsonProperty("MariaDBConnectParam")]
        public MariaDBConnectParam MariaDBConnectParam{ get; set; }

        /// <summary>
        /// <p>SQLServer配置，Type为SQLSERVER时必填</p>
        /// </summary>
        [JsonProperty("SQLServerConnectParam")]
        public SQLServerConnectParam SQLServerConnectParam{ get; set; }

        /// <summary>
        /// <p>Doris 配置，Type为 DORIS 时必填</p>
        /// </summary>
        [JsonProperty("DorisConnectParam")]
        public DorisConnectParam DorisConnectParam{ get; set; }

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
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "DtsConnectParam.", this.DtsConnectParam);
            this.SetParamObj(map, prefix + "MongoDBConnectParam.", this.MongoDBConnectParam);
            this.SetParamObj(map, prefix + "EsConnectParam.", this.EsConnectParam);
            this.SetParamObj(map, prefix + "ClickHouseConnectParam.", this.ClickHouseConnectParam);
            this.SetParamObj(map, prefix + "MySQLConnectParam.", this.MySQLConnectParam);
            this.SetParamObj(map, prefix + "PostgreSQLConnectParam.", this.PostgreSQLConnectParam);
            this.SetParamObj(map, prefix + "MariaDBConnectParam.", this.MariaDBConnectParam);
            this.SetParamObj(map, prefix + "SQLServerConnectParam.", this.SQLServerConnectParam);
            this.SetParamObj(map, prefix + "DorisConnectParam.", this.DorisConnectParam);
            this.SetParamObj(map, prefix + "KafkaConnectParam.", this.KafkaConnectParam);
            this.SetParamObj(map, prefix + "MqttConnectParam.", this.MqttConnectParam);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

