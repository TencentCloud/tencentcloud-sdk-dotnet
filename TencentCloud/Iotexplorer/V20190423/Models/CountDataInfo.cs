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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CountDataInfo : AbstractModel
    {
        
        /// <summary>
        /// 视频上报异常次数
        /// </summary>
        [JsonProperty("VideoExceptionNum")]
        public ulong? VideoExceptionNum{ get; set; }

        /// <summary>
        /// 视频上报成功次数
        /// </summary>
        [JsonProperty("VideoSuccessNum")]
        public ulong? VideoSuccessNum{ get; set; }

        /// <summary>
        /// 视频上报成功率
        /// </summary>
        [JsonProperty("VideoSuccessRate")]
        public string VideoSuccessRate{ get; set; }

        /// <summary>
        /// 事件上报异常次数
        /// </summary>
        [JsonProperty("EventExceptionNum")]
        public ulong? EventExceptionNum{ get; set; }

        /// <summary>
        /// 事件上报成功次数
        /// </summary>
        [JsonProperty("EventSuccessNum")]
        public ulong? EventSuccessNum{ get; set; }

        /// <summary>
        /// 事件上报成功率
        /// </summary>
        [JsonProperty("EventSuccessRate")]
        public string EventSuccessRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoExceptionNum", this.VideoExceptionNum);
            this.SetParamSimple(map, prefix + "VideoSuccessNum", this.VideoSuccessNum);
            this.SetParamSimple(map, prefix + "VideoSuccessRate", this.VideoSuccessRate);
            this.SetParamSimple(map, prefix + "EventExceptionNum", this.EventExceptionNum);
            this.SetParamSimple(map, prefix + "EventSuccessNum", this.EventSuccessNum);
            this.SetParamSimple(map, prefix + "EventSuccessRate", this.EventSuccessRate);
        }
    }
}

