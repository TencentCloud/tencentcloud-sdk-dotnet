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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CSIPMachineExtraInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>公网IP</p>
        /// </summary>
        [JsonProperty("WanIP")]
        public string WanIP{ get; set; }

        /// <summary>
        /// <p>内网IP</p>
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// <p>实例ID（CVM/BM/ECM唯一标识）</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WanIP", this.WanIP);
            this.SetParamSimple(map, prefix + "PrivateIP", this.PrivateIP);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
        }
    }
}

