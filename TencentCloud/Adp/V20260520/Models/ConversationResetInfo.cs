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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConversationResetInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>最近一次重置的毫秒级时间戳</p>
        /// </summary>
        [JsonProperty("ResetTime")]
        public string ResetTime{ get; set; }

        /// <summary>
        /// <p>最近一次重置边界；该记录及更早的记录不再作为对话上下文</p>
        /// </summary>
        [JsonProperty("ResetThroughRecordId")]
        public string ResetThroughRecordId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResetTime", this.ResetTime);
            this.SetParamSimple(map, prefix + "ResetThroughRecordId", this.ResetThroughRecordId);
        }
    }
}

