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

    public class StopPublishCdnStreamRequest : AbstractModel
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
        /// 录制任务 key，标识一个录制任务，对应转推任务发起时指定 RecordKey；
        /// 如果填写该参数，表示调用者希望立即结束该录制任务。当RecordKey 指定的录制任务正在录制当前转推任务时，录制任务立即结束，否则录制任务不受影响。
        /// 如果没有填写该参数，但是转推任务发起时填写了 RecordKey，则表示在续录等待时间结束后才结束录制任务，续录等待期间可以使用相同的 RecordKey 发起新的转推任务，和当前转推任务录制到同一文件。
        /// </summary>
        [JsonProperty("RecordKey")]
        public string RecordKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "RecordKey", this.RecordKey);
        }
    }
}

