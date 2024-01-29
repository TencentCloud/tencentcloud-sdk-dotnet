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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCodeSearchInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 搜索关键词
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 要查询的搜索范围
        /// </summary>
        [JsonProperty("SearchScope")]
        public string SearchScope{ get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 条数
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 搜索范围列表
        /// </summary>
        [JsonProperty("SearchScopes")]
        public string[] SearchScopes{ get; set; }

        /// <summary>
        /// 责任人ID列表
        /// </summary>
        [JsonProperty("OwnerIds")]
        public string[] OwnerIds{ get; set; }

        /// <summary>
        /// 文件类型列表
        /// </summary>
        [JsonProperty("FileTypes")]
        public string[] FileTypes{ get; set; }

        /// <summary>
        /// 任务类型列表
        /// </summary>
        [JsonProperty("TaskTypes")]
        public string[] TaskTypes{ get; set; }

        /// <summary>
        /// 更新时间范围：开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 更新时间范围：结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 开发态/生产态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [JsonProperty("WorkflowIds")]
        public string[] WorkflowIds{ get; set; }

        /// <summary>
        /// 文件夹ID
        /// </summary>
        [JsonProperty("FolderIds")]
        public string[] FolderIds{ get; set; }

        /// <summary>
        /// 数据源ID
        /// </summary>
        [JsonProperty("DatasourceIds")]
        public string[] DatasourceIds{ get; set; }

        /// <summary>
        /// 文件夹路径
        /// </summary>
        [JsonProperty("FolderPaths")]
        public string[] FolderPaths{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string[] TaskStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "SearchScope", this.SearchScope);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "SearchScopes.", this.SearchScopes);
            this.SetParamArraySimple(map, prefix + "OwnerIds.", this.OwnerIds);
            this.SetParamArraySimple(map, prefix + "FileTypes.", this.FileTypes);
            this.SetParamArraySimple(map, prefix + "TaskTypes.", this.TaskTypes);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "WorkflowIds.", this.WorkflowIds);
            this.SetParamArraySimple(map, prefix + "FolderIds.", this.FolderIds);
            this.SetParamArraySimple(map, prefix + "DatasourceIds.", this.DatasourceIds);
            this.SetParamArraySimple(map, prefix + "FolderPaths.", this.FolderPaths);
            this.SetParamArraySimple(map, prefix + "TaskStatus.", this.TaskStatus);
        }
    }
}

