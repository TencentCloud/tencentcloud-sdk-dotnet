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

    public class CasterDisplayInfo : AbstractModel
    {
        
        /// <summary>
        /// 布局Index。
        /// 如果使用自定义布局，为自定义布局下标。
        /// 如果使用单输入布局，如使用输入1，则LayoutIndexType=1， 且LayoutIndex=1，以此类推。
        /// </summary>
        [JsonProperty("LayoutIndex")]
        public ulong? LayoutIndex{ get; set; }

        /// <summary>
        /// 使用的水印Index列表。
        /// 注：当作为入参使用时，列表中的水印Index需要已经存在。
        /// </summary>
        [JsonProperty("MarkPicIndexList")]
        public ulong?[] MarkPicIndexList{ get; set; }

        /// <summary>
        /// 使用的文字水印Index列表。
        /// 注：作为入参使用时，列表中的Index需要已经存在。
        /// </summary>
        [JsonProperty("MarkWordIndexList")]
        public ulong?[] MarkWordIndexList{ get; set; }

        /// <summary>
        /// 使用的转场类型。
        /// 注：支持的转场类型可通过DescribeCasterTransitionTypes接口获取。
        /// </summary>
        [JsonProperty("TransitionType")]
        public string TransitionType{ get; set; }

        /// <summary>
        /// 使用的音频输入Index列表。
        /// 注：当该字段非空时，表示使用布局中对应的输入源的视频，AudioIndexList中对应的输入源的音频。且这些输入源需已存在。
        /// </summary>
        [JsonProperty("AudioIndexList")]
        public ulong?[] AudioIndexList{ get; set; }

        /// <summary>
        /// 作为入参时，表示使用点播输入源，单画面输入时，点播文件是否从头开始播放。
        /// 默认为0。
        /// 有效值，0,1。
        /// 0代表不从头播放
        /// 1代表从头播放
        /// </summary>
        [JsonProperty("InputStartType")]
        public long? InputStartType{ get; set; }

        /// <summary>
        /// LayoutIndex类型，
        /// 默认值:0
        /// 可选值[0,1]
        /// 0:默认类型，代表普通布局
        /// 1:单输入类型，代表单输入布局
        /// </summary>
        [JsonProperty("LayoutIndexType")]
        public long? LayoutIndexType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LayoutIndex", this.LayoutIndex);
            this.SetParamArraySimple(map, prefix + "MarkPicIndexList.", this.MarkPicIndexList);
            this.SetParamArraySimple(map, prefix + "MarkWordIndexList.", this.MarkWordIndexList);
            this.SetParamSimple(map, prefix + "TransitionType", this.TransitionType);
            this.SetParamArraySimple(map, prefix + "AudioIndexList.", this.AudioIndexList);
            this.SetParamSimple(map, prefix + "InputStartType", this.InputStartType);
            this.SetParamSimple(map, prefix + "LayoutIndexType", this.LayoutIndexType);
        }
    }
}

