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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartPublishLiveStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否转码，0表示无需转码，1表示需要转码。是否收取转码费是由WithTranscoding参数决定的，WithTranscoding为0，表示旁路转推，不会收取转码费用，WithTranscoding为1，表示混流转推，会收取转码费用。 示例值：1
        /// </summary>
        [JsonProperty("WithTranscoding")]
        public long? WithTranscoding{ get; set; }

        /// <summary>
        /// 所有参与混流转推的主播持续离开TRTC房间或切换成观众超过MaxIdleTime的时长，自动停止转推，单位：秒。默认值为 30 秒，该值需大于等于 5秒，且小于等于 86400秒(24小时)。
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public long? MaxIdleTime{ get; set; }

        /// <summary>
        /// 转推视频参数
        /// </summary>
        [JsonProperty("VideoParams")]
        public VideoParams VideoParams{ get; set; }

        /// <summary>
        /// 转推的URL参数，一个任务最多支持10个推流URL
        /// </summary>
        [JsonProperty("PublishParams")]
        public PublishParams[] PublishParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WithTranscoding", this.WithTranscoding);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamObj(map, prefix + "VideoParams.", this.VideoParams);
            this.SetParamArrayObj(map, prefix + "PublishParams.", this.PublishParams);
        }
    }
}

