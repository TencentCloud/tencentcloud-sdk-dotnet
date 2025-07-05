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

namespace TencentCloud.Aiart.V20221229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户图 URL 列表
        /// </summary>
        [JsonProperty("ImageUrls")]
        public string[] ImageUrls{ get; set; }

        /// <summary>
        /// 模版图人脸坐标。
        /// </summary>
        [JsonProperty("TemplateFaceRect")]
        public Rect TemplateFaceRect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageUrls.", this.ImageUrls);
            this.SetParamObj(map, prefix + "TemplateFaceRect.", this.TemplateFaceRect);
        }
    }
}

