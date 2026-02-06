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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableMappingObject : AbstractModel
    {
        
        /// <summary>
        /// 源端实例Id
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 映射数据库名称
        /// </summary>
        [JsonProperty("MapDatabaseName")]
        public string MapDatabaseName{ get; set; }

        /// <summary>
        /// 映射表名
        /// </summary>
        [JsonProperty("MapTableName")]
        public string MapTableName{ get; set; }

        /// <summary>
        /// 同步状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 同步进度
        /// </summary>
        [JsonProperty("Process")]
        public float? Process{ get; set; }

        /// <summary>
        /// 延迟
        /// </summary>
        [JsonProperty("Lag")]
        public long? Lag{ get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 是否为主表
        /// </summary>
        [JsonProperty("IsPrimary")]
        public bool? IsPrimary{ get; set; }

        /// <summary>
        /// 虚拟列填充值
        /// </summary>
        [JsonProperty("VirtualColValue")]
        public string VirtualColValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "MapDatabaseName", this.MapDatabaseName);
            this.SetParamSimple(map, prefix + "MapTableName", this.MapTableName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Process", this.Process);
            this.SetParamSimple(map, prefix + "Lag", this.Lag);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "IsPrimary", this.IsPrimary);
            this.SetParamSimple(map, prefix + "VirtualColValue", this.VirtualColValue);
        }
    }
}

