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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAIWorkbenchArtifactRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产物 ID</p>
        /// </summary>
        [JsonProperty("ArtifactId")]
        public string ArtifactId{ get; set; }

        /// <summary>
        /// <p>是否需要下载 URL</p><p><code>1</code> = 需要，<code>0</code> 或不传 = 不需要</p>
        /// </summary>
        [JsonProperty("NeedDownloadURL")]
        public long? NeedDownloadURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ArtifactId", this.ArtifactId);
            this.SetParamSimple(map, prefix + "NeedDownloadURL", this.NeedDownloadURL);
        }
    }
}

