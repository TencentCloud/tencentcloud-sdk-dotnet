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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListTaskFoldersRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 父文件夹绝对路径，如/abc/de，如果是根目录则传/
        /// </summary>
        [JsonProperty("ParentTaskFolderPath")]
        public string ParentTaskFolderPath{ get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 任务文件夹类型
        /// 
        /// | 任务文件夹类型取值 | 任务文件夹类型界面对应名称 |
        /// | ---------------- | ------------------------ |
        /// | ETL              | 集成任务                 |
        /// | EMR              | EMR                      |
        /// | DLC              | DLC                      |
        /// | SETATS           | SETATS                   |
        /// | TDSQL            | TDSQL                    |
        /// | TCHOUSE          | TCHOUSE                  |
        /// | GENERAL          | 通用                     |
        /// | TI_ONE           | TI-ONE机器学习           |
        /// | ACROSS_WORKFLOWS | 跨工作流                 |
        /// 
        /// </summary>
        [JsonProperty("TaskFolderType")]
        public string TaskFolderType{ get; set; }

        /// <summary>
        /// 数据页数，大于等于1。默认1
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页显示的数据条数，最小为10条，最大为200 条。默认10
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ParentTaskFolderPath", this.ParentTaskFolderPath);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "TaskFolderType", this.TaskFolderType);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

