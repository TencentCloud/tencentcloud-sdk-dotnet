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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskFullRespInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>任务所属Database的名称。</p>
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// <p>任务数据量。</p>
        /// </summary>
        [JsonProperty("DataAmount")]
        public long? DataAmount{ get; set; }

        /// <summary>
        /// <p>任务Id。</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>计算耗时，单位： ms</p>
        /// </summary>
        [JsonProperty("UsedTime")]
        public long? UsedTime{ get; set; }

        /// <summary>
        /// <p>任务输出路径。</p>
        /// </summary>
        [JsonProperty("OutputPath")]
        public string OutputPath{ get; set; }

        /// <summary>
        /// <p>任务创建时间。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>任务状态：0 初始化， 1 执行中， 2 执行成功，3 数据写入中，4 排队中。-1 执行失败，-3 已取消。</p>
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// <p>任务SQL类型，DDL|DML等</p>
        /// </summary>
        [JsonProperty("SQLType")]
        public string SQLType{ get; set; }

        /// <summary>
        /// <p>任务SQL语句</p>
        /// </summary>
        [JsonProperty("SQL")]
        public string SQL{ get; set; }

        /// <summary>
        /// <p>结果是否过期。</p>
        /// </summary>
        [JsonProperty("ResultExpired")]
        public bool? ResultExpired{ get; set; }

        /// <summary>
        /// <p>数据影响统计信息。</p>
        /// </summary>
        [JsonProperty("RowAffectInfo")]
        public string RowAffectInfo{ get; set; }

        /// <summary>
        /// <p>任务结果数据表。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSet")]
        public string DataSet{ get; set; }

        /// <summary>
        /// <p>失败信息, 例如：errorMessage。该字段已废弃。</p>
        /// </summary>
        [JsonProperty("Error")]
        public string Error{ get; set; }

        /// <summary>
        /// <p>任务执行进度num/100(%)</p>
        /// </summary>
        [JsonProperty("Percentage")]
        public long? Percentage{ get; set; }

        /// <summary>
        /// <p>任务执行输出信息。</p>
        /// </summary>
        [JsonProperty("OutputMessage")]
        public string OutputMessage{ get; set; }

        /// <summary>
        /// <p>执行SQL的引擎类型</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>任务进度明细</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProgressDetail")]
        public string ProgressDetail{ get; set; }

        /// <summary>
        /// <p>任务结束时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>计算资源id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataEngineId")]
        public string DataEngineId{ get; set; }

        /// <summary>
        /// <p>执行sql的子uin</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// <p>计算资源名字</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// <p>导入类型是本地导入还是cos</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// <p>导入配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputConf")]
        public string InputConf{ get; set; }

        /// <summary>
        /// <p>数据条数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataNumber")]
        public long? DataNumber{ get; set; }

        /// <summary>
        /// <p>查询数据能不能下载</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CanDownload")]
        public bool? CanDownload{ get; set; }

        /// <summary>
        /// <p>用户别名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserAlias")]
        public string UserAlias{ get; set; }

        /// <summary>
        /// <p>spark应用作业名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkJobName")]
        public string SparkJobName{ get; set; }

        /// <summary>
        /// <p>spark应用作业Id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkJobId")]
        public string SparkJobId{ get; set; }

        /// <summary>
        /// <p>spark应用入口jar文件</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkJobFile")]
        public string SparkJobFile{ get; set; }

        /// <summary>
        /// <p>spark ui url</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UiUrl")]
        public string UiUrl{ get; set; }

        /// <summary>
        /// <p>任务耗时，单位： ms</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalTime")]
        public long? TotalTime{ get; set; }

        /// <summary>
        /// <p>spark app job执行task的程序入口参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CmdArgs")]
        public string CmdArgs{ get; set; }

        /// <summary>
        /// <p>集群镜像大版本名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageVersion")]
        public string ImageVersion{ get; set; }

        /// <summary>
        /// <p>driver规格：small,medium,large,xlarge；内存型(引擎类型)：m.small,m.medium,m.large,m.xlarge</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DriverSize")]
        public string DriverSize{ get; set; }

        /// <summary>
        /// <p>executor规格：small,medium,large,xlarge；内存型(引擎类型)：m.small,m.medium,m.large,m.xlarge</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorSize")]
        public string ExecutorSize{ get; set; }

        /// <summary>
        /// <p>指定executor数量，最小值为1，最大值小于集群规格</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorNums")]
        public ulong? ExecutorNums{ get; set; }

        /// <summary>
        /// <p>指定executor max数量（动态配置场景下），最小值为1，最大值小于集群规格（当ExecutorMaxNumbers小于ExecutorNums时，改值设定为ExecutorNums）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorMaxNumbers")]
        public ulong? ExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// <p>任务公共指标数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CommonMetrics")]
        public CommonMetrics CommonMetrics{ get; set; }

        /// <summary>
        /// <p>spark任务指标数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkMonitorMetrics")]
        public SparkMonitorMetrics SparkMonitorMetrics{ get; set; }

        /// <summary>
        /// <p>presto任务指标数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrestoMonitorMetrics")]
        public PrestoMonitorMetrics PrestoMonitorMetrics{ get; set; }

        /// <summary>
        /// <p>结果文件格式：默认为csv</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultFormat")]
        public string ResultFormat{ get; set; }

        /// <summary>
        /// <p>引擎类型，SparkSQL：SparkSQL 引擎；SparkBatch：Spark作业引擎；PrestoSQL：Presto引擎</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineTypeDetail")]
        public string EngineTypeDetail{ get; set; }

        /// <summary>
        /// <p>spark引擎资源组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// <p>任务来源信息,如thirdPartyApi,dataExploration, sparkAppTask等</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>子渠道信息，一般由第三方调用定义</p>
        /// </summary>
        [JsonProperty("SourceExtra")]
        public string SourceExtra{ get; set; }

        /// <summary>
        /// <p>创建人uin</p>
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// <p>创建人名字</p>
        /// </summary>
        [JsonProperty("CreatorAlias")]
        public string CreatorAlias{ get; set; }

        /// <summary>
        /// <p>引擎参数</p>
        /// </summary>
        [JsonProperty("CustomizedConf")]
        public string CustomizedConf{ get; set; }

        /// <summary>
        /// <p>单位秒，累计 CPU* 秒 ( 累计 CPU * 时 = 累计 CPU* 秒/ 3600)，统计参与计算所用 Spark Executor 每个 core 的 CPU 执行时长总和<br>示例值：4329</p>
        /// </summary>
        [JsonProperty("TaskTimeSum")]
        public long? TaskTimeSum{ get; set; }

        /// <summary>
        /// <p>引擎执行时间</p>
        /// </summary>
        [JsonProperty("StageStartTime")]
        public long? StageStartTime{ get; set; }

        /// <summary>
        /// <p>数据扫描条数</p>
        /// </summary>
        [JsonProperty("InputRecordsSum")]
        public long? InputRecordsSum{ get; set; }

        /// <summary>
        /// <p>健康状态</p>
        /// </summary>
        [JsonProperty("AnalysisStatusType")]
        public long? AnalysisStatusType{ get; set; }

        /// <summary>
        /// <p>输出总行数</p>
        /// </summary>
        [JsonProperty("OutputRecordsSum")]
        public long? OutputRecordsSum{ get; set; }

        /// <summary>
        /// <p>输出总大小</p>
        /// </summary>
        [JsonProperty("OutputBytesSum")]
        public long? OutputBytesSum{ get; set; }

        /// <summary>
        /// <p>输出文件个数</p>
        /// </summary>
        [JsonProperty("OutputFilesNum")]
        public long? OutputFilesNum{ get; set; }

        /// <summary>
        /// <p>输出小文件个数</p>
        /// </summary>
        [JsonProperty("OutputSmallFilesNum")]
        public long? OutputSmallFilesNum{ get; set; }

        /// <summary>
        /// <p>数据shuffle行数</p>
        /// </summary>
        [JsonProperty("ShuffleReadRecordsSum")]
        public long? ShuffleReadRecordsSum{ get; set; }

        /// <summary>
        /// <p>数据shuffle大小</p>
        /// </summary>
        [JsonProperty("ShuffleReadBytesSum")]
        public long? ShuffleReadBytesSum{ get; set; }

        /// <summary>
        /// <p>spark作业id</p>
        /// </summary>
        [JsonProperty("SparkAppId")]
        public string SparkAppId{ get; set; }

        /// <summary>
        /// <p>任务大类，DLC2.0中任务区分为两大类，sql任务和作业任务</p>
        /// </summary>
        [JsonProperty("TaskCategory")]
        public string TaskCategory{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>引擎类型，用做任务详情页跳转引擎tab</p>
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// <p>引擎是否支持洞察数据采集</p>
        /// </summary>
        [JsonProperty("EngineHasListenerConfig")]
        public bool? EngineHasListenerConfig{ get; set; }

        /// <summary>
        /// <p>spark引擎资源组id</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>任务计算耗时</p>
        /// </summary>
        [JsonProperty("JobTimeSum")]
        public long? JobTimeSum{ get; set; }

        /// <summary>
        /// <p>任务启动耗时</p>
        /// </summary>
        [JsonProperty("LaunchTime")]
        public string LaunchTime{ get; set; }

        /// <summary>
        /// <p>Gpu Driver 规格</p>
        /// </summary>
        [JsonProperty("GpuDriverSize")]
        public long? GpuDriverSize{ get; set; }

        /// <summary>
        /// <p>Gpu Executor 规格</p>
        /// </summary>
        [JsonProperty("GpuExecutorSize")]
        public long? GpuExecutorSize{ get; set; }

        /// <summary>
        /// <p>ShuffleWrite数据量</p>
        /// </summary>
        [JsonProperty("ShuffleWriteBytesSum")]
        public long? ShuffleWriteBytesSum{ get; set; }

        /// <summary>
        /// <p>活跃core</p>
        /// </summary>
        [JsonProperty("ActiveCore")]
        public long? ActiveCore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "DataAmount", this.DataAmount);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "UsedTime", this.UsedTime);
            this.SetParamSimple(map, prefix + "OutputPath", this.OutputPath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "SQLType", this.SQLType);
            this.SetParamSimple(map, prefix + "SQL", this.SQL);
            this.SetParamSimple(map, prefix + "ResultExpired", this.ResultExpired);
            this.SetParamSimple(map, prefix + "RowAffectInfo", this.RowAffectInfo);
            this.SetParamSimple(map, prefix + "DataSet", this.DataSet);
            this.SetParamSimple(map, prefix + "Error", this.Error);
            this.SetParamSimple(map, prefix + "Percentage", this.Percentage);
            this.SetParamSimple(map, prefix + "OutputMessage", this.OutputMessage);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "ProgressDetail", this.ProgressDetail);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "DataEngineId", this.DataEngineId);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "InputConf", this.InputConf);
            this.SetParamSimple(map, prefix + "DataNumber", this.DataNumber);
            this.SetParamSimple(map, prefix + "CanDownload", this.CanDownload);
            this.SetParamSimple(map, prefix + "UserAlias", this.UserAlias);
            this.SetParamSimple(map, prefix + "SparkJobName", this.SparkJobName);
            this.SetParamSimple(map, prefix + "SparkJobId", this.SparkJobId);
            this.SetParamSimple(map, prefix + "SparkJobFile", this.SparkJobFile);
            this.SetParamSimple(map, prefix + "UiUrl", this.UiUrl);
            this.SetParamSimple(map, prefix + "TotalTime", this.TotalTime);
            this.SetParamSimple(map, prefix + "CmdArgs", this.CmdArgs);
            this.SetParamSimple(map, prefix + "ImageVersion", this.ImageVersion);
            this.SetParamSimple(map, prefix + "DriverSize", this.DriverSize);
            this.SetParamSimple(map, prefix + "ExecutorSize", this.ExecutorSize);
            this.SetParamSimple(map, prefix + "ExecutorNums", this.ExecutorNums);
            this.SetParamSimple(map, prefix + "ExecutorMaxNumbers", this.ExecutorMaxNumbers);
            this.SetParamObj(map, prefix + "CommonMetrics.", this.CommonMetrics);
            this.SetParamObj(map, prefix + "SparkMonitorMetrics.", this.SparkMonitorMetrics);
            this.SetParamObj(map, prefix + "PrestoMonitorMetrics.", this.PrestoMonitorMetrics);
            this.SetParamSimple(map, prefix + "ResultFormat", this.ResultFormat);
            this.SetParamSimple(map, prefix + "EngineTypeDetail", this.EngineTypeDetail);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceExtra", this.SourceExtra);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "CreatorAlias", this.CreatorAlias);
            this.SetParamSimple(map, prefix + "CustomizedConf", this.CustomizedConf);
            this.SetParamSimple(map, prefix + "TaskTimeSum", this.TaskTimeSum);
            this.SetParamSimple(map, prefix + "StageStartTime", this.StageStartTime);
            this.SetParamSimple(map, prefix + "InputRecordsSum", this.InputRecordsSum);
            this.SetParamSimple(map, prefix + "AnalysisStatusType", this.AnalysisStatusType);
            this.SetParamSimple(map, prefix + "OutputRecordsSum", this.OutputRecordsSum);
            this.SetParamSimple(map, prefix + "OutputBytesSum", this.OutputBytesSum);
            this.SetParamSimple(map, prefix + "OutputFilesNum", this.OutputFilesNum);
            this.SetParamSimple(map, prefix + "OutputSmallFilesNum", this.OutputSmallFilesNum);
            this.SetParamSimple(map, prefix + "ShuffleReadRecordsSum", this.ShuffleReadRecordsSum);
            this.SetParamSimple(map, prefix + "ShuffleReadBytesSum", this.ShuffleReadBytesSum);
            this.SetParamSimple(map, prefix + "SparkAppId", this.SparkAppId);
            this.SetParamSimple(map, prefix + "TaskCategory", this.TaskCategory);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "EngineHasListenerConfig", this.EngineHasListenerConfig);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "JobTimeSum", this.JobTimeSum);
            this.SetParamSimple(map, prefix + "LaunchTime", this.LaunchTime);
            this.SetParamSimple(map, prefix + "GpuDriverSize", this.GpuDriverSize);
            this.SetParamSimple(map, prefix + "GpuExecutorSize", this.GpuExecutorSize);
            this.SetParamSimple(map, prefix + "ShuffleWriteBytesSum", this.ShuffleWriteBytesSum);
            this.SetParamSimple(map, prefix + "ActiveCore", this.ActiveCore);
        }
    }
}

