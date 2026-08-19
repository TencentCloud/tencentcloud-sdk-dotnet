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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UninstallClusterAgentRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群CA证书MD5列表（单/批量统一）<br>用途：指定需要卸载容器安全Agent的集群<br>取值参考：通过 DescribeClusterListV2 接口返回项中的 ClusterCaMD5 字段获取<br>说明：capi 层不对该字段做存在性/类型校验，按 cluster_ca_md5 透传到接入侧 ClusterUninstall RPC</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5List")]
        public string[] ClusterCaMD5List{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ClusterCaMD5List.", this.ClusterCaMD5List);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

