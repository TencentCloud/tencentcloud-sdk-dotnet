/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ModifyExecStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则组ID
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// 监控类型 1.未配置, 2.关联生产调度, 3.离线周期检测
        /// </summary>
        [JsonProperty("MonitorType")]
        public ulong? MonitorType{ get; set; }

        /// <summary>
        /// 计算队列
        /// </summary>
        [JsonProperty("ExecQueue")]
        public string ExecQueue{ get; set; }

        /// <summary>
        /// 执行资源组ID
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// 执行资源组名称
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// 关联的生产调度任务列表
        /// </summary>
        [JsonProperty("Tasks")]
        public ProdSchedulerTask[] Tasks{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 离线周期模式下,生效日期-开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 离线周期模式下,生效日期-结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 离线周期模式下,调度周期 
        /// MINUTE_CYCLE:I,
        /// HOUR_CYCLE:H,
        /// DAY_CYCLE:D,
        /// WEEK_CYCLE:W,
        /// MONTH_CYCLE:M
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// 离线周期模式下,调度步长
        /// </summary>
        [JsonProperty("CycleStep")]
        public ulong? CycleStep{ get; set; }

        /// <summary>
        /// 离线周期模式下,指定时间
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// 延时执行时间，单位分钟，可选: <0-1439
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// 数据库Id
        /// </summary>
        [JsonProperty("DatabaseId")]
        public string DatabaseId{ get; set; }

        /// <summary>
        /// 数据源Id
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// 数据表Id
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }


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
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CycleStep", this.CycleStep);
            this.SetParamSimple(map, prefix + "TaskAction", this.TaskAction);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
        }
    }
}

