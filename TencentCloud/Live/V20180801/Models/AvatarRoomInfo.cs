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
        /// 数字人直播间 ID。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 数字人直播间名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数字人直播间状态，
        /// CLOSE - 未开播。
        /// OPEN - 直播中。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 数字人形象 KEY。
        /// </summary>
        [JsonProperty("AvatarKey")]
        public string AvatarKey{ get; set; }

        /// <summary>
        /// 音色 KEy。
        /// </summary>
        [JsonProperty("TimbreKey")]
        public string TimbreKey{ get; set; }

        /// <summary>
        /// 数字人形象图片 URL。
        /// </summary>
        [JsonProperty("AvatarImageUrl")]
        public string AvatarImageUrl{ get; set; }

        /// <summary>
        /// 背景图片 URL。
        /// </summary>
        [JsonProperty("BackgroundUrl")]
        public string BackgroundUrl{ get; set; }

        /// <summary>
        /// 推流目标描述。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 目标推流地址。
        /// </summary>
        [JsonProperty("ToUrl")]
        public string ToUrl{ get; set; }

        /// <summary>
        /// 主播大小，默认1.00。 取值范围(0, 15.00]。
        /// </summary>
        [JsonProperty("AnchorScale")]
        public float? AnchorScale{ get; set; }

        /// <summary>
        /// 主播纵向位置。默认-1贴底部。
        /// </summary>
        [JsonProperty("AnchorVerticalPos")]
        public long? AnchorVerticalPos{ get; set; }

        /// <summary>
        /// 主播横向位置。默认-1居中。
        /// </summary>
        [JsonProperty("AnchorHorizontalPos")]
        public long? AnchorHorizontalPos{ get; set; }

        /// <summary>
        /// 语速（1.0为正常语速，范围[0.5-1.5]，值为0.5时播报语速最慢，值为1.5时播报语速最快。
        /// </summary>
        [JsonProperty("SpeechSpeed")]
        public float? SpeechSpeed{ get; set; }

        /// <summary>
        /// 音量大小，范围[0，10]，对应音量大小。默认为0，代表正常音量，值越大音量越高。
        /// </summary>
        [JsonProperty("SpeechVolume")]
        public long? SpeechVolume{ get; set; }

        /// <summary>
        /// 直播间创建时间，UTC时间。
        /// 注意：UTC时间和北京时间相差八小时。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 直播间最后更新时间，UTC时间。
        /// 注意：UTC时间和北京时间相差八小时。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


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
        }
    }
}

