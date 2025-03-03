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

    public class UpdateStreamIngestRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC的SDKAppId，和任务的房间所对应的SDKAppId相同
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 任务的唯一Id，在启动任务成功后会返回。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 源流URL。
        /// </summary>
        [JsonProperty("StreamUrl")]
        public string StreamUrl{ get; set; }

        /// <summary>
        /// 音量，取值范围[0, 100]，默认100，表示原音量。
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// 是否暂停，默认false表示不暂停。暂停期间任务仍在进行中仍会计费，如果要销毁任务请调用停止接口。
        /// </summary>
        [JsonProperty("IsPause")]
        public bool? IsPause{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "StreamUrl", this.StreamUrl);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "IsPause", this.IsPause);
        }
    }
}

