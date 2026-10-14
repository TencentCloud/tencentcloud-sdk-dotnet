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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditProxyLogItem : AbstractModel
    {
        
        /// <summary>
        /// <p>SQL 执行时间点（格式化字符串，yyyy-MM-dd HH:mm:ss）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// <p>集群 ID（dcdb/mariadb 集群标识，与 InstanceId 相同）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>影响行数。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AffectRows")]
        public long? AffectRows{ get; set; }

        /// <summary>
        /// <p>是否自动提交。1 表示开启，0 表示关闭。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Autocommit")]
        public string Autocommit{ get; set; }

        /// <summary>
        /// <p>MySQL 网络协议命令类型（如 COM_QUERY、COM_CONNECT 等）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComType")]
        public string ComType{ get; set; }

        /// <summary>
        /// <p>新建连接耗时。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnTc")]
        public long? ConnTc{ get; set; }

        /// <summary>
        /// <p>后端 DB 实例地址（多个用英文逗号分隔）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DBHost")]
        public string DBHost{ get; set; }

        /// <summary>
        /// <p>SQL 执行所在的数据库名。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DBName")]
        public string DBName{ get; set; }

        /// <summary>
        /// <p>SQL 执行返回的错误码，0 表示成功。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// <p>错误信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrInfo")]
        public string ErrInfo{ get; set; }

        /// <summary>
        /// <p>SQL 执行耗时（微秒）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecTime")]
        public long? ExecTime{ get; set; }

        /// <summary>
        /// <p>请求结束后仍占用的连接数（非事务请求通常为 0）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HoldConns")]
        public string HoldConns{ get; set; }

        /// <summary>
        /// <p>客户端来源 IP。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>是否开启全局一致性读（0 否、1 是）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mc")]
        public string Mc{ get; set; }

        /// <summary>
        /// <p>SQL 开始时间（微秒精度中的微秒部分）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlStartTimeUs")]
        public long? SqlStartTimeUs{ get; set; }

        /// <summary>
        /// <p>本次请求新建的连接数。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewConnNum")]
        public long? NewConnNum{ get; set; }

        /// <summary>
        /// <p>Proxy 代理节点地址。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyHost")]
        public string ProxyHost{ get; set; }

        /// <summary>
        /// <p>Proxy ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// <p>查询 ID（用于关联查询）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryId")]
        public string QueryId{ get; set; }

        /// <summary>
        /// <p>返回行数（扫描结果集行数）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SentRows")]
        public long? SentRows{ get; set; }

        /// <summary>
        /// <p>是否为 Proxy 改写后的查询：0 原始查询，1 改写后查询。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Splited")]
        public long? Splited{ get; set; }

        /// <summary>
        /// <p>执行的 SQL 语句原文。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// <p>SQL 模板。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlTemplate")]
        public string SqlTemplate{ get; set; }

        /// <summary>
        /// <p>SQL 模板 ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlTemplateId")]
        public string SqlTemplateId{ get; set; }

        /// <summary>
        /// <p>SQL 类型（如 Select、Insert、Create、Login、Set 等）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// <p>涉及的表（多表以英文逗号分隔）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tables")]
        public string Tables{ get; set; }

        /// <summary>
        /// <p>线程 ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThreadId")]
        public string ThreadId{ get; set; }

        /// <summary>
        /// <p>SQL 开始时间（毫秒级时间戳）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlStartTime")]
        public long? SqlStartTime{ get; set; }

        /// <summary>
        /// <p>执行 SQL 的数据库用户名。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// <p>客户端连接的 HostPort。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostPort")]
        public string HostPort{ get; set; }

        /// <summary>
        /// <p>Proxy 节点处理线程 ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyThread")]
        public string ProxyThread{ get; set; }

        /// <summary>
        /// <p>后端 DB Host 数量。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbHostNum")]
        public string DbHostNum{ get; set; }

        /// <summary>
        /// <p>业务码（由业务侧 SQL 注释中 i/o/p 等 KV 提取）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// <p>业务标签（根据业务码后置补齐）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessTag")]
        public string BusinessTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamSimple(map, prefix + "Autocommit", this.Autocommit);
            this.SetParamSimple(map, prefix + "ComType", this.ComType);
            this.SetParamSimple(map, prefix + "ConnTc", this.ConnTc);
            this.SetParamSimple(map, prefix + "DBHost", this.DBHost);
            this.SetParamSimple(map, prefix + "DBName", this.DBName);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrInfo", this.ErrInfo);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "HoldConns", this.HoldConns);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Mc", this.Mc);
            this.SetParamSimple(map, prefix + "SqlStartTimeUs", this.SqlStartTimeUs);
            this.SetParamSimple(map, prefix + "NewConnNum", this.NewConnNum);
            this.SetParamSimple(map, prefix + "ProxyHost", this.ProxyHost);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "QueryId", this.QueryId);
            this.SetParamSimple(map, prefix + "SentRows", this.SentRows);
            this.SetParamSimple(map, prefix + "Splited", this.Splited);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "SqlTemplate", this.SqlTemplate);
            this.SetParamSimple(map, prefix + "SqlTemplateId", this.SqlTemplateId);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "Tables", this.Tables);
            this.SetParamSimple(map, prefix + "ThreadId", this.ThreadId);
            this.SetParamSimple(map, prefix + "SqlStartTime", this.SqlStartTime);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "HostPort", this.HostPort);
            this.SetParamSimple(map, prefix + "ProxyThread", this.ProxyThread);
            this.SetParamSimple(map, prefix + "DbHostNum", this.DbHostNum);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessTag", this.BusinessTag);
        }
    }
}

