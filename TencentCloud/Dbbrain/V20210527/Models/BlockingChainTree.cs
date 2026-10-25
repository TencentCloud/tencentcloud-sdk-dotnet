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

    public class BlockingChainTree : AbstractModel
    {
        
        /// <summary>
        /// <p>监控轮次ID（同一实例内唯一标识一次采集快照，同一快照可包含多棵独立阻塞树）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorLoop")]
        public string MonitorLoop{ get; set; }

        /// <summary>
        /// <p>阻塞发生所在的数据库名称（整条链路隶属同一 database，放在树级返回一次即可）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// <p>头阻塞会话ID（对应 SQL Server sys.dm_exec_sessions.session_id，即 SPID）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingSessionId")]
        public long? BlockingSessionId{ get; set; }

        /// <summary>
        /// <p>头阻塞会话事务ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingTransactionId")]
        public long? BlockingTransactionId{ get; set; }

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
        /// <p>头阻塞会话运行时状态（SQL Server sys.dm_exec_sessions.status 文本），常见取值：running / sleeping / suspended / background。sleeping + BlockingTranCount&gt;0 是 C2_SLEEPING_UNCOMMITTED（休眠会话持未提交事务）的直接证据。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingStatus")]
        public string BlockingStatus{ get; set; }

        /// <summary>
        /// <p>头阻塞会话事务隔离级别（SQL Server 原生取值：read uncommitted / read committed / repeatable read / serializable / snapshot）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingIsolationLevel")]
        public string BlockingIsolationLevel{ get; set; }

        /// <summary>
        /// <p>头阻塞会话当前显式事务嵌套层数（XEvent trancount）。&gt;0 表示持有显式事务；与 BlockingStatus=sleeping 组合是 C2_SLEEPING_UNCOMMITTED（休眠会话持未提交事务）的直接证据。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingTranCount")]
        public long? BlockingTranCount{ get; set; }

        /// <summary>
        /// <p>头阻塞会话正在执行的 SQL 原文（对应 DBCC INPUTBUFFER 返回内容，单条最长 16KB，超长截断）。</p>
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
        /// <p>头阻塞会话自身的等待时长（毫秒，来自XML blocking-process/process的waittime属性）。多数场景为0。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlockingWaitTimeMs")]
        public long? BlockingWaitTimeMs{ get; set; }

        /// <summary>
        /// <p>根因分类。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RootCause")]
        public string RootCause{ get; set; }

        /// <summary>
        /// <p>根因分类的可读中文描述（服务端已完成中文化，前端可直接展示；与 RootCause 代号一一对应；未识别或空值统一返回“未识别”）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RootCauseDesc")]
        public string RootCauseDesc{ get; set; }

        /// <summary>
        /// <p>该链路阻塞事件的起始时间（该树内__time最小值），格式：yyyy-MM-dd HH:mm:ss。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>该链路阻塞事件的结束时间（该树内__time最大值），格式：yyyy-MM-dd HH:mm:ss。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>该链路最长等待时长（毫秒），作为链路影响时长。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DurationMs")]
        public long? DurationMs{ get; set; }

        /// <summary>
        /// <p>该链路被阻塞会话数（等价于树节点数-1，即受影响会话数）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChainLength")]
        public long? ChainLength{ get; set; }

        /// <summary>
        /// <p>树深度（根节点为0，最长路径的深度）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChainDepth")]
        public long? ChainDepth{ get; set; }

        /// <summary>
        /// <p>被阻塞节点子树（可能为空，也可能多叉或多层）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Details")]
        public BlockingChainNode[] Details{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonitorLoop", this.MonitorLoop);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "BlockingSessionId", this.BlockingSessionId);
            this.SetParamSimple(map, prefix + "BlockingTransactionId", this.BlockingTransactionId);
            this.SetParamSimple(map, prefix + "BlockingLoginName", this.BlockingLoginName);
            this.SetParamSimple(map, prefix + "BlockingHostName", this.BlockingHostName);
            this.SetParamSimple(map, prefix + "BlockingClientApp", this.BlockingClientApp);
            this.SetParamSimple(map, prefix + "BlockingStatus", this.BlockingStatus);
            this.SetParamSimple(map, prefix + "BlockingIsolationLevel", this.BlockingIsolationLevel);
            this.SetParamSimple(map, prefix + "BlockingTranCount", this.BlockingTranCount);
            this.SetParamSimple(map, prefix + "BlockingInputBuffer", this.BlockingInputBuffer);
            this.SetParamSimple(map, prefix + "BlockingSqlTemplate", this.BlockingSqlTemplate);
            this.SetParamSimple(map, prefix + "BlockingSqlMd5", this.BlockingSqlMd5);
            this.SetParamSimple(map, prefix + "BlockingWaitTimeMs", this.BlockingWaitTimeMs);
            this.SetParamSimple(map, prefix + "RootCause", this.RootCause);
            this.SetParamSimple(map, prefix + "RootCauseDesc", this.RootCauseDesc);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DurationMs", this.DurationMs);
            this.SetParamSimple(map, prefix + "ChainLength", this.ChainLength);
            this.SetParamSimple(map, prefix + "ChainDepth", this.ChainDepth);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
        }
    }
}

