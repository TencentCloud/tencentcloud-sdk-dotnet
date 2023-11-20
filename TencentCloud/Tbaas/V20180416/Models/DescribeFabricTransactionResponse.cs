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

    public class DescribeFabricTransactionResponse : AbstractModel
    {
        
        /// <summary>
        /// 交易ID
        /// </summary>
        [JsonProperty("TxId")]
        public string TxId{ get; set; }

        /// <summary>
        /// 交易Hash
        /// </summary>
        [JsonProperty("TxHash")]
        public string TxHash{ get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonProperty("TxStatus")]
        public string TxStatus{ get; set; }

        /// <summary>
        /// 参与的组织列表
        /// </summary>
        [JsonProperty("JoinOrgList")]
        public string[] JoinOrgList{ get; set; }

        /// <summary>
        /// 交易发送者
        /// </summary>
        [JsonProperty("Sender")]
        public string Sender{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 区块高度
        /// </summary>
        [JsonProperty("BlockHeight")]
        public long? BlockHeight{ get; set; }

        /// <summary>
        /// 交易所属合约
        /// </summary>
        [JsonProperty("ChaincodeName")]
        public string ChaincodeName{ get; set; }

        /// <summary>
        /// 交易数据，base64编码，解码后为json化的字符串
        /// </summary>
        [JsonProperty("TransactionData")]
        public string TransactionData{ get; set; }

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
            this.SetParamSimple(map, prefix + "TxId", this.TxId);
            this.SetParamSimple(map, prefix + "TxHash", this.TxHash);
            this.SetParamSimple(map, prefix + "TxStatus", this.TxStatus);
            this.SetParamArraySimple(map, prefix + "JoinOrgList.", this.JoinOrgList);
            this.SetParamSimple(map, prefix + "Sender", this.Sender);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BlockHeight", this.BlockHeight);
            this.SetParamSimple(map, prefix + "ChaincodeName", this.ChaincodeName);
            this.SetParamSimple(map, prefix + "TransactionData", this.TransactionData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

