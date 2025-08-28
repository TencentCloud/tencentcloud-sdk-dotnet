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
        /// 资源类型  type类型如下: 
        /// KAFKA,
        /// EB_ES,
        /// EB_COS,
        /// EB_CLS,
        /// EB_,
        /// MONGODB,
        /// HTTP,
        /// TDW,
        /// ES,
        /// CLICKHOUSE,
        /// DTS,
        /// CLS,
        /// COS,
        /// TOPIC,
        /// MYSQL,
        /// MQTT,
        /// MYSQL_DATA,
        /// DORIS,
        /// POSTGRESQL,
        /// TDSQL_C_POSTGRESQL,
        /// TDSQL_POSTGRESQL,
        /// WAREHOUSE_POSTGRESQL,
        /// TDSQL_C_MYSQL,
        /// MARIADB,
        /// SQLSERVER,
        /// CTSDB,
        /// SCF
        /// 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// ckafka配置，Type为KAFKA时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaParam")]
        public KafkaParam KafkaParam{ get; set; }

        /// <summary>
        /// EB配置，Type为EB时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventBusParam")]
        public EventBusParam EventBusParam{ get; set; }

        /// <summary>
        /// MongoDB配置，Type为MONGODB时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MongoDBParam")]
        public MongoDBParam MongoDBParam{ get; set; }

        /// <summary>
        /// Es配置，Type为ES时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsParam")]
        public EsParam EsParam{ get; set; }

        /// <summary>
        /// Tdw配置，Type为TDW时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TdwParam")]
        public TdwParam TdwParam{ get; set; }

        /// <summary>
        /// Dts配置，Type为DTS时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DtsParam")]
        public DtsParam DtsParam{ get; set; }

        /// <summary>
        /// ClickHouse配置，Type为CLICKHOUSE时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClickHouseParam")]
        public ClickHouseParam ClickHouseParam{ get; set; }

        /// <summary>
        /// Cls配置，Type为CLS时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClsParam")]
        public ClsParam ClsParam{ get; set; }

        /// <summary>
        /// Cos配置，Type为COS时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosParam")]
        public CosParam CosParam{ get; set; }

        /// <summary>
        /// MySQL配置，Type为MYSQL时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MySQLParam")]
        public MySQLParam MySQLParam{ get; set; }

        /// <summary>
        /// PostgreSQL配置，Type为POSTGRESQL或TDSQL_C_POSTGRESQL时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostgreSQLParam")]
        public PostgreSQLParam PostgreSQLParam{ get; set; }

        /// <summary>
        /// Topic配置，Type为Topic时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicParam")]
        public TopicParam TopicParam{ get; set; }

        /// <summary>
        /// MariaDB配置，Type为MARIADB时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MariaDBParam")]
        public MariaDBParam MariaDBParam{ get; set; }

        /// <summary>
        /// SQLServer配置，Type为SQLSERVER时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SQLServerParam")]
        public SQLServerParam SQLServerParam{ get; set; }

        /// <summary>
        /// Ctsdb配置，Type为CTSDB时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CtsdbParam")]
        public CtsdbParam CtsdbParam{ get; set; }

        /// <summary>
        /// Scf配置，Type为SCF时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScfParam")]
        public ScfParam ScfParam{ get; set; }

        /// <summary>
        /// MQTT配置，Type为 MQTT 时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MqttParam")]
        public MqttParam MqttParam{ get; set; }


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
        }
    }
}

