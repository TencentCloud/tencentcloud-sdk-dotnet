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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AvatarAnchorInfo : AbstractModel
    {
        
        /// <summary>
        /// 主播昵称。同一个主播可以存在多个数字人ID。
        /// </summary>
        [JsonProperty("AnchorName")]
        public string AnchorName{ get; set; }

        /// <summary>
        /// 主播 ID。用于标识主播形象。同一个主播ID可存在竖屏和横屏两种数字人。
        /// </summary>
        [JsonProperty("AnchorId")]
        public string AnchorId{ get; set; }

        /// <summary>
        /// 主播性别。male-男性，femal-女性。
        /// </summary>
        [JsonProperty("AnchorGender")]
        public string AnchorGender{ get; set; }

        /// <summary>
        /// 形象图片。
        /// </summary>
        [JsonProperty("PoseImage")]
        public string PoseImage{ get; set; }

        /// <summary>
        /// 主播形象图片的分辨率。
        /// </summary>
        [JsonProperty("PoseImageResolution")]
        public string PoseImageResolution{ get; set; }

        /// <summary>
        /// 形象预览视频段。
        /// </summary>
        [JsonProperty("ReferenceVideoSegmentUrl")]
        public string ReferenceVideoSegmentUrl{ get; set; }

        /// <summary>
        /// 横屏数字人信息。
        /// </summary>
        [JsonProperty("HorizontalAvatar")]
        public AvatarImageInfo HorizontalAvatar{ get; set; }

        /// <summary>
        /// 竖屏数字人信息。
        /// </summary>
        [JsonProperty("VerticalAvatar")]
        public AvatarImageInfo VerticalAvatar{ get; set; }

        /// <summary>
        /// 推荐音色。
        /// </summary>
        [JsonProperty("SuggestTimbreKey")]
        public string SuggestTimbreKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnchorName", this.AnchorName);
            this.SetParamSimple(map, prefix + "AnchorId", this.AnchorId);
            this.SetParamSimple(map, prefix + "AnchorGender", this.AnchorGender);
            this.SetParamSimple(map, prefix + "PoseImage", this.PoseImage);
            this.SetParamSimple(map, prefix + "PoseImageResolution", this.PoseImageResolution);
            this.SetParamSimple(map, prefix + "ReferenceVideoSegmentUrl", this.ReferenceVideoSegmentUrl);
            this.SetParamObj(map, prefix + "HorizontalAvatar.", this.HorizontalAvatar);
            this.SetParamObj(map, prefix + "VerticalAvatar.", this.VerticalAvatar);
            this.SetParamSimple(map, prefix + "SuggestTimbreKey", this.SuggestTimbreKey);
        }
    }
}

