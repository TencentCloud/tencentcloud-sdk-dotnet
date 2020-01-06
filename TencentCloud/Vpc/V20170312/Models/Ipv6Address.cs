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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Ipv6Address : AbstractModel
    {
        
        /// <summary>
        /// `IPv6`地址，形如：`3402:4e00:20:100:0:8cd9:2a67:71f3`
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 是否是主`IP`。
        /// </summary>
        [JsonProperty("Primary")]
        public bool? Primary{ get; set; }

        /// <summary>
        /// `EIP`实例`ID`，形如：`eip-hxlqja90`。
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 公网IP是否被封堵。
        /// </summary>
        [JsonProperty("IsWanIpBlocked")]
        public bool? IsWanIpBlocked{ get; set; }

        /// <summary>
        /// `IPv6`地址状态：
        /// <li>`PENDING`：生产中</li>
        /// <li>`MIGRATING`：迁移中</li>
        /// <li>`DELETING`：删除中</li>
        /// <li>`AVAILABLE`：可用的</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Primary", this.Primary);
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsWanIpBlocked", this.IsWanIpBlocked);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

