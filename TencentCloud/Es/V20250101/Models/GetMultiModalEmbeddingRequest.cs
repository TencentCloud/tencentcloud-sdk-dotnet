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

namespace TencentCloud.Es.V20250101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetMultiModalEmbeddingRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型名称，支持WeCLIPv2-Base和WeCLIPv2-Large
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 需进行向量化的文本集，一次输入限10条，单条文本长度限72
        /// </summary>
        [JsonProperty("Texts")]
        public string[] Texts{ get; set; }

        /// <summary>
        /// 输入图片，base64编码格式，一次输入限制8个，单张图片限制1M
        /// </summary>
        [JsonProperty("ImageData")]
        public string[] ImageData{ get; set; }

        /// <summary>
        /// 输入图片url，一次输入限8个，推荐cos地址，速度更快
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string[] ImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamArraySimple(map, prefix + "Texts.", this.Texts);
            this.SetParamArraySimple(map, prefix + "ImageData.", this.ImageData);
            this.SetParamArraySimple(map, prefix + "ImageUrl.", this.ImageUrl);
        }
    }
}

