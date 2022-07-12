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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SparkJobInfo : AbstractModel
    {
        
        /// <summary>
        /// spark作业ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// spark作业名
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// spark作业类型，可去1或者2，1表示batch作业， 2表示streaming作业
        /// </summary>
        [JsonProperty("JobType")]
        public long? JobType{ get; set; }

        /// <summary>
        /// 引擎名
        /// </summary>
        [JsonProperty("DataEngine")]
        public string DataEngine{ get; set; }

        /// <summary>
        /// 该字段已下线，请使用字段Datasource
        /// </summary>
        [JsonProperty("Eni")]
        public string Eni{ get; set; }

        /// <summary>
        /// 程序包是否本地上传，cos或者lakefs
        /// </summary>
        [JsonProperty("IsLocal")]
        public string IsLocal{ get; set; }

        /// <summary>
        /// 程序包路径
        /// </summary>
        [JsonProperty("JobFile")]
        public string JobFile{ get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonProperty("RoleArn")]
        public long? RoleArn{ get; set; }

        /// <summary>
        /// spark作业运行主类
        /// </summary>
        [JsonProperty("MainClass")]
        public string MainClass{ get; set; }

        /// <summary>
        /// 命令行参数，spark作业命令行参数，空格分隔
        /// </summary>
        [JsonProperty("CmdArgs")]
        public string CmdArgs{ get; set; }

        /// <summary>
        /// spark原生配置，换行符分隔
        /// </summary>
        [JsonProperty("JobConf")]
        public string JobConf{ get; set; }

        /// <summary>
        /// 依赖jars是否本地上传，cos或者lakefs
        /// </summary>
        [JsonProperty("IsLocalJars")]
        public string IsLocalJars{ get; set; }

        /// <summary>
        /// spark作业依赖jars，逗号分隔
        /// </summary>
        [JsonProperty("JobJars")]
        public string JobJars{ get; set; }

        /// <summary>
        /// 依赖文件是否本地上传，cos或者lakefs
        /// </summary>
        [JsonProperty("IsLocalFiles")]
        public string IsLocalFiles{ get; set; }

        /// <summary>
        /// spark作业依赖文件，逗号分隔
        /// </summary>
        [JsonProperty("JobFiles")]
        public string JobFiles{ get; set; }

        /// <summary>
        /// spark作业driver资源大小
        /// </summary>
        [JsonProperty("JobDriverSize")]
        public string JobDriverSize{ get; set; }

        /// <summary>
        /// spark作业executor资源大小
        /// </summary>
        [JsonProperty("JobExecutorSize")]
        public string JobExecutorSize{ get; set; }

        /// <summary>
        /// spark作业executor个数
        /// </summary>
        [JsonProperty("JobExecutorNums")]
        public long? JobExecutorNums{ get; set; }

        /// <summary>
        /// spark流任务最大重试次数
        /// </summary>
        [JsonProperty("JobMaxAttempts")]
        public long? JobMaxAttempts{ get; set; }

        /// <summary>
        /// spark作业创建者
        /// </summary>
        [JsonProperty("JobCreator")]
        public string JobCreator{ get; set; }

        /// <summary>
        /// spark作业创建时间
        /// </summary>
        [JsonProperty("JobCreateTime")]
        public long? JobCreateTime{ get; set; }

        /// <summary>
        /// spark作业更新时间
        /// </summary>
        [JsonProperty("JobUpdateTime")]
        public ulong? JobUpdateTime{ get; set; }

        /// <summary>
        /// spark作业最近任务ID
        /// </summary>
        [JsonProperty("CurrentTaskId")]
        public string CurrentTaskId{ get; set; }

        /// <summary>
        /// spark作业最近运行状态
        /// </summary>
        [JsonProperty("JobStatus")]
        public long? JobStatus{ get; set; }

        /// <summary>
        /// spark流作业统计
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StreamingStat")]
        public StreamingStatistics StreamingStat{ get; set; }

        /// <summary>
        /// 数据源名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// pyspark：依赖上传方式，1、cos；2、lakefs（控制台使用，该方式不支持直接接口调用）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsLocalPythonFiles")]
        public string IsLocalPythonFiles{ get; set; }

        /// <summary>
        /// 注：该返回值已废弃
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppPythonFiles")]
        public string AppPythonFiles{ get; set; }

        /// <summary>
        /// archives：依赖上传方式，1、cos；2、lakefs（控制台使用，该方式不支持直接接口调用）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsLocalArchives")]
        public string IsLocalArchives{ get; set; }

        /// <summary>
        /// archives：依赖资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobArchives")]
        public string JobArchives{ get; set; }

        /// <summary>
        /// pyspark：python依赖, 除py文件外，还支持zip/egg等归档格式，多文件以逗号分隔
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobPythonFiles")]
        public string JobPythonFiles{ get; set; }

        /// <summary>
        /// 当前job正在运行或准备运行的任务个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskNum")]
        public long? TaskNum{ get; set; }


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
            this.SetParamSimple(map, prefix + "JobPythonFiles", this.JobPythonFiles);
            this.SetParamSimple(map, prefix + "TaskNum", this.TaskNum);
        }
    }
}

