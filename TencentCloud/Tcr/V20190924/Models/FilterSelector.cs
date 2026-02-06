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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FilterSelector : AbstractModel
    {
        
        /// <summary>
        /// <p>过滤规则类型，在tag过滤中，可选值为matches（匹配），excludes(排除)，在仓库过滤中，可选值为repoMatches（仓库匹配），repoExcludes（仓库排除）</p>
        /// </summary>
        [JsonProperty("Decoration")]
        public string Decoration{ get; set; }

        /// <summary>
        /// <p>过滤表达式</p>
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Decoration", this.Decoration);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
        }
    }
}

