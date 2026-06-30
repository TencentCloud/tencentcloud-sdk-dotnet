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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleExecResult : AbstractModel
    {
        
        /// <summary>
        /// <p>规则执行ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleExecId")]
        public ulong? RuleExecId{ get; set; }

        /// <summary>
        /// <p>规则组执行ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleGroupExecId")]
        public ulong? RuleGroupExecId{ get; set; }

        /// <summary>
        /// <p>规则组ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// <p>规则ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// <p>规则名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>规则类型 1.系统模版, 2.自定义模版, 3.自定义SQL</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleType")]
        public ulong? RuleType{ get; set; }

        /// <summary>
        /// <p>源字段详细类型，int string</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceObjectDataTypeName")]
        public string SourceObjectDataTypeName{ get; set; }

        /// <summary>
        /// <p>源字段名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceObjectValue")]
        public string SourceObjectValue{ get; set; }

        /// <summary>
        /// <p>条件扫描WHERE条件表达式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConditionExpression")]
        public string ConditionExpression{ get; set; }

        /// <summary>
        /// <p>检测结果（1:检测通过，2：触发规则，3：检测失败）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecResultStatus")]
        public ulong? ExecResultStatus{ get; set; }

        /// <summary>
        /// <p>触发结果，告警发送成功, 阻断任务成功</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerResult")]
        public string TriggerResult{ get; set; }

        /// <summary>
        /// <p>对比结果</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareResult")]
        public CompareResult CompareResult{ get; set; }

        /// <summary>
        /// <p>模版名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>质量维度</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityDim")]
        public ulong? QualityDim{ get; set; }

        /// <summary>
        /// <p>目标表-库表名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetDBTableName")]
        public string TargetDBTableName{ get; set; }

        /// <summary>
        /// <p>目标表-字段名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetObjectValue")]
        public string TargetObjectValue{ get; set; }

        /// <summary>
        /// <p>目标表-字段类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetObjectDataType")]
        public string TargetObjectDataType{ get; set; }

        /// <summary>
        /// <p>自定义模版sql表达式参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldConfig")]
        public RuleFieldConfig FieldConfig{ get; set; }

        /// <summary>
        /// <p>源字段与目标字段关联条件on表达式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelConditionExpr")]
        public string RelConditionExpr{ get; set; }

        /// <summary>
        /// <p>执行时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>1/2/3:低/中/高</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// <p>触发条件</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerCondition")]
        public string TriggerCondition{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleGroupName")]
        public string RuleGroupName{ get; set; }

        /// <summary>
        /// <p>数据源ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// <p>数据源名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceName")]
        public string DatasourceName{ get; set; }

        /// <summary>
        /// <p>数据库名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// <p>模式名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// <p>表名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>判断是否屏蔽监控 0.屏蔽 1.不屏蔽</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleGroupExist")]
        public long? RuleGroupExist{ get; set; }

        /// <summary>
        /// <p>数据源类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceType")]
        public long? DatasourceType{ get; set; }

        /// <summary>
        /// <p>数据表id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleGroupTableId")]
        public ulong? RuleGroupTableId{ get; set; }

        /// <summary>
        /// <p>监控方式 1.未配置, 2.关联生产调度, 3.离线周期检测</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorType")]
        public long? MonitorType{ get; set; }

        /// <summary>
        /// <p>执行结束时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>任务类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// <p>编排任务id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AspectTaskId")]
        public string AspectTaskId{ get; set; }

        /// <summary>
        /// <p>目录</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// <p>规则执行状态</p><p>枚举值：</p><ul><li>0： 初始状态</li><li>1： 运行中</li><li>2： 运行成功</li><li>3： 运行失败</li><li>4： 被杀死</li></ul>
        /// </summary>
        [JsonProperty("RuleExecStatus")]
        public long? RuleExecStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleExecId", this.RuleExecId);
            this.SetParamSimple(map, prefix + "RuleGroupExecId", this.RuleGroupExecId);
            this.SetParamSimple(map, prefix + "RuleGroupId", this.RuleGroupId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "SourceObjectDataTypeName", this.SourceObjectDataTypeName);
            this.SetParamSimple(map, prefix + "SourceObjectValue", this.SourceObjectValue);
            this.SetParamSimple(map, prefix + "ConditionExpression", this.ConditionExpression);
            this.SetParamSimple(map, prefix + "ExecResultStatus", this.ExecResultStatus);
            this.SetParamSimple(map, prefix + "TriggerResult", this.TriggerResult);
            this.SetParamObj(map, prefix + "CompareResult.", this.CompareResult);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "QualityDim", this.QualityDim);
            this.SetParamSimple(map, prefix + "TargetDBTableName", this.TargetDBTableName);
            this.SetParamSimple(map, prefix + "TargetObjectValue", this.TargetObjectValue);
            this.SetParamSimple(map, prefix + "TargetObjectDataType", this.TargetObjectDataType);
            this.SetParamObj(map, prefix + "FieldConfig.", this.FieldConfig);
            this.SetParamSimple(map, prefix + "RelConditionExpr", this.RelConditionExpr);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "TriggerCondition", this.TriggerCondition);
            this.SetParamSimple(map, prefix + "RuleGroupName", this.RuleGroupName);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "DatasourceName", this.DatasourceName);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "RuleGroupExist", this.RuleGroupExist);
            this.SetParamSimple(map, prefix + "DatasourceType", this.DatasourceType);
            this.SetParamSimple(map, prefix + "RuleGroupTableId", this.RuleGroupTableId);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "AspectTaskId", this.AspectTaskId);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "RuleExecStatus", this.RuleExecStatus);
        }
    }
}

