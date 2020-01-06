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

    public class Block : AbstractModel
    {
        
        /// <summary>
        /// 区块编号
        /// </summary>
        [JsonProperty("BlockNum")]
        public ulong? BlockNum{ get; set; }

        /// <summary>
        /// 区块Hash数值
        /// </summary>
        [JsonProperty("DataHash")]
        public string DataHash{ get; set; }

        /// <summary>
        /// 区块ID，与区块编号一致
        /// </summary>
        [JsonProperty("BlockId")]
        public ulong? BlockId{ get; set; }

        /// <summary>
        /// 前一个区块Hash（未使用）,与区块Hash数值一致
        /// </summary>
        [JsonProperty("PreHash")]
        public string PreHash{ get; set; }

        /// <summary>
        /// 区块内的交易数量
        /// </summary>
        [JsonProperty("TxCount")]
        public ulong? TxCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlockNum", this.BlockNum);
            this.SetParamSimple(map, prefix + "DataHash", this.DataHash);
            this.SetParamSimple(map, prefix + "BlockId", this.BlockId);
            this.SetParamSimple(map, prefix + "PreHash", this.PreHash);
            this.SetParamSimple(map, prefix + "TxCount", this.TxCount);
        }
    }
}

