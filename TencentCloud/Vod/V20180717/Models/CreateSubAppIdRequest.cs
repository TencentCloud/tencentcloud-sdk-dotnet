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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSubAppIdRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用名称，长度限制：40个字符。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>应用简介，长度限制： 300个字符。不填则应用简介默认为空。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>应用类型， 取值有：<li>AllInOne：一体化；</li><li>Professional：专业版。</li>默认值为 AllInOne。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>此应用的模式，可选值为：</p><ul><li>fileid：仅FileID模式</li><li>fileid+path：FileID &amp; Path模式<br>留空时默认选择仅FileID模式</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>Mode是仅fileid时，用于设置默认存储地域，可选。<br>Mode是fileid+path时，用于指定存储地域，必填。</p><p>取值参考：<a href="https://cloud.tencent.com/document/product/266/9760">已支持地域列表</a></p>
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// <p>此应用需要绑定的tag</p>
        /// </summary>
        [JsonProperty("Tags")]
        public ResourceTag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

