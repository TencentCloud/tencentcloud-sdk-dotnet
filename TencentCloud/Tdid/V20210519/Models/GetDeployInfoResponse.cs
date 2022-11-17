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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetDeployInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 合约CNS地址
        /// </summary>
        [JsonProperty("Hash")]
        public string Hash{ get; set; }

        /// <summary>
        /// 合约主群组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 部署机构DID
        /// </summary>
        [JsonProperty("DeployDid")]
        public string DeployDid{ get; set; }

        /// <summary>
        /// TDID SDK版本
        /// </summary>
        [JsonProperty("SdkVersion")]
        public string SdkVersion{ get; set; }

        /// <summary>
        /// TDID 合约版本
        /// </summary>
        [JsonProperty("ContractVersion")]
        public string ContractVersion{ get; set; }

        /// <summary>
        /// 区块链节点版本
        /// </summary>
        [JsonProperty("BlockVersion")]
        public string BlockVersion{ get; set; }

        /// <summary>
        /// 区块链节点IP
        /// </summary>
        [JsonProperty("BlockIp")]
        public string BlockIp{ get; set; }

        /// <summary>
        /// DID合约地址
        /// </summary>
        [JsonProperty("DidAddress")]
        public string DidAddress{ get; set; }

        /// <summary>
        /// CPT合约地址
        /// </summary>
        [JsonProperty("CptAddress")]
        public string CptAddress{ get; set; }

        /// <summary>
        /// Authority Issuer地址
        /// </summary>
        [JsonProperty("AuthorityAddress")]
        public string AuthorityAddress{ get; set; }

        /// <summary>
        /// Evidence合约地址
        /// </summary>
        [JsonProperty("EvidenceAddress")]
        public string EvidenceAddress{ get; set; }

        /// <summary>
        /// Specific Issuer合约地址
        /// </summary>
        [JsonProperty("SpecificAddress")]
        public string SpecificAddress{ get; set; }

        /// <summary>
        /// 链ID
        /// </summary>
        [JsonProperty("ChainId")]
        public string ChainId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Hash", this.Hash);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "DeployDid", this.DeployDid);
            this.SetParamSimple(map, prefix + "SdkVersion", this.SdkVersion);
            this.SetParamSimple(map, prefix + "ContractVersion", this.ContractVersion);
            this.SetParamSimple(map, prefix + "BlockVersion", this.BlockVersion);
            this.SetParamSimple(map, prefix + "BlockIp", this.BlockIp);
            this.SetParamSimple(map, prefix + "DidAddress", this.DidAddress);
            this.SetParamSimple(map, prefix + "CptAddress", this.CptAddress);
            this.SetParamSimple(map, prefix + "AuthorityAddress", this.AuthorityAddress);
            this.SetParamSimple(map, prefix + "EvidenceAddress", this.EvidenceAddress);
            this.SetParamSimple(map, prefix + "SpecificAddress", this.SpecificAddress);
            this.SetParamSimple(map, prefix + "ChainId", this.ChainId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

