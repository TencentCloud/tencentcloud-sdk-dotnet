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

    public class DescribeClusterNodeListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群资产 id</p>
        /// </summary>
        [JsonProperty("ClusterAssetId")]
        [System.Obsolete]
        public string ClusterAssetId{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>通用过滤条件列表。支持的过滤字段：<br>NodeName：节点名称，模糊匹配。<br>NodeId：节点ID，精确匹配。<br>NodeUniqueID：节点唯一ID，精确匹配（NodeAssetID 为等价别名）。<br>NodeType：节点类型，精确匹配。取值：SUPER（超级节点）、MASTER（主节点）、WORKER（工作节点）。<br>RunStatus：节点运行状态，精确匹配。<br>InternalIP：内网IP，精确匹配。<br>ClientStatus：客户端状态，精确匹配。取值：ONLINE（在线）、OFFLINE（离线）、UNINSTALL（未安装）。</p>
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }

        /// <summary>
        /// <p>集群ca证书md5值，集群的唯一标识</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterAssetId", this.ClusterAssetId);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
        }
    }
}

