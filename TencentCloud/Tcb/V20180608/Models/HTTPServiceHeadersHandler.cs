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

    public class HTTPServiceHeadersHandler : AbstractModel
    {
        
        /// <summary>
        /// 添加请求头列表
        /// </summary>
        [JsonProperty("RequestHeadersToAdd")]
        public HTTPServiceHeaderToAdd[] RequestHeadersToAdd{ get; set; }

        /// <summary>
        /// 删除请求头列表
        /// </summary>
        [JsonProperty("RequestHeadersToRemove")]
        public string[] RequestHeadersToRemove{ get; set; }

        /// <summary>
        /// 添加返回头列表
        /// </summary>
        [JsonProperty("ResponseHeadersToAdd")]
        public HTTPServiceHeaderToAdd[] ResponseHeadersToAdd{ get; set; }

        /// <summary>
        /// 删除返回头列表
        /// </summary>
        [JsonProperty("ResponseHeadersToRemove")]
        public string[] ResponseHeadersToRemove{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "RequestHeadersToAdd.", this.RequestHeadersToAdd);
            this.SetParamArraySimple(map, prefix + "RequestHeadersToRemove.", this.RequestHeadersToRemove);
            this.SetParamArrayObj(map, prefix + "ResponseHeadersToAdd.", this.ResponseHeadersToAdd);
            this.SetParamArraySimple(map, prefix + "ResponseHeadersToRemove.", this.ResponseHeadersToRemove);
        }
    }
}

