/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePersonSampleRequest : AbstractModel
    {
        
        /// <summary>
        /// 人物名称，长度限制：20 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 人脸图片 [Base64](https://tools.ietf.org/html/rfc4648) 编码后的字符串，仅支持 jpeg、png 图片格式。数组长度限制：5 张图片。
        /// 注意：图片必须是单人像正面人脸较清晰的照片，像素不低于 200*200。
        /// </summary>
        [JsonProperty("FaceContents")]
        public string[] FaceContents{ get; set; }

        /// <summary>
        /// 人物应用场景，可选值：
        /// 1. Recognition：用于内容识别，等价于 Recognition.Face。
        /// 2. Review：用于内容审核，等价于 Review.Face。
        /// 3. All：用于内容识别、内容审核，等价于 1+2。
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// 人物描述，长度限制：1024 个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 人物标签
        /// <li>数组长度限制：20 个标签；</li>
        /// <li>单个标签长度限制：128 个字符。</li>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "FaceContents.", this.FaceContents);
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
        }
    }
}

