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

namespace TencentCloud.Tag.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddResourceTagRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要绑定的标签键，取值规范参考：https://cloud.tencent.com/document/product/651/13354
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }

        /// <summary>
        /// 需要绑定的标签值，取值规范参考：https://cloud.tencent.com/document/product/651/13354
        /// </summary>
        [JsonProperty("TagValue")]
        public string TagValue{ get; set; }

        /// <summary>
        /// 待关联的资源，用标准的资源六段式表示。正确的资源六段式请参考：https://cloud.tencent.com/document/product/651/89122
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
            this.SetParamSimple(map, prefix + "TagValue", this.TagValue);
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
        }
    }
}

