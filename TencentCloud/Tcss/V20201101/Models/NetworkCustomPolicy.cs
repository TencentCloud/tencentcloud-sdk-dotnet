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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkCustomPolicy : AbstractModel
    {
        
        /// <summary>
        /// 网络策略方向，分为FROM和TO
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 网络策略策略端口
        /// </summary>
        [JsonProperty("Ports")]
        public NetworkPorts[] Ports{ get; set; }

        /// <summary>
        /// 网络策略策略对象
        /// 
        /// 开启待确认：PublishedNoConfirm
        /// 
        /// 开启已确认：PublishedConfirmed
        /// 
        /// 关闭中：unPublishing
        /// 
        /// 开启中：Publishing
        /// 
        /// 待开启：unPublishEdit
        /// </summary>
        [JsonProperty("Peer")]
        public NetworkPeer[] Peer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamArrayObj(map, prefix + "Peer.", this.Peer);
        }
    }
}

