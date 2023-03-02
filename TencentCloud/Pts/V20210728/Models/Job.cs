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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Job : AbstractModel
    {
        
        /// <summary>
        /// 任务的JobID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 任务的场景ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScenarioId")]
        public string ScenarioId{ get; set; }

        /// <summary>
        /// 任务的施压配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Load")]
        public Load Load{ get; set; }

        /// <summary>
        /// 此字段不再使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Configs")]
        public string[] Configs{ get; set; }

        /// <summary>
        /// 任务的数据集文件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Datasets")]
        public TestData[] Datasets{ get; set; }

        /// <summary>
        /// 此字段不再使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extensions")]
        public string[] Extensions{ get; set; }

        /// <summary>
        /// 任务的运行状态, JobUnknown: 0,JobCreated:1,JobPending:2, JobPreparing:3,JobSelectClustering:4,JobCreateTasking:5,JobSyncTasking:6
        /// JobRunning:11,JobFinished:12,JobPrepareException:13,JobFinishException:14,JobAborting:15,JobAborted:16,JobAbortException:17,JobDeleted:18,
        /// JobSelectClusterException:19,JobCreateTaskException:20,JobSyncTaskException:21
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 任务的开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务的结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务的最大VU数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxVirtualUserCount")]
        public long? MaxVirtualUserCount{ get; set; }

        /// <summary>
        /// 任务的备注信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 错误率百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorRate")]
        public float? ErrorRate{ get; set; }

        /// <summary>
        /// 任务发起人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobOwner")]
        public string JobOwner{ get; set; }

        /// <summary>
        /// 此字段不再使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadSources")]
        public LoadSource LoadSources{ get; set; }

        /// <summary>
        /// 任务时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 最大每秒请求数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxRequestsPerSecond")]
        public long? MaxRequestsPerSecond{ get; set; }

        /// <summary>
        /// 总请求数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestTotal")]
        public float? RequestTotal{ get; set; }

        /// <summary>
        /// 平均每秒请求数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestsPerSecond")]
        public float? RequestsPerSecond{ get; set; }

        /// <summary>
        /// 平均响应时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseTimeAverage")]
        public float? ResponseTimeAverage{ get; set; }

        /// <summary>
        /// 响应时间第99百分位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseTimeP99")]
        public float? ResponseTimeP99{ get; set; }

        /// <summary>
        /// 响应时间第95百分位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseTimeP95")]
        public float? ResponseTimeP95{ get; set; }

        /// <summary>
        /// 响应时间第90百分位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseTimeP90")]
        public float? ResponseTimeP90{ get; set; }

        /// <summary>
        /// 此字段不再使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Scripts")]
        public string[] Scripts{ get; set; }

        /// <summary>
        /// 最大响应时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseTimeMax")]
        public float? ResponseTimeMax{ get; set; }

        /// <summary>
        /// 最小响应时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseTimeMin")]
        public float? ResponseTimeMin{ get; set; }

        /// <summary>
        /// 发压host信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadSourceInfos")]
        public LoadSource[] LoadSourceInfos{ get; set; }

        /// <summary>
        /// 测试脚本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TestScripts")]
        public ScriptInfo[] TestScripts{ get; set; }

        /// <summary>
        /// 协议脚本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocols")]
        public ProtocolInfo[] Protocols{ get; set; }

        /// <summary>
        /// 请求文件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestFiles")]
        public FileInfo[] RequestFiles{ get; set; }

        /// <summary>
        /// 拓展包文件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Plugins")]
        public FileInfo[] Plugins{ get; set; }

        /// <summary>
        /// 定时任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CronId")]
        public string CronId{ get; set; }

        /// <summary>
        /// 场景类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 域名绑定配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainNameConfig")]
        public DomainNameConfig DomainNameConfig{ get; set; }

        /// <summary>
        /// false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Debug")]
        public bool? Debug{ get; set; }

        /// <summary>
        /// 中断原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AbortReason")]
        public long? AbortReason{ get; set; }

        /// <summary>
        /// 任务的创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 项目ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 通知事件回调
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotificationHooks")]
        public NotificationHook[] NotificationHooks{ get; set; }

        /// <summary>
        /// 每秒接收字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkReceiveRate")]
        public float? NetworkReceiveRate{ get; set; }

        /// <summary>
        /// 每秒发送字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkSendRate")]
        public float? NetworkSendRate{ get; set; }

        /// <summary>
        /// 任务状态描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// test-project
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// test-scenario
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScenarioName")]
        public string ScenarioName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "ScenarioId", this.ScenarioId);
            this.SetParamObj(map, prefix + "Load.", this.Load);
            this.SetParamArraySimple(map, prefix + "Configs.", this.Configs);
            this.SetParamArrayObj(map, prefix + "Datasets.", this.Datasets);
            this.SetParamArraySimple(map, prefix + "Extensions.", this.Extensions);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MaxVirtualUserCount", this.MaxVirtualUserCount);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "ErrorRate", this.ErrorRate);
            this.SetParamSimple(map, prefix + "JobOwner", this.JobOwner);
            this.SetParamObj(map, prefix + "LoadSources.", this.LoadSources);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "MaxRequestsPerSecond", this.MaxRequestsPerSecond);
            this.SetParamSimple(map, prefix + "RequestTotal", this.RequestTotal);
            this.SetParamSimple(map, prefix + "RequestsPerSecond", this.RequestsPerSecond);
            this.SetParamSimple(map, prefix + "ResponseTimeAverage", this.ResponseTimeAverage);
            this.SetParamSimple(map, prefix + "ResponseTimeP99", this.ResponseTimeP99);
            this.SetParamSimple(map, prefix + "ResponseTimeP95", this.ResponseTimeP95);
            this.SetParamSimple(map, prefix + "ResponseTimeP90", this.ResponseTimeP90);
            this.SetParamArraySimple(map, prefix + "Scripts.", this.Scripts);
            this.SetParamSimple(map, prefix + "ResponseTimeMax", this.ResponseTimeMax);
            this.SetParamSimple(map, prefix + "ResponseTimeMin", this.ResponseTimeMin);
            this.SetParamArrayObj(map, prefix + "LoadSourceInfos.", this.LoadSourceInfos);
            this.SetParamArrayObj(map, prefix + "TestScripts.", this.TestScripts);
            this.SetParamArrayObj(map, prefix + "Protocols.", this.Protocols);
            this.SetParamArrayObj(map, prefix + "RequestFiles.", this.RequestFiles);
            this.SetParamArrayObj(map, prefix + "Plugins.", this.Plugins);
            this.SetParamSimple(map, prefix + "CronId", this.CronId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "DomainNameConfig.", this.DomainNameConfig);
            this.SetParamSimple(map, prefix + "Debug", this.Debug);
            this.SetParamSimple(map, prefix + "AbortReason", this.AbortReason);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "NotificationHooks.", this.NotificationHooks);
            this.SetParamSimple(map, prefix + "NetworkReceiveRate", this.NetworkReceiveRate);
            this.SetParamSimple(map, prefix + "NetworkSendRate", this.NetworkSendRate);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "ScenarioName", this.ScenarioName);
        }
    }
}

