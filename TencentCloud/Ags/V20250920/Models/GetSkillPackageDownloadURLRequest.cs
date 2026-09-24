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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetSkillPackageDownloadURLRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>父 Registry ID。</p>
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// <p>Record ID；必须 AGENT_SKILLS 且 ContentStatus=READY。</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>可选。指定要下载的 Version；与 Label 互斥；均省略时使用 Stable。</p>
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// <p>可选。指定要下载的 Label 目标；与 VersionId 互斥；均省略时使用 Stable。</p>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "Label", this.Label);
        }
    }
}

