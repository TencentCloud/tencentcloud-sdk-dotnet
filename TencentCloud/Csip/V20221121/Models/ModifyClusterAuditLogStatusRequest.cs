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

    public class ModifyClusterAuditLogStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>审计日志开关，审计日志目标状态：true-开启，false-关闭。开启要求集群已开启防护，关闭不要求。</p>
        /// </summary>
        [JsonProperty("AuditLogSwitch")]
        public bool? AuditLogSwitch{ get; set; }

        /// <summary>
        /// <p>集群资产 id（已废弃）</p>
        /// </summary>
        [JsonProperty("ClusterAssetId")]
        public string ClusterAssetId{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// 被调用的集团账号的成员id
        /// </summary>
        [JsonProperty("OperatedMemberId")]
        public string[] OperatedMemberId{ get; set; }

        /// <summary>
        /// <p>集群 CA 证书 MD5 列表，集群的唯一标识，支持单个或批量修改</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5List")]
        public string[] ClusterCaMD5List{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditLogSwitch", this.AuditLogSwitch);
            this.SetParamSimple(map, prefix + "ClusterAssetId", this.ClusterAssetId);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "OperatedMemberId.", this.OperatedMemberId);
            this.SetParamArraySimple(map, prefix + "ClusterCaMD5List.", this.ClusterCaMD5List);
        }
    }
}

