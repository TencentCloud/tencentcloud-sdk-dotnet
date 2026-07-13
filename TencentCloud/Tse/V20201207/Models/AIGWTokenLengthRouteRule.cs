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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWTokenLengthRouteRule : AbstractModel
    {
        
        /// <summary>
        /// <p>token 长度下界，闭区间；0 合法</p>
        /// </summary>
        [JsonProperty("MinTokenLength")]
        public long? MinTokenLength{ get; set; }

        /// <summary>
        /// <p>token 长度上界，闭区间</p>
        /// </summary>
        [JsonProperty("MaxTokenLength")]
        public long? MaxTokenLength{ get; set; }

        /// <summary>
        /// <p>命中该分段后执行的二级路由</p>
        /// </summary>
        [JsonProperty("Target")]
        public AIGWLLMModelServiceSubRoute Target{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinTokenLength", this.MinTokenLength);
            this.SetParamSimple(map, prefix + "MaxTokenLength", this.MaxTokenLength);
            this.SetParamObj(map, prefix + "Target.", this.Target);
        }
    }
}

