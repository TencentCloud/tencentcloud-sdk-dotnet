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

    public class CreateCodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 模版名
        /// </summary>
        [JsonProperty("CodeTemplateName")]
        public string CodeTemplateName{ get; set; }

        /// <summary>
        /// 30Python，32DLC，50 DLC-PySpark
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 模版描述
        /// </summary>
        [JsonProperty("CodeTemplateDesc")]
        public string CodeTemplateDesc{ get; set; }

        /// <summary>
        /// 文件夹ID
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// 指定脚本内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CodeTemplateName", this.CodeTemplateName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "CodeTemplateDesc", this.CodeTemplateDesc);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "Content", this.Content);
        }
    }
}

