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

    public class BcosTransInfo : AbstractModel
    {
        
        /// <summary>
        /// 所属区块高度
        /// </summary>
        [JsonProperty("BlockNumber")]
        public long? BlockNumber{ get; set; }

        /// <summary>
        /// 区块时间戳
        /// </summary>
        [JsonProperty("BlockTimestamp")]
        public string BlockTimestamp{ get; set; }

        /// <summary>
        /// 交易哈希
        /// </summary>
        [JsonProperty("TransHash")]
        public string TransHash{ get; set; }

        /// <summary>
        /// 交易发起者
        /// </summary>
        [JsonProperty("TransFrom")]
        public string TransFrom{ get; set; }

        /// <summary>
        /// 交易接收者
        /// </summary>
        [JsonProperty("TransTo")]
        public string TransTo{ get; set; }

        /// <summary>
        /// 落库时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlockNumber", this.BlockNumber);
            this.SetParamSimple(map, prefix + "BlockTimestamp", this.BlockTimestamp);
            this.SetParamSimple(map, prefix + "TransHash", this.TransHash);
            this.SetParamSimple(map, prefix + "TransFrom", this.TransFrom);
            this.SetParamSimple(map, prefix + "TransTo", this.TransTo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

