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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectionInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>防护实例 ID。</p>
        /// </summary>
        [JsonProperty("ProtectionId")]
        public string ProtectionId{ get; set; }

        /// <summary>
        /// <p>防护实例名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>防护实例的防护级别。</p><p>枚举值：</p><ul><li>advanced： 增强防护；</li><li>ultimate： 卓越防护。</li></ul>
        /// </summary>
        [JsonProperty("ProtectionLevel")]
        public string ProtectionLevel{ get; set; }

        /// <summary>
        /// <p>防护实例状态。</p><p>枚举值：</p><ul><li>protecting： 防护中；</li><li>processing： 变更中；</li><li>disabling： 停用中；</li><li>disabled： 已停用。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>资源标签列表。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>防护实例中的防护资源数量。</p>
        /// </summary>
        [JsonProperty("ResourceCount")]
        public long? ResourceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectionId", this.ProtectionId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ProtectionLevel", this.ProtectionLevel);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ResourceCount", this.ResourceCount);
        }
    }
}

