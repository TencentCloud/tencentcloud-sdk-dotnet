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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkData : AbstractModel
    {
        
        /// <summary>
        /// 时延数组，最大长度30
        /// </summary>
        [JsonProperty("RTT")]
        public float?[] RTT{ get; set; }

        /// <summary>
        /// 丢包率
        /// </summary>
        [JsonProperty("Loss")]
        public float? Loss{ get; set; }

        /// <summary>
        /// 抖动
        /// </summary>
        [JsonProperty("Jitter")]
        public float? Jitter{ get; set; }

        /// <summary>
        /// 10位秒级时间戳
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RTT.", this.RTT);
            this.SetParamSimple(map, prefix + "Loss", this.Loss);
            this.SetParamSimple(map, prefix + "Jitter", this.Jitter);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
        }
    }
}

