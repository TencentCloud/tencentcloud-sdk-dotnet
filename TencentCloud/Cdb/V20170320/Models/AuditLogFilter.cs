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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditLogFilter : AbstractModel
    {
        
        /// <summary>
        /// 客户端地址。
        /// </summary>
        [JsonProperty("Host")]
        public string[] Host{ get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("User")]
        public string[] User{ get; set; }

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("DBName")]
        public string[] DBName{ get; set; }

        /// <summary>
        /// 表名称。
        /// </summary>
        [JsonProperty("TableName")]
        public string[] TableName{ get; set; }

        /// <summary>
        /// 审计策略名称。
        /// </summary>
        [JsonProperty("PolicyName")]
        public string[] PolicyName{ get; set; }

        /// <summary>
        /// SQL 语句。支持模糊匹配。
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// SQL 类型。目前支持："SELECT", "INSERT", "UPDATE", "DELETE", "CREATE", "DROP", "ALTER", "SET", "REPLACE", "EXECUTE"。
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// 执行时间。单位为：ms。表示筛选执行时间大于该值的审计日志。
        /// </summary>
        [JsonProperty("ExecTime")]
        public long? ExecTime{ get; set; }

        /// <summary>
        /// 影响行数。表示筛选影响行数大于该值的审计日志。
        /// </summary>
        [JsonProperty("AffectRows")]
        public long? AffectRows{ get; set; }

        /// <summary>
        /// SQL 类型。支持多个类型同时查询。目前支持："SELECT", "INSERT", "UPDATE", "DELETE", "CREATE", "DROP", "ALTER", "SET", "REPLACE", "EXECUTE"。
        /// </summary>
        [JsonProperty("SqlTypes")]
        public string[] SqlTypes{ get; set; }

        /// <summary>
        /// SQL 语句。支持传递多个sql语句。
        /// </summary>
        [JsonProperty("Sqls")]
        public string[] Sqls{ get; set; }

        /// <summary>
        /// 影响行数，格式为M-N，例如：10-200
        /// </summary>
        [JsonProperty("AffectRowsSection")]
        public string AffectRowsSection{ get; set; }

        /// <summary>
        /// 返回行数，格式为M-N，例如：10-200
        /// </summary>
        [JsonProperty("SentRowsSection")]
        public string SentRowsSection{ get; set; }

        /// <summary>
        /// 执行时间，格式为M-N，例如：10-200
        /// </summary>
        [JsonProperty("ExecTimeSection")]
        public string ExecTimeSection{ get; set; }

        /// <summary>
        /// 锁等待时间，格式为M-N，例如：10-200
        /// </summary>
        [JsonProperty("LockWaitTimeSection")]
        public string LockWaitTimeSection{ get; set; }

        /// <summary>
        /// IO等待时间，格式为M-N，例如：10-200
        /// </summary>
        [JsonProperty("IoWaitTimeSection")]
        public string IoWaitTimeSection{ get; set; }

        /// <summary>
        /// 事务持续时间，格式为M-N，例如：10-200
        /// </summary>
        [JsonProperty("TransactionLivingTimeSection")]
        public string TransactionLivingTimeSection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Host.", this.Host);
            this.SetParamArraySimple(map, prefix + "User.", this.User);
            this.SetParamArraySimple(map, prefix + "DBName.", this.DBName);
            this.SetParamArraySimple(map, prefix + "TableName.", this.TableName);
            this.SetParamArraySimple(map, prefix + "PolicyName.", this.PolicyName);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamArraySimple(map, prefix + "SqlTypes.", this.SqlTypes);
            this.SetParamArraySimple(map, prefix + "Sqls.", this.Sqls);
            this.SetParamSimple(map, prefix + "AffectRowsSection", this.AffectRowsSection);
            this.SetParamSimple(map, prefix + "SentRowsSection", this.SentRowsSection);
            this.SetParamSimple(map, prefix + "ExecTimeSection", this.ExecTimeSection);
            this.SetParamSimple(map, prefix + "LockWaitTimeSection", this.LockWaitTimeSection);
            this.SetParamSimple(map, prefix + "IoWaitTimeSection", this.IoWaitTimeSection);
            this.SetParamSimple(map, prefix + "TransactionLivingTimeSection", this.TransactionLivingTimeSection);
        }
    }
}

