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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddLoginWhiteListsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>异地登录白名单实体</p>
        /// </summary>
        [JsonProperty("HostLoginWhiteObj")]
        public HostLoginWhiteObj HostLoginWhiteObj{ get; set; }

        /// <summary>
        /// <p>事件同步处理方式：<br>  &quot;&quot; -- 不操作<br>  &quot;All&quot; -- 将符合此配置的所有事件记录加白<br>  &quot;Id&quot; -- 将EventId对应的事件记录加白</p>
        /// </summary>
        [JsonProperty("ProcessType")]
        public string ProcessType{ get; set; }

        /// <summary>
        /// <p>异地登录事件ID，当ProcessType为Id时此项必填</p>
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HostLoginWhiteObj.", this.HostLoginWhiteObj);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
        }
    }
}

