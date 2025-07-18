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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FrequencyLimitConfig : AbstractModel
    {
        
        /// <summary>
        /// 限额对象 "ConnectionsLimit" 或 "QPSLimit"
        /// </summary>
        [JsonProperty("LimitObject")]
        public string LimitObject{ get; set; }

        /// <summary>
        /// 限额配置
        /// </summary>
        [JsonProperty("LimitConfig")]
        public string LimitConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LimitObject", this.LimitObject);
            this.SetParamSimple(map, prefix + "LimitConfig", this.LimitConfig);
        }
    }
}

