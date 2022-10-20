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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulScanAuthorizedImageSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 全部已授权的本地镜像数
        /// </summary>
        [JsonProperty("AllAuthorizedImageCount")]
        public long? AllAuthorizedImageCount{ get; set; }

        /// <summary>
        /// 已授权未扫描的本地镜像数
        /// </summary>
        [JsonProperty("UnScanAuthorizedImageCount")]
        public long? UnScanAuthorizedImageCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllAuthorizedImageCount", this.AllAuthorizedImageCount);
            this.SetParamSimple(map, prefix + "UnScanAuthorizedImageCount", this.UnScanAuthorizedImageCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

