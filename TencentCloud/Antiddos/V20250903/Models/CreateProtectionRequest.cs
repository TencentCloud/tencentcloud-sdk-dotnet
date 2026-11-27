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

    public class CreateProtectionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>防护实例名称。</p><p>入参限制：防护实例名称最多 60 个字符，同一主账号下不可重名。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>防护实例的防护级别。</p><p>枚举值：</p><ul><li>advanced： 增强防护；</li><li>ultimate： 卓越防护，仅在当前主账号已订阅任意扩展包时可用。</li></ul><p>不同订阅套餐版本下可用的防护级别不同，可接入的防护资源类型与防护容量也相应不同，具体请参见 <a href="https://cloud.tencent.com/document/product/297/137986">DDoS 防护容量说明</a>。</p>
        /// </summary>
        [JsonProperty("ProtectionLevel")]
        public string ProtectionLevel{ get; set; }

        /// <summary>
        /// <p>标签。用于对防护实例进行分权限管控与分账。<p>需要先前往 <a href="https://console.cloud.tencent.com/tag/taglist">标签控制台</a> 创建对应标签，方可在此处传入标签键与标签值。</p></p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ProtectionLevel", this.ProtectionLevel);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

