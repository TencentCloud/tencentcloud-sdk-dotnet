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

    public class Transaction : AbstractModel
    {
        
        /// <summary>
        /// 交易ID
        /// </summary>
        [JsonProperty("TxId")]
        public string TxId{ get; set; }

        /// <summary>
        /// 合约名称
        /// </summary>
        [JsonProperty("ChaincodeName")]
        public string ChaincodeName{ get; set; }

        /// <summary>
        /// 交易发送者
        /// </summary>
        [JsonProperty("Sender")]
        public string Sender{ get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 交易所在区块高度
        /// </summary>
        [JsonProperty("BlockHeight")]
        public long? BlockHeight{ get; set; }

        /// <summary>
        /// 交易在区块中的序号
        /// </summary>
        [JsonProperty("TxIndex")]
        public long? TxIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TxId", this.TxId);
            this.SetParamSimple(map, prefix + "ChaincodeName", this.ChaincodeName);
            this.SetParamSimple(map, prefix + "Sender", this.Sender);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BlockHeight", this.BlockHeight);
            this.SetParamSimple(map, prefix + "TxIndex", this.TxIndex);
        }
    }
}

