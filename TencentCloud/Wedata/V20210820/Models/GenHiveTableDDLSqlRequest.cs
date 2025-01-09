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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GenHiveTableDDLSqlRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 目标数据库
        /// </summary>
        [JsonProperty("SinkDatabase")]
        public string SinkDatabase{ get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 元数据类型(MYSQL、ORACLE)
        /// </summary>
        [JsonProperty("MsType")]
        public string MsType{ get; set; }

        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// 来源库名
        /// </summary>
        [JsonProperty("SourceDatabase")]
        public string SourceDatabase{ get; set; }

        /// <summary>
        /// 来源表名
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 目标表元数据类型(HIVE、GBASE)
        /// </summary>
        [JsonProperty("SinkType")]
        public string SinkType{ get; set; }

        /// <summary>
        /// 源端schema名称
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// 上游节点的字段信息
        /// </summary>
        [JsonProperty("SourceFieldInfoList")]
        public SourceFieldInfo[] SourceFieldInfoList{ get; set; }

        /// <summary>
        /// 分区字段
        /// </summary>
        [JsonProperty("Partitions")]
        public Partition[] Partitions{ get; set; }

        /// <summary>
        /// 建表属性
        /// </summary>
        [JsonProperty("Properties")]
        public Property[] Properties{ get; set; }

        /// <summary>
        /// 建表模式，0:向导模式，1:ddl
        /// </summary>
        [JsonProperty("TableMode")]
        public long? TableMode{ get; set; }

        /// <summary>
        /// DLC表版本，v1/v2
        /// </summary>
        [JsonProperty("TableVersion")]
        public string TableVersion{ get; set; }

        /// <summary>
        /// 是否upsert写入
        /// </summary>
        [JsonProperty("UpsertFlag")]
        public bool? UpsertFlag{ get; set; }

        /// <summary>
        /// 表描述信息
        /// </summary>
        [JsonProperty("TableComment")]
        public string TableComment{ get; set; }

        /// <summary>
        /// 增加的文件数量阈值, 超过值将触发小文件合并
        /// </summary>
        [JsonProperty("AddDataFiles")]
        public long? AddDataFiles{ get; set; }

        /// <summary>
        /// 增加的Equality delete数量阈值, 超过值将触发小文件合并
        /// </summary>
        [JsonProperty("AddEqualityDeletes")]
        public long? AddEqualityDeletes{ get; set; }

        /// <summary>
        /// 增加的Position delete数量阈值, 超过值将触发小文件合并
        /// </summary>
        [JsonProperty("AddPositionDeletes")]
        public long? AddPositionDeletes{ get; set; }

        /// <summary>
        /// 增加的delete file数量阈值
        /// </summary>
        [JsonProperty("AddDeleteFiles")]
        public long? AddDeleteFiles{ get; set; }

        /// <summary>
        /// 下游节点数据源ID
        /// </summary>
        [JsonProperty("TargetDatasourceId")]
        public string TargetDatasourceId{ get; set; }

        /// <summary>
        /// dlc upsert主键
        /// </summary>
        [JsonProperty("UpsertKeys")]
        public string[] UpsertKeys{ get; set; }

        /// <summary>
        /// dlc表治理信息
        /// </summary>
        [JsonProperty("TableBaseInfo")]
        public TableBaseInfo TableBaseInfo{ get; set; }

        /// <summary>
        /// 目标端schema名称
        /// </summary>
        [JsonProperty("SinkSchemaName")]
        public string SinkSchemaName{ get; set; }

        /// <summary>
        /// 获取源信息的环境
        /// </summary>
        [JsonProperty("Env")]
        public string Env{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "SinkDatabase", this.SinkDatabase);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "MsType", this.MsType);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "SourceDatabase", this.SourceDatabase);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "SinkType", this.SinkType);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamArrayObj(map, prefix + "SourceFieldInfoList.", this.SourceFieldInfoList);
            this.SetParamArrayObj(map, prefix + "Partitions.", this.Partitions);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamSimple(map, prefix + "TableMode", this.TableMode);
            this.SetParamSimple(map, prefix + "TableVersion", this.TableVersion);
            this.SetParamSimple(map, prefix + "UpsertFlag", this.UpsertFlag);
            this.SetParamSimple(map, prefix + "TableComment", this.TableComment);
            this.SetParamSimple(map, prefix + "AddDataFiles", this.AddDataFiles);
            this.SetParamSimple(map, prefix + "AddEqualityDeletes", this.AddEqualityDeletes);
            this.SetParamSimple(map, prefix + "AddPositionDeletes", this.AddPositionDeletes);
            this.SetParamSimple(map, prefix + "AddDeleteFiles", this.AddDeleteFiles);
            this.SetParamSimple(map, prefix + "TargetDatasourceId", this.TargetDatasourceId);
            this.SetParamArraySimple(map, prefix + "UpsertKeys.", this.UpsertKeys);
            this.SetParamObj(map, prefix + "TableBaseInfo.", this.TableBaseInfo);
            this.SetParamSimple(map, prefix + "SinkSchemaName", this.SinkSchemaName);
            this.SetParamSimple(map, prefix + "Env", this.Env);
        }
    }
}

