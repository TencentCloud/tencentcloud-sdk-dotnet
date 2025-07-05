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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDsFolderTreeRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 是否一级拉取 true 是 
        /// false 否
        /// </summary>
        [JsonProperty("FirstLevelPull")]
        public bool? FirstLevelPull{ get; set; }

        /// <summary>
        /// 文件夹ID
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 关键字搜索
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 是否包含工作流 true 是 
        /// false 否
        /// </summary>
        [JsonProperty("IncludeWorkflow")]
        public bool? IncludeWorkflow{ get; set; }

        /// <summary>
        /// 是否包含任务 true 是 
        /// false 否
        /// </summary>
        [JsonProperty("IncludeTask")]
        public bool? IncludeTask{ get; set; }

        /// <summary>
        /// 是否包含虚拟任务，当 IncludeTask 为 true 的时候，该参数才生效，默认为 true
        /// </summary>
        [JsonProperty("IncludeVirtualTask")]
        public bool? IncludeVirtualTask{ get; set; }

        /// <summary>
        /// 任务目录id
        /// </summary>
        [JsonProperty("TaskFolderId")]
        public string TaskFolderId{ get; set; }

        /// <summary>
        /// classification.分类展示  catalog.目录展示
        /// </summary>
        [JsonProperty("DisplayType")]
        public string DisplayType{ get; set; }

        /// <summary>
        /// 是否包含任务目录 true 是 
        /// false 否
        /// </summary>
        [JsonProperty("IncludeTaskFolder")]
        public bool? IncludeTaskFolder{ get; set; }

        /// <summary>
        /// 是否使用最新模式展示目录树
        /// </summary>
        [JsonProperty("NewFolderTreeMode")]
        public bool? NewFolderTreeMode{ get; set; }

        /// <summary>
        /// 节点分类ID
        /// </summary>
        [JsonProperty("TaskNodeId")]
        public string TaskNodeId{ get; set; }

        /// <summary>
        /// 工作流类型, 使用场景: 任务复制,选择工作流. 取值范围
        /// 
        /// - cycle    周期工作流
        /// - manual    手动工作流
        /// </summary>
        [JsonProperty("WorkflowType")]
        public string WorkflowType{ get; set; }

        /// <summary>
        /// 任务类型id列表
        /// </summary>
        [JsonProperty("TaskTypeIdList")]
        public long?[] TaskTypeIdList{ get; set; }

        /// <summary>
        /// 责任人id列表
        /// </summary>
        [JsonProperty("InChargeIdList")]
        public string[] InChargeIdList{ get; set; }

        /// <summary>
        /// 自身责任人
        /// </summary>
        [JsonProperty("OnlyMe")]
        public bool? OnlyMe{ get; set; }

        /// <summary>
        /// 是否包含代码模版
        /// </summary>
        [JsonProperty("IncludeCodeTemplate")]
        public bool? IncludeCodeTemplate{ get; set; }

        /// <summary>
        /// 编排空间 或代码模版 orchestrationSpace 编排空间 template模版管理
        /// </summary>
        [JsonProperty("FolderForm")]
        public string FolderForm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "FirstLevelPull", this.FirstLevelPull);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "IncludeWorkflow", this.IncludeWorkflow);
            this.SetParamSimple(map, prefix + "IncludeTask", this.IncludeTask);
            this.SetParamSimple(map, prefix + "IncludeVirtualTask", this.IncludeVirtualTask);
            this.SetParamSimple(map, prefix + "TaskFolderId", this.TaskFolderId);
            this.SetParamSimple(map, prefix + "DisplayType", this.DisplayType);
            this.SetParamSimple(map, prefix + "IncludeTaskFolder", this.IncludeTaskFolder);
            this.SetParamSimple(map, prefix + "NewFolderTreeMode", this.NewFolderTreeMode);
            this.SetParamSimple(map, prefix + "TaskNodeId", this.TaskNodeId);
            this.SetParamSimple(map, prefix + "WorkflowType", this.WorkflowType);
            this.SetParamArraySimple(map, prefix + "TaskTypeIdList.", this.TaskTypeIdList);
            this.SetParamArraySimple(map, prefix + "InChargeIdList.", this.InChargeIdList);
            this.SetParamSimple(map, prefix + "OnlyMe", this.OnlyMe);
            this.SetParamSimple(map, prefix + "IncludeCodeTemplate", this.IncludeCodeTemplate);
            this.SetParamSimple(map, prefix + "FolderForm", this.FolderForm);
        }
    }
}

