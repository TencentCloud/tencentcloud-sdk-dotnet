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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComposeCoupletResponse : AbstractModel
    {
        
        /// <summary>
        /// 横批。
        /// </summary>
        [JsonProperty("TopScroll")]
        public string TopScroll{ get; set; }

        /// <summary>
        /// 上联与下联。
        /// </summary>
        [JsonProperty("Content")]
        public string[] Content{ get; set; }

        /// <summary>
        /// 当对联随机生成时，展示随机生成原因。
        /// </summary>
        [JsonProperty("RandomCause")]
        public string RandomCause{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopScroll", this.TopScroll);
            this.SetParamArraySimple(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "RandomCause", this.RandomCause);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

