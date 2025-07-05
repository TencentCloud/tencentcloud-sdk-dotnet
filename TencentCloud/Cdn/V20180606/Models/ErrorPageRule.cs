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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ErrorPageRule : AbstractModel
    {
        
        /// <summary>
        /// 状态码
        /// 支持 400、403、404、500
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// 重定向状态码设置
        /// 支持 301 或 302
        /// </summary>
        [JsonProperty("RedirectCode")]
        public long? RedirectCode{ get; set; }

        /// <summary>
        /// 重定向 URL
        /// 需要为完整跳转路径，如 https://www.test.com/error.html
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "RedirectCode", this.RedirectCode);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
        }
    }
}

