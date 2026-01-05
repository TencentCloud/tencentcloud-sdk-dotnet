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

    public class ProductImageConfig : AbstractModel
    {
        
        /// <summary>
        /// 生成图片背景的提示词。如果此字段缺省则内部会自行生成灵感。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 要阻止模型生成图片的提示词。
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// 关于产品的描述，详细的描述，有助于生成更符合要求的图片。
        /// </summary>
        [JsonProperty("ProductDesc")]
        public string ProductDesc{ get; set; }

        /// <summary>
        /// 特殊要求。如有特殊要求，可通过该字段传入。
        /// </summary>
        [JsonProperty("MoreRequirement")]
        public string MoreRequirement{ get; set; }

        /// <summary>
        /// 期望生成的图片张数。不传默认值为1，最大合法值为10。
        /// </summary>
        [JsonProperty("OutputImageCount")]
        public ulong? OutputImageCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "ProductDesc", this.ProductDesc);
            this.SetParamSimple(map, prefix + "MoreRequirement", this.MoreRequirement);
            this.SetParamSimple(map, prefix + "OutputImageCount", this.OutputImageCount);
        }
    }
}

