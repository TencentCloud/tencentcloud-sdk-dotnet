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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MySQLParam : AbstractModel
    {
        
        /// <summary>
        /// MySQL的数据库名称，"*"为全数据库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// MySQL的数据表名称，"*"为所监听的所有数据库中的非系统表，可以","间隔，监听多个数据表，但数据表需要以"数据库名.数据表名"的格式进行填写，需要填入正则表达式时，格式为"数据库名\\.数据表名"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 该MySQL在连接管理内的Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// 复制存量信息(schema_only不复制, initial全量)，默认位initial
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotMode")]
        public string SnapshotMode{ get; set; }

        /// <summary>
        /// 存放MySQL的Ddl信息的Topic，为空则默认不存放
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DdlTopic")]
        public string DdlTopic{ get; set; }

        /// <summary>
        /// "TABLE" 表示读取项为 table，"QUERY" 表示读取项为 query
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceMonitorMode")]
        public string DataSourceMonitorMode{ get; set; }

        /// <summary>
        /// 当 "DataMonitorMode"="TABLE" 时，传入需要读取的 Table；当 "DataMonitorMode"="QUERY" 时，传入需要读取的查询 sql 语句
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceMonitorResource")]
        public string DataSourceMonitorResource{ get; set; }

        /// <summary>
        /// "TIMESTAMP" 表示增量列为时间戳类型，"INCREMENT" 表示增量列为自增 id 类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceIncrementMode")]
        public string DataSourceIncrementMode{ get; set; }

        /// <summary>
        /// 传入需要监听的列名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceIncrementColumn")]
        public string DataSourceIncrementColumn{ get; set; }

        /// <summary>
        /// "HEAD" 表示复制存量 + 增量数据，"TAIL" 表示只复制增量数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceStartFrom")]
        public string DataSourceStartFrom{ get; set; }

        /// <summary>
        /// "INSERT" 表示使用 Insert 模式插入，"UPSERT" 表示使用 Upsert 模式插入
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataTargetInsertMode")]
        public string DataTargetInsertMode{ get; set; }

        /// <summary>
        /// 当 "DataInsertMode"="UPSERT" 时，传入当前 upsert 时依赖的主键
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataTargetPrimaryKeyField")]
        public string DataTargetPrimaryKeyField{ get; set; }

        /// <summary>
        /// 表与消息间的映射关系
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataTargetRecordMapping")]
        public RecordMapping[] DataTargetRecordMapping{ get; set; }

        /// <summary>
        /// 事件路由到特定主题的正则表达式，默认为(.*)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicRegex")]
        public string TopicRegex{ get; set; }

        /// <summary>
        /// TopicRegex的引用组，指定$1、$2等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicReplacement")]
        public string TopicReplacement{ get; set; }

        /// <summary>
        /// 格式：库1.表1:字段1,字段2;库2.表2:字段2，表之间;（分号）隔开，字段之间,（逗号）隔开。不指定的表默认取表的主键
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyColumns")]
        public string KeyColumns{ get; set; }

        /// <summary>
        /// Mysql 是否抛弃解析失败的消息，默认为true
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DropInvalidMessage")]
        public bool? DropInvalidMessage{ get; set; }

        /// <summary>
        /// 当设置成员参数DropInvalidMessageToCls设置为true时,DropInvalidMessage参数失效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DropCls")]
        public DropCls DropCls{ get; set; }

        /// <summary>
        /// 输出格式，DEFAULT、CANAL_1、CANAL_2
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }

        /// <summary>
        /// 当Table输入的是前缀时，该项值为true，否则为false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsTablePrefix")]
        public bool? IsTablePrefix{ get; set; }

        /// <summary>
        /// 如果该值为all，则DDL数据以及DML数据也会写入到选中的topic；若该值为dml，则只有DML数据写入到选中的topic
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncludeContentChanges")]
        public string IncludeContentChanges{ get; set; }

        /// <summary>
        /// 如果该值为true，且MySQL中"binlog_rows_query_log_events"配置项的值为"ON"，则流入到topic的数据包含原SQL语句；若该值为false，流入到topic的数据不包含原SQL语句
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncludeQuery")]
        public bool? IncludeQuery{ get; set; }

        /// <summary>
        /// 如果该值为 true，则消息中会携带消息结构体对应的schema，如果该值为false则不会携带
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordWithSchema")]
        public bool? RecordWithSchema{ get; set; }

        /// <summary>
        /// 存放信令表的数据库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignalDatabase")]
        public string SignalDatabase{ get; set; }

        /// <summary>
        /// 输入的table是否为正则表达式，如果该选项以及IsTablePrefix同时为true，该选项的判断优先级高于IsTablePrefix
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsTableRegular")]
        public bool? IsTableRegular{ get; set; }

        /// <summary>
        /// 信号表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignalTable")]
        public string SignalTable{ get; set; }

        /// <summary>
        /// datetime 类型字段转换为时间戳的时区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DateTimeZone")]
        public string DateTimeZone{ get; set; }

        /// <summary>
        /// 自建
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfBuilt")]
        public bool? SelfBuilt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "SnapshotMode", this.SnapshotMode);
            this.SetParamSimple(map, prefix + "DdlTopic", this.DdlTopic);
            this.SetParamSimple(map, prefix + "DataSourceMonitorMode", this.DataSourceMonitorMode);
            this.SetParamSimple(map, prefix + "DataSourceMonitorResource", this.DataSourceMonitorResource);
            this.SetParamSimple(map, prefix + "DataSourceIncrementMode", this.DataSourceIncrementMode);
            this.SetParamSimple(map, prefix + "DataSourceIncrementColumn", this.DataSourceIncrementColumn);
            this.SetParamSimple(map, prefix + "DataSourceStartFrom", this.DataSourceStartFrom);
            this.SetParamSimple(map, prefix + "DataTargetInsertMode", this.DataTargetInsertMode);
            this.SetParamSimple(map, prefix + "DataTargetPrimaryKeyField", this.DataTargetPrimaryKeyField);
            this.SetParamArrayObj(map, prefix + "DataTargetRecordMapping.", this.DataTargetRecordMapping);
            this.SetParamSimple(map, prefix + "TopicRegex", this.TopicRegex);
            this.SetParamSimple(map, prefix + "TopicReplacement", this.TopicReplacement);
            this.SetParamSimple(map, prefix + "KeyColumns", this.KeyColumns);
            this.SetParamSimple(map, prefix + "DropInvalidMessage", this.DropInvalidMessage);
            this.SetParamObj(map, prefix + "DropCls.", this.DropCls);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "IsTablePrefix", this.IsTablePrefix);
            this.SetParamSimple(map, prefix + "IncludeContentChanges", this.IncludeContentChanges);
            this.SetParamSimple(map, prefix + "IncludeQuery", this.IncludeQuery);
            this.SetParamSimple(map, prefix + "RecordWithSchema", this.RecordWithSchema);
            this.SetParamSimple(map, prefix + "SignalDatabase", this.SignalDatabase);
            this.SetParamSimple(map, prefix + "IsTableRegular", this.IsTableRegular);
            this.SetParamSimple(map, prefix + "SignalTable", this.SignalTable);
            this.SetParamSimple(map, prefix + "DateTimeZone", this.DateTimeZone);
            this.SetParamSimple(map, prefix + "SelfBuilt", this.SelfBuilt);
        }
    }
}

