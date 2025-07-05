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

    public class ImmutableTagRule : AbstractModel
    {
        
        /// <summary>
        /// 仓库匹配规则
        /// </summary>
        [JsonProperty("RepositoryPattern")]
        public string RepositoryPattern{ get; set; }

        /// <summary>
        /// Tag 匹配规则
        /// </summary>
        [JsonProperty("TagPattern")]
        public string TagPattern{ get; set; }

        /// <summary>
        /// repoMatches或repoExcludes
        /// </summary>
        [JsonProperty("RepositoryDecoration")]
        public string RepositoryDecoration{ get; set; }

        /// <summary>
        /// matches或excludes
        /// </summary>
        [JsonProperty("TagDecoration")]
        public string TagDecoration{ get; set; }

        /// <summary>
        /// 禁用规则
        /// </summary>
        [JsonProperty("Disabled")]
        public bool? Disabled{ get; set; }

        /// <summary>
        /// 规则 Id
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("NsName")]
        public string NsName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepositoryPattern", this.RepositoryPattern);
            this.SetParamSimple(map, prefix + "TagPattern", this.TagPattern);
            this.SetParamSimple(map, prefix + "RepositoryDecoration", this.RepositoryDecoration);
            this.SetParamSimple(map, prefix + "TagDecoration", this.TagDecoration);
            this.SetParamSimple(map, prefix + "Disabled", this.Disabled);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "NsName", this.NsName);
        }
    }
}

