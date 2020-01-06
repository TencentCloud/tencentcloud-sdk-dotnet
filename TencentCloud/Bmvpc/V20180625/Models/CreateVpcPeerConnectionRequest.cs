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

namespace TencentCloud.Bmvpc.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVpcPeerConnectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 本端VPC唯一ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 对端VPC唯一ID
        /// </summary>
        [JsonProperty("PeerVpcId")]
        public string PeerVpcId{ get; set; }

        /// <summary>
        /// 对端地域，取值范围为gz,sh,bj,hk,cd,de,sh_bm,gz_bm,bj_bm,cq_bm等
        /// </summary>
        [JsonProperty("PeerRegion")]
        public string PeerRegion{ get; set; }

        /// <summary>
        /// 对等连接名称
        /// </summary>
        [JsonProperty("VpcPeerConnectionName")]
        public string VpcPeerConnectionName{ get; set; }

        /// <summary>
        /// 对端账户OwnerUin（默认值为本端账户）
        /// </summary>
        [JsonProperty("PeerUin")]
        public string PeerUin{ get; set; }

        /// <summary>
        /// 跨地域必传，带宽上限值
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "PeerVpcId", this.PeerVpcId);
            this.SetParamSimple(map, prefix + "PeerRegion", this.PeerRegion);
            this.SetParamSimple(map, prefix + "VpcPeerConnectionName", this.VpcPeerConnectionName);
            this.SetParamSimple(map, prefix + "PeerUin", this.PeerUin);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
        }
    }
}

