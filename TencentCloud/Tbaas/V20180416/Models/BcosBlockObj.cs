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

    public class BcosBlockObj : AbstractModel
    {
        
        /// <summary>
        /// 区块哈希
        /// </summary>
        [JsonProperty("BlockHash")]
        public string BlockHash{ get; set; }

        /// <summary>
        /// 区块高度
        /// </summary>
        [JsonProperty("BlockNumber")]
        public long? BlockNumber{ get; set; }

        /// <summary>
        /// 区块时间戳
        /// </summary>
        [JsonProperty("BlockTimestamp")]
        public string BlockTimestamp{ get; set; }

        /// <summary>
        /// 打包节点id
        /// </summary>
        [JsonProperty("Sealer")]
        public string Sealer{ get; set; }

        /// <summary>
        /// 打包节点索引
        /// </summary>
        [JsonProperty("SealerIndex")]
        public long? SealerIndex{ get; set; }

        /// <summary>
        /// 记录保存时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 交易数量
        /// </summary>
        [JsonProperty("TransCount")]
        public long? TransCount{ get; set; }

        /// <summary>
        /// 记录修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlockHash", this.BlockHash);
            this.SetParamSimple(map, prefix + "BlockNumber", this.BlockNumber);
            this.SetParamSimple(map, prefix + "BlockTimestamp", this.BlockTimestamp);
            this.SetParamSimple(map, prefix + "Sealer", this.Sealer);
            this.SetParamSimple(map, prefix + "SealerIndex", this.SealerIndex);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TransCount", this.TransCount);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

