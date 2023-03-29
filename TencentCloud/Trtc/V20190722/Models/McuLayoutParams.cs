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

    public class McuLayoutParams : AbstractModel
    {
        
        /// <summary>
        /// 布局模式：动态布局（1：悬浮布局（默认），2：屏幕分享布局，3：九宫格布局），静态布局（4：自定义布局）。
        /// </summary>
        [JsonProperty("MixLayoutMode")]
        public ulong? MixLayoutMode{ get; set; }

        /// <summary>
        /// 纯音频上行是否占布局位置，只在动态布局中有效。0表示纯音频不占布局位置，1表示纯音频占布局位置，不填默认为0。
        /// </summary>
        [JsonProperty("PureAudioHoldPlaceMode")]
        public ulong? PureAudioHoldPlaceMode{ get; set; }

        /// <summary>
        /// 自定义模板中有效，指定用户视频在混合画面中的位置。
        /// </summary>
        [JsonProperty("MixLayoutList")]
        public McuLayout[] MixLayoutList{ get; set; }

        /// <summary>
        /// 指定动态布局中悬浮布局和屏幕分享布局的大画面信息，只在悬浮布局和屏幕分享布局有效。
        /// </summary>
        [JsonProperty("MaxVideoUser")]
        public MaxVideoUser MaxVideoUser{ get; set; }

        /// <summary>
        /// 屏幕分享模板、悬浮模板、九宫格模版有效，画面在输出时的显示模式：0为裁剪，1为缩放，2为缩放并显示黑底
        /// </summary>
        [JsonProperty("RenderMode")]
        public ulong? RenderMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MixLayoutMode", this.MixLayoutMode);
            this.SetParamSimple(map, prefix + "PureAudioHoldPlaceMode", this.PureAudioHoldPlaceMode);
            this.SetParamArrayObj(map, prefix + "MixLayoutList.", this.MixLayoutList);
            this.SetParamObj(map, prefix + "MaxVideoUser.", this.MaxVideoUser);
            this.SetParamSimple(map, prefix + "RenderMode", this.RenderMode);
        }
    }
}

