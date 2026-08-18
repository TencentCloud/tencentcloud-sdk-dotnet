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

    public class DatahubResource : AbstractModel
    {
        
        /// <summary>
        /// <p>资源类型  type类型如下:<br>KAFKA,<br>EB_ES,<br>EB_COS,<br>EB_CLS,<br>EB_,<br>MONGODB,<br>HTTP,<br>TDW,<br>ES,<br>CLICKHOUSE,<br>DTS,<br>CLS,<br>COS,<br>TOPIC,<br>MYSQL,<br>MQTT,<br>MYSQL_DATA,<br>DORIS,<br>POSTGRESQL,<br>TDSQL_C_POSTGRESQL,<br>TDSQL_POSTGRESQL,<br>WAREHOUSE_POSTGRESQL,<br>TDSQL_C_MYSQL,<br>MARIADB,<br>SQLSERVER,<br>CTSDB,<br>SCF</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>ckafka配置，Type为KAFKA时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaParam")]
        public KafkaParam KafkaParam{ get; set; }

        /// <summary>
        /// <p>EB配置，Type为EB时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventBusParam")]
        public EventBusParam EventBusParam{ get; set; }

        /// <summary>
        /// <p>MongoDB配置，Type为MONGODB时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MongoDBParam")]
        public MongoDBParam MongoDBParam{ get; set; }

        /// <summary>
        /// <p>Es配置，Type为ES时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsParam")]
        public EsParam EsParam{ get; set; }

        /// <summary>
        /// <p>Tdw配置，Type为TDW时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TdwParam")]
        public TdwParam TdwParam{ get; set; }

        /// <summary>
        /// <p>Dts配置，Type为DTS时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DtsParam")]
        public DtsParam DtsParam{ get; set; }

        /// <summary>
        /// <p>ClickHouse配置，Type为CLICKHOUSE时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClickHouseParam")]
        public ClickHouseParam ClickHouseParam{ get; set; }

        /// <summary>
        /// <p>Cls配置，Type为CLS时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClsParam")]
        public ClsParam ClsParam{ get; set; }

        /// <summary>
        /// <p>Cos配置，Type为COS时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosParam")]
        public CosParam CosParam{ get; set; }

        /// <summary>
        /// <p>MySQL配置，Type为MYSQL时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MySQLParam")]
        public MySQLParam MySQLParam{ get; set; }

        /// <summary>
        /// <p>PostgreSQL配置，Type为POSTGRESQL或TDSQL_C_POSTGRESQL时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostgreSQLParam")]
        public PostgreSQLParam PostgreSQLParam{ get; set; }

        /// <summary>
        /// <p>Topic配置，Type为Topic时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicParam")]
        public TopicParam TopicParam{ get; set; }

        /// <summary>
        /// <p>MariaDB配置，Type为MARIADB时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MariaDBParam")]
        public MariaDBParam MariaDBParam{ get; set; }

        /// <summary>
        /// <p>SQLServer配置，Type为SQLSERVER时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SQLServerParam")]
        public SQLServerParam SQLServerParam{ get; set; }

        /// <summary>
        /// <p>Ctsdb配置，Type为CTSDB时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CtsdbParam")]
        public CtsdbParam CtsdbParam{ get; set; }

        /// <summary>
        /// <p>Scf配置，Type为SCF时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScfParam")]
        public ScfParam ScfParam{ get; set; }

        /// <summary>
        /// <p>MQTT配置，Type为 MQTT 时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MqttParam")]
        public MqttParam MqttParam{ get; set; }

        /// <summary>
        /// <p>IceBerg配置</p>
        /// </summary>
        [JsonProperty("IcebergParam")]
        public IcebergParam IcebergParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "KafkaParam.", this.KafkaParam);
            this.SetParamObj(map, prefix + "EventBusParam.", this.EventBusParam);
            this.SetParamObj(map, prefix + "MongoDBParam.", this.MongoDBParam);
            this.SetParamObj(map, prefix + "EsParam.", this.EsParam);
            this.SetParamObj(map, prefix + "TdwParam.", this.TdwParam);
            this.SetParamObj(map, prefix + "DtsParam.", this.DtsParam);
            this.SetParamObj(map, prefix + "ClickHouseParam.", this.ClickHouseParam);
            this.SetParamObj(map, prefix + "ClsParam.", this.ClsParam);
            this.SetParamObj(map, prefix + "CosParam.", this.CosParam);
            this.SetParamObj(map, prefix + "MySQLParam.", this.MySQLParam);
            this.SetParamObj(map, prefix + "PostgreSQLParam.", this.PostgreSQLParam);
            this.SetParamObj(map, prefix + "TopicParam.", this.TopicParam);
            this.SetParamObj(map, prefix + "MariaDBParam.", this.MariaDBParam);
            this.SetParamObj(map, prefix + "SQLServerParam.", this.SQLServerParam);
            this.SetParamObj(map, prefix + "CtsdbParam.", this.CtsdbParam);
            this.SetParamObj(map, prefix + "ScfParam.", this.ScfParam);
            this.SetParamObj(map, prefix + "MqttParam.", this.MqttParam);
            this.SetParamObj(map, prefix + "IcebergParam.", this.IcebergParam);
        }
    }
}

