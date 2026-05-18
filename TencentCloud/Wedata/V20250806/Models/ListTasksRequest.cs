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

    public class ListTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>请求的数据页数。默认值为1，取值大于等于1</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页显示的数据条数。默认值为10 ，最小值为10，最大值为200</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>所属工作流ID</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>责任人ID</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>任务类型</p>
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public long? TaskTypeId{ get; set; }

        /// <summary>
        /// <p>任务状态</p><ul><li>N: 新建 </li><li>Y: 调度中 </li><li>F: 已下线 </li><li>O: 已暂停 </li><li>T: 下线中 </li><li>INVALID: 已失效</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>提交状态</p>
        /// </summary>
        [JsonProperty("Submit")]
        public bool? Submit{ get; set; }

        /// <summary>
        /// <p>BundleId信息</p>
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// <p>创建人ID</p>
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// <p>修改时间区间 yyyy-MM-dd HH:mm:ss，需要在数组填入两个时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string[] ModifyTime{ get; set; }

        /// <summary>
        /// <p>创建时间区间 yyyy-MM-dd HH:mm:ss，需要在数组填入两个时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string[] CreateTime{ get; set; }

        /// <summary>
        /// <p>任务文件夹路径列表，支持多选，从工作流下的目录开始填写，节点类型无需填写。选择上层文件夹时，自动包含所有子文件夹下的任务。 路径格式为绝对路径，如 &quot;/子目录A&quot;，根目录为 &quot;/&quot;</p>
        /// </summary>
        [JsonProperty("TaskFolderPathList")]
        public string[] TaskFolderPathList{ get; set; }

        /// <summary>
        /// <p>工作流文件夹路径列表，支持多选。选择上层文件夹时，自动包含所有子文件夹下工作流的任务。 路径格式为绝对路径，如 &quot;/数据开发/子目录&quot;，根目录为 &quot;/&quot;。</p>
        /// </summary>
        [JsonProperty("WorkflowFolderPathList")]
        public string[] WorkflowFolderPathList{ get; set; }

        /// <summary>
        /// <p>节点类型列表，用于按任务节点分类筛选，支持多选， 可选值参考下面枚举类型 。 传入后将根据这些节点类型包含的任务类型ID列表进行筛选。</p><p>枚举值：</p><ul><li>ETL： 数据集成节点</li><li>EMR： EMR节点</li><li>DLC： DLC节点</li><li>SETATS： SETATS节点</li><li>TDSQL： TDSQL节点</li><li>TCHOUSE： TCHOUSE节点</li><li>GENERAL： 通用节点</li><li>DATA_QUALITY： 数据质量节点</li><li>INDICATOR： 指标节点</li><li>TI_ONE： TI-ONE机器学习节点</li></ul>
        /// </summary>
        [JsonProperty("TaskNodeTypeList")]
        public string[] TaskNodeTypeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Submit", this.Submit);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamArraySimple(map, prefix + "ModifyTime.", this.ModifyTime);
            this.SetParamArraySimple(map, prefix + "CreateTime.", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "TaskFolderPathList.", this.TaskFolderPathList);
            this.SetParamArraySimple(map, prefix + "WorkflowFolderPathList.", this.WorkflowFolderPathList);
            this.SetParamArraySimple(map, prefix + "TaskNodeTypeList.", this.TaskNodeTypeList);
        }
    }
}

