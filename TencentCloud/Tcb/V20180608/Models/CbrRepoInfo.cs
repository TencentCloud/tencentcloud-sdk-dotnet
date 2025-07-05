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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CbrRepoInfo : AbstractModel
    {
        
        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("Repo")]
        public string Repo{ get; set; }

        /// <summary>
        /// 仓库平台
        /// </summary>
        [JsonProperty("RepoType")]
        public string RepoType{ get; set; }

        /// <summary>
        /// 仓库语言
        /// </summary>
        [JsonProperty("RepoLanguage")]
        public string RepoLanguage{ get; set; }

        /// <summary>
        /// 分支名称
        /// </summary>
        [JsonProperty("Branch")]
        public string Branch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Repo", this.Repo);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamSimple(map, prefix + "RepoLanguage", this.RepoLanguage);
            this.SetParamSimple(map, prefix + "Branch", this.Branch);
        }
    }
}

