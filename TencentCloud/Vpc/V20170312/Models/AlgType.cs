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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlgType : AbstractModel
    {
        
        /// <summary>
        /// Ftp协议Alg功能是否开启，可选值：
        /// <li>true：开启Ftp协议Alg功能</li>
        /// <li>false：不开启Ftp协议Alg功能</li>
        /// </summary>
        [JsonProperty("Ftp")]
        public bool? Ftp{ get; set; }

        /// <summary>
        /// Sip协议Alg功能是否开启，可选值：
        /// <li>true：开启Sip协议Alg功能</li>
        /// <li>false：不开启Sip协议Alg功能</li>
        /// </summary>
        [JsonProperty("Sip")]
        public bool? Sip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ftp", this.Ftp);
            this.SetParamSimple(map, prefix + "Sip", this.Sip);
        }
    }
}

