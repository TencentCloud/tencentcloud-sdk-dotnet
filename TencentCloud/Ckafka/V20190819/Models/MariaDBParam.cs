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

    public class MariaDBParam : AbstractModel
    {
        
        /// <summary>
        /// MariaDB的数据库名称，"*"为全数据库
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// MariaDB的数据表名称，"*"为所监听的所有数据库中的非系统表，可以","间隔，监听多个数据表，但数据表需要以"数据库名.数据表名"的格式进行填写
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 该MariaDB在连接管理内的Id
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// 复制存量信息(schema_only不复制, initial全量)，默认值initial
        /// </summary>
        [JsonProperty("SnapshotMode")]
        public string SnapshotMode{ get; set; }

        /// <summary>
        /// 格式：库1.表1:字段1,字段2;库2.表2:字段2，表之间;（分号）隔开，字段之间,（逗号）隔开。不指定的表默认取表的主键
        /// </summary>
        [JsonProperty("KeyColumns")]
        public string KeyColumns{ get; set; }

        /// <summary>
        /// 当Table输入的是前缀时，该项值为true，否则为false
        /// </summary>
        [JsonProperty("IsTablePrefix")]
        public bool? IsTablePrefix{ get; set; }

        /// <summary>
        /// 输出格式，DEFAULT、CANAL_1、CANAL_2
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }

        /// <summary>
        /// 如果该值为all，则DDL数据以及DML数据也会写入到选中的topic；若该值为dml，则只有DML数据写入到选中的topic
        /// </summary>
        [JsonProperty("IncludeContentChanges")]
        public string IncludeContentChanges{ get; set; }

        /// <summary>
        /// 如果该值为true，且MySQL中"binlog_rows_query_log_events"配置项的值为"ON"，则流入到topic的数据包含原SQL语句；若该值为false，流入到topic的数据不包含原SQL语句
        /// </summary>
        [JsonProperty("IncludeQuery")]
        public bool? IncludeQuery{ get; set; }

        /// <summary>
        /// 如果该值为 true，则消息中会携带消息结构体对应的schema，如果该值为false则不会携带
        /// </summary>
        [JsonProperty("RecordWithSchema")]
        public bool? RecordWithSchema{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "SnapshotMode", this.SnapshotMode);
            this.SetParamSimple(map, prefix + "KeyColumns", this.KeyColumns);
            this.SetParamSimple(map, prefix + "IsTablePrefix", this.IsTablePrefix);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "IncludeContentChanges", this.IncludeContentChanges);
            this.SetParamSimple(map, prefix + "IncludeQuery", this.IncludeQuery);
            this.SetParamSimple(map, prefix + "RecordWithSchema", this.RecordWithSchema);
        }
    }
}

