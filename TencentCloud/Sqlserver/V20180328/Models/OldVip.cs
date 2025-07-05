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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OldVip : AbstractModel
    {
        
        /// <summary>
        /// 未回收的旧ip
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// ip回收时间
        /// </summary>
        [JsonProperty("RecycleTime")]
        public string RecycleTime{ get; set; }

        /// <summary>
        /// 旧IP保留时间小时数
        /// </summary>
        [JsonProperty("OldIpRetainTime")]
        public long? OldIpRetainTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "RecycleTime", this.RecycleTime);
            this.SetParamSimple(map, prefix + "OldIpRetainTime", this.OldIpRetainTime);
        }
    }
}

