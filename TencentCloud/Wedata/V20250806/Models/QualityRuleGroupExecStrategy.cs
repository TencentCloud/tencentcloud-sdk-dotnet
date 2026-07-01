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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityRuleGroupExecStrategy : AbstractModel
    {
        
        /// <summary>
        /// <p>监控类型 2.关联生产调度, 3.离线周期检测</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorType")]
        public ulong? MonitorType{ get; set; }

        /// <summary>
        /// <p>执行资源组ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// <p>监控任务名称</p>
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
        /// <p>数据源id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// <p>表名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>监控任务的Id，编辑更新监控任务时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// <p>计算队列，数据源为HIVE、ICEBERG、DLC时必填，数据源为DLC时，该字段填写DLC数据引擎名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecQueue")]
        public string ExecQueue{ get; set; }

        /// <summary>
        /// <p>执行资源组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// <p>关联的生产调度任务列表，MonitorType=2时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tasks")]
        public QualityProdSchedulerTask[] Tasks{ get; set; }

        /// <summary>
        /// <p>周期开始时间，MonitorType=3时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>周期结束时间，MonitorType=3时必填</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>调度周期类型，MonitorType=3时必填，具体可填值参考：<br>I：按分钟调度<br>H：按小时调度<br>D：按天调度<br>W：按周调度<br>M：按月调度</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// <p>延迟调度时间，MonitorType=3时必填，主要用于调度周期为天/周/月的任务，<br>计量单位为分钟，比如天任务需要延迟到02:00执行，则该字段值为120，表示延迟2小时（120分钟）<br>对于小时/分钟任务，该字段无意义，填固定值0，否则字段校验不通过</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// <p>间隔，MonitorType=3时必填，表示周期任务间隔时间<br>周/月/天任务可选：1<br>分钟任务可选：10，20，30<br>小时任务可选：1，2，3，4，6，8，12</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleStep")]
        public ulong? CycleStep{ get; set; }

        /// <summary>
        /// <p>时间指定，主要用于调度周期为周/月的任务<br>调度周期为周时：含义为指定周几运行，可选多个，英文逗号隔开<br>可填1,2...7，依次代表周日，周一...周六，例如填“1,2”，表示周日、周一执行；</p><p>调度周期为月时，含义为指定每月的几号运行，可选多个，英文逗号隔开<br>可填1,2,...,31，依次代表1号，2号...31号，例如填“1,2”，表示每月的1号、2号执行</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// <p>运行的执行引擎，不传时会请求该数据源下默认的执行引擎</p>
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
        /// <p>触发类型，主要用于“关联生产调度”（MonitorType=2）的监控任务，可选值：<br>CYCLE：周期调度<br>MAKE_UP：补录<br>RERUN：重跑</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerTypes")]
        public string[] TriggerTypes{ get; set; }

        /// <summary>
        /// <p>数据源为DLC时，对应DLC资源组，根据ExecQueue中填的DLC引擎名称，选择对应引擎下的资源组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DlcGroupName")]
        public string DlcGroupName{ get; set; }

        /// <summary>
        /// <p>schema名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// <p>任务描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>时区，默认为UTC+8</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// <p>任务监控参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupConfig")]
        public QualityRuleGroupConfig GroupConfig{ get; set; }

        /// <summary>
        /// <p>引擎参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineParam")]
        public string EngineParam{ get; set; }

        /// <summary>
        /// <p>数据目录名称，不填默认为DataLakeCatalog（更新质量监控时该参数无效）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// <p>执行失败是否阻塞下游</p><p>枚举值：</p><ul><li>0： 失败不阻塞（默认）</li><li>1： 失败阻塞</li></ul><p>默认值：0</p><p>仅作用于“关联生产调度”类型的质量监控</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecFailBlock")]
        public long? ExecFailBlock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "RuleGroupName", this.RuleGroupName);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "RuleGroupId", this.RuleGroupId);
            this.SetParamSimple(map, prefix + "ExecQueue", this.ExecQueue);
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
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamObj(map, prefix + "GroupConfig.", this.GroupConfig);
            this.SetParamSimple(map, prefix + "EngineParam", this.EngineParam);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "ExecFailBlock", this.ExecFailBlock);
        }
    }
}

