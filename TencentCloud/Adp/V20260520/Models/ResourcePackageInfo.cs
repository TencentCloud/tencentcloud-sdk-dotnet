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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourcePackageInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>套餐类型</p><p>枚举值：</p><ul><li>1： 免费版</li><li>2： 专业版</li><li>3： 企业版</li></ul>
        /// </summary>
        [JsonProperty("PackageType")]
        public ulong? PackageType{ get; set; }

        /// <summary>
        /// <p>资源包总量</p>
        /// </summary>
        [JsonProperty("ResourceTotal")]
        public long? ResourceTotal{ get; set; }

        /// <summary>
        /// <p>资源包用量</p>
        /// </summary>
        [JsonProperty("ResourceUsage")]
        public float? ResourceUsage{ get; set; }

        /// <summary>
        /// <p>知识库容量</p>
        /// </summary>
        [JsonProperty("KnowledgeCapacity")]
        public float? KnowledgeCapacity{ get; set; }

        /// <summary>
        /// <p>知识库用量</p>
        /// </summary>
        [JsonProperty("KnowledgeUsage")]
        public float? KnowledgeUsage{ get; set; }

        /// <summary>
        /// <p>资源包状态</p><p>枚举值：</p><ul><li>1： 正常</li><li>3： 已到期</li><li>4： 即将到期</li></ul>
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public ulong? ResourceStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "ResourceTotal", this.ResourceTotal);
            this.SetParamSimple(map, prefix + "ResourceUsage", this.ResourceUsage);
            this.SetParamSimple(map, prefix + "KnowledgeCapacity", this.KnowledgeCapacity);
            this.SetParamSimple(map, prefix + "KnowledgeUsage", this.KnowledgeUsage);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
        }
    }
}

