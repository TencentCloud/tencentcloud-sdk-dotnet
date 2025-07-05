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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSubscribeReturnableResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例是否支持退还/退货
        /// </summary>
        [JsonProperty("IsReturnable")]
        public bool? IsReturnable{ get; set; }

        /// <summary>
        /// 不支持退还的原因
        /// </summary>
        [JsonProperty("ReturnFailMessage")]
        public string ReturnFailMessage{ get; set; }

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
            this.SetParamSimple(map, prefix + "IsReturnable", this.IsReturnable);
            this.SetParamSimple(map, prefix + "ReturnFailMessage", this.ReturnFailMessage);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

