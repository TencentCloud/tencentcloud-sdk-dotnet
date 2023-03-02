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

    public class MixLayoutParams : AbstractModel
    {
        
        /// <summary>
        /// 布局模式:
        /// 1：悬浮布局；
        /// 2：屏幕分享布局；
        /// 3：九宫格布局（默认）；
        /// 4：自定义布局；
        /// 
        /// 悬浮布局：默认第一个进入房间的主播（也可以指定一个主播）的视频画面会铺满整个屏幕。其他主播的视频画面从左下角开始依次按照进房顺序水平排列，显示为小画面，小画面悬浮于大画面之上。当画面数量小于等于17个时，每行4个（4 x 4排列）。当画面数量大于17个时，重新布局小画面为每行5个（5 x 5）排列。最多支持25个画面，如果用户只发送音频，仍然会占用画面位置。
        /// 
        /// 屏幕分享布局：指定一个主播在屏幕左侧的大画面位置（如果不指定，那么大画面位置为背景色），其他主播自上而下依次垂直排列于右侧。当画面数量少于17个的时候，右侧每列最多8人，最多占据两列。当画面数量多于17个的时候，超过17个画面的主播从左下角开始依次水平排列。最多支持25个画面，如果主播只发送音频，仍然会占用画面位置。
        /// 
        /// 九宫格布局：根据主播的数量自动调整每个画面的大小，每个主播的画面大小一致，最多支持25个画面。
        /// 
        /// 自定义布局：根据需要在MixLayoutList内定制每个主播画面的布局。
        /// </summary>
        [JsonProperty("MixLayoutMode")]
        public ulong? MixLayoutMode{ get; set; }

        /// <summary>
        /// 如果MixLayoutMode 选择为4自定义布局模式的话，设置此参数为每个主播所对应的布局画面的详细信息，最大不超过25个。
        /// </summary>
        [JsonProperty("MixLayoutList")]
        public MixLayout[] MixLayoutList{ get; set; }

        /// <summary>
        /// 录制背景颜色，RGB的颜色表的16进制表示，每个颜色通过8bit长度标识，默认为黑色。比如橙色对应的RGB为 R:255 G:165 B:0, 那么对应的字符串描述为#FFA500，格式规范：‘#‘开头，后面跟固定RGB的颜色值
        /// </summary>
        [JsonProperty("BackGroundColor")]
        public string BackGroundColor{ get; set; }

        /// <summary>
        /// 在布局模式为1：悬浮布局和 2：屏幕分享布局时，设定为显示大视频画面的UserId。不填的话：悬浮布局默认是第一个进房间的主播，屏幕分享布局默认是背景色
        /// </summary>
        [JsonProperty("MaxResolutionUserId")]
        public string MaxResolutionUserId{ get; set; }

        /// <summary>
        /// 主辅路标识，
        /// 0：主流（默认）；
        /// 1：辅流（屏幕分享）；
        /// 这个位置的MediaId代表的是对应MaxResolutionUserId的主辅路，MixLayoutList内代表的是自定义用户的主辅路。
        /// </summary>
        [JsonProperty("MediaId")]
        public ulong? MediaId{ get; set; }

        /// <summary>
        /// 图片的url地址， 只支持jpg， png，大小限制不超过5M，url不可包含中文。
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }

        /// <summary>
        /// 设置为1时代表启用占位图功能，0时代表不启用占位图功能，默认为0。启用占位图功能时，在预设位置的用户没有上行视频时可显示对应的占位图。
        /// </summary>
        [JsonProperty("PlaceHolderMode")]
        public ulong? PlaceHolderMode{ get; set; }

        /// <summary>
        /// 背景画面宽高比不一致的时候处理方案，与MixLayoufList定义的RenderMode一致。
        /// </summary>
        [JsonProperty("BackgroundImageRenderMode")]
        public ulong? BackgroundImageRenderMode{ get; set; }

        /// <summary>
        /// 子画面占位图url地址， 只支持jpg， png，大小限制不超过5M，宽高比不一致的处理方案同 RenderMode。
        /// </summary>
        [JsonProperty("DefaultSubBackgroundImage")]
        public string DefaultSubBackgroundImage{ get; set; }

        /// <summary>
        /// 水印布局参数， 最多支持25个。
        /// </summary>
        [JsonProperty("WaterMarkList")]
        public WaterMark[] WaterMarkList{ get; set; }

        /// <summary>
        /// 模板布局下，背景画面宽高比不一致的时候处理方案。自定义布局不生效，与MixLayoufList定义的RenderMode一致。
        /// </summary>
        [JsonProperty("RenderMode")]
        public ulong? RenderMode{ get; set; }

        /// <summary>
        /// 屏幕分享模板有效。设置为1时代表大画面居右，小画面居左布局。默认为0。
        /// </summary>
        [JsonProperty("MaxResolutionUserAlign")]
        public ulong? MaxResolutionUserAlign{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MixLayoutMode", this.MixLayoutMode);
            this.SetParamArrayObj(map, prefix + "MixLayoutList.", this.MixLayoutList);
            this.SetParamSimple(map, prefix + "BackGroundColor", this.BackGroundColor);
            this.SetParamSimple(map, prefix + "MaxResolutionUserId", this.MaxResolutionUserId);
            this.SetParamSimple(map, prefix + "MediaId", this.MediaId);
            this.SetParamSimple(map, prefix + "BackgroundImageUrl", this.BackgroundImageUrl);
            this.SetParamSimple(map, prefix + "PlaceHolderMode", this.PlaceHolderMode);
            this.SetParamSimple(map, prefix + "BackgroundImageRenderMode", this.BackgroundImageRenderMode);
            this.SetParamSimple(map, prefix + "DefaultSubBackgroundImage", this.DefaultSubBackgroundImage);
            this.SetParamArrayObj(map, prefix + "WaterMarkList.", this.WaterMarkList);
            this.SetParamSimple(map, prefix + "RenderMode", this.RenderMode);
            this.SetParamSimple(map, prefix + "MaxResolutionUserAlign", this.MaxResolutionUserAlign);
        }
    }
}

