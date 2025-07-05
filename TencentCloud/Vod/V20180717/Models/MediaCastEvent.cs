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

    public class MediaCastEvent : AbstractModel
    {
        
        /// <summary>
        /// 媒体转推 ID。
        /// </summary>
        [JsonProperty("CastId")]
        public string CastId{ get; set; }

        /// <summary>
        /// 转推状态，取值有：
        /// <li>Working ：运行中；</li>
        /// <li>Scheduled ：等待定时时间到达后启动；</li>
        /// <li>Stopped ：已经停止转推；</li>
        /// <li>Idle ：空闲。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CastId", this.CastId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

