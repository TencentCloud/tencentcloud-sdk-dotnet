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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTaskTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务模板名称
        /// </summary>
        [JsonProperty("TaskTemplateName")]
        public string TaskTemplateName{ get; set; }

        /// <summary>
        /// 任务模板内容，参数要求与任务一致
        /// </summary>
        [JsonProperty("TaskTemplateInfo")]
        public Task TaskTemplateInfo{ get; set; }

        /// <summary>
        /// 任务模板描述
        /// </summary>
        [JsonProperty("TaskTemplateDescription")]
        public string TaskTemplateDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskTemplateName", this.TaskTemplateName);
            this.SetParamObj(map, prefix + "TaskTemplateInfo.", this.TaskTemplateInfo);
            this.SetParamSimple(map, prefix + "TaskTemplateDescription", this.TaskTemplateDescription);
        }
    }
}

