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

    public class CreateRegistryRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>同一 AppId + Region 唯一、长度 1–255</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>描述文本；最长 4096。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>审批模式；创建时确定，创建后不可修改；省略时默认为 AUTO，枚举值区分大小写。</p>
        /// </summary>
        [JsonProperty("ApprovalMode")]
        public string ApprovalMode{ get; set; }

        /// <summary>
        /// <p>创建时绑定的腾讯云自定义标签；Key 不可重复；最多 10 个。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public CloudTag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ApprovalMode", this.ApprovalMode);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

