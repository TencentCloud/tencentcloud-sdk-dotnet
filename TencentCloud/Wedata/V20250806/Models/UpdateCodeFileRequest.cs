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

    public class UpdateCodeFileRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 代码文件ID，参数值来自CreateCodeFile接口的返回
        /// </summary>
        [JsonProperty("CodeFileId")]
        public string CodeFileId{ get; set; }

        /// <summary>
        /// 代码文件配置
        /// </summary>
        [JsonProperty("CodeFileConfig")]
        public CodeFileConfig CodeFileConfig{ get; set; }

        /// <summary>
        /// 代码文件内容
        /// </summary>
        [JsonProperty("CodeFileContent")]
        public string CodeFileContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CodeFileId", this.CodeFileId);
            this.SetParamObj(map, prefix + "CodeFileConfig.", this.CodeFileConfig);
            this.SetParamSimple(map, prefix + "CodeFileContent", this.CodeFileContent);
        }
    }
}

