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

namespace TencentCloud.Ump.V20200918.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProgramStateItem : AbstractModel
    {
        
        /// <summary>
        /// 服务器IP
        /// </summary>
        [JsonProperty("ServerIp")]
        public string ServerIp{ get; set; }

        /// <summary>
        /// 进程名字
        /// </summary>
        [JsonProperty("ProgramName")]
        public string ProgramName{ get; set; }

        /// <summary>
        /// 在线个数
        /// </summary>
        [JsonProperty("OnlineCount")]
        public ulong? OnlineCount{ get; set; }

        /// <summary>
        /// 离线个数
        /// </summary>
        [JsonProperty("OfflineCount")]
        public ulong? OfflineCount{ get; set; }

        /// <summary>
        /// 上报状态:
        /// 1: 正常上报
        /// 2: 异常上报
        /// 注：此处异常上报是指本次上报由于场内服务内部原因导致上报数据不可信等。此时离线个数重置为1，在线个数重置为0
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServerIp", this.ServerIp);
            this.SetParamSimple(map, prefix + "ProgramName", this.ProgramName);
            this.SetParamSimple(map, prefix + "OnlineCount", this.OnlineCount);
            this.SetParamSimple(map, prefix + "OfflineCount", this.OfflineCount);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

