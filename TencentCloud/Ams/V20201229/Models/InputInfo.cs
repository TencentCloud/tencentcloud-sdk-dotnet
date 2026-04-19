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

namespace TencentCloud.Ams.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>该字段表示文件访问类型，取值为<strong>URL</strong>（资源链接）和<strong>COS</strong> (腾讯云对象存储)。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>该字段表示文件访问的链接地址，格式为标准URL格式。<br> 备注：当Type为URL时此字段不为空。</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>该字段表示文件访问的腾讯云存储桶信息。<br> 备注：当Type为COS时此字段不为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketInfo")]
        public BucketInfo BucketInfo{ get; set; }

        /// <summary>
        /// <p>大模型审核可选输入图片列表</p>
        /// </summary>
        [JsonProperty("ImageUrlList")]
        public string[] ImageUrlList{ get; set; }

        /// <summary>
        /// <p>大模型审核场景下，base64编码的审核要求内容</p>
        /// </summary>
        [JsonProperty("TextContent")]
        public string TextContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamObj(map, prefix + "BucketInfo.", this.BucketInfo);
            this.SetParamArraySimple(map, prefix + "ImageUrlList.", this.ImageUrlList);
            this.SetParamSimple(map, prefix + "TextContent", this.TextContent);
        }
    }
}

