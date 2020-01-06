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

namespace TencentCloud.Cws.V20180312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSitesScansRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点的ID列表
        /// </summary>
        [JsonProperty("SiteIds")]
        public ulong?[] SiteIds{ get; set; }

        /// <summary>
        /// 扫描模式，normal-正常扫描；deep-深度扫描
        /// </summary>
        [JsonProperty("ScannerType")]
        public string ScannerType{ get; set; }

        /// <summary>
        /// 扫描速率限制，每秒发送X个HTTP请求
        /// </summary>
        [JsonProperty("RateLimit")]
        public ulong? RateLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SiteIds.", this.SiteIds);
            this.SetParamSimple(map, prefix + "ScannerType", this.ScannerType);
            this.SetParamSimple(map, prefix + "RateLimit", this.RateLimit);
        }
    }
}

