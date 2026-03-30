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

namespace TencentCloud.Vcube.V20220410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Overview : AbstractModel
    {
        
        /// <summary>
        /// 过期license数量
        /// </summary>
        [JsonProperty("Expired")]
        public ulong? Expired{ get; set; }

        /// <summary>
        /// 有效license数量
        /// </summary>
        [JsonProperty("Valid")]
        public ulong? Valid{ get; set; }

        /// <summary>
        /// 临期license数量
        /// </summary>
        [JsonProperty("Near")]
        public ulong? Near{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Expired", this.Expired);
            this.SetParamSimple(map, prefix + "Valid", this.Valid);
            this.SetParamSimple(map, prefix + "Near", this.Near);
        }
    }
}

