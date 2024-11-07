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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateComplexAdaptiveDynamicStreamingTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 主媒体文件的媒体 ID。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 自适应码流参数，最大支持8个。
        /// </summary>
        [JsonProperty("StreamParaSet")]
        public ComplexAdaptiveDynamicStreamingTaskStreamPara[] StreamParaSet{ get; set; }

        /// <summary>
        /// 片头片尾列表，支持多片头片尾，最大可支持 4 个。
        /// 如果填写了该字段，AudioSet 和 SubtitleSet 中指定的媒体的起始时间将会自动调整，和主媒体保持同步。
        /// </summary>
        [JsonProperty("HeadTailSet")]
        public HeadTailTaskInput[] HeadTailSet{ get; set; }

        /// <summary>
        /// 多语言音频流参数，最大支持16个。
        /// 每个数组元素对应自适应码流中的一条音频流。如果要将主媒体文件中的音频流添加到输出的自适应码流中，那么也需要在此处指定。
        /// 数组中元素的顺序将决定自适应码流中的音频流顺序。
        /// 如果输入的媒体文件同时带有视频流和音频流，那么视频流将被忽略。
        /// </summary>
        [JsonProperty("AudioSet")]
        public ComplexAdaptiveDynamicStreamingTaskAudioInput[] AudioSet{ get; set; }

        /// <summary>
        /// 多语言字幕参数，最大可支持16个。
        /// 每个数组元素对应自适应码流中的一条字幕流。
        /// 数组中元素的顺序将决定自适应码流中的字幕流顺序。
        /// </summary>
        [JsonProperty("SubtitleSet")]
        public ComplexAdaptiveDynamicStreamingTaskSubtitleInput[] SubtitleSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamArrayObj(map, prefix + "StreamParaSet.", this.StreamParaSet);
            this.SetParamArrayObj(map, prefix + "HeadTailSet.", this.HeadTailSet);
            this.SetParamArrayObj(map, prefix + "AudioSet.", this.AudioSet);
            this.SetParamArrayObj(map, prefix + "SubtitleSet.", this.SubtitleSet);
        }
    }
}

