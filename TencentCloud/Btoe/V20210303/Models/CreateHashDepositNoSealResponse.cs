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

namespace TencentCloud.Btoe.V20210303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateHashDepositNoSealResponse : AbstractModel
    {
        
        /// <summary>
        /// 透传字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 存证编码
        /// </summary>
        [JsonProperty("EvidenceId")]
        public string EvidenceId{ get; set; }

        /// <summary>
        /// 上链时间
        /// </summary>
        [JsonProperty("EvidenceTime")]
        public string EvidenceTime{ get; set; }

        /// <summary>
        /// 区块链交易哈希
        /// </summary>
        [JsonProperty("EvidenceTxHash")]
        public string EvidenceTxHash{ get; set; }

        /// <summary>
        /// 区块高度
        /// </summary>
        [JsonProperty("BlockchainHeight")]
        public ulong? BlockchainHeight{ get; set; }

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
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "EvidenceId", this.EvidenceId);
            this.SetParamSimple(map, prefix + "EvidenceTime", this.EvidenceTime);
            this.SetParamSimple(map, prefix + "EvidenceTxHash", this.EvidenceTxHash);
            this.SetParamSimple(map, prefix + "BlockchainHeight", this.BlockchainHeight);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

