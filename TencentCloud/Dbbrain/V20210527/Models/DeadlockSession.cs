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

    public class DeadlockSession : AbstractModel
    {
        
        /// <summary>
        /// <p>SQL 归一化后的指纹（SHA-1 前 16 位）。去掉字面量、注释、参数名、空白差异后计算，抗字面量差异，用于聚合相同 SQL 模板。SqlText 为空时为 null。</p>
        /// </summary>
        [JsonProperty("SqlFingerprint")]
        public string SqlFingerprint{ get; set; }

        /// <summary>
        /// <p>SQL Server 登录账号，用于权限归因。可判断是 SQLAgent、业务账号还是 DBA 账号。</p>
        /// </summary>
        [JsonProperty("LoginName")]
        public string LoginName{ get; set; }

        /// <summary>
        /// <p>会话执行栈帧列表（xml 的 executionStack.frame），用于定位到存储过程内的具体语句区间。partial 事件为空数组。</p>
        /// </summary>
        [JsonProperty("Frames")]
        public DeadlockFrame[] Frames{ get; set; }

        /// <summary>
        /// <p>事务隔离级别，例如 &#39;read committed (2)&#39;、&#39;repeatable read (3)&#39;、&#39;serializable (4)&#39; 等。显著影响锁形态和死锁模式。</p>
        /// </summary>
        [JsonProperty("IsolationLevel")]
        public string IsolationLevel{ get; set; }

        /// <summary>
        /// <p>进程状态。常见值：suspended（挂起等锁）/ running / background。判断是否运行中被检测终止。</p>
        /// </summary>
        [JsonProperty("ProcessStatus")]
        public string ProcessStatus{ get; set; }

        /// <summary>
        /// <p>客户端应用名（xml 的 clientapp）。判断连接来源，例如 SQLAgent Job、ORM、SSMS、业务服务名等。</p>
        /// </summary>
        [JsonProperty("ClientApp")]
        public string ClientApp{ get; set; }

        /// <summary>
        /// <p>会话的 DEADLOCK_PRIORITY 设置。-10 表示主动降级为牺牲者候选；10 表示优先级更高。可解释为何这一方成为牺牲品。</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>会话当前活跃的数据库名（xml 的 currentdbname）。</p>
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// <p>本进程当前持有的锁资源描述列表（死锁环的持有边）。格式同 LockRequest 但结尾为 &#39;holding&#39;。partial 事件为空数组。</p>
        /// </summary>
        [JsonProperty("LockHold")]
        public string[] LockHold{ get; set; }

        /// <summary>
        /// <p>会话最近执行的 SQL 文本（xml 的 InputBuf）。是 AI 诊断的主输入与 SqlFingerprint 的来源。</p>
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// <p>客户端主机的 IP 地址（点分十进制，来自 message.ip）。判断是否来自同一台机器、批处理源。</p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>会话当前活跃的数据库 ID（xml 的 currentdb）。</p>
        /// </summary>
        [JsonProperty("DatabaseId")]
        public long? DatabaseId{ get; set; }

        /// <summary>
        /// <p>本事务是否为牺牲事务。true 表示 SQL Server 已回滚该事务；false 表示正常提交；null 表示 XML 缺 VictimProcessIds 无法判定。</p>
        /// </summary>
        [JsonProperty("IsVictim")]
        public bool? IsVictim{ get; set; }

        /// <summary>
        /// <p>等锁时长，单位毫秒。判断死锁检测延迟、事务超时的辅助指标。</p>
        /// </summary>
        [JsonProperty("WaitTimeMs")]
        public long? WaitTimeMs{ get; set; }

        /// <summary>
        /// <p>事务开始时间（xml 里的 lasttranstarted，本地时间字符串，如 2026-09-16T14:58:23.840）。用于分析长事务、锁持有时长。</p>
        /// </summary>
        [JsonProperty("LastTransStarted")]
        public string LastTransStarted{ get; set; }

        /// <summary>
        /// <p>该边对应进程的并行执行子线程 ID。</p>
        /// </summary>
        [JsonProperty("ExecutionContextId")]
        public long? ExecutionContextId{ get; set; }

        /// <summary>
        /// <p>SQL Server 引擎内的进程指针，例如 process260256c7468。与 Resources.Owners/Waiters.ProcessId 拼接死锁环。partial 事件为 null。</p>
        /// </summary>
        [JsonProperty("ProcessId")]
        public string ProcessId{ get; set; }

        /// <summary>
        /// <p>归一化后的客户端应用名。去掉 SQLAgent 的 JobId（16-64 位十六进制串）、Step 号、GUID、末尾进程号等易变部分，用于按应用类别聚合。</p>
        /// </summary>
        [JsonProperty("ClientAppNormalized")]
        public string ClientAppNormalized{ get; set; }

        /// <summary>
        /// <p>本进程正在等待的锁资源描述列表（死锁环的等待边）。每条形如 &#39;keylock on tempdb.dbo.dl_a mode X waiting&#39;。applicationlock 会展示原始资源名（如 &#39;lock_a&#39;）。partial 事件为空数组。</p>
        /// </summary>
        [JsonProperty("LockRequest")]
        public string[] LockRequest{ get; set; }

        /// <summary>
        /// <p>SQL Server 会话 ID。日志排查主键。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public long? SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SqlFingerprint", this.SqlFingerprint);
            this.SetParamSimple(map, prefix + "LoginName", this.LoginName);
            this.SetParamArrayObj(map, prefix + "Frames.", this.Frames);
            this.SetParamSimple(map, prefix + "IsolationLevel", this.IsolationLevel);
            this.SetParamSimple(map, prefix + "ProcessStatus", this.ProcessStatus);
            this.SetParamSimple(map, prefix + "ClientApp", this.ClientApp);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamArraySimple(map, prefix + "LockHold.", this.LockHold);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "IsVictim", this.IsVictim);
            this.SetParamSimple(map, prefix + "WaitTimeMs", this.WaitTimeMs);
            this.SetParamSimple(map, prefix + "LastTransStarted", this.LastTransStarted);
            this.SetParamSimple(map, prefix + "ExecutionContextId", this.ExecutionContextId);
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "ClientAppNormalized", this.ClientAppNormalized);
            this.SetParamArraySimple(map, prefix + "LockRequest.", this.LockRequest);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

