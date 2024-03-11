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

namespace TencentCloud.Tbaas.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryChainMakerDemoBlockTransactionResponse : AbstractModel
    {
        
        /// <summary>
        /// 区块交易
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public ChainMakerTransactionResult[] Result{ get; set; }

        /// <summary>
        /// 区块高度
        /// </summary>
        [JsonProperty("BlockHeight")]
        public long? BlockHeight{ get; set; }

        /// <summary>
        /// 交易数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TxCount")]
        public long? TxCount{ get; set; }

        /// <summary>
        /// 区块时间戳，单位是秒
        /// </summary>
        [JsonProperty("BlockTimestamp")]
        public long? BlockTimestamp{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Result.", this.Result);
            this.SetParamSimple(map, prefix + "BlockHeight", this.BlockHeight);
            this.SetParamSimple(map, prefix + "TxCount", this.TxCount);
            this.SetParamSimple(map, prefix + "BlockTimestamp", this.BlockTimestamp);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

