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

    public class AiSampleFaceOperation : AbstractModel
    {
        
        /// <summary>
        /// 操作类型，可选值：add（添加）、delete（删除）、reset（重置）。重置操作将清空该人物已有人脸数据，并添加 FaceContents 指定人脸数据。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 人脸 ID 集合，当 Type为delete 时，该字段必填。
        /// </summary>
        [JsonProperty("FaceIds")]
        public string[] FaceIds{ get; set; }

        /// <summary>
        /// 人脸图片 [Base64](https://tools.ietf.org/html/rfc4648) 编码后的字符串集合。
        /// <li>当 Type为add 或 reset 时，该字段必填；</li>
        /// <li>数组长度限制：5 张图片。</li>
        /// 注意：图片必须是单人像正面人脸较清晰的照片，像素不低于 200*200。
        /// </summary>
        [JsonProperty("FaceContents")]
        public string[] FaceContents{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "FaceIds.", this.FaceIds);
            this.SetParamArraySimple(map, prefix + "FaceContents.", this.FaceContents);
        }
    }
}

