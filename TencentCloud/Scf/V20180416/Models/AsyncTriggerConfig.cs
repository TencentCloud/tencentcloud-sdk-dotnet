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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AsyncTriggerConfig : AbstractModel
    {
        
        /// <summary>
        /// 用户错误的异步重试重试配置
        /// </summary>
        [JsonProperty("RetryConfig")]
        public RetryConfig[] RetryConfig{ get; set; }

        /// <summary>
        /// 消息保留时间
        /// </summary>
        [JsonProperty("MsgTTL")]
        public long? MsgTTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "RetryConfig.", this.RetryConfig);
            this.SetParamSimple(map, prefix + "MsgTTL", this.MsgTTL);
        }
    }
}

