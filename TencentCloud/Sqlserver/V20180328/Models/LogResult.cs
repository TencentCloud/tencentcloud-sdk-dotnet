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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogResult : AbstractModel
    {
        
        /// <summary>
        /// <p>时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// <p>错误类别</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>客户端应用程序名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientAppName")]
        public string ClientAppName{ get; set; }

        /// <summary>
        /// <p>客户端主机名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientHostName")]
        public string ClientHostName{ get; set; }

        /// <summary>
        /// <p>CPU 时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuTime")]
        public long? CpuTime{ get; set; }

        /// <summary>
        /// <p>数据库 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseId")]
        public long? DatabaseId{ get; set; }

        /// <summary>
        /// <p>数据库名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// <p>执行时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>错误编号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorNumber")]
        public long? ErrorNumber{ get; set; }

        /// <summary>
        /// <p>是否被拦截</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsIntercepted")]
        public string IsIntercepted{ get; set; }

        /// <summary>
        /// <p>最后行计数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastRowCount")]
        public long? LastRowCount{ get; set; }

        /// <summary>
        /// <p>逻辑读取</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogicalReads")]
        public long? LogicalReads{ get; set; }

        /// <summary>
        /// <p>消息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>对象 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectId")]
        public long? ObjectId{ get; set; }

        /// <summary>
        /// <p>对象名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectName")]
        public string ObjectName{ get; set; }

        /// <summary>
        /// <p>对象类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// <p>输出参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputParameters")]
        public string OutputParameters{ get; set; }

        /// <summary>
        /// <p>参数化计划句柄</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParameterizedPlanHandle")]
        public string ParameterizedPlanHandle{ get; set; }

        /// <summary>
        /// <p>物理读取</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhysicalReads")]
        public long? PhysicalReads{ get; set; }

        /// <summary>
        /// <p>结果</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// <p>行计数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RowCount")]
        public long? RowCount{ get; set; }

        /// <summary>
        /// <p>服务器主体名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServerPrincipalName")]
        public string ServerPrincipalName{ get; set; }

        /// <summary>
        /// <p>会话服务器主体名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionServerPrincipalName")]
        public string SessionServerPrincipalName{ get; set; }

        /// <summary>
        /// <p>严重性</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Severity")]
        public long? Severity{ get; set; }

        /// <summary>
        /// <p>源数据库 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceDatabaseId")]
        public long? SourceDatabaseId{ get; set; }

        /// <summary>
        /// <p>SQL 文本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// <p>语句</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Statement")]
        public string Statement{ get; set; }

        /// <summary>
        /// <p>系统线程 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemThreadId")]
        public long? SystemThreadId{ get; set; }

        /// <summary>
        /// <p>事务 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionId")]
        public long? TransactionId{ get; set; }

        /// <summary>
        /// <p>用户定义</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserDefined")]
        public string UserDefined{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>写入</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Writes")]
        public long? Writes{ get; set; }

        /// <summary>
        /// <p>目标</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Destination")]
        public string Destination{ get; set; }

        /// <summary>
        /// <p>事件名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "ClientAppName", this.ClientAppName);
            this.SetParamSimple(map, prefix + "ClientHostName", this.ClientHostName);
            this.SetParamSimple(map, prefix + "CpuTime", this.CpuTime);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ErrorNumber", this.ErrorNumber);
            this.SetParamSimple(map, prefix + "IsIntercepted", this.IsIntercepted);
            this.SetParamSimple(map, prefix + "LastRowCount", this.LastRowCount);
            this.SetParamSimple(map, prefix + "LogicalReads", this.LogicalReads);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "ObjectName", this.ObjectName);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamSimple(map, prefix + "OutputParameters", this.OutputParameters);
            this.SetParamSimple(map, prefix + "ParameterizedPlanHandle", this.ParameterizedPlanHandle);
            this.SetParamSimple(map, prefix + "PhysicalReads", this.PhysicalReads);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "RowCount", this.RowCount);
            this.SetParamSimple(map, prefix + "ServerPrincipalName", this.ServerPrincipalName);
            this.SetParamSimple(map, prefix + "SessionServerPrincipalName", this.SessionServerPrincipalName);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "SourceDatabaseId", this.SourceDatabaseId);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Statement", this.Statement);
            this.SetParamSimple(map, prefix + "SystemThreadId", this.SystemThreadId);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "UserDefined", this.UserDefined);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Writes", this.Writes);
            this.SetParamSimple(map, prefix + "Destination", this.Destination);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
        }
    }
}

