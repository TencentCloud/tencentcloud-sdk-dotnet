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
        /// 集群SerialId
        /// </summary>
        [JsonProperty("ClusterGroupSerialId")]
        public string ClusterGroupSerialId{ get; set; }

        /// <summary>
        /// 创建者appId
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 创建者主账号
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 创建者账号
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// zone
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Session集群状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Session集群消耗的cu数量
        /// </summary>
        [JsonProperty("CuNum")]
        public float? CuNum{ get; set; }

        /// <summary>
        /// Session集群的Flink版本
        /// </summary>
        [JsonProperty("FlinkVersion")]
        public string FlinkVersion{ get; set; }

        /// <summary>
        /// session集群FlinkUi地址
        /// </summary>
        [JsonProperty("WebUIUrl")]
        public string WebUIUrl{ get; set; }

        /// <summary>
        /// session集群高级参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Properties")]
        public Property[] Properties{ get; set; }

        /// <summary>
        /// 引用资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceRefs")]
        public SessionClusterRefItem[] ResourceRefs{ get; set; }

        /// <summary>
        /// JobManager的规格
        /// </summary>
        [JsonProperty("JobManagerCuSpec")]
        public float? JobManagerCuSpec{ get; set; }

        /// <summary>
        /// TaskManager的规格
        /// </summary>
        [JsonProperty("TaskManagerCuSpec")]
        public float? TaskManagerCuSpec{ get; set; }

        /// <summary>
        /// TaskManager启动的数量
        /// </summary>
        [JsonProperty("TaskManagerNum")]
        public long? TaskManagerNum{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// JobManagerCpu
        /// </summary>
        [JsonProperty("JobManagerCpu")]
        public float? JobManagerCpu{ get; set; }

        /// <summary>
        /// JobManagerMem
        /// </summary>
        [JsonProperty("JobManagerMem")]
        public float? JobManagerMem{ get; set; }

        /// <summary>
        /// TaskManagerCpu
        /// </summary>
        [JsonProperty("TaskManagerCpu")]
        public float? TaskManagerCpu{ get; set; }

        /// <summary>
        /// TaskManagerMem
        /// </summary>
        [JsonProperty("TaskManagerMem")]
        public float? TaskManagerMem{ get; set; }

        /// <summary>
        /// jdk版本
        /// </summary>
        [JsonProperty("JdkVersion")]
        public string JdkVersion{ get; set; }


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
        }
    }
}

