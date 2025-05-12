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

    public class CreateCodeTemplateVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 模版Id
        /// </summary>
        [JsonProperty("CodeTemplateId")]
        public string CodeTemplateId{ get; set; }

        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 模版关联的任务以及调度参数设置
        /// </summary>
        [JsonProperty("Tasks")]
        public TaskFormParams[] Tasks{ get; set; }

        /// <summary>
        /// 代码模本脚本内置参数
        /// </summary>
        [JsonProperty("OriginalParams")]
        public string[] OriginalParams{ get; set; }

        /// <summary>
        /// 提交描述
        /// </summary>
        [JsonProperty("VersionRemark")]
        public string VersionRemark{ get; set; }

        /// <summary>
        /// true表示：针对新建、已下线状态的任务仅生成开发态保存版本，您可在任务中自行提交到生产。针对调度中、已暂停、已失效的任务生成开发态保存版本并提交到生产（即本次代码模板的改动在调度中生效）； 
        /// false表示：针对所有状态的任务均仅生成开发态保存版本。
        /// </summary>
        [JsonProperty("NeedSubmitScheduleForTemplate")]
        public bool? NeedSubmitScheduleForTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CodeTemplateId", this.CodeTemplateId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamArraySimple(map, prefix + "OriginalParams.", this.OriginalParams);
            this.SetParamSimple(map, prefix + "VersionRemark", this.VersionRemark);
            this.SetParamSimple(map, prefix + "NeedSubmitScheduleForTemplate", this.NeedSubmitScheduleForTemplate);
        }
    }
}

