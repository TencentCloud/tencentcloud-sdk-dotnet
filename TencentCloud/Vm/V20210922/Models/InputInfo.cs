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

namespace TencentCloud.Vm.V20210922.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>传入的类型可选：URL，COS</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Url地址</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>桶信息。当输入当时COS时，该字段不为空</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketInfo")]
        public string BucketInfo{ get; set; }

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
            this.SetParamSimple(map, prefix + "BucketInfo", this.BucketInfo);
            this.SetParamArraySimple(map, prefix + "ImageUrlList.", this.ImageUrlList);
            this.SetParamSimple(map, prefix + "TextContent", this.TextContent);
        }
    }
}

