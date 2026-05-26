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

    public class AigcImageTaskInputFileInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>输入的文件类型。取值有： <li>File：点播媒体文件；</li> <li>Url：可访问的 Url；</li>  <li>Base64：图片或视频转换的Base64字符串；</li></p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>图片文件的媒体文件 ID，即该文件在云点播上的全局唯一标识符，在上传成功后由云点播后台分配。可以在 <a href="/document/product/266/7830">视频上传完成事件通知</a> 或 <a href="https://console.cloud.tencent.com/vod/media">云点播控制台</a> 获取该字段。当 Type 取值为 File 时，本参数有效。<br>说明：</p><ol><li>推荐使用小于7M的图片；</li><li>图片格式的取值为：jpeg，jpg, png, webp。</li></ol>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>可访问的文件 URL。当 Type 取值为 Url 时，本参数有效。<br>说明：</p><ol><li>推荐使用小于7M的图片；</li><li>图片格式的取值为：jpeg，jpg, png, webp。</li></ol>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>可访问的文件 Base64。当 Type 取值为 Base64 时，本参数有效。说明：</p><ol><li>所有文件的文件大小总和不能超过 7 MB，避免转为 Base64 后超出云 API 的 10 MB包大小上限；</li><li>图片格式应为：jpeg，jpg, png, webp；</li><li>不要有data:image/jpeg;base64,之类的前缀。</li></ol>
        /// </summary>
        [JsonProperty("Base64")]
        public string Base64{ get; set; }

        /// <summary>
        /// <p>输入图片的描述信息，用于帮助模型理解图片。仅GEM 2.5、GEM 3.0 有效。</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p><strong>仅当 ModelName 为 OG 时有效</strong>。图片类型。</p><p>枚举值：</p><ul><li>mask： 图片蒙版。</li></ul>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Base64", this.Base64);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
        }
    }
}

