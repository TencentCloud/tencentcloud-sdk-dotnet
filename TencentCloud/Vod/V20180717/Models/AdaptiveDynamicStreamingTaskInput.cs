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

    public class AdaptiveDynamicStreamingTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 转自适应码流模板 ID。
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 水印列表，支持多张图片或文字水印，最大可支持 10 张。
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }

        /// <summary>
        /// 溯源水印。
        /// </summary>
        [JsonProperty("TraceWatermark")]
        public TraceWatermarkInput TraceWatermark{ get; set; }

        /// <summary>
        /// 版权水印。
        /// </summary>
        [JsonProperty("CopyRightWatermark")]
        public CopyRightWatermarkInput CopyRightWatermark{ get; set; }

        /// <summary>
        /// 字幕列表，元素为字幕 ID，支持多个字幕，最大可支持16个。
        /// </summary>
        [JsonProperty("SubtitleSet")]
        public string[] SubtitleSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
            this.SetParamObj(map, prefix + "TraceWatermark.", this.TraceWatermark);
            this.SetParamObj(map, prefix + "CopyRightWatermark.", this.CopyRightWatermark);
            this.SetParamArraySimple(map, prefix + "SubtitleSet.", this.SubtitleSet);
        }
    }
}

