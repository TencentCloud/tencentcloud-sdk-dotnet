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

    public class RuleGroupExecStrategy : AbstractModel
    {
        
        /// <summary>
        /// <p>规则组Id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// 监控类型：1-未配置，2-关联生产调度，3-离线周期检测
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorType")]
        public ulong? MonitorType{ get; set; }

        /// <summary>
        /// <p>计算队列</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecQueue")]
        public string ExecQueue{ get; set; }

        /// <summary>
        /// <p>执行资源组ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// <p>执行资源组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// <p>关联的生产调度任务列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tasks")]
        public ProdSchedulerTask[] Tasks{ get; set; }

        /// <summary>
        /// <p>周期开始时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>周期结束时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 周期类型：MINUTE-分钟，HOUR-小时，DAY-天，WEEK-周，MONTH-月，YEAR-年
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// <p>延迟调度时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// <p>间隔</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleStep")]
        public ulong? CycleStep{ get; set; }

        /// <summary>
        /// <p>时间指定</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// 执行引擎类型，可选值：MYSQL, HIVE, SPARK, LIVY, DLC, GBASE, CDW_PG, TCHouse-P, DORIS, TCHouse-D
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecEngineType")]
        public string ExecEngineType{ get; set; }

        /// <summary>
        /// <p>执行计划</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecPlan")]
        public string ExecPlan{ get; set; }

        /// <summary>
        /// <p>规则id</p>
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
        /// 触发类型数组：1-手动触发，2-调度事件触发，3-周期调度触发
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerTypes")]
        public string[] TriggerTypes{ get; set; }

        /// <summary>
        /// <p>DLC资源组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DlcGroupName")]
        public string DlcGroupName{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleGroupName")]
        public string RuleGroupName{ get; set; }

        /// <summary>
        /// <p>数据库名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// <p>schema名称</p>
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
        /// <p>数据源id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// <p>任务描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>时区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// <p>任务监控参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupConfig")]
        public RuleGroupConfig GroupConfig{ get; set; }

        /// <summary>
        /// <p>引擎参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineParam")]
        public string EngineParam{ get; set; }

        /// <summary>
        /// <p>catalog名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// <p>执行失败是否阻塞下游</p><p>枚举值：</p><ul><li>0： 失败不阻塞（默认）</li><li>1： 失败阻塞</li></ul><p>默认值：0</p><p>仅作用于“关联生产调度”类型的质量监控</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecFailBlock")]
        public ulong? ExecFailBlock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleGroupId", this.RuleGroupId);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "ExecQueue", this.ExecQueue);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "ExecutorGroupName", this.ExecutorGroupName);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "CycleStep", this.CycleStep);
            this.SetParamSimple(map, prefix + "TaskAction", this.TaskAction);
            this.SetParamSimple(map, prefix + "ExecEngineType", this.ExecEngineType);
            this.SetParamSimple(map, prefix + "ExecPlan", this.ExecPlan);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArraySimple(map, prefix + "TriggerTypes.", this.TriggerTypes);
            this.SetParamSimple(map, prefix + "DlcGroupName", this.DlcGroupName);
            this.SetParamSimple(map, prefix + "RuleGroupName", this.RuleGroupName);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamObj(map, prefix + "GroupConfig.", this.GroupConfig);
            this.SetParamSimple(map, prefix + "EngineParam", this.EngineParam);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "ExecFailBlock", this.ExecFailBlock);
        }
    }
}

