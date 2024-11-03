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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApiAnalyzeStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 已经开启的数量,如果返回值为3（大于支持的域名开启数量），则表示开启失败
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 不支持开启的域名列表
        /// </summary>
        [JsonProperty("UnSupportedList")]
        public string[] UnSupportedList{ get; set; }

        /// <summary>
        /// 开启/关闭失败的域名列表
        /// </summary>
        [JsonProperty("FailDomainList")]
        public string[] FailDomainList{ get; set; }

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
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamArraySimple(map, prefix + "UnSupportedList.", this.UnSupportedList);
            this.SetParamArraySimple(map, prefix + "FailDomainList.", this.FailDomainList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

