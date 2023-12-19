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

namespace TencentCloud.Facefusion.V20220927.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MergeInfo : AbstractModel
    {
        
        /// <summary>
        /// 输入图片base64
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 输入图片url
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 上传的图片人脸位置信息（人脸框）
        /// </summary>
        [JsonProperty("InputImageFaceRect")]
        public FaceRect InputImageFaceRect{ get; set; }

        /// <summary>
        /// 素材人脸ID，不填默认取最大人脸。
        /// </summary>
        [JsonProperty("TemplateFaceID")]
        public string TemplateFaceID{ get; set; }

        /// <summary>
        /// 模版中人脸位置信息(人脸框)，不填默认取最大人脸。此字段仅适用于图片融合自定义模版素材场景。
        /// </summary>
        [JsonProperty("TemplateFaceRect")]
        public FaceRect TemplateFaceRect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamObj(map, prefix + "InputImageFaceRect.", this.InputImageFaceRect);
            this.SetParamSimple(map, prefix + "TemplateFaceID", this.TemplateFaceID);
            this.SetParamObj(map, prefix + "TemplateFaceRect.", this.TemplateFaceRect);
        }
    }
}

