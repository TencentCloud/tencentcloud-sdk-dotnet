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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JobV1 : AbstractModel
    {
        
        /// <summary>
        /// 作业ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 用户AppId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 用户UIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 创建者UIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// 作业名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 作业类型，1：sql作业，2：Jar作业
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobType")]
        public long? JobType{ get; set; }

        /// <summary>
        /// 作业状态，1：未初始化，2：未发布，3：操作中，4：运行中，5：停止，6：暂停，-1：故障
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 作业创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 作业启动时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 作业停止时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StopTime")]
        public string StopTime{ get; set; }

        /// <summary>
        /// 作业更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 作业累计运行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalRunMillis")]
        public long? TotalRunMillis{ get; set; }

        /// <summary>
        /// 备注信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 操作错误提示信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastOpResult")]
        public string LastOpResult{ get; set; }

        /// <summary>
        /// 集群名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 最新配置版本号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestJobConfigVersion")]
        public long? LatestJobConfigVersion{ get; set; }

        /// <summary>
        /// 已发布的配置版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublishedJobConfigVersion")]
        public long? PublishedJobConfigVersion{ get; set; }

        /// <summary>
        /// 运行的CU数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningCuNum")]
        public long? RunningCuNum{ get; set; }

        /// <summary>
        /// 作业内存规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CuMem")]
        public long? CuMem{ get; set; }

        /// <summary>
        /// 作业状态描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 运行状态时表示单次运行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentRunMillis")]
        public long? CurrentRunMillis{ get; set; }

        /// <summary>
        /// 作业所在的集群ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 作业管理WEB UI 入口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebUIUrl")]
        public string WebUIUrl{ get; set; }

        /// <summary>
        /// 作业所在集群类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerType")]
        public long? SchedulerType{ get; set; }

        /// <summary>
        /// 作业所在集群状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public long? ClusterStatus{ get; set; }

        /// <summary>
        /// 细粒度下的运行的CU数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningCu")]
        public float? RunningCu{ get; set; }

        /// <summary>
        /// 作业运行的 Flink 版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlinkVersion")]
        public string FlinkVersion{ get; set; }

        /// <summary>
        /// 工作空间 SerialId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkSpaceId")]
        public string WorkSpaceId{ get; set; }

        /// <summary>
        /// 工作空间名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkSpaceName")]
        public string WorkSpaceName{ get; set; }

        /// <summary>
        /// 作业标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 作业异常事件信息	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventInfo")]
        public JobEventInfo EventInfo{ get; set; }

        /// <summary>
        /// 描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "StopTime", this.StopTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "TotalRunMillis", this.TotalRunMillis);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "LastOpResult", this.LastOpResult);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "LatestJobConfigVersion", this.LatestJobConfigVersion);
            this.SetParamSimple(map, prefix + "PublishedJobConfigVersion", this.PublishedJobConfigVersion);
            this.SetParamSimple(map, prefix + "RunningCuNum", this.RunningCuNum);
            this.SetParamSimple(map, prefix + "CuMem", this.CuMem);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "CurrentRunMillis", this.CurrentRunMillis);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "WebUIUrl", this.WebUIUrl);
            this.SetParamSimple(map, prefix + "SchedulerType", this.SchedulerType);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "RunningCu", this.RunningCu);
            this.SetParamSimple(map, prefix + "FlinkVersion", this.FlinkVersion);
            this.SetParamSimple(map, prefix + "WorkSpaceId", this.WorkSpaceId);
            this.SetParamSimple(map, prefix + "WorkSpaceName", this.WorkSpaceName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "EventInfo.", this.EventInfo);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

