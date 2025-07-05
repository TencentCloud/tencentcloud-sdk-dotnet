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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FieldWriteConfig : AbstractModel
    {
        
        /// <summary>
        /// 1:开启 0:不开启
        /// </summary>
        [JsonProperty("EnableHeaders")]
        public long? EnableHeaders{ get; set; }

        /// <summary>
        /// 1:开启 0:不开启
        /// </summary>
        [JsonProperty("EnableBody")]
        public long? EnableBody{ get; set; }

        /// <summary>
        /// 1:开启 0:不开启
        /// </summary>
        [JsonProperty("EnableBot")]
        public long? EnableBot{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableHeaders", this.EnableHeaders);
            this.SetParamSimple(map, prefix + "EnableBody", this.EnableBody);
            this.SetParamSimple(map, prefix + "EnableBot", this.EnableBot);
        }
    }
}

