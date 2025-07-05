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

namespace TencentCloud.Tdcpg.V20211118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyClustersAutoRenewFlagRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID列表
        /// </summary>
        [JsonProperty("ClusterIdSet")]
        public string[] ClusterIdSet{ get; set; }

        /// <summary>
        /// 是否自动续费，0-不 1-是。默认为0，只有当集群的PayMode为PREPAID时生效。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ClusterIdSet.", this.ClusterIdSet);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
        }
    }
}

