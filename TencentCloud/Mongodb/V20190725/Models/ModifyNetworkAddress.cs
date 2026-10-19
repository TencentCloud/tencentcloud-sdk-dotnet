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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetworkAddress : AbstractModel
    {
        
        /// <summary>
        /// <p>新IP地址。</p>
        /// </summary>
        [JsonProperty("NewIPAddress")]
        public string NewIPAddress{ get; set; }

        /// <summary>
        /// <p>原IP地址。</p>
        /// </summary>
        [JsonProperty("OldIpAddress")]
        public string OldIpAddress{ get; set; }

        /// <summary>
        /// <p>在副本集时，修改网络需要传此字段，用于标识该ip地址为主节点或者hidden节点</p><p>枚举值：</p><ul><li>PRIMARY： 主节点</li><li>HIDDEN： hidden节点</li></ul>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NewIPAddress", this.NewIPAddress);
            this.SetParamSimple(map, prefix + "OldIpAddress", this.OldIpAddress);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
        }
    }
}

