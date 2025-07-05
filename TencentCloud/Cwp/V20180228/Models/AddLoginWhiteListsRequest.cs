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
        /// 异地登录白名单实体
        /// </summary>
        [JsonProperty("HostLoginWhiteObj")]
        public HostLoginWhiteObj HostLoginWhiteObj{ get; set; }

        /// <summary>
        /// 事件同步处理方式：
        ///   "" -- 不操作
        ///   "All" -- 将符合此配置的所有事件记录加白
        ///   "Id" -- 将EventId对应的事件记录加白
        /// </summary>
        [JsonProperty("ProcessType")]
        public string ProcessType{ get; set; }

        /// <summary>
        /// 异地登录事件ID，当ProcessType为Id时此项必填
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

