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

namespace TencentCloud.Msp.V20180319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Task : AbstractModel
    {
        
        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 迁移类型
        /// </summary>
        [JsonProperty("MigrationType")]
        public string MigrationType{ get; set; }

        /// <summary>
        /// 迁移状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 迁移源信息
        /// </summary>
        [JsonProperty("SrcInfo")]
        public SrcInfo SrcInfo{ get; set; }

        /// <summary>
        /// 迁移时间信息
        /// </summary>
        [JsonProperty("MigrationTimeLine")]
        public TimeObj MigrationTimeLine{ get; set; }

        /// <summary>
        /// 状态更新时间
        /// </summary>
        [JsonProperty("Updated")]
        public string Updated{ get; set; }

        /// <summary>
        /// 迁移目的信息
        /// </summary>
        [JsonProperty("DstInfo")]
        public DstInfo DstInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "MigrationType", this.MigrationType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamObj(map, prefix + "MigrationTimeLine.", this.MigrationTimeLine);
            this.SetParamSimple(map, prefix + "Updated", this.Updated);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
        }
    }
}

