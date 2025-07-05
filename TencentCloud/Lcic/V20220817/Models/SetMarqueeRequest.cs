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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetMarqueeRequest : AbstractModel
    {
        
        /// <summary>
        /// 学校ID
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 房间号
        /// </summary>
        [JsonProperty("RoomId")]
        public ulong? RoomId{ get; set; }

        /// <summary>
        ///  跑马灯类型：1为固定值，2为用户昵称，3为固定值+用户昵称，4为用户ID，5为originId+固定值，6为用户昵称（originId）
        /// </summary>
        [JsonProperty("MarqueeType")]
        public ulong? MarqueeType{ get; set; }

        /// <summary>
        /// 显示方式：1为滚动，2为闪烁
        /// </summary>
        [JsonProperty("DisplayMode")]
        public ulong? DisplayMode{ get; set; }

        /// <summary>
        /// 固定值内容（当MarqueeType=1或5，则展示固定值内容）
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 字体大小（数字，像素单位，范围：10到24）。
        /// </summary>
        [JsonProperty("FontSize")]
        public ulong? FontSize{ get; set; }

        /// <summary>
        /// 字体粗细：1为粗体，0为细体
        /// </summary>
        [JsonProperty("FontWeight")]
        public ulong? FontWeight{ get; set; }

        /// <summary>
        /// 字体颜色（十六进制颜色值，例如：#00FF00（绿色））
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// 字体透明度（数字，范围 0.0 到 1.0）
        /// </summary>
        [JsonProperty("FontOpacity")]
        public float? FontOpacity{ get; set; }

        /// <summary>
        /// 背景颜色（十六进制颜色值，例如：#FFFF00（黄色））
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public string BackgroundColor{ get; set; }

        /// <summary>
        /// 背景透明度（数字，范围 0.0 到 1.0）
        /// </summary>
        [JsonProperty("BackgroundOpacity")]
        public float? BackgroundOpacity{ get; set; }

        /// <summary>
        /// 跑马灯文字移动/闪烁指定像素所需时间，范围：1-10；数值越小，跑马灯滚动/闪烁速度越快
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 跑马灯个数：目前仅支持1或2, 对应显示单排或双排
        /// </summary>
        [JsonProperty("MarqueeCount")]
        public ulong? MarqueeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "MarqueeType", this.MarqueeType);
            this.SetParamSimple(map, prefix + "DisplayMode", this.DisplayMode);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontWeight", this.FontWeight);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontOpacity", this.FontOpacity);
            this.SetParamSimple(map, prefix + "BackgroundColor", this.BackgroundColor);
            this.SetParamSimple(map, prefix + "BackgroundOpacity", this.BackgroundOpacity);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "MarqueeCount", this.MarqueeCount);
        }
    }
}

