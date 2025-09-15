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

namespace TencentCloud.Tdai.V20250717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CodeRepo : AbstractModel
    {
        
        /// <summary>
        /// 代码仓库地址
        /// </summary>
        [JsonProperty("RepoUrl")]
        public string RepoUrl{ get; set; }

        /// <summary>
        /// 分支名
        /// </summary>
        [JsonProperty("Branch")]
        public string Branch{ get; set; }

        /// <summary>
        /// Commit信息
        /// </summary>
        [JsonProperty("GitCommitPipelines")]
        public string[] GitCommitPipelines{ get; set; }

        /// <summary>
        /// 数据库ORM类型
        /// </summary>
        [JsonProperty("GitORMType")]
        public string GitORMType{ get; set; }

        /// <summary>
        /// 代码编写语言
        /// </summary>
        [JsonProperty("GitCodeLanguage")]
        public string GitCodeLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepoUrl", this.RepoUrl);
            this.SetParamSimple(map, prefix + "Branch", this.Branch);
            this.SetParamArraySimple(map, prefix + "GitCommitPipelines.", this.GitCommitPipelines);
            this.SetParamSimple(map, prefix + "GitORMType", this.GitORMType);
            this.SetParamSimple(map, prefix + "GitCodeLanguage", this.GitCodeLanguage);
        }
    }
}

