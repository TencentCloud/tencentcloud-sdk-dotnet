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

    public class ModifyCloudTranscriptionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>TRTC的SdkAppId，和转录的房间所对应的SdkAppId相同。</p>
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// <p>转录任务的唯一Id，在启动转录成功后会返回。</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>客户保证同一个任务，每次更新请求中的SequenceNumber递增，防止请求乱序。</p>
        /// </summary>
        [JsonProperty("SequenceNumber")]
        public ulong? SequenceNumber{ get; set; }

        /// <summary>
        /// <p>转录订阅用户信息，包括白名单和黑名单。</p>
        /// </summary>
        [JsonProperty("SubscribeUserInfo")]
        public TranscriptionSubscribeParam SubscribeUserInfo{ get; set; }

        /// <summary>
        /// <p>转录服务翻译使用的参数。</p>
        /// </summary>
        [JsonProperty("TranslationParam")]
        public TranslationParam TranslationParam{ get; set; }

        /// <summary>
        /// <p>转录服务TTS使用的参数。</p>
        /// </summary>
        [JsonProperty("TTSParam")]
        public TTSParam[] TTSParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SequenceNumber", this.SequenceNumber);
            this.SetParamObj(map, prefix + "SubscribeUserInfo.", this.SubscribeUserInfo);
            this.SetParamObj(map, prefix + "TranslationParam.", this.TranslationParam);
            this.SetParamArrayObj(map, prefix + "TTSParam.", this.TTSParam);
        }
    }
}

