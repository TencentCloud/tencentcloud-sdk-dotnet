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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OmittedDuration : AbstractModel
    {
        
        /// <summary>
        /// 录制暂停时间戳对应的视频播放时间(单位: 毫秒)
        /// </summary>
        [JsonProperty("VideoTime")]
        public long? VideoTime{ get; set; }

        /// <summary>
        /// 录制暂停时间戳(单位: 毫秒)
        /// </summary>
        [JsonProperty("PauseTime")]
        public long? PauseTime{ get; set; }

        /// <summary>
        /// 录制恢复时间戳(单位: 毫秒)
        /// </summary>
        [JsonProperty("ResumeTime")]
        public long? ResumeTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoTime", this.VideoTime);
            this.SetParamSimple(map, prefix + "PauseTime", this.PauseTime);
            this.SetParamSimple(map, prefix + "ResumeTime", this.ResumeTime);
        }
    }
}

