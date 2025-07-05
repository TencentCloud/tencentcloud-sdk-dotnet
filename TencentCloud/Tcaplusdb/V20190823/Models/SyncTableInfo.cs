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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncTableInfo : AbstractModel
    {
        
        /// <summary>
        /// 目标缓写表的分表数目
        /// </summary>
        [JsonProperty("TargetTableSplitNum")]
        public ulong? TargetTableSplitNum{ get; set; }

        /// <summary>
        /// 目标缓写表名前缀
        /// </summary>
        [JsonProperty("TargetTableNamePrefix")]
        public string[] TargetTableNamePrefix{ get; set; }

        /// <summary>
        /// 缓写数据库实例ID
        /// </summary>
        [JsonProperty("TargetSyncDBInstanceId")]
        public string TargetSyncDBInstanceId{ get; set; }

        /// <summary>
        /// 缓写表所在数据库名称
        /// </summary>
        [JsonProperty("TargetDatabaseName")]
        public string TargetDatabaseName{ get; set; }

        /// <summary>
        /// 缓写状态，0：创建中，1：进行中，2：关闭，-1：被删除
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 表格所在集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 表格所在表格组ID
        /// </summary>
        [JsonProperty("TableGroupId")]
        public ulong? TableGroupId{ get; set; }

        /// <summary>
        /// 表格名称
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 表格ID
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// TcaplusDB表主键字段到目标缓写表字段的映射
        /// </summary>
        [JsonProperty("KeyFieldMapping")]
        public SyncTableField[] KeyFieldMapping{ get; set; }

        /// <summary>
        /// TcaplusDB表字段到目标缓写表字段的映射
        /// </summary>
        [JsonProperty("ValueFieldMapping")]
        public SyncTableField[] ValueFieldMapping{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetTableSplitNum", this.TargetTableSplitNum);
            this.SetParamArraySimple(map, prefix + "TargetTableNamePrefix.", this.TargetTableNamePrefix);
            this.SetParamSimple(map, prefix + "TargetSyncDBInstanceId", this.TargetSyncDBInstanceId);
            this.SetParamSimple(map, prefix + "TargetDatabaseName", this.TargetDatabaseName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamArrayObj(map, prefix + "KeyFieldMapping.", this.KeyFieldMapping);
            this.SetParamArrayObj(map, prefix + "ValueFieldMapping.", this.ValueFieldMapping);
        }
    }
}

