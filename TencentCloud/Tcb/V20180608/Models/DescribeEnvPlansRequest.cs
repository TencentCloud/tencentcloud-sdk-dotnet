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

    public class DescribeEnvPlansRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>套餐英文标识，不指定则返回所有可售卖套餐</p><p>枚举值：</p><ul><li>baas_integration： 集成版</li><li>baas_personal： 个人版</li><li>baas_pf_standard： 标准版</li><li>baas_pf_enterprise： 企业版</li><li>baas_pf_enterprise_senior： 企业高级版</li></ul>
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
        }
    }
}

