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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnblockResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>申请解封的资源列表。支持按照公网 IP 解封；可通过 DescribeDDoSBlockRecords 接口获取被封堵的资源详情。参数示例如下：</p><ul><li>公网 IP：117.175.94.230。</li></ul><p>入参限制：列表长度最大限制 10。</p>
        /// </summary>
        [JsonProperty("Resources")]
        public string[] Resources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Resources.", this.Resources);
        }
    }
}

