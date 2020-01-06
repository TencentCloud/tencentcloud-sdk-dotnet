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

    public class TransactionItem : AbstractModel
    {
        
        /// <summary>
        /// 交易ID
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// 交易hash
        /// </summary>
        [JsonProperty("TransactionHash")]
        public string TransactionHash{ get; set; }

        /// <summary>
        /// 创建交易的组织名
        /// </summary>
        [JsonProperty("CreateOrgName")]
        public string CreateOrgName{ get; set; }

        /// <summary>
        /// 交易所在区块号
        /// </summary>
        [JsonProperty("BlockId")]
        public ulong? BlockId{ get; set; }

        /// <summary>
        /// 交易类型（普通交易和配置交易）
        /// </summary>
        [JsonProperty("TransactionType")]
        public string TransactionType{ get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 交易所在区块高度
        /// </summary>
        [JsonProperty("BlockHeight")]
        public ulong? BlockHeight{ get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonProperty("TransactionStatus")]
        public string TransactionStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "TransactionHash", this.TransactionHash);
            this.SetParamSimple(map, prefix + "CreateOrgName", this.CreateOrgName);
            this.SetParamSimple(map, prefix + "BlockId", this.BlockId);
            this.SetParamSimple(map, prefix + "TransactionType", this.TransactionType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BlockHeight", this.BlockHeight);
            this.SetParamSimple(map, prefix + "TransactionStatus", this.TransactionStatus);
        }
    }
}

