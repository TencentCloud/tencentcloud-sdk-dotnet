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

namespace TencentCloud.Tbaas.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFabricBlockResponse : AbstractModel
    {
        
        /// <summary>
        /// 区块高度
        /// </summary>
        [JsonProperty("BlockHeight")]
        public long? BlockHeight{ get; set; }

        /// <summary>
        /// 区块Hash
        /// </summary>
        [JsonProperty("BlockHash")]
        public string BlockHash{ get; set; }

        /// <summary>
        /// 前置区块Hash
        /// </summary>
        [JsonProperty("PreBlockHash")]
        public string PreBlockHash{ get; set; }

        /// <summary>
        /// 区块中交易数量
        /// </summary>
        [JsonProperty("TxCount")]
        public long? TxCount{ get; set; }

        /// <summary>
        /// 区块中交易列表
        /// </summary>
        [JsonProperty("TransactionList")]
        public Transaction[] TransactionList{ get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("CreateTimestamp")]
        public string CreateTimestamp{ get; set; }

        /// <summary>
        /// 提案组织
        /// </summary>
        [JsonProperty("ProposerOrg")]
        public string ProposerOrg{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlockHeight", this.BlockHeight);
            this.SetParamSimple(map, prefix + "BlockHash", this.BlockHash);
            this.SetParamSimple(map, prefix + "PreBlockHash", this.PreBlockHash);
            this.SetParamSimple(map, prefix + "TxCount", this.TxCount);
            this.SetParamArrayObj(map, prefix + "TransactionList.", this.TransactionList);
            this.SetParamSimple(map, prefix + "CreateTimestamp", this.CreateTimestamp);
            this.SetParamSimple(map, prefix + "ProposerOrg", this.ProposerOrg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

