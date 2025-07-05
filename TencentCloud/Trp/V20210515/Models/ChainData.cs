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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChainData : AbstractModel
    {
        
        /// <summary>
        /// 区块hash
        /// </summary>
        [JsonProperty("BlockHash")]
        public string BlockHash{ get; set; }

        /// <summary>
        /// 区块高度
        /// </summary>
        [JsonProperty("BlockHeight")]
        public string BlockHeight{ get; set; }

        /// <summary>
        /// 区块时间
        /// </summary>
        [JsonProperty("BlockTime")]
        public string BlockTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlockHash", this.BlockHash);
            this.SetParamSimple(map, prefix + "BlockHeight", this.BlockHeight);
            this.SetParamSimple(map, prefix + "BlockTime", this.BlockTime);
        }
    }
}

