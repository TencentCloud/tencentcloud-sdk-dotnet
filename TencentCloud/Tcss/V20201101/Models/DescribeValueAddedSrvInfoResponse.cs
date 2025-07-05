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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeValueAddedSrvInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 仓库镜像未授权数量
        /// </summary>
        [JsonProperty("RegistryImageCnt")]
        public ulong? RegistryImageCnt{ get; set; }

        /// <summary>
        /// 本地镜像未授权数量
        /// </summary>
        [JsonProperty("LocalImageCnt")]
        public ulong? LocalImageCnt{ get; set; }

        /// <summary>
        /// 未使用的镜像安全扫描授权数
        /// </summary>
        [JsonProperty("UnusedAuthorizedCnt")]
        public ulong? UnusedAuthorizedCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "RegistryImageCnt", this.RegistryImageCnt);
            this.SetParamSimple(map, prefix + "LocalImageCnt", this.LocalImageCnt);
            this.SetParamSimple(map, prefix + "UnusedAuthorizedCnt", this.UnusedAuthorizedCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

