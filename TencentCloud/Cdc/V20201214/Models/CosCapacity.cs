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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosCapacity : AbstractModel
    {
        
        /// <summary>
        /// 已购cos的总容量大小，单位GB
        /// </summary>
        [JsonProperty("TotalCapacity")]
        public float? TotalCapacity{ get; set; }

        /// <summary>
        /// 剩余可用cos的容量大小，单位GB
        /// </summary>
        [JsonProperty("TotalFreeCapacity")]
        public float? TotalFreeCapacity{ get; set; }

        /// <summary>
        /// 已用cos的容量大小，单位GB
        /// </summary>
        [JsonProperty("TotalUsedCapacity")]
        public float? TotalUsedCapacity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCapacity", this.TotalCapacity);
            this.SetParamSimple(map, prefix + "TotalFreeCapacity", this.TotalFreeCapacity);
            this.SetParamSimple(map, prefix + "TotalUsedCapacity", this.TotalUsedCapacity);
        }
    }
}

