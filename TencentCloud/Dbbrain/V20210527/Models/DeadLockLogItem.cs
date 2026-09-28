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

    public class DeadLockLogItem : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID，例如 mssql-ks3s56dj。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>时间字段来源。XML_EVENT 表示时间来自 xml_deadlock_report 的引擎打点；OBSERVED_LOG 表示时间来自 chain/lock 观测记录（partial 事件）。</p>
        /// </summary>
        [JsonProperty("TimestampSource")]
        public string TimestampSource{ get; set; }

        /// <summary>
        /// <p>降级原因码。IsPartial=true 时值为 XML_NOT_AVAILABLE；否则为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartialReasonCode")]
        public string PartialReasonCode{ get; set; }

        /// <summary>
        /// <p>被回滚的进程内部指针列表，例如 process260256c7468。与 Resources.Owners/Waiters.ProcessId 对齐，可用于死锁环节点定位。</p>
        /// </summary>
        [JsonProperty("VictimProcessIds")]
        public string[] VictimProcessIds{ get; set; }

        /// <summary>
        /// <p>原始负载是否被上游截断。true 表示 XmlReport 或 chain/lock payload 有过截断，会影响诊断可信度。</p>
        /// </summary>
        [JsonProperty("PayloadTruncated")]
        public bool? PayloadTruncated{ get; set; }

        /// <summary>
        /// <p>组成本事件的所有 XEvent 原始消息 UUID 列表（去重后按字典序排序），用于多源溯源、审计、补数。</p>
        /// </summary>
        [JsonProperty("SourceUuids")]
        public string[] SourceUuids{ get; set; }

        /// <summary>
        /// <p>实际可归因（有 TransactionId）的事务数量。</p>
        /// </summary>
        [JsonProperty("ObservedTransactionCount")]
        public long? ObservedTransactionCount{ get; set; }

        /// <summary>
        /// <p>死锁发生时间。ISO-8601 带偏移格式，例如 2026-09-16T06:58:52.611+00:00。来源于 XEvent 原始 timestamp。</p>
        /// </summary>
        [JsonProperty("EventTimestamp")]
        public string EventTimestamp{ get; set; }

        /// <summary>
        /// <p>死锁图完整性。COMPLETE 表示成功装配 xml_deadlock_report；MISSING 表示无 xml 只有 chain/lock 消息（对应 IsPartial=true）。</p>
        /// </summary>
        [JsonProperty("GraphStatus")]
        public string GraphStatus{ get; set; }

        /// <summary>
        /// <p>本次响应中是否内联了原始死锁 XML。仅当请求参数 IncludeXml=true 且事件为 COMPLETE 时为 true。</p>
        /// </summary>
        [JsonProperty("XmlIncluded")]
        public bool? XmlIncluded{ get; set; }

        /// <summary>
        /// <p>参与死锁的进程总数。2 方死锁最常见，N 方死锁更严重。</p>
        /// </summary>
        [JsonProperty("ProcessCount")]
        public long? ProcessCount{ get; set; }

        /// <summary>
        /// <p>参与死锁的事务列表（按 IsVictim=true 排前、TransactionId 升序）。每个事务下可能有多个 Session（例如并行执行 worker）。</p>
        /// </summary>
        [JsonProperty("Transactions")]
        public DeadlockTransaction[] Transactions{ get; set; }

        /// <summary>
        /// <p>引擎内的死锁编号，例如 84。与 SQL Server 端 xml_deadlock_report 对齐。同实例短期内可辨识，重启后会复用。若上游数据缺失则为 null。</p>
        /// </summary>
        [JsonProperty("DeadlockId")]
        public string DeadlockId{ get; set; }

        /// <summary>
        /// <p>原始 SQL Server 死锁图 XML 字符串（xml_deadlock_report 输出）。IncludeXml=false 或事件为 partial 时为 null。可用于前端直接绘制死锁环、AI 深度诊断，或落到对象存储做冷归档。</p>
        /// </summary>
        [JsonProperty("XmlReport")]
        public string XmlReport{ get; set; }

        /// <summary>
        /// <p>原始 XML 字节数，用于采集侧健康度评估。partial 事件为 null。</p>
        /// </summary>
        [JsonProperty("OriginalXmlBytes")]
        public long? OriginalXmlBytes{ get; set; }

        /// <summary>
        /// <p>被 SQL Server 选中回滚的会话 SPID 列表（去重）。DBA 复盘定位牺牲者的核心字段。</p>
        /// </summary>
        [JsonProperty("VictimSessionIds")]
        public long?[] VictimSessionIds{ get; set; }

        /// <summary>
        /// <p>是否为降级 partial 事件。true 表示无 xml_deadlock_report，Transactions/Resources 只能从 chain/lock 消息尽力还原。AI 诊断前建议过滤 IsPartial=true 的记录。</p>
        /// </summary>
        [JsonProperty("IsPartial")]
        public bool? IsPartial{ get; set; }

        /// <summary>
        /// <p>涉及的数据库名去重列表，用于分库聚合与影响范围判断。</p>
        /// </summary>
        [JsonProperty("DatabaseNames")]
        public string[] DatabaseNames{ get; set; }

        /// <summary>
        /// <p>事件唯一 ID，格式为 xml:&lt;uuid&gt; 或 partial:&lt;uuid&gt;。前缀 xml 表示由 xml_deadlock_report 装配的完整事件；partial 表示只有 chain/lock 消息的降级事件。可作为幂等主键。</p>
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// <p>死锁事件级签名（SHA-1 前 16 位）。基于参与死锁的所有锁资源三元组 (Kind, ObjectName, IndexName, Mode) 排序后计算，用于聚合相同锁冲突模式的死锁模板。partial 事件无 Resources 时为 null。</p>
        /// </summary>
        [JsonProperty("DeadlockSignature")]
        public string DeadlockSignature{ get; set; }

        /// <summary>
        /// <p>死锁涉及的锁资源节点列表。每个资源节点有若干 Owners（持有边）与 Waiters（等待边），二者组合构成死锁环。partial 事件为空数组。</p>
        /// </summary>
        [JsonProperty("Resources")]
        public DeadlockResource[] Resources{ get; set; }

        /// <summary>
        /// <p>XE 辅助事件（chain/lock）与 XML 图的关联状态。MATCHED 表示至少一个 chain/lock 消息已关联到该 xml；UNMATCHED 表示只有孤立 xml 或降级 partial 事件。</p>
        /// </summary>
        [JsonProperty("AssociationStatus")]
        public string AssociationStatus{ get; set; }

        /// <summary>
        /// <p>参与死锁的事务总数（有 TransactionId 的会话按事务分组后的数量）。当存在无 TransactionId 的会话时为 null，通过 ObservedTransactionCount 与该字段的差值可以判断归因缺失情况。</p>
        /// </summary>
        [JsonProperty("TransactionCount")]
        public long? TransactionCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TimestampSource", this.TimestampSource);
            this.SetParamSimple(map, prefix + "PartialReasonCode", this.PartialReasonCode);
            this.SetParamArraySimple(map, prefix + "VictimProcessIds.", this.VictimProcessIds);
            this.SetParamSimple(map, prefix + "PayloadTruncated", this.PayloadTruncated);
            this.SetParamArraySimple(map, prefix + "SourceUuids.", this.SourceUuids);
            this.SetParamSimple(map, prefix + "ObservedTransactionCount", this.ObservedTransactionCount);
            this.SetParamSimple(map, prefix + "EventTimestamp", this.EventTimestamp);
            this.SetParamSimple(map, prefix + "GraphStatus", this.GraphStatus);
            this.SetParamSimple(map, prefix + "XmlIncluded", this.XmlIncluded);
            this.SetParamSimple(map, prefix + "ProcessCount", this.ProcessCount);
            this.SetParamArrayObj(map, prefix + "Transactions.", this.Transactions);
            this.SetParamSimple(map, prefix + "DeadlockId", this.DeadlockId);
            this.SetParamSimple(map, prefix + "XmlReport", this.XmlReport);
            this.SetParamSimple(map, prefix + "OriginalXmlBytes", this.OriginalXmlBytes);
            this.SetParamArraySimple(map, prefix + "VictimSessionIds.", this.VictimSessionIds);
            this.SetParamSimple(map, prefix + "IsPartial", this.IsPartial);
            this.SetParamArraySimple(map, prefix + "DatabaseNames.", this.DatabaseNames);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "DeadlockSignature", this.DeadlockSignature);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "AssociationStatus", this.AssociationStatus);
            this.SetParamSimple(map, prefix + "TransactionCount", this.TransactionCount);
        }
    }
}

