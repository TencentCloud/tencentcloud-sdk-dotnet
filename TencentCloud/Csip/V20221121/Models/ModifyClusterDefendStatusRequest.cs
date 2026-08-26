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

    public class ModifyClusterDefendStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>防护开关</p>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public bool? DefendStatus{ get; set; }

        /// <summary>
        /// 关闭防护时是否同步解绑集群下主机 License
        /// 枚举值：
        /// true：同步解绑集群所有节点主机授权
        /// false：仅停止容器计费，节点保留主机安全防护
        /// 默认值：false
        /// 补充说明：仅 DefendStatus=false（关闭防护）时生效
        /// </summary>
        [JsonProperty("UnbindHostLicense")]
        public bool? UnbindHostLicense{ get; set; }

        /// <summary>
        /// <p>集群id数组</p>
        /// </summary>
        [JsonProperty("ClusterAssetIds")]
        [System.Obsolete]
        public string[] ClusterAssetIds{ get; set; }

        /// <summary>
        /// 被调用的集团账号的成员id
        /// </summary>
        [JsonProperty("OperatedMemberId")]
        public string[] OperatedMemberId{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>集群ca证书md5值，集群的唯一标识</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5List")]
        public string[] ClusterCaMD5List{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "UnbindHostLicense", this.UnbindHostLicense);
            this.SetParamArraySimple(map, prefix + "ClusterAssetIds.", this.ClusterAssetIds);
            this.SetParamArraySimple(map, prefix + "OperatedMemberId.", this.OperatedMemberId);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "ClusterCaMD5List.", this.ClusterCaMD5List);
        }
    }
}

