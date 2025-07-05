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

    public class TableGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 表格组ID
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// 表格组名称
        /// </summary>
        [JsonProperty("TableGroupName")]
        public string TableGroupName{ get; set; }

        /// <summary>
        /// 表格组创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 表格组包含的表格数量
        /// </summary>
        [JsonProperty("TableCount")]
        public ulong? TableCount{ get; set; }

        /// <summary>
        /// 表格组包含的表格存储总量（MB）
        /// </summary>
        [JsonProperty("TotalSize")]
        public ulong? TotalSize{ get; set; }

        /// <summary>
        /// 表格Txh备份文件多少天后过期删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TxhBackupExpireDay")]
        public ulong? TxhBackupExpireDay{ get; set; }

        /// <summary>
        /// 是否开启mysql负载均衡,0未开启 1开启中 2已开启
        /// </summary>
        [JsonProperty("EnableMysql")]
        public ulong? EnableMysql{ get; set; }

        /// <summary>
        /// mysql负载均衡vip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MysqlConnIp")]
        public string MysqlConnIp{ get; set; }

        /// <summary>
        /// mysql负载均衡vport
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MysqlConnPort")]
        public ulong? MysqlConnPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "TableGroupName", this.TableGroupName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "TableCount", this.TableCount);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
            this.SetParamSimple(map, prefix + "TxhBackupExpireDay", this.TxhBackupExpireDay);
            this.SetParamSimple(map, prefix + "EnableMysql", this.EnableMysql);
            this.SetParamSimple(map, prefix + "MysqlConnIp", this.MysqlConnIp);
            this.SetParamSimple(map, prefix + "MysqlConnPort", this.MysqlConnPort);
        }
    }
}

