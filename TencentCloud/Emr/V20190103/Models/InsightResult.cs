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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InsightResult : AbstractModel
    {
        
        /// <summary>
        /// 当Type为HIVE时，是Hive查询ID，当Type为MAPREDUCE，SPARK，TEZ时则是YarnAppID
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 洞察应用的类型，HIVE,SPARK,MAPREDUCE,TEZ
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 洞察规则ID
        /// HIVE-ScanManyMeta:元数据扫描过多
        /// HIVE-ScanManyPartition:大表扫描
        /// HIVE-SlowCompile:编译耗时过长
        /// HIVE-UnSuitableConfig:不合理参数
        /// MAPREDUCE-MapperDataSkew:Map数据倾斜
        /// MAPREDUCE-MapperMemWaste:MapMemory资源浪费
        /// MAPREDUCE-MapperSlowTask:Map慢Task
        /// MAPREDUCE-MapperTaskGC:MapperTaskGC
        /// MAPREDUCE-MemExceeded:峰值内存超限
        /// MAPREDUCE-ReducerDataSkew:Reduce数据倾斜
        /// MAPREDUCE-ReducerMemWaste:ReduceMemory资源浪费
        /// MAPREDUCE-ReducerSlowTask:Reduce慢Task
        /// MAPREDUCE-ReducerTaskGC:ReducerTaskGC
        /// MAPREDUCE-SchedulingDelay:调度延迟
        /// SPARK-CpuWaste:CPU资源浪费
        /// SPARK-DataSkew:数据倾斜
        /// SPARK-ExecutorGC:ExecutorGC
        /// SPARK-MemExceeded:峰值内存超限
        /// SPARK-MemWaste:Memory资源浪费
        /// SPARK-ScheduleOverhead:ScheduleOverhead
        /// SPARK-ScheduleSkew:调度倾斜
        /// SPARK-SlowTask:慢Task
        /// TEZ-DataSkew:数据倾斜
        /// TEZ-MapperDataSkew:Map数据倾斜
        /// TEZ-ReducerDataSkew:Reduce数据倾斜
        /// TEZ-TezMemWaste:Memory资源浪费
        /// TEZ-TezSlowTask:慢Task
        /// TEZ-TezTaskGC:TasksGC
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// 洞察规则名字，可参考RuleID的说明
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 洞察规则解释
        /// </summary>
        [JsonProperty("RuleExplain")]
        public string RuleExplain{ get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 建议信息
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 洞察异常衡量值，同类型的洞察项越大越严重，不同类型的洞察项无对比意义
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }

        /// <summary>
        /// 调度任务执行ID
        /// </summary>
        [JsonProperty("ScheduleTaskExecID")]
        public string ScheduleTaskExecID{ get; set; }

        /// <summary>
        /// 调度流，DAG
        /// </summary>
        [JsonProperty("ScheduleFlowName")]
        public string ScheduleFlowName{ get; set; }

        /// <summary>
        /// 调度flow中的某个task节点
        /// </summary>
        [JsonProperty("ScheduleTaskName")]
        public string ScheduleTaskName{ get; set; }

        /// <summary>
        /// Yarn任务的部分核心配置
        /// </summary>
        [JsonProperty("JobConf")]
        public string JobConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleExplain", this.RuleExplain);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "ScheduleTaskExecID", this.ScheduleTaskExecID);
            this.SetParamSimple(map, prefix + "ScheduleFlowName", this.ScheduleFlowName);
            this.SetParamSimple(map, prefix + "ScheduleTaskName", this.ScheduleTaskName);
            this.SetParamSimple(map, prefix + "JobConf", this.JobConf);
        }
    }
}

