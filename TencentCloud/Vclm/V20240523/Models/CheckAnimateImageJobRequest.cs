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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckAnimateImageJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 动作模板ID。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 图片格式：支持PNG、JPG、JPEG、BMP、WEBP格式；
        /// 图片分辨率：长边分辨率范围【192，4096】；
        /// 图片大小：不超过10M；
        /// 图片宽高比：【宽：高】数值在 1:2 到 1:1.2 范围内
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片base64数据。
        /// 图片格式：支持PNG、JPG、JPEG、BMP、WEBP格式；
        /// 图片分辨率：长边分辨率范围【192，4096】；
        /// 图片大小：不超过10M；
        /// 图片宽高比：【宽：高】数值在 1:2 到 1:1.2 范围内
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 是否检测输入图人体12个身体部位（头部、颈部、右肩、右肘、右腕、左肩、左肘、左腕、右髋、左髋,、左膝、右膝）。默认不检测。
        /// </summary>
        [JsonProperty("EnableBodyJoins")]
        public bool? EnableBodyJoins{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "EnableBodyJoins", this.EnableBodyJoins);
        }
    }
}

