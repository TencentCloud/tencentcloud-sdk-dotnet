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

    public class CreateRebuildMediaTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 输出文件封装格式，可选值：mp4、flv、hls。
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// <b>点播[子应用](/document/product/266/14574) ID。如果要访问子应用中的资源，则将该字段填写为子应用 ID；否则无需填写该字段。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 音画质重生模版名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 模版描述。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 音画质重生视频控制控制信息。
        /// </summary>
        [JsonProperty("RebuildVideoInfo")]
        public RebuildVideoInfo RebuildVideoInfo{ get; set; }

        /// <summary>
        /// 音画质重生音频控制控制信息。
        /// </summary>
        [JsonProperty("RebuildAudioInfo")]
        public RebuildAudioInfo RebuildAudioInfo{ get; set; }

        /// <summary>
        /// 输出目标视频控制信息。
        /// </summary>
        [JsonProperty("TargetVideoInfo")]
        public RebuildMediaTargetVideoStream TargetVideoInfo{ get; set; }

        /// <summary>
        /// 输出目标音频控制信息。
        /// </summary>
        [JsonProperty("TargetAudioInfo")]
        public RebuildMediaTargetAudioStream TargetAudioInfo{ get; set; }

        /// <summary>
        /// 是否去除视频数据，可选值：
        /// <li>0：保留</li>
        /// <li>1：去除</li>
        /// 默认值 0。
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// 是否去除音频数据，可选值：
        /// <li>0：保留</li>
        /// <li>1：去除</li>
        /// 默认值 0。
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public string RemoveAudio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "RebuildVideoInfo.", this.RebuildVideoInfo);
            this.SetParamObj(map, prefix + "RebuildAudioInfo.", this.RebuildAudioInfo);
            this.SetParamObj(map, prefix + "TargetVideoInfo.", this.TargetVideoInfo);
            this.SetParamObj(map, prefix + "TargetAudioInfo.", this.TargetAudioInfo);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
        }
    }
}

