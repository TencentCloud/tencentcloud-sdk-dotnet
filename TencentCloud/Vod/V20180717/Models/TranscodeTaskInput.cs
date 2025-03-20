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

    public class TranscodeTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 视频转码模板 ID。
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
        /// 马赛克列表，最大可支持 10 张。
        /// </summary>
        [JsonProperty("MosaicSet")]
        public MosaicInput[] MosaicSet{ get; set; }

        /// <summary>
        /// 片头片尾列表，支持多片头片尾，最大可支持 10 个。
        /// </summary>
        [JsonProperty("HeadTailSet")]
        public HeadTailTaskInput[] HeadTailSet{ get; set; }

        /// <summary>
        /// 转码后的视频的起始时间偏移，单位：秒。
        /// <li>不填或填0，表示转码后的视频从原始视频的起始位置开始；</li>
        /// <li>当数值大于0时（假设为 n），表示转码后的视频从原始视频的第 n 秒位置开始；</li>
        /// <li>当数值小于0时（假设为 -n），表示转码后的视频从原始视频结束 n 秒前的位置开始。</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 转码后视频的终止时间偏移，单位：秒。
        /// <li>不填或填0，表示转码后的视频持续到原始视频的末尾终止；</li>
        /// <li>当数值大于0时（假设为 n），表示转码后的视频持续到原始视频第 n 秒时终止；</li>
        /// <li>当数值小于0时（假设为 -n），表示转码后的视频持续到原始视频结束 n 秒前终止。</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
            this.SetParamObj(map, prefix + "TraceWatermark.", this.TraceWatermark);
            this.SetParamObj(map, prefix + "CopyRightWatermark.", this.CopyRightWatermark);
            this.SetParamArrayObj(map, prefix + "MosaicSet.", this.MosaicSet);
            this.SetParamArrayObj(map, prefix + "HeadTailSet.", this.HeadTailSet);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
        }
    }
}

