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

    public class ModifyLiveAvatarRoomRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数字人直播间 ID。</p>
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// <p>直播间名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>数字人形象KEY。</p>
        /// </summary>
        [JsonProperty("AvatarKey")]
        public string AvatarKey{ get; set; }

        /// <summary>
        /// <p>音色KEY。</p>
        /// </summary>
        [JsonProperty("TimbreKey")]
        public string TimbreKey{ get; set; }

        /// <summary>
        /// <p>背景图片URL。</p>
        /// </summary>
        [JsonProperty("BackgroundUrl")]
        public string BackgroundUrl{ get; set; }

        /// <summary>
        /// <p>主播大小，默认1.00。<br>取值范围(0, 15.00]。<br>精度：使用小数点后两位。</p>
        /// </summary>
        [JsonProperty("AnchorScale")]
        public float? AnchorScale{ get; set; }

        /// <summary>
        /// <p>主播纵向位置。默认-1贴底部。<br>左上角为原点，形象顶部离屏幕顶部的距离，最大不能使形象底部超出屏幕。<br>即该纵向位置最大为：数字人分辨率的高 - 形象高。</p>
        /// </summary>
        [JsonProperty("AnchorVerticalPos")]
        public long? AnchorVerticalPos{ get; set; }

        /// <summary>
        /// <p>主播横向位置。默认-1居中。<br>左上角为原点，形象左侧离左侧屏幕的距离。最大值不可使形象右侧超出右侧屏幕。<br>即最大值为：数字人分辨率的宽 - 形象宽。</p>
        /// </summary>
        [JsonProperty("AnchorHorizontalPos")]
        public long? AnchorHorizontalPos{ get; set; }

        /// <summary>
        /// <p>语速（1.0为正常语速，范围[0.6-2.5]，值为0.6时播报语速最慢，值为2.5时播报语速最快。</p>
        /// </summary>
        [JsonProperty("SpeechSpeed")]
        public float? SpeechSpeed{ get; set; }

        /// <summary>
        /// <p>音量大小，范围[0，10]，对应音量大小。默认为5，代表正常音量，值越大音量越高。</p>
        /// </summary>
        [JsonProperty("SpeechVolume")]
        public long? SpeechVolume{ get; set; }

        /// <summary>
        /// <p>操作者。</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>房间类型。AIGC：AIGC形象房间；PRESET：预设形象房间</p><p>枚举值：</p><ul><li>AIGC： AIGC形象房间</li><li>PRESET： 预设形象房间</li></ul>
        /// </summary>
        [JsonProperty("RoomType")]
        public string RoomType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AvatarKey", this.AvatarKey);
            this.SetParamSimple(map, prefix + "TimbreKey", this.TimbreKey);
            this.SetParamSimple(map, prefix + "BackgroundUrl", this.BackgroundUrl);
            this.SetParamSimple(map, prefix + "AnchorScale", this.AnchorScale);
            this.SetParamSimple(map, prefix + "AnchorVerticalPos", this.AnchorVerticalPos);
            this.SetParamSimple(map, prefix + "AnchorHorizontalPos", this.AnchorHorizontalPos);
            this.SetParamSimple(map, prefix + "SpeechSpeed", this.SpeechSpeed);
            this.SetParamSimple(map, prefix + "SpeechVolume", this.SpeechVolume);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "RoomType", this.RoomType);
        }
    }
}

