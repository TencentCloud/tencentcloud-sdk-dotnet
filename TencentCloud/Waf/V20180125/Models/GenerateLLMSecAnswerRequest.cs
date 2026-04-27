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

    public class GenerateLLMSecAnswerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>消息结构体内容</p>
        /// </summary>
        [JsonProperty("Message")]
        public SSEClientMessage Message{ get; set; }

        /// <summary>
        /// <p>消息id，传入 要回答的MsgID ，用于匹配自定义回答模板，最终可得到优化的代答结果</p>
        /// </summary>
        [JsonProperty("MsgID")]
        public string MsgID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Message.", this.Message);
            this.SetParamSimple(map, prefix + "MsgID", this.MsgID);
        }
    }
}

