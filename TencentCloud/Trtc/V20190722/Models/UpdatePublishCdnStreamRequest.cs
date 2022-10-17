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

    public class UpdatePublishCdnStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC的[SdkAppId](https://cloud.tencent.com/document/product/647/46351#sdkappid)，和转推的房间所对应的SdkAppId相同。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 唯一标识转推任务。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 客户保证同一个任务，每次更新请求中的SequenceNumber递增，防止请求乱序。
        /// </summary>
        [JsonProperty("SequenceNumber")]
        public ulong? SequenceNumber{ get; set; }

        /// <summary>
        /// 是否转码，0表示无需转码，1表示需要转码。
        /// </summary>
        [JsonProperty("WithTranscoding")]
        public ulong? WithTranscoding{ get; set; }

        /// <summary>
        /// 更新相关参数，只支持更新参与混音的主播列表参数。不填表示不更新此参数。
        /// </summary>
        [JsonProperty("AudioParams")]
        public McuAudioParams AudioParams{ get; set; }

        /// <summary>
        /// 更新视频相关参数，转码时支持更新除编码类型之外的编码参数，视频布局参数，背景图片和背景颜色参数，水印参数。不填表示不更新此参数。
        /// </summary>
        [JsonProperty("VideoParams")]
        public McuVideoParams VideoParams{ get; set; }

        /// <summary>
        /// 更新单流转推的用户上行参数，仅在非转码时有效。不填表示不更新此参数。
        /// </summary>
        [JsonProperty("SingleSubscribeParams")]
        public SingleSubscribeParams SingleSubscribeParams{ get; set; }

        /// <summary>
        /// 更新转推的CDN参数。不填表示不更新此参数。
        /// </summary>
        [JsonProperty("PublishCdnParams")]
        public McuPublishCdnParam[] PublishCdnParams{ get; set; }

        /// <summary>
        /// 混流SEI参数
        /// </summary>
        [JsonProperty("SeiParams")]
        public McuSeiParams SeiParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SequenceNumber", this.SequenceNumber);
            this.SetParamSimple(map, prefix + "WithTranscoding", this.WithTranscoding);
            this.SetParamObj(map, prefix + "AudioParams.", this.AudioParams);
            this.SetParamObj(map, prefix + "VideoParams.", this.VideoParams);
            this.SetParamObj(map, prefix + "SingleSubscribeParams.", this.SingleSubscribeParams);
            this.SetParamArrayObj(map, prefix + "PublishCdnParams.", this.PublishCdnParams);
            this.SetParamObj(map, prefix + "SeiParams.", this.SeiParams);
        }
    }
}

