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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Content : AbstractModel
    {
        
        /// <summary>
        /// 内容类型
        /// 注意：
        /// 需包含至少一个 Type 为"text"的参数。
        /// 参数值可选范围：[text", "image_url","video_url"]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 当 Type 为 text 时使用，表示具体的文本内容。当 Type 为 image_url 时，当前字段内容需保持为空，传递内容不生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 图片的url，当 Type 为 image_url 时使用，表示具体的图片内容
        /// 如"https://example.com/1.png" 或 图片的base64（注意 "data:image/jpeg;base64," 为必要部分）："data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAA......"。当 Type 为 text 时，当前字段内容需保持为空，传递内容不生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public ImageUrl ImageUrl{ get; set; }

        /// <summary>
        /// 当type为video_url时使用，标识具体的视频链接内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoUrl")]
        public VideoUrl VideoUrl{ get; set; }

        /// <summary>
        /// 当type为video_frames时使用，标识具体的视频内图像帧内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoFrames")]
        public VideoFrames VideoFrames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamObj(map, prefix + "ImageUrl.", this.ImageUrl);
            this.SetParamObj(map, prefix + "VideoUrl.", this.VideoUrl);
            this.SetParamObj(map, prefix + "VideoFrames.", this.VideoFrames);
        }
    }
}

