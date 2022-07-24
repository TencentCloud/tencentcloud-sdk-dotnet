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
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// MySQL的数据表名称，"*"为所监听的所有数据库中的非系统表，可以","间隔，监听多个数据表，但数据表需要以"数据库名.数据表名"的格式进行填写
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 该MySQL在连接管理内的Id
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// 复制存量信息(schema_only不复制, initial全量)，默认位initial
        /// </summary>
        [JsonProperty("SnapshotMode")]
        public string SnapshotMode{ get; set; }

        /// <summary>
        /// 存放MySQL的Ddl信息的Topic，为空则默认不存放
        /// </summary>
        [JsonProperty("DdlTopic")]
        public string DdlTopic{ get; set; }

        /// <summary>
        /// "TABLE" 表示读取项为 table，"QUERY" 表示读取项为 query
        /// </summary>
        [JsonProperty("DataSourceMonitorMode")]
        public string DataSourceMonitorMode{ get; set; }

        /// <summary>
        /// 当 "DataMonitorMode"="TABLE" 时，传入需要读取的 Table；当 "DataMonitorMode"="QUERY" 时，传入需要读取的查询 sql 语句
        /// </summary>
        [JsonProperty("DataSourceMonitorResource")]
        public string DataSourceMonitorResource{ get; set; }

        /// <summary>
        /// "TIMESTAMP" 表示增量列为时间戳类型，"INCREMENT" 表示增量列为自增 id 类型
        /// </summary>
        [JsonProperty("DataSourceIncrementMode")]
        public string DataSourceIncrementMode{ get; set; }

        /// <summary>
        /// 传入需要监听的列名称
        /// </summary>
        [JsonProperty("DataSourceIncrementColumn")]
        public string DataSourceIncrementColumn{ get; set; }

        /// <summary>
        /// "HEAD" 表示复制存量 + 增量数据，"TAIL" 表示只复制增量数据
        /// </summary>
        [JsonProperty("DataSourceStartFrom")]
        public string DataSourceStartFrom{ get; set; }

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
        }
    }
}

