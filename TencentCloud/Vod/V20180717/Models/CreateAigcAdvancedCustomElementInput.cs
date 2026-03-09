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

    public class CreateAigcAdvancedCustomElementInput : AbstractModel
    {
        
        /// <summary>
        /// <p>主体名称。</p>
        /// </summary>
        [JsonProperty("ElementName")]
        public string ElementName{ get; set; }

        /// <summary>
        /// <p>主体描述。</p>
        /// </summary>
        [JsonProperty("ElementDescription")]
        public string ElementDescription{ get; set; }

        /// <summary>
        /// <p>主体参考方式。</p>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }

        /// <summary>
        /// <p>主体音色。</p>
        /// </summary>
        [JsonProperty("ElementVoiceId")]
        public string ElementVoiceId{ get; set; }

        /// <summary>
        /// <p>主体参考视频。</p>
        /// </summary>
        [JsonProperty("ElementVideoList")]
        public string ElementVideoList{ get; set; }

        /// <summary>
        /// <p>主体参考图。</p>
        /// </summary>
        [JsonProperty("ElementImageList")]
        public string ElementImageList{ get; set; }

        /// <summary>
        /// <p>主体配置标签。</p>
        /// </summary>
        [JsonProperty("TagList")]
        public string TagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ElementName", this.ElementName);
            this.SetParamSimple(map, prefix + "ElementDescription", this.ElementDescription);
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
            this.SetParamSimple(map, prefix + "ElementVoiceId", this.ElementVoiceId);
            this.SetParamSimple(map, prefix + "ElementVideoList", this.ElementVideoList);
            this.SetParamSimple(map, prefix + "ElementImageList", this.ElementImageList);
            this.SetParamSimple(map, prefix + "TagList", this.TagList);
        }
    }
}

