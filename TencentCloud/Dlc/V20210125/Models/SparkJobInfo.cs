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

    public class SparkJobInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>spark作业ID</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>spark作业名</p>
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// <p>spark作业类型，可去1或者2，1表示batch作业， 2表示streaming作业</p>
        /// </summary>
        [JsonProperty("JobType")]
        public long? JobType{ get; set; }

        /// <summary>
        /// <p>引擎名</p>
        /// </summary>
        [JsonProperty("DataEngine")]
        public string DataEngine{ get; set; }

        /// <summary>
        /// <p>该字段已下线，请使用字段Datasource</p>
        /// </summary>
        [JsonProperty("Eni")]
        public string Eni{ get; set; }

        /// <summary>
        /// <p>程序包是否本地上传，cos或者lakefs</p>
        /// </summary>
        [JsonProperty("IsLocal")]
        public string IsLocal{ get; set; }

        /// <summary>
        /// <p>程序包路径</p>
        /// </summary>
        [JsonProperty("JobFile")]
        public string JobFile{ get; set; }

        /// <summary>
        /// <p>角色ID</p>
        /// </summary>
        [JsonProperty("RoleArn")]
        public long? RoleArn{ get; set; }

        /// <summary>
        /// <p>spark作业运行主类</p>
        /// </summary>
        [JsonProperty("MainClass")]
        public string MainClass{ get; set; }

        /// <summary>
        /// <p>命令行参数，spark作业命令行参数，空格分隔</p>
        /// </summary>
        [JsonProperty("CmdArgs")]
        public string CmdArgs{ get; set; }

        /// <summary>
        /// <p>spark原生配置，换行符分隔</p>
        /// </summary>
        [JsonProperty("JobConf")]
        public string JobConf{ get; set; }

        /// <summary>
        /// <p>依赖jars是否本地上传，cos或者lakefs</p>
        /// </summary>
        [JsonProperty("IsLocalJars")]
        public string IsLocalJars{ get; set; }

        /// <summary>
        /// <p>spark作业依赖jars，逗号分隔</p>
        /// </summary>
        [JsonProperty("JobJars")]
        public string JobJars{ get; set; }

        /// <summary>
        /// <p>依赖文件是否本地上传，cos或者lakefs</p>
        /// </summary>
        [JsonProperty("IsLocalFiles")]
        public string IsLocalFiles{ get; set; }

        /// <summary>
        /// <p>spark作业依赖文件，逗号分隔</p>
        /// </summary>
        [JsonProperty("JobFiles")]
        public string JobFiles{ get; set; }

        /// <summary>
        /// <p>spark作业driver资源大小</p>
        /// </summary>
        [JsonProperty("JobDriverSize")]
        public string JobDriverSize{ get; set; }

        /// <summary>
        /// <p>spark作业executor资源大小</p>
        /// </summary>
        [JsonProperty("JobExecutorSize")]
        public string JobExecutorSize{ get; set; }

        /// <summary>
        /// <p>spark作业executor个数</p>
        /// </summary>
        [JsonProperty("JobExecutorNums")]
        public long? JobExecutorNums{ get; set; }

        /// <summary>
        /// <p>spark流任务最大重试次数</p>
        /// </summary>
        [JsonProperty("JobMaxAttempts")]
        public long? JobMaxAttempts{ get; set; }

        /// <summary>
        /// <p>spark作业创建者</p>
        /// </summary>
        [JsonProperty("JobCreator")]
        public string JobCreator{ get; set; }

        /// <summary>
        /// <p>spark作业创建时间</p>
        /// </summary>
        [JsonProperty("JobCreateTime")]
        public long? JobCreateTime{ get; set; }

        /// <summary>
        /// <p>spark作业更新时间</p>
        /// </summary>
        [JsonProperty("JobUpdateTime")]
        public ulong? JobUpdateTime{ get; set; }

        /// <summary>
        /// <p>spark作业最近任务ID</p>
        /// </summary>
        [JsonProperty("CurrentTaskId")]
        public string CurrentTaskId{ get; set; }

        /// <summary>
        /// <p>spark作业最近运行状态，初始化：0，运行中：1，成功：2，数据写入中： 3， 排队中： 4， 失败： -1， 已删除： -3，已过期： -5</p>
        /// </summary>
        [JsonProperty("JobStatus")]
        public long? JobStatus{ get; set; }

        /// <summary>
        /// <p>spark流作业统计</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StreamingStat")]
        public StreamingStatistics StreamingStat{ get; set; }

        /// <summary>
        /// <p>数据源名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// <p>pyspark：依赖上传方式，1、cos；2、lakefs（控制台使用，该方式不支持直接接口调用）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsLocalPythonFiles")]
        public string IsLocalPythonFiles{ get; set; }

        /// <summary>
        /// <p>注：该返回值已废弃</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppPythonFiles")]
        public string AppPythonFiles{ get; set; }

        /// <summary>
        /// <p>archives：依赖上传方式，1、cos；2、lakefs（控制台使用，该方式不支持直接接口调用）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsLocalArchives")]
        public string IsLocalArchives{ get; set; }

        /// <summary>
        /// <p>archives：依赖资源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobArchives")]
        public string JobArchives{ get; set; }

        /// <summary>
        /// <p>Spark Image 版本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkImage")]
        public string SparkImage{ get; set; }

        /// <summary>
        /// <p>pyspark：python依赖, 除py文件外，还支持zip/egg等归档格式，多文件以逗号分隔</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobPythonFiles")]
        public string JobPythonFiles{ get; set; }

        /// <summary>
        /// <p>当前job正在运行或准备运行的任务个数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskNum")]
        public long? TaskNum{ get; set; }

        /// <summary>
        /// <p>引擎状态：-100（默认：未知状态），-2~11：引擎正常状态；</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataEngineStatus")]
        public long? DataEngineStatus{ get; set; }

        /// <summary>
        /// <p>指定的Executor数量（最大值），默认为1，当开启动态分配有效，若未开启，则该值等于JobExecutorNums</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobExecutorMaxNumbers")]
        public long? JobExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// <p>镜像版本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkImageVersion")]
        public string SparkImageVersion{ get; set; }

        /// <summary>
        /// <p>查询脚本关联id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>spark_emr_livy</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataEngineClusterType")]
        public string DataEngineClusterType{ get; set; }

        /// <summary>
        /// <p>Spark 3.2-EMR</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataEngineImageVersion")]
        public string DataEngineImageVersion{ get; set; }

        /// <summary>
        /// <p>任务资源配置是否继承集群模板，0（默认）不继承，1：继承</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsInherit")]
        public ulong? IsInherit{ get; set; }

        /// <summary>
        /// <p>是否使用session脚本的sql运行任务：false：否，true：是</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSessionStarted")]
        public bool? IsSessionStarted{ get; set; }

        /// <summary>
        /// <p>引擎详细类型：SparkSQL、PrestoSQL、SparkBatch、StandardSpark、StandardPresto</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineTypeDetail")]
        public string EngineTypeDetail{ get; set; }

        /// <summary>
        /// <p>标准引擎依赖包</p>
        /// </summary>
        [JsonProperty("DependencyPackages")]
        public DependencyPackage[] DependencyPackages{ get; set; }

        /// <summary>
        /// <p>作业运行鉴权身份</p>
        /// </summary>
        [JsonProperty("RunAsIdentity")]
        public string RunAsIdentity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamSimple(map, prefix + "DataEngine", this.DataEngine);
            this.SetParamSimple(map, prefix + "Eni", this.Eni);
            this.SetParamSimple(map, prefix + "IsLocal", this.IsLocal);
            this.SetParamSimple(map, prefix + "JobFile", this.JobFile);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "MainClass", this.MainClass);
            this.SetParamSimple(map, prefix + "CmdArgs", this.CmdArgs);
            this.SetParamSimple(map, prefix + "JobConf", this.JobConf);
            this.SetParamSimple(map, prefix + "IsLocalJars", this.IsLocalJars);
            this.SetParamSimple(map, prefix + "JobJars", this.JobJars);
            this.SetParamSimple(map, prefix + "IsLocalFiles", this.IsLocalFiles);
            this.SetParamSimple(map, prefix + "JobFiles", this.JobFiles);
            this.SetParamSimple(map, prefix + "JobDriverSize", this.JobDriverSize);
            this.SetParamSimple(map, prefix + "JobExecutorSize", this.JobExecutorSize);
            this.SetParamSimple(map, prefix + "JobExecutorNums", this.JobExecutorNums);
            this.SetParamSimple(map, prefix + "JobMaxAttempts", this.JobMaxAttempts);
            this.SetParamSimple(map, prefix + "JobCreator", this.JobCreator);
            this.SetParamSimple(map, prefix + "JobCreateTime", this.JobCreateTime);
            this.SetParamSimple(map, prefix + "JobUpdateTime", this.JobUpdateTime);
            this.SetParamSimple(map, prefix + "CurrentTaskId", this.CurrentTaskId);
            this.SetParamSimple(map, prefix + "JobStatus", this.JobStatus);
            this.SetParamObj(map, prefix + "StreamingStat.", this.StreamingStat);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "IsLocalPythonFiles", this.IsLocalPythonFiles);
            this.SetParamSimple(map, prefix + "AppPythonFiles", this.AppPythonFiles);
            this.SetParamSimple(map, prefix + "IsLocalArchives", this.IsLocalArchives);
            this.SetParamSimple(map, prefix + "JobArchives", this.JobArchives);
            this.SetParamSimple(map, prefix + "SparkImage", this.SparkImage);
            this.SetParamSimple(map, prefix + "JobPythonFiles", this.JobPythonFiles);
            this.SetParamSimple(map, prefix + "TaskNum", this.TaskNum);
            this.SetParamSimple(map, prefix + "DataEngineStatus", this.DataEngineStatus);
            this.SetParamSimple(map, prefix + "JobExecutorMaxNumbers", this.JobExecutorMaxNumbers);
            this.SetParamSimple(map, prefix + "SparkImageVersion", this.SparkImageVersion);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "DataEngineClusterType", this.DataEngineClusterType);
            this.SetParamSimple(map, prefix + "DataEngineImageVersion", this.DataEngineImageVersion);
            this.SetParamSimple(map, prefix + "IsInherit", this.IsInherit);
            this.SetParamSimple(map, prefix + "IsSessionStarted", this.IsSessionStarted);
            this.SetParamSimple(map, prefix + "EngineTypeDetail", this.EngineTypeDetail);
            this.SetParamArrayObj(map, prefix + "DependencyPackages.", this.DependencyPackages);
            this.SetParamSimple(map, prefix + "RunAsIdentity", this.RunAsIdentity);
        }
    }
}

