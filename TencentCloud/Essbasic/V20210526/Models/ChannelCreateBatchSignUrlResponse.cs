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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelCreateBatchSignUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 批量签署链接，以短链形式返回，短链的有效期参考回参中的 ExpiredTime。
        /// 
        /// 注: 
        /// 1. 非小程序和APP集成使用
        /// 2. <font color="red">生成的链路后面不能再增加参数</font>（会出现覆盖链接中已有参数导致错误）
        /// </summary>
        [JsonProperty("SignUrl")]
        public string SignUrl{ get; set; }

        /// <summary>
        /// 链接过期时间以 Unix 时间戳格式表示，从生成链接时间起，往后7天有效期。过期后短链将失效，无法打开。
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public long? ExpiredTime{ get; set; }

        /// <summary>
        /// 从客户小程序或者客户APP跳转至腾讯电子签小程序进行批量签署的跳转路径
        /// 
        /// 注: 
        /// 1. 小程序和APP集成使用
        /// 2. <font color="red">生成的链路后面不能再增加参数</font>（会出现覆盖链接中已有参数导致错误）
        /// </summary>
        [JsonProperty("MiniAppPath")]
        public string MiniAppPath{ get; set; }

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
            this.SetParamSimple(map, prefix + "SignUrl", this.SignUrl);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "MiniAppPath", this.MiniAppPath);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

