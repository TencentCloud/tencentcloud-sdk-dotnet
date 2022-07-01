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

    public class DescribeTaskInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 页号，默认为1
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 页大小，默认为10，最大不超过200
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 工作流id列表
        /// </summary>
        [JsonProperty("WorkflowIdList")]
        public string[] WorkflowIdList{ get; set; }

        /// <summary>
        /// 工作流名称列表，支持模糊搜索
        /// </summary>
        [JsonProperty("WorkflowNameList")]
        public string[] WorkflowNameList{ get; set; }

        /// <summary>
        /// 起始数据时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("DateFrom")]
        public string DateFrom{ get; set; }

        /// <summary>
        /// 结束数据时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("DateTo")]
        public string DateTo{ get; set; }

        /// <summary>
        /// 任务id列表
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// 任务名称列表，支持模糊搜索
        /// </summary>
        [JsonProperty("TaskNameList")]
        public string[] TaskNameList{ get; set; }

        /// <summary>
        /// 责任人名称列表
        /// </summary>
        [JsonProperty("InChargeList")]
        public string[] InChargeList{ get; set; }

        /// <summary>
        /// 任务类型码列表，26离线同步，30Python，31PySpark，32DLC，33Impala，34Hive SQL，35Shell，36Spark SQL，39Spark，40CDW PG，92MapReduce
        /// </summary>
        [JsonProperty("TaskTypeIdList")]
        public long?[] TaskTypeIdList{ get; set; }

        /// <summary>
        /// 实例状态列表，0等待事件，1等待上游，2等待运行，3运行中，4正在终止，5失败重试，6失败，7成功
        /// </summary>
        [JsonProperty("StateList")]
        public string[] StateList{ get; set; }

        /// <summary>
        /// 周期类型列表，I分钟，H小时，D天，W周，M月，Y年，O一次性，C crontab
        /// </summary>
        [JsonProperty("TaskCycleUnitList")]
        public string[] TaskCycleUnitList{ get; set; }

        /// <summary>
        /// 实例类型，0补录实例，1周期实例，2非周期实例
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// 排序字段信息列表，ScheduleDateTime / CostTime / StartTime / EndTime
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField[] OrderFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "WorkflowIdList.", this.WorkflowIdList);
            this.SetParamArraySimple(map, prefix + "WorkflowNameList.", this.WorkflowNameList);
            this.SetParamSimple(map, prefix + "DateFrom", this.DateFrom);
            this.SetParamSimple(map, prefix + "DateTo", this.DateTo);
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamArraySimple(map, prefix + "TaskNameList.", this.TaskNameList);
            this.SetParamArraySimple(map, prefix + "InChargeList.", this.InChargeList);
            this.SetParamArraySimple(map, prefix + "TaskTypeIdList.", this.TaskTypeIdList);
            this.SetParamArraySimple(map, prefix + "StateList.", this.StateList);
            this.SetParamArraySimple(map, prefix + "TaskCycleUnitList.", this.TaskCycleUnitList);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
        }
    }
}

