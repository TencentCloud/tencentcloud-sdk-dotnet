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

    public class CloudBaseGWAPIQPSPolicy : AbstractModel
    {
        
        /// <summary>
        /// qps限额总量
        /// </summary>
        [JsonProperty("QPSTotal")]
        public long? QPSTotal{ get; set; }

        /// <summary>
        /// 客户端限频，如果不限制，LimitBy=None
        /// </summary>
        [JsonProperty("QPSPerClient")]
        public CloudBaseClientQPSPolicy QPSPerClient{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QPSTotal", this.QPSTotal);
            this.SetParamObj(map, prefix + "QPSPerClient.", this.QPSPerClient);
        }
    }
}

