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

    public class AvatarRoomInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>数字人直播间 ID。</p>
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// <p>数字人直播间名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>数字人直播间状态，<br>CLOSE - 未开播。<br>OPEN - 直播中。</p><p>枚举值：</p><ul><li>CLOSE： 未开播</li><li>OPEN： 直播中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>数字人形象 KEY。</p>
        /// </summary>
        [JsonProperty("AvatarKey")]
        public string AvatarKey{ get; set; }

        /// <summary>
        /// <p>音色 KEY。</p>
        /// </summary>
        [JsonProperty("TimbreKey")]
        public string TimbreKey{ get; set; }

        /// <summary>
        /// <p>数字人形象图片 URL。</p>
        /// </summary>
        [JsonProperty("AvatarImageUrl")]
        public string AvatarImageUrl{ get; set; }

        /// <summary>
        /// <p>背景图片 URL。</p>
        /// </summary>
        [JsonProperty("BackgroundUrl")]
        public string BackgroundUrl{ get; set; }

        /// <summary>
        /// <p>推流目标描述。</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>目标推流地址。</p>
        /// </summary>
        [JsonProperty("ToUrl")]
        public string ToUrl{ get; set; }

        /// <summary>
        /// <p>主播大小，默认1.00。 取值范围(0, 15.00]。</p>
        /// </summary>
        [JsonProperty("AnchorScale")]
        public float? AnchorScale{ get; set; }

        /// <summary>
        /// <p>主播纵向位置。默认-1贴底部。</p>
        /// </summary>
        [JsonProperty("AnchorVerticalPos")]
        public long? AnchorVerticalPos{ get; set; }

        /// <summary>
        /// <p>主播横向位置。默认-1居中。</p>
        /// </summary>
        [JsonProperty("AnchorHorizontalPos")]
        public long? AnchorHorizontalPos{ get; set; }

        /// <summary>
        /// <p>语速（1.0为正常语速，范围[0.5-1.5]，值为0.5时播报语速最慢，值为1.5时播报语速最快。</p>
        /// </summary>
        [JsonProperty("SpeechSpeed")]
        public float? SpeechSpeed{ get; set; }

        /// <summary>
        /// <p>音量大小，范围[0，10]，对应音量大小。默认为0，代表正常音量，值越大音量越高。</p>
        /// </summary>
        [JsonProperty("SpeechVolume")]
        public long? SpeechVolume{ get; set; }

        /// <summary>
        /// <p>直播间创建时间，UTC时间。<br>注意：UTC时间和北京时间相差八小时。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>直播间最后更新时间，UTC时间。<br>注意：UTC时间和北京时间相差八小时。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>直播间类型。</p><p>枚举值：</p><ul><li>AIGC： AIGC直播</li></ul>
        /// </summary>
        [JsonProperty("RoomType")]
        public string RoomType{ get; set; }

        /// <summary>
        /// <p>通过AIGC生成的数字人形象图片 URL。</p>
        /// </summary>
        [JsonProperty("AvatarAigcImageUrl")]
        public string AvatarAigcImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AvatarKey", this.AvatarKey);
            this.SetParamSimple(map, prefix + "TimbreKey", this.TimbreKey);
            this.SetParamSimple(map, prefix + "AvatarImageUrl", this.AvatarImageUrl);
            this.SetParamSimple(map, prefix + "BackgroundUrl", this.BackgroundUrl);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "ToUrl", this.ToUrl);
            this.SetParamSimple(map, prefix + "AnchorScale", this.AnchorScale);
            this.SetParamSimple(map, prefix + "AnchorVerticalPos", this.AnchorVerticalPos);
            this.SetParamSimple(map, prefix + "AnchorHorizontalPos", this.AnchorHorizontalPos);
            this.SetParamSimple(map, prefix + "SpeechSpeed", this.SpeechSpeed);
            this.SetParamSimple(map, prefix + "SpeechVolume", this.SpeechVolume);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RoomType", this.RoomType);
            this.SetParamSimple(map, prefix + "AvatarAigcImageUrl", this.AvatarAigcImageUrl);
        }
    }
}

