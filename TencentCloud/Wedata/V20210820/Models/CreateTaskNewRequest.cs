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

    public class CreateTaskNewRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 工作流id
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 26离线同步，30Python，31PySpark，32DLC，33Impala，34Hive SQL，35Shell，36Spark SQL，39Spark，40CDW PG，92MapReduce
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [JsonProperty("TaskExt")]
        public TaskExtInfo[] TaskExt{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 任务实例初始化策略
        /// </summary>
        [JsonProperty("InstanceInitStrategy")]
        public string InstanceInitStrategy{ get; set; }

        /// <summary>
        /// 画布坐标横轴
        /// </summary>
        [JsonProperty("LeftCoordinate")]
        public float? LeftCoordinate{ get; set; }

        /// <summary>
        /// 画布坐标纵轴
        /// </summary>
        [JsonProperty("TopCoordinate")]
        public float? TopCoordinate{ get; set; }

        /// <summary>
        /// 工作流目录ID
        /// </summary>
        [JsonProperty("TaskFolderId")]
        public string TaskFolderId{ get; set; }

        /// <summary>
        /// （必填参数）指定脚本内容，base64编码
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 代码模板ID
        /// </summary>
        [JsonProperty("CodeTemplateId")]
        public string CodeTemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArrayObj(map, prefix + "TaskExt.", this.TaskExt);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "InstanceInitStrategy", this.InstanceInitStrategy);
            this.SetParamSimple(map, prefix + "LeftCoordinate", this.LeftCoordinate);
            this.SetParamSimple(map, prefix + "TopCoordinate", this.TopCoordinate);
            this.SetParamSimple(map, prefix + "TaskFolderId", this.TaskFolderId);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "CodeTemplateId", this.CodeTemplateId);
        }
    }
}

