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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomGroupItem : AbstractModel
    {
        
        /// <summary>
        /// <p>条目内容。</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>条目类型。</p><p>枚举值：</p><ul><li>JA3： JA3 指纹，仅当所属组 GroupType 为 TLSFingerprint 时可用</li><li>JA4： JA4 指纹，仅当所属组 GroupType 为 TLSFingerprint 时可用</li><li>UA： UA 值，仅当所属组 GroupType 为 UA 时可用</li><li>Referer： Referer 值，仅当所属组 GroupType 为 Referer 时可用</li></ul>
        /// </summary>
        [JsonProperty("ItemType")]
        public string ItemType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ItemType", this.ItemType);
        }
    }
}

