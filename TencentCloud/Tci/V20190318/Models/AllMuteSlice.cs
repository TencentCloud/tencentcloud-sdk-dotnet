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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllMuteSlice : AbstractModel
    {
        
        /// <summary>
        /// 所有静音片段。
        /// </summary>
        [JsonProperty("MuteSlice")]
        public MuteSlice[] MuteSlice{ get; set; }

        /// <summary>
        /// 静音时长占比。
        /// </summary>
        [JsonProperty("MuteRatio")]
        public float? MuteRatio{ get; set; }

        /// <summary>
        /// 静音总时长。
        /// </summary>
        [JsonProperty("TotalMuteDuration")]
        public long? TotalMuteDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "MuteSlice.", this.MuteSlice);
            this.SetParamSimple(map, prefix + "MuteRatio", this.MuteRatio);
            this.SetParamSimple(map, prefix + "TotalMuteDuration", this.TotalMuteDuration);
        }
    }
}

