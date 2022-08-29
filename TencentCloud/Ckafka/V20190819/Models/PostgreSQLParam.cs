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

    public class PostgreSQLParam : AbstractModel
    {
        
        /// <summary>
        /// PostgreSQL的数据库名称
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// PostgreSQL的数据表名称，"*"为所监听的所有数据库中的非系统表，可以","间隔，监听多个数据表，但数据表需要以"数据库名.数据表名"的格式进行填写
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 该PostgreSQL在连接管理内的Id
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// 插件名(decoderbufs/pgoutput)，默认为decoderbufs
        /// </summary>
        [JsonProperty("PluginName")]
        public string PluginName{ get; set; }

        /// <summary>
        /// 复制存量信息(never增量, initial全量)，默认为initial
        /// </summary>
        [JsonProperty("SnapshotMode")]
        public string SnapshotMode{ get; set; }

        /// <summary>
        /// 上游数据格式(JSON/Debezium), 当数据库同步模式为默认字段匹配时,必填
        /// </summary>
        [JsonProperty("DataFormat")]
        public string DataFormat{ get; set; }

        /// <summary>
        /// "INSERT" 表示使用 Insert 模式插入，"UPSERT" 表示使用 Upsert 模式插入
        /// </summary>
        [JsonProperty("DataTargetInsertMode")]
        public string DataTargetInsertMode{ get; set; }

        /// <summary>
        /// 当 "DataInsertMode"="UPSERT" 时，传入当前 upsert 时依赖的主键
        /// </summary>
        [JsonProperty("DataTargetPrimaryKeyField")]
        public string DataTargetPrimaryKeyField{ get; set; }

        /// <summary>
        /// 表与消息间的映射关系
        /// </summary>
        [JsonProperty("DataTargetRecordMapping")]
        public RecordMapping[] DataTargetRecordMapping{ get; set; }

        /// <summary>
        /// 是否抛弃解析失败的消息，默认为true
        /// </summary>
        [JsonProperty("DropInvalidMessage")]
        public bool? DropInvalidMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "PluginName", this.PluginName);
            this.SetParamSimple(map, prefix + "SnapshotMode", this.SnapshotMode);
            this.SetParamSimple(map, prefix + "DataFormat", this.DataFormat);
            this.SetParamSimple(map, prefix + "DataTargetInsertMode", this.DataTargetInsertMode);
            this.SetParamSimple(map, prefix + "DataTargetPrimaryKeyField", this.DataTargetPrimaryKeyField);
            this.SetParamArrayObj(map, prefix + "DataTargetRecordMapping.", this.DataTargetRecordMapping);
            this.SetParamSimple(map, prefix + "DropInvalidMessage", this.DropInvalidMessage);
        }
    }
}

