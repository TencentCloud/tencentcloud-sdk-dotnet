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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAdaptiveDynamicStreamingTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>自适应转码模板唯一标识。</p>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <p><b>点播<a href="/document/product/266/14574">应用</a> ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>模板名称，长度限制：64 个字符。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>自适应转码格式，取值范围：</p><li>HLS；</li><li>MPEG-DASH。</li>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// <p>是否禁止视频低码率转高码率，取值范围：</p><li>0：否，</li><li>1：是。</li>
        /// </summary>
        [JsonProperty("DisableHigherVideoBitrate")]
        public ulong? DisableHigherVideoBitrate{ get; set; }

        /// <summary>
        /// <p>是否禁止视频分辨率转高分辨率，取值范围：</p><li>0：否，</li><li>1：是。</li>
        /// </summary>
        [JsonProperty("DisableHigherVideoResolution")]
        public ulong? DisableHigherVideoResolution{ get; set; }

        /// <summary>
        /// <p>自适应转码输入流参数信息，最多输入10路流。<br>注意：各个流的帧率必须保持一致；如果不一致，采用第一个流的帧率作为输出帧率。</p>
        /// </summary>
        [JsonProperty("StreamInfos")]
        public AdaptiveStreamTemplate[] StreamInfos{ get; set; }

        /// <summary>
        /// <p>模板描述信息，长度限制：256 个字符。</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>分片类型，可选值：<br>ts: HLS，内部映射为ts-segment</p><p>mp4: HLS/DASH，HLS情况下内部映射为mp4-mp4-segment，DASH情况下内部映射为mp4-mp4-byterange</p><p>ts-segment：HLS+TS 切片</p><p>ts-byterange：HLS+TS byte range</p><p>mp4-segment：HLS+MP4 切片</p><p>mp4-byterange：HLS+MP4 byte range</p><p>ts-packed-audio：HLS+TS+Packed Audio 切片</p><p>mp4-packed-audio：HLS+MP4+Packed Audio 切片</p><p>ts-ts-segment：HLS+TS+TS 切片</p><p>ts-ts-byterange：HLS+TS+TS byte range</p><p>mp4-mp4-segment：HLS+MP4+MP4 切片</p><p>mp4-mp4-byterange：HLS/DASH+MP4+MP4 byte range</p><p>ts-packed-audio-byterange：HLS+TS+Packed Audio byte range</p><p>mp4-packed-audio-byterange：HLS+MP4+Packed Audio byte range<br> 默认值：ts-segment 注：自适应码流的分片格式以此字段为准。DASH格式下SegmentType只能为mp4-mp4-byterange。</p><p>FairPlay：只能用于HLS，切片格式只能是mp4或mp4-mp4-segment Widevine：可以用于HLS和DASH，HLS下切片格式只能是mp4或mp4-mp4-segment，DASH下切片格式只能是mp4或mp4-mp4-byterange Widevine+FairPlay: 只能用于HLS，切片格式只能是mp4或mp4-mp4-segment</p>
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }

        /// <summary>
        /// <p>切片平均时长。</p><p>取值范围：[1, 10]</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("SegmentDuration")]
        public long? SegmentDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "DisableHigherVideoBitrate", this.DisableHigherVideoBitrate);
            this.SetParamSimple(map, prefix + "DisableHigherVideoResolution", this.DisableHigherVideoResolution);
            this.SetParamArrayObj(map, prefix + "StreamInfos.", this.StreamInfos);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "SegmentDuration", this.SegmentDuration);
        }
    }
}

