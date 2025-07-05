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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetRunMetadataFileResponse : AbstractModel
    {
        
        /// <summary>
        /// 文件预签名链接，一分钟内有效。
        /// </summary>
        [JsonProperty("CosSignedUrl")]
        public string CosSignedUrl{ get; set; }

        /// <summary>
        /// 批量文件预签名链接，一分钟内有效。
        /// </summary>
        [JsonProperty("CosSignedUrls")]
        public string[] CosSignedUrls{ get; set; }

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
            this.SetParamSimple(map, prefix + "CosSignedUrl", this.CosSignedUrl);
            this.SetParamArraySimple(map, prefix + "CosSignedUrls.", this.CosSignedUrls);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

