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

    public class ListOpsTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id	
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public string PageSize{ get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public string PageNumber{ get; set; }

        /// <summary>
        /// 任务类型Id 
        ///  - 20：通用数据同步
        ///  - 25：ETLTaskType
        ///  - 26：ETLTaskType
        ///  - 30：python
        ///  - 31：pyspark
        ///  - 34：HiveSQLTaskType
        ///  - 35：shell
        ///  - 36：SparkSQLTaskType
        ///  - 21：JDBCSQLTaskType
        ///  - 32：DLCTaskType
        ///  - 33：ImpalaTaskType
        ///  - 40：CDWTaskType
        ///  - 41：kettle
        ///  - 46：DLCSparkTaskType
        ///  - 47：TiOne机器学习
        ///  - 48：TrinoTaskType
        ///  - 50：DLCPyspark39：spark
        ///  - 92：mr
        ///  - 38：shell脚本
        ///  - 70：hivesql脚本
        ///  - 1000：自定义业务通用
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public string TaskTypeId{ get; set; }

        /// <summary>
        /// 工作流Id
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 工作流名称
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// 责任人id
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 文件夹Id
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("SourceServiceId")]
        public string SourceServiceId{ get; set; }

        /// <summary>
        /// 目标数据源id
        /// </summary>
        [JsonProperty("TargetServiceId")]
        public string TargetServiceId{ get; set; }

        /// <summary>
        /// 资源组id
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// 任务周期类型
        /// * ONEOFF_CYCLE: 一次性
        /// * YEAR_CYCLE: 年
        /// * MONTH_CYCLE: 月
        /// * WEEK_CYCLE: 周
        /// * DAY_CYCLE: 天
        /// * HOUR_CYCLE: 小时
        /// * MINUTE_CYCLE: 分钟
        /// * CRONTAB_CYCLE: crontab表达式类型
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// 任务状态:
        /// - Y: 运行
        /// - F: 停止
        /// - O: 冻结
        /// - T: 停止中
        /// - INVALID: 已失效
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 时区, 默认默认UTC+8
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "SourceServiceId", this.SourceServiceId);
            this.SetParamSimple(map, prefix + "TargetServiceId", this.TargetServiceId);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}

