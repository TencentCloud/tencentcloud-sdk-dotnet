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

    public class ExpectedThreshold : AbstractModel
    {
        
        /// <summary>
        /// 期望发起加速的时延阈值
        /// </summary>
        [JsonProperty("RTT")]
        public float? RTT{ get; set; }

        /// <summary>
        /// 期望发起加速的丢包率阈值
        /// </summary>
        [JsonProperty("Loss")]
        public float? Loss{ get; set; }

        /// <summary>
        /// 期望发起加速的抖动阈值
        /// </summary>
        [JsonProperty("Jitter")]
        public float? Jitter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RTT", this.RTT);
            this.SetParamSimple(map, prefix + "Loss", this.Loss);
            this.SetParamSimple(map, prefix + "Jitter", this.Jitter);
        }
    }
}

