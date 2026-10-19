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

    public class BlockingLogItem : AbstractModel
    {
        
        /// <summary>
        /// <p>本条明细行上报时间（事件时间，__time；时区UTC+8），格式：yyyy-MM-dd HH:mm:ss。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportTime")]
        public string ReportTime{ get; set; }

        /// <summary>
        /// <p>监控轮次ID（同一实例内唯一标识一次采集快照，可透传至DescribeBlockingLockTree下钻查看完整阻塞树）。文本承载数值。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorLoop")]
        public string MonitorLoop{ get; set; }

        /// <summary>
        /// <p>被阻塞方的等待时长（毫秒）。来源：Kafka顶层Fields.duration÷1000（微秒→毫秒），来自SQL Server内核XEvent事件的duration字段。与BlockedWaitTimeMs来源不同但通常非常接近（非严格相等，两者为同一事件的两个独立快照）；仅为OrderBy=durationMs排序别名保留。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DurationMs")]
        public long? DurationMs{ get; set; }

        /// <summary>
        /// <p>阻塞发生所在的数据库名称。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// <p>阻塞发生所在的数据库 ID（Fields.database_id，对应 SQL Server sys.databases.database_id）。可配合 DatabaseName 使用：ID 稳定、Name 易读；Name 在重命名场景下会变化，ID 则不会。采样为空时该字段不返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseId")]
        public long? DatabaseId{ get; set; }

        /// <summary>
        /// <p>阻塞锁资源归属的对象 ID（Fields.object_id，对应 SQL Server sys.objects.object_id）。标识具体的表/视图/存储过程等用户对象；可结合 sys.objects 元数据查询对象名。采样为空时该字段不返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectId")]
        public long? ObjectId{ get; set; }

        /// <summary>
        /// <p>阻塞锁资源归属的索引 ID（Fields.index_id，对应 SQL Server sys.indexes.index_id）。常见取值：0=堆（无聚集索引）、1=聚集索引、&gt;1=非聚集索引；&gt;250 通常为系统内部索引（如全文/XML/空间索引），诊断时按&quot;是否为用户索引&quot;判断即可。采样为空时该字段不返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexId")]
        public long? IndexId{ get; set; }

        /// <summary>
        /// <p>根因分类（与枚举BlockingRootCause一一对应）。取值：C1_LONG_QUERY=长查询正常运行阻塞；C2_SLEEPING_UNCOMMITTED=休眠会话且存在未提交事务；C3_CLIENT_NOT_FETCHING=客户端未取完结果行；C4_APP_DEADLOCK=应用层分布式死锁；C5_ROLLBACK=会话正在rollback；C6_ORPHAN_TRANSACTION=孤立事务；UNKNOWN=未识别。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RootCause")]
        public string RootCause{ get; set; }

        /// <summary>
        /// <p>根因分类的可读中文描述（服务端已完成中文化，前端可直接展示；与RootCause代号一一对应，例如C1_LONG_QUERY→&quot;长查询正常运行阻塞，考虑优化SQL/索引&quot;，未识别或空值统一返回&quot;未识别&quot;）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RootCauseDesc")]
        public string RootCauseDesc{ get; set; }

        /// <summary>
        /// <p>头阻塞会话 ID（对应 SQL Server sys.dm_exec_sessions.session_id，即 SPID）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingSessionId")]
        public long? BlockingSessionId{ get; set; }

        /// <summary>
        /// <p>头阻塞会话数据库用户。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingLoginName")]
        public string BlockingLoginName{ get; set; }

        /// <summary>
        /// <p>头阻塞会话客户端主机。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingHostName")]
        public string BlockingHostName{ get; set; }

        /// <summary>
        /// <p>头阻塞会话客户端应用名。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingClientApp")]
        public string BlockingClientApp{ get; set; }

        /// <summary>
        /// <p>头阻塞会话运行时状态（SQL Server sys.dm_exec_sessions.status文本），常见取值：running / sleeping / suspended / background。sleeping+trancount&gt;0是C2_SLEEPING_UNCOMMITTED（休眠会话持未提交事务）的直接证据。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingStatus")]
        public string BlockingStatus{ get; set; }

        /// <summary>
        /// <p>头阻塞会话事务隔离级别（SQL Server原生取值：read uncommitted / read committed / repeatable read / serializable / snapshot）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingIsolationLevel")]
        public string BlockingIsolationLevel{ get; set; }

        /// <summary>
        /// <p>头阻塞会话当前显式事务名（XEvent transactionname，如user_transaction / implicit_transaction）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingTransactionName")]
        public string BlockingTransactionName{ get; set; }

        /// <summary>
        /// <p>头阻塞会话当前显式事务嵌套层数（XEvent trancount）。&gt;0表示持有显式事务；与BlockingStatus=sleeping组合是C2_SLEEPING_UNCOMMITTED（休眠会话持未提交事务）的直接证据。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingTranCount")]
        public long? BlockingTranCount{ get; set; }

        /// <summary>
        /// <p>头阻塞会话显式事务BEGIN TRAN时刻（XEvent lasttranstarted，SQL Server服务端本地时区的ISO 8601字符串，无时区后缀）。该字段代表事务持锁开始时刻：ReportTime-BlockingLastTranStarted≈事务持锁时长，用于C1_LONG_QUERY / C6_ORPHAN_TRANSACTION根因复核；在多语句事务场景下比lastbatchstarted更稳定（不会被每个新batch刷新）。值为空表示XML未提供该属性（blocking-process侧常见）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingLastTranStarted")]
        public string BlockingLastTranStarted{ get; set; }

        /// <summary>
        /// <p>头阻塞会话正在执行的SQL原文（对应DBCC INPUTBUFFER返回内容，单条最长16KB，超长截断）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingInputBuffer")]
        public string BlockingInputBuffer{ get; set; }

        /// <summary>
        /// <p>头阻塞SQL归一化模板。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingSqlTemplate")]
        public string BlockingSqlTemplate{ get; set; }

        /// <summary>
        /// <p>头阻塞SQL模板MD5。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingSqlMd5")]
        public string BlockingSqlMd5{ get; set; }

        /// <summary>
        /// <p>头阻塞会话持有或请求的锁模式（SQL Server原生lock_mode枚举；blocker通常不处于等锁状态，该字段多为空）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingLockMode")]
        public string BlockingLockMode{ get; set; }

        /// <summary>
        /// <p>头阻塞会话自身的等待时长（毫秒）。多数场景为0。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingWaitTimeMs")]
        public long? BlockingWaitTimeMs{ get; set; }

        /// <summary>
        /// <p>被阻塞会话 ID（对应 SQL Server sys.dm_exec_sessions.session_id，即 SPID）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedSessionId")]
        public long? BlockedSessionId{ get; set; }

        /// <summary>
        /// <p>被阻塞会话事务ID（SQL Server transaction_id，bigint）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedTransactionId")]
        public long? BlockedTransactionId{ get; set; }

        /// <summary>
        /// <p>被阻塞会话等待时长（毫秒）。来源：XML &lt;blocked-process&gt;&lt;process waittime&gt;属性（来自ys.dm_os_waiting_tasks.wait_duration_ms在report生成瞬间的快照）。与DurationMs来源不同但通常非常接近；仅为OrderBy=blockedWaitTimeMs排序别名保留。</p>
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
        /// <p>被阻塞会话运行时状态（SQL Server sys.dm_exec_sessions.status文本），常见取值：running / sleeping / suspended / background。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedStatus")]
        public string BlockedStatus{ get; set; }

        /// <summary>
        /// <p>被阻塞会话事务隔离级别（SQL Server原生取值：read uncommitted / read committed / repeatable read / serializable / snapshot）。</p>
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
        /// <p>被阻塞会话显式事务BEGIN TRAN时刻（XEvent lasttranstarted，SQL Server服务端本地时区的ISO 8601字符串，无时区后缀）。该字段代表事务开始时刻，在多语句事务场景下比lastbatchstarted更稳定。咨视值1900-01-01T00:00:00表示未知。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedLastTranStarted")]
        public string BlockedLastTranStarted{ get; set; }

        /// <summary>
        /// <p>被阻塞会话正在执行的SQL原文（对应DBCC INPUTBUFFER返回内容，单条最长16KB，超长截断）。</p>
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
        /// <p>被阻塞方 blocked_process_report 原始 XML 文本（含完整执行计划、等待链、死锁明细等原始现场；字段体积较大，KB 级起步）。仅当请求参数 WithXml=true 时才返回；默认 false 时该字段省略，不出现在响应体中。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockedProcessXml")]
        public string BlockedProcessXml{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReportTime", this.ReportTime);
            this.SetParamSimple(map, prefix + "MonitorLoop", this.MonitorLoop);
            this.SetParamSimple(map, prefix + "DurationMs", this.DurationMs);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "IndexId", this.IndexId);
            this.SetParamSimple(map, prefix + "RootCause", this.RootCause);
            this.SetParamSimple(map, prefix + "RootCauseDesc", this.RootCauseDesc);
            this.SetParamSimple(map, prefix + "BlockingSessionId", this.BlockingSessionId);
            this.SetParamSimple(map, prefix + "BlockingLoginName", this.BlockingLoginName);
            this.SetParamSimple(map, prefix + "BlockingHostName", this.BlockingHostName);
            this.SetParamSimple(map, prefix + "BlockingClientApp", this.BlockingClientApp);
            this.SetParamSimple(map, prefix + "BlockingStatus", this.BlockingStatus);
            this.SetParamSimple(map, prefix + "BlockingIsolationLevel", this.BlockingIsolationLevel);
            this.SetParamSimple(map, prefix + "BlockingTransactionName", this.BlockingTransactionName);
            this.SetParamSimple(map, prefix + "BlockingTranCount", this.BlockingTranCount);
            this.SetParamSimple(map, prefix + "BlockingLastTranStarted", this.BlockingLastTranStarted);
            this.SetParamSimple(map, prefix + "BlockingInputBuffer", this.BlockingInputBuffer);
            this.SetParamSimple(map, prefix + "BlockingSqlTemplate", this.BlockingSqlTemplate);
            this.SetParamSimple(map, prefix + "BlockingSqlMd5", this.BlockingSqlMd5);
            this.SetParamSimple(map, prefix + "BlockingLockMode", this.BlockingLockMode);
            this.SetParamSimple(map, prefix + "BlockingWaitTimeMs", this.BlockingWaitTimeMs);
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
            this.SetParamSimple(map, prefix + "BlockedProcessXml", this.BlockedProcessXml);
        }
    }
}

