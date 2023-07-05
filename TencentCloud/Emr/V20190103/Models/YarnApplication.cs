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

    public class YarnApplication : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 用户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 应用名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 队列
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// 应用类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// 运行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ElapsedTime")]
        public string ElapsedTime{ get; set; }

        /// <summary>
        /// 状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 最终状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinalStatus")]
        public string FinalStatus{ get; set; }

        /// <summary>
        /// 进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// 开始时间毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartedTime")]
        public long? StartedTime{ get; set; }

        /// <summary>
        /// 结束时间毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinishedTime")]
        public long? FinishedTime{ get; set; }

        /// <summary>
        /// 申请内存MB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllocatedMB")]
        public long? AllocatedMB{ get; set; }

        /// <summary>
        /// 申请VCores
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllocatedVCores")]
        public long? AllocatedVCores{ get; set; }

        /// <summary>
        /// 运行的Containers数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningContainers")]
        public long? RunningContainers{ get; set; }

        /// <summary>
        /// 内存MB*时间秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemorySeconds")]
        public long? MemorySeconds{ get; set; }

        /// <summary>
        /// VCores*时间秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VCoreSeconds")]
        public long? VCoreSeconds{ get; set; }

        /// <summary>
        /// 队列资源占比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueUsagePercentage")]
        public float? QueueUsagePercentage{ get; set; }

        /// <summary>
        /// 集群资源占比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterUsagePercentage")]
        public float? ClusterUsagePercentage{ get; set; }

        /// <summary>
        /// 预占用的内存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreemptedResourceMB")]
        public long? PreemptedResourceMB{ get; set; }

        /// <summary>
        /// 预占用的VCore
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreemptedResourceVCores")]
        public long? PreemptedResourceVCores{ get; set; }

        /// <summary>
        /// 预占的非应用程序主节点容器数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumNonAMContainerPreempted")]
        public long? NumNonAMContainerPreempted{ get; set; }

        /// <summary>
        /// AM预占用的容器数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumAMContainerPreempted")]
        public long? NumAMContainerPreempted{ get; set; }

        /// <summary>
        /// Map总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MapsTotal")]
        public long? MapsTotal{ get; set; }

        /// <summary>
        /// 完成的Map数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MapsCompleted")]
        public long? MapsCompleted{ get; set; }

        /// <summary>
        /// Reduce总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReducesTotal")]
        public long? ReducesTotal{ get; set; }

        /// <summary>
        /// 完成的Reduce数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReducesCompleted")]
        public long? ReducesCompleted{ get; set; }

        /// <summary>
        /// 平均Map时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvgMapTime")]
        public long? AvgMapTime{ get; set; }

        /// <summary>
        /// 平均Reduce时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvgReduceTime")]
        public long? AvgReduceTime{ get; set; }

        /// <summary>
        /// 平均Shuffle时间毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvgShuffleTime")]
        public long? AvgShuffleTime{ get; set; }

        /// <summary>
        /// 平均Merge时间毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvgMergeTime")]
        public long? AvgMergeTime{ get; set; }

        /// <summary>
        /// 失败的Reduce执行次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedReduceAttempts")]
        public long? FailedReduceAttempts{ get; set; }

        /// <summary>
        /// Kill的Reduce执行次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KilledReduceAttempts")]
        public long? KilledReduceAttempts{ get; set; }

        /// <summary>
        /// 成功的Reduce执行次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessfulReduceAttempts")]
        public long? SuccessfulReduceAttempts{ get; set; }

        /// <summary>
        /// 失败的Map执行次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedMapAttempts")]
        public long? FailedMapAttempts{ get; set; }

        /// <summary>
        /// Kill的Map执行次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KilledMapAttempts")]
        public long? KilledMapAttempts{ get; set; }

        /// <summary>
        /// 成功的Map执行次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessfulMapAttempts")]
        public long? SuccessfulMapAttempts{ get; set; }

        /// <summary>
        /// GC毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GcTimeMillis")]
        public long? GcTimeMillis{ get; set; }

        /// <summary>
        /// Map使用的VCore毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VCoreMillisMaps")]
        public long? VCoreMillisMaps{ get; set; }

        /// <summary>
        /// Map使用的内存毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MbMillisMaps")]
        public long? MbMillisMaps{ get; set; }

        /// <summary>
        /// Reduce使用的VCore毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VCoreMillisReduces")]
        public long? VCoreMillisReduces{ get; set; }

        /// <summary>
        /// Reduce使用的内存毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MbMillisReduces")]
        public long? MbMillisReduces{ get; set; }

        /// <summary>
        /// 启动Map的总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalLaunchedMaps")]
        public long? TotalLaunchedMaps{ get; set; }

        /// <summary>
        /// 启动Reduce的总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalLaunchedReduces")]
        public long? TotalLaunchedReduces{ get; set; }

        /// <summary>
        /// Map输入记录数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MapInputRecords")]
        public long? MapInputRecords{ get; set; }

        /// <summary>
        /// Map输出记录数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MapOutputRecords")]
        public long? MapOutputRecords{ get; set; }

        /// <summary>
        /// Reduce输入记录数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReduceInputRecords")]
        public long? ReduceInputRecords{ get; set; }

        /// <summary>
        /// Reduce输出记录数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReduceOutputRecords")]
        public long? ReduceOutputRecords{ get; set; }

        /// <summary>
        /// HDFS写入字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HDFSBytesWritten")]
        public long? HDFSBytesWritten{ get; set; }

        /// <summary>
        /// HDFS读取字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HDFSBytesRead")]
        public long? HDFSBytesRead{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "ElapsedTime", this.ElapsedTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "FinalStatus", this.FinalStatus);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "StartedTime", this.StartedTime);
            this.SetParamSimple(map, prefix + "FinishedTime", this.FinishedTime);
            this.SetParamSimple(map, prefix + "AllocatedMB", this.AllocatedMB);
            this.SetParamSimple(map, prefix + "AllocatedVCores", this.AllocatedVCores);
            this.SetParamSimple(map, prefix + "RunningContainers", this.RunningContainers);
            this.SetParamSimple(map, prefix + "MemorySeconds", this.MemorySeconds);
            this.SetParamSimple(map, prefix + "VCoreSeconds", this.VCoreSeconds);
            this.SetParamSimple(map, prefix + "QueueUsagePercentage", this.QueueUsagePercentage);
            this.SetParamSimple(map, prefix + "ClusterUsagePercentage", this.ClusterUsagePercentage);
            this.SetParamSimple(map, prefix + "PreemptedResourceMB", this.PreemptedResourceMB);
            this.SetParamSimple(map, prefix + "PreemptedResourceVCores", this.PreemptedResourceVCores);
            this.SetParamSimple(map, prefix + "NumNonAMContainerPreempted", this.NumNonAMContainerPreempted);
            this.SetParamSimple(map, prefix + "NumAMContainerPreempted", this.NumAMContainerPreempted);
            this.SetParamSimple(map, prefix + "MapsTotal", this.MapsTotal);
            this.SetParamSimple(map, prefix + "MapsCompleted", this.MapsCompleted);
            this.SetParamSimple(map, prefix + "ReducesTotal", this.ReducesTotal);
            this.SetParamSimple(map, prefix + "ReducesCompleted", this.ReducesCompleted);
            this.SetParamSimple(map, prefix + "AvgMapTime", this.AvgMapTime);
            this.SetParamSimple(map, prefix + "AvgReduceTime", this.AvgReduceTime);
            this.SetParamSimple(map, prefix + "AvgShuffleTime", this.AvgShuffleTime);
            this.SetParamSimple(map, prefix + "AvgMergeTime", this.AvgMergeTime);
            this.SetParamSimple(map, prefix + "FailedReduceAttempts", this.FailedReduceAttempts);
            this.SetParamSimple(map, prefix + "KilledReduceAttempts", this.KilledReduceAttempts);
            this.SetParamSimple(map, prefix + "SuccessfulReduceAttempts", this.SuccessfulReduceAttempts);
            this.SetParamSimple(map, prefix + "FailedMapAttempts", this.FailedMapAttempts);
            this.SetParamSimple(map, prefix + "KilledMapAttempts", this.KilledMapAttempts);
            this.SetParamSimple(map, prefix + "SuccessfulMapAttempts", this.SuccessfulMapAttempts);
            this.SetParamSimple(map, prefix + "GcTimeMillis", this.GcTimeMillis);
            this.SetParamSimple(map, prefix + "VCoreMillisMaps", this.VCoreMillisMaps);
            this.SetParamSimple(map, prefix + "MbMillisMaps", this.MbMillisMaps);
            this.SetParamSimple(map, prefix + "VCoreMillisReduces", this.VCoreMillisReduces);
            this.SetParamSimple(map, prefix + "MbMillisReduces", this.MbMillisReduces);
            this.SetParamSimple(map, prefix + "TotalLaunchedMaps", this.TotalLaunchedMaps);
            this.SetParamSimple(map, prefix + "TotalLaunchedReduces", this.TotalLaunchedReduces);
            this.SetParamSimple(map, prefix + "MapInputRecords", this.MapInputRecords);
            this.SetParamSimple(map, prefix + "MapOutputRecords", this.MapOutputRecords);
            this.SetParamSimple(map, prefix + "ReduceInputRecords", this.ReduceInputRecords);
            this.SetParamSimple(map, prefix + "ReduceOutputRecords", this.ReduceOutputRecords);
            this.SetParamSimple(map, prefix + "HDFSBytesWritten", this.HDFSBytesWritten);
            this.SetParamSimple(map, prefix + "HDFSBytesRead", this.HDFSBytesRead);
        }
    }
}

