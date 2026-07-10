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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProviderTestConnectionErrorInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>上游模型侧返回的HTTP状态码</p>
        /// </summary>
        [JsonProperty("HttpCode")]
        public ulong? HttpCode{ get; set; }

        /// <summary>
        /// <p>错误状态码</p>
        /// </summary>
        [JsonProperty("ErrorStatus")]
        public string ErrorStatus{ get; set; }

        /// <summary>
        /// <p>探测请求错误信息</p>
        /// </summary>
        [JsonProperty("OriginalMessage")]
        public string OriginalMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HttpCode", this.HttpCode);
            this.SetParamSimple(map, prefix + "ErrorStatus", this.ErrorStatus);
            this.SetParamSimple(map, prefix + "OriginalMessage", this.OriginalMessage);
        }
    }
}

