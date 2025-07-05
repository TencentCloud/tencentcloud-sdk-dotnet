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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartPublishCdnStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC的[SdkAppId](https://cloud.tencent.com/document/product/647/46351#sdkappid)，和转推的房间所对应的SdkAppId相同。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 主房间信息RoomId，转推的TRTC房间所对应的RoomId。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 主房间信息RoomType，必须和转推的房间所对应的RoomId类型相同，0为整型房间号，1为字符串房间号。
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// 转推服务加入TRTC房间的机器人参数。
        /// </summary>
        [JsonProperty("AgentParams")]
        public AgentParams AgentParams{ get; set; }

        /// <summary>
        /// 是否转码，0表示无需转码，1表示需要转码。是否收取转码费是由WithTranscoding参数决定的，WithTranscoding为0，表示旁路转推，不会收取转码费用，WithTranscoding为1，表示混流转推，会收取转码费用。
        /// 注：混流是必须转码，这个参数需设置为1。
        /// </summary>
        [JsonProperty("WithTranscoding")]
        public ulong? WithTranscoding{ get; set; }

        /// <summary>
        /// 转推流的音频编码参数。由于音频是必转码的（不会收取转码费用），所以启动任务的时候，必须填写。
        /// </summary>
        [JsonProperty("AudioParams")]
        public McuAudioParams AudioParams{ get; set; }

        /// <summary>
        /// 转推流的视频编码参数，不填表示纯音频转推。
        /// </summary>
        [JsonProperty("VideoParams")]
        public McuVideoParams VideoParams{ get; set; }

        /// <summary>
        /// 需要单流旁路转推的用户上行参数，单流旁路转推时，WithTranscoding需要设置为0。
        /// </summary>
        [JsonProperty("SingleSubscribeParams")]
        public SingleSubscribeParams SingleSubscribeParams{ get; set; }

        /// <summary>
        /// 转推的CDN参数，一个任务最多支持10个推流URL。和回推房间参数必须要有一个。
        /// </summary>
        [JsonProperty("PublishCdnParams")]
        public McuPublishCdnParam[] PublishCdnParams{ get; set; }

        /// <summary>
        /// 混流SEI参数
        /// </summary>
        [JsonProperty("SeiParams")]
        public McuSeiParams SeiParams{ get; set; }

        /// <summary>
        /// 回推房间信息，一个任务最多支持回推10个房间，和转推CDN参数必须要有一个。注：回推房间需使用10.4及以上SDK版本，如您有需求，请联系腾讯云技术支持。
        /// </summary>
        [JsonProperty("FeedBackRoomParams")]
        public McuFeedBackRoomParams[] FeedBackRoomParams{ get; set; }

        /// <summary>
        /// 转推录制参数，[参考文档](https://cloud.tencent.com/document/product/647/111748)。
        /// </summary>
        [JsonProperty("RecordParams")]
        public McuRecordParams RecordParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamObj(map, prefix + "AgentParams.", this.AgentParams);
            this.SetParamSimple(map, prefix + "WithTranscoding", this.WithTranscoding);
            this.SetParamObj(map, prefix + "AudioParams.", this.AudioParams);
            this.SetParamObj(map, prefix + "VideoParams.", this.VideoParams);
            this.SetParamObj(map, prefix + "SingleSubscribeParams.", this.SingleSubscribeParams);
            this.SetParamArrayObj(map, prefix + "PublishCdnParams.", this.PublishCdnParams);
            this.SetParamObj(map, prefix + "SeiParams.", this.SeiParams);
            this.SetParamArrayObj(map, prefix + "FeedBackRoomParams.", this.FeedBackRoomParams);
            this.SetParamObj(map, prefix + "RecordParams.", this.RecordParams);
        }
    }
}

