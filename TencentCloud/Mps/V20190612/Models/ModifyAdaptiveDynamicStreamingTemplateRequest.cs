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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAdaptiveDynamicStreamingTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 转自适应码流模板唯一标识。
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 转自适应码流格式，取值范围：
        /// <li>HLS，</li>
        /// <li>MPEG-DASH。</li>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 是否禁止视频低码率转高码率，取值范围：
        /// <li>0：否，</li>
        /// <li>1：是。</li>
        /// </summary>
        [JsonProperty("DisableHigherVideoBitrate")]
        public ulong? DisableHigherVideoBitrate{ get; set; }

        /// <summary>
        /// 是否禁止视频分辨率转高分辨率，取值范围：
        /// <li>0：否，</li>
        /// <li>1：是。</li>
        /// </summary>
        [JsonProperty("DisableHigherVideoResolution")]
        public ulong? DisableHigherVideoResolution{ get; set; }

        /// <summary>
        /// 转自适应码流输入流参数信息，最多输入10路流。
        /// 注意：
        /// 1、各个流的帧率必须保持一致；如果不一致，采用第一个流的帧率作为输出帧率。
        /// 2、修改子流信息时需要全量修改添加所有字段值，否则没填字段会使用默认值。
        /// </summary>
        [JsonProperty("StreamInfos")]
        public AdaptiveStreamTemplate[] StreamInfos{ get; set; }

        /// <summary>
        /// 模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 是否为纯音频，0表示视频模板，1表示纯音频模板
        /// 当值为1：
        /// 1. StreamInfos.N.RemoveVideo=1
        /// 2. StreamInfos.N.RemoveAudio=0
        /// 3. StreamInfos.N.Video.Codec=copy
        /// 当值为0：
        /// 1. StreamInfos.N.Video.Codec不能为copy
        /// 2. StreamInfos.N.Video.Fps不能为null
        /// 注意：
        /// 此值只是区分模板类型，任务使用RemoveAudio和RemoveVideo的值
        /// </summary>
        [JsonProperty("PureAudio")]
        public ulong? PureAudio{ get; set; }

        /// <summary>
        /// 分片类型，可选值： <li>ts-segment：HLS+TS 切片</li> <li>ts-byterange：HLS+TS byte range</li> <li>mp4-segment：HLS+MP4 切片</li> <li>mp4-byterange：HLS/DASH+MP4 byte range</li> <li>ts-packed-audio：TS+Packed Audio</li> <li>mp4-packed-audio：MP4+Packed Audio</li> 默认值：ts-segment 
        /// 注：自适应码流的hls分片格式已此字段为准。DASH格式下SegmentType只能为mp4-byterange。
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "DisableHigherVideoBitrate", this.DisableHigherVideoBitrate);
            this.SetParamSimple(map, prefix + "DisableHigherVideoResolution", this.DisableHigherVideoResolution);
            this.SetParamArrayObj(map, prefix + "StreamInfos.", this.StreamInfos);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "PureAudio", this.PureAudio);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
        }
    }
}

