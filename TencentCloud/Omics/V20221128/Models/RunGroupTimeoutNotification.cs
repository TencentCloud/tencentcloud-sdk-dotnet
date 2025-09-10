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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunGroupTimeoutNotification : AbstractModel
    {
        
        /// <summary>
        /// 任务批次超时时间，单位分钟。
        /// </summary>
        [JsonProperty("TimeoutMinutes")]
        public ulong? TimeoutMinutes{ get; set; }

        /// <summary>
        /// 通知类型。
        /// </summary>
        [JsonProperty("NotificationType")]
        public NotificationType NotificationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeoutMinutes", this.TimeoutMinutes);
            this.SetParamObj(map, prefix + "NotificationType.", this.NotificationType);
        }
    }
}

