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

    public class CreateScriptsImportTasksDsRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务属性
        /// </summary>
        [JsonProperty("Task")]
        public TaskDsDTOLite Task{ get; set; }

        /// <summary>
        /// 自定义业务实体信息列表
        /// </summary>
        [JsonProperty("EntityDTOList")]
        public CustomizeBusinessEntityDTO[] EntityDTOList{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 0:跳过；1:重命名
        /// </summary>
        [JsonProperty("TaskNameExistMode")]
        public long? TaskNameExistMode{ get; set; }

        /// <summary>
        /// 任务目录ID
        /// </summary>
        [JsonProperty("TaskFolderId")]
        public string TaskFolderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Task.", this.Task);
            this.SetParamArrayObj(map, prefix + "EntityDTOList.", this.EntityDTOList);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskNameExistMode", this.TaskNameExistMode);
            this.SetParamSimple(map, prefix + "TaskFolderId", this.TaskFolderId);
        }
    }
}

