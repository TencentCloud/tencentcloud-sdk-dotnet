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

    public class BlockingChainNode : AbstractModel
    {
        
        /// <summary>
        /// <p>被阻塞会话 ID（对应 SQL Server sys.dm_exec_sessions.session_id，即 SPID）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedSessionId")]
        public long? BlockedSessionId{ get; set; }

        /// <summary>
        /// <p>被阻塞会话事务ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedTransactionId")]
        public long? BlockedTransactionId{ get; set; }

        /// <summary>
        /// <p>被阻塞会话等待时长（毫秒）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedWaitTimeMs")]
        public long? BlockedWaitTimeMs{ get; set; }

        /// <summary>
        /// <p>被阻塞会话正在等待的锁模式（SQL Server原生lock_mode枚举，常见取值：S、U、X、IS、IU、IX、SIU、SIX、UIX、Sch-S、Sch-M）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedLockMode")]
        public string BlockedLockMode{ get; set; }

        /// <summary>
        /// <p>被阻塞会话等待资源。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedWaitResource")]
        public string BlockedWaitResource{ get; set; }

        /// <summary>
        /// <p>被阻塞会话数据库用户。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedLoginName")]
        public string BlockedLoginName{ get; set; }

        /// <summary>
        /// <p>被阻塞会话客户端主机。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedHostName")]
        public string BlockedHostName{ get; set; }

        /// <summary>
        /// <p>被阻塞会话客户端应用名。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedClientApp")]
        public string BlockedClientApp{ get; set; }

        /// <summary>
        /// <p>被阻塞会话运行时状态（SQL Server sys.dm_exec_sessions.status 文本），常见取值：running / sleeping / suspended / background。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedStatus")]
        public string BlockedStatus{ get; set; }

        /// <summary>
        /// <p>被阻塞会话事务隔离级别（SQL Server 原生取值：read uncommitted / read committed / repeatable read / serializable / snapshot）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedIsolationLevel")]
        public string BlockedIsolationLevel{ get; set; }

        /// <summary>
        /// <p>被阻塞会话当前显式事务名（XEvent transactionname）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedTransactionName")]
        public string BlockedTransactionName{ get; set; }

        /// <summary>
        /// <p>被阻塞会话当前显式事务嵌套层数（XEvent trancount）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedTranCount")]
        public long? BlockedTranCount{ get; set; }

        /// <summary>
        /// <p>被阻塞会话显式事务 BEGIN TRAN 时刻（XEvent lasttranstarted，SQL Server 服务端本地时区的 ISO 8601 字符串，无时区后缀）。多语句事务场景下比 lastbatchstarted 更稳定。咨视值 1900-01-01T00:00:00 表示未知。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedLastTranStarted")]
        public string BlockedLastTranStarted{ get; set; }

        /// <summary>
        /// <p>被阻塞会话正在执行的 SQL 原文（对应 DBCC INPUTBUFFER 返回内容，单条最长 16KB，超长截断）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedInputBuffer")]
        public string BlockedInputBuffer{ get; set; }

        /// <summary>
        /// <p>被阻塞SQL归一化模板。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedSqlTemplate")]
        public string BlockedSqlTemplate{ get; set; }

        /// <summary>
        /// <p>被阻塞SQL模板MD5。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedSqlMd5")]
        public string BlockedSqlMd5{ get; set; }

        /// <summary>
        /// <p>根因分类（继承自所属报告的rootCause）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RootCause")]
        public string RootCause{ get; set; }

        /// <summary>
        /// <p>本节点上报事件时间（__time），格式：yyyy-MM-dd HH:mm:ss。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportTime")]
        public string ReportTime{ get; set; }

        /// <summary>
        /// <p>本节点又阻塞的下级会话（可能为空）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Children")]
        public BlockingChainNode[] Children{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlockedSessionId", this.BlockedSessionId);
            this.SetParamSimple(map, prefix + "BlockedTransactionId", this.BlockedTransactionId);
            this.SetParamSimple(map, prefix + "BlockedWaitTimeMs", this.BlockedWaitTimeMs);
            this.SetParamSimple(map, prefix + "BlockedLockMode", this.BlockedLockMode);
            this.SetParamSimple(map, prefix + "BlockedWaitResource", this.BlockedWaitResource);
            this.SetParamSimple(map, prefix + "BlockedLoginName", this.BlockedLoginName);
            this.SetParamSimple(map, prefix + "BlockedHostName", this.BlockedHostName);
            this.SetParamSimple(map, prefix + "BlockedClientApp", this.BlockedClientApp);
            this.SetParamSimple(map, prefix + "BlockedStatus", this.BlockedStatus);
            this.SetParamSimple(map, prefix + "BlockedIsolationLevel", this.BlockedIsolationLevel);
            this.SetParamSimple(map, prefix + "BlockedTransactionName", this.BlockedTransactionName);
            this.SetParamSimple(map, prefix + "BlockedTranCount", this.BlockedTranCount);
            this.SetParamSimple(map, prefix + "BlockedLastTranStarted", this.BlockedLastTranStarted);
            this.SetParamSimple(map, prefix + "BlockedInputBuffer", this.BlockedInputBuffer);
            this.SetParamSimple(map, prefix + "BlockedSqlTemplate", this.BlockedSqlTemplate);
            this.SetParamSimple(map, prefix + "BlockedSqlMd5", this.BlockedSqlMd5);
            this.SetParamSimple(map, prefix + "RootCause", this.RootCause);
            this.SetParamSimple(map, prefix + "ReportTime", this.ReportTime);
            this.SetParamArrayObj(map, prefix + "Children.", this.Children);
        }
    }
}

