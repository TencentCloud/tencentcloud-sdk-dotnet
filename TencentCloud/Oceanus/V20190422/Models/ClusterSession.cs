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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterSession : AbstractModel
    {
        
        /// <summary>
        /// <p>集群SerialId</p>
        /// </summary>
        [JsonProperty("ClusterGroupSerialId")]
        public string ClusterGroupSerialId{ get; set; }

        /// <summary>
        /// <p>创建者appId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>创建者主账号</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>创建者账号</p>
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// <p>区域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>zone</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Session集群状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Session集群消耗的cu数量</p>
        /// </summary>
        [JsonProperty("CuNum")]
        public float? CuNum{ get; set; }

        /// <summary>
        /// <p>Session集群的Flink版本</p>
        /// </summary>
        [JsonProperty("FlinkVersion")]
        public string FlinkVersion{ get; set; }

        /// <summary>
        /// <p>session集群FlinkUi地址</p>
        /// </summary>
        [JsonProperty("WebUIUrl")]
        public string WebUIUrl{ get; set; }

        /// <summary>
        /// <p>session集群高级参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Properties")]
        public Property[] Properties{ get; set; }

        /// <summary>
        /// <p>引用资源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceRefs")]
        public SessionClusterRefItem[] ResourceRefs{ get; set; }

        /// <summary>
        /// <p>JobManager的规格</p>
        /// </summary>
        [JsonProperty("JobManagerCuSpec")]
        public float? JobManagerCuSpec{ get; set; }

        /// <summary>
        /// <p>TaskManager的规格</p>
        /// </summary>
        [JsonProperty("TaskManagerCuSpec")]
        public float? TaskManagerCuSpec{ get; set; }

        /// <summary>
        /// <p>TaskManager启动的数量</p>
        /// </summary>
        [JsonProperty("TaskManagerNum")]
        public long? TaskManagerNum{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>JobManagerCpu</p>
        /// </summary>
        [JsonProperty("JobManagerCpu")]
        public float? JobManagerCpu{ get; set; }

        /// <summary>
        /// <p>JobManagerMem</p>
        /// </summary>
        [JsonProperty("JobManagerMem")]
        public float? JobManagerMem{ get; set; }

        /// <summary>
        /// <p>TaskManagerCpu</p>
        /// </summary>
        [JsonProperty("TaskManagerCpu")]
        public float? TaskManagerCpu{ get; set; }

        /// <summary>
        /// <p>TaskManagerMem</p>
        /// </summary>
        [JsonProperty("TaskManagerMem")]
        public float? TaskManagerMem{ get; set; }

        /// <summary>
        /// <p>jdk版本</p>
        /// </summary>
        [JsonProperty("JdkVersion")]
        public string JdkVersion{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>session集群SerialId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SerialId")]
        public string SerialId{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterGroupName")]
        public string ClusterGroupName{ get; set; }

        /// <summary>
        /// <p>cu</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalCpu")]
        public float? TotalCpu{ get; set; }

        /// <summary>
        /// <p>使用Mem</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalMem")]
        public float? TotalMem{ get; set; }

        /// <summary>
        /// <p>空间Id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkSpaceId")]
        public string WorkSpaceId{ get; set; }

        /// <summary>
        /// <p>空间名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkSpaceName")]
        public string WorkSpaceName{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>采集日志配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogConfig")]
        public string LogConfig{ get; set; }

        /// <summary>
        /// <p>更新用户</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUin")]
        public string UpdateUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterGroupSerialId", this.ClusterGroupSerialId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CuNum", this.CuNum);
            this.SetParamSimple(map, prefix + "FlinkVersion", this.FlinkVersion);
            this.SetParamSimple(map, prefix + "WebUIUrl", this.WebUIUrl);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamArrayObj(map, prefix + "ResourceRefs.", this.ResourceRefs);
            this.SetParamSimple(map, prefix + "JobManagerCuSpec", this.JobManagerCuSpec);
            this.SetParamSimple(map, prefix + "TaskManagerCuSpec", this.TaskManagerCuSpec);
            this.SetParamSimple(map, prefix + "TaskManagerNum", this.TaskManagerNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "JobManagerCpu", this.JobManagerCpu);
            this.SetParamSimple(map, prefix + "JobManagerMem", this.JobManagerMem);
            this.SetParamSimple(map, prefix + "TaskManagerCpu", this.TaskManagerCpu);
            this.SetParamSimple(map, prefix + "TaskManagerMem", this.TaskManagerMem);
            this.SetParamSimple(map, prefix + "JdkVersion", this.JdkVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SerialId", this.SerialId);
            this.SetParamSimple(map, prefix + "ClusterGroupName", this.ClusterGroupName);
            this.SetParamSimple(map, prefix + "TotalCpu", this.TotalCpu);
            this.SetParamSimple(map, prefix + "TotalMem", this.TotalMem);
            this.SetParamSimple(map, prefix + "WorkSpaceId", this.WorkSpaceId);
            this.SetParamSimple(map, prefix + "WorkSpaceName", this.WorkSpaceName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LogConfig", this.LogConfig);
            this.SetParamSimple(map, prefix + "UpdateUin", this.UpdateUin);
        }
    }
}

