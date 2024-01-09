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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorInfo : AbstractModel
    {
        
        /// <summary>
        /// 当前分区的编号，从0开始
        /// </summary>
        [JsonProperty("PartitionNo")]
        public long? PartitionNo{ get; set; }

        /// <summary>
        /// 当前分区的偏移量
        /// </summary>
        [JsonProperty("ConsumerGroupOffset")]
        public long? ConsumerGroupOffset{ get; set; }

        /// <summary>
        /// 当前分区未消费的数据量
        /// </summary>
        [JsonProperty("ConsumerGroupLag")]
        public long? ConsumerGroupLag{ get; set; }

        /// <summary>
        /// 当前分区的消费延迟(单位为秒)
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionNo", this.PartitionNo);
            this.SetParamSimple(map, prefix + "ConsumerGroupOffset", this.ConsumerGroupOffset);
            this.SetParamSimple(map, prefix + "ConsumerGroupLag", this.ConsumerGroupLag);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
        }
    }
}

