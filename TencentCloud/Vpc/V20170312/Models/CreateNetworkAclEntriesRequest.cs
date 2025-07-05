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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNetworkAclEntriesRequest : AbstractModel
    {
        
        /// <summary>
        /// 网络ACL实例ID。例如：acl-12345678。
        /// </summary>
        [JsonProperty("NetworkAclId")]
        public string NetworkAclId{ get; set; }

        /// <summary>
        /// 网络三元组ACL规则集。
        /// </summary>
        [JsonProperty("NetworkAclEntrySet")]
        public NetworkAclEntrySet NetworkAclEntrySet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkAclId", this.NetworkAclId);
            this.SetParamObj(map, prefix + "NetworkAclEntrySet.", this.NetworkAclEntrySet);
        }
    }
}

