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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LayoutParams : AbstractModel
    {
        
        /// <summary>
        /// 混流布局模板ID，0为悬浮模板(默认);1为九宫格模板;2为屏幕分享模板;3为画中画模板;4为自定义模板。
        /// </summary>
        [JsonProperty("Template")]
        public ulong? Template{ get; set; }

        /// <summary>
        /// 屏幕分享模板、悬浮模板、画中画模板中有效，代表大画面对应的用户ID。
        /// </summary>
        [JsonProperty("MainVideoUserId")]
        public string MainVideoUserId{ get; set; }

        /// <summary>
        /// 屏幕分享模板、悬浮模板、画中画模板中有效，代表大画面对应的流类型，0为摄像头，1为屏幕分享。左侧大画面为web用户时此值填0。
        /// </summary>
        [JsonProperty("MainVideoStreamType")]
        public ulong? MainVideoStreamType{ get; set; }

        /// <summary>
        /// 画中画模板中有效，代表小画面的布局参数。
        /// </summary>
        [JsonProperty("SmallVideoLayoutParams")]
        public SmallVideoLayoutParams SmallVideoLayoutParams{ get; set; }

        /// <summary>
        /// 屏幕分享模板有效。设置为1时代表大画面居右，小画面居左布局。默认为0。
        /// </summary>
        [JsonProperty("MainVideoRightAlign")]
        public ulong? MainVideoRightAlign{ get; set; }

        /// <summary>
        /// 悬浮模板、九宫格、屏幕分享模板有效。设置此参数后，输出流混合此参数中包含用户的音视频，以及其他用户的纯音频。最多可设置16个用户。
        /// </summary>
        [JsonProperty("MixVideoUids")]
        public string[] MixVideoUids{ get; set; }

        /// <summary>
        /// 自定义模板中有效，指定用户视频在混合画面中的位置。
        /// </summary>
        [JsonProperty("PresetLayoutConfig")]
        public PresetLayoutConfig[] PresetLayoutConfig{ get; set; }

        /// <summary>
        /// 自定义模板中有效，设置为1时代表启用占位图功能，0时代表不启用占位图功能，默认为0。启用占位图功能时，在预设位置的用户没有上行视频时可显示对应的占位图。
        /// </summary>
        [JsonProperty("PlaceHolderMode")]
        public ulong? PlaceHolderMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Template", this.Template);
            this.SetParamSimple(map, prefix + "MainVideoUserId", this.MainVideoUserId);
            this.SetParamSimple(map, prefix + "MainVideoStreamType", this.MainVideoStreamType);
            this.SetParamObj(map, prefix + "SmallVideoLayoutParams.", this.SmallVideoLayoutParams);
            this.SetParamSimple(map, prefix + "MainVideoRightAlign", this.MainVideoRightAlign);
            this.SetParamArraySimple(map, prefix + "MixVideoUids.", this.MixVideoUids);
            this.SetParamArrayObj(map, prefix + "PresetLayoutConfig.", this.PresetLayoutConfig);
            this.SetParamSimple(map, prefix + "PlaceHolderMode", this.PlaceHolderMode);
        }
    }
}

