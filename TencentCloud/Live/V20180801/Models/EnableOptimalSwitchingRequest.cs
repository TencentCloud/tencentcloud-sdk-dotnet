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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnableOptimalSwitchingRequest : AbstractModel
    {
        
        /// <summary>
        /// 针对该流 ID 启用择优调度。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 启用开关，默认为启用。
        /// 0 - 禁用。
        /// 1 - 启用。
        /// </summary>
        [JsonProperty("EnableSwitch")]
        public long? EnableSwitch{ get; set; }

        /// <summary>
        /// 要启用自动择优的流所属的域名分组名称。
        /// </summary>
        [JsonProperty("HostGroupName")]
        public string HostGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "EnableSwitch", this.EnableSwitch);
            this.SetParamSimple(map, prefix + "HostGroupName", this.HostGroupName);
        }
    }
}

