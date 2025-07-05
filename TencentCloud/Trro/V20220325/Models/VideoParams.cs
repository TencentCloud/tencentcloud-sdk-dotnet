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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoParams : AbstractModel
    {
        
        /// <summary>
        /// 输出流宽，音视频输出时必填。取值范围[0,1920]，单位为像素值。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 输出流高，音视频输出时必填。取值范围[0,1080]，单位为像素值。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 输出流帧率，音视频输出时必填。取值范围[1,60]，表示混流的输出帧率可选范围为1到60fps。
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// 输出流码率，音视频输出时必填。取值范围[1,10000]，单位为kbps。
        /// </summary>
        [JsonProperty("BitRate")]
        public long? BitRate{ get; set; }

        /// <summary>
        /// 输出流gop，音视频输出时必填。取值范围[1,5]，单位为秒。
        /// </summary>
        [JsonProperty("Gop")]
        public long? Gop{ get; set; }

        /// <summary>
        /// 转推视频流列表
        /// </summary>
        [JsonProperty("VideoList")]
        public VideoList[] VideoList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "BitRate", this.BitRate);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamArrayObj(map, prefix + "VideoList.", this.VideoList);
        }
    }
}

