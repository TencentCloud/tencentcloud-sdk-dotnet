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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UseDefaultRepoParameters : AbstractModel
    {
        
        /// <summary>
        /// 企业版实例名
        /// </summary>
        [JsonProperty("EnterpriseInstanceName")]
        public string EnterpriseInstanceName{ get; set; }

        /// <summary>
        /// 企业版收费类型  0 按量收费   1 包年包月
        /// </summary>
        [JsonProperty("EnterpriseInstanceChargeType")]
        public long? EnterpriseInstanceChargeType{ get; set; }

        /// <summary>
        /// 企业版规格：basic-基础班 ，standard-标准版，premium-高级版
        /// </summary>
        [JsonProperty("EnterpriseInstanceType")]
        public string EnterpriseInstanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnterpriseInstanceName", this.EnterpriseInstanceName);
            this.SetParamSimple(map, prefix + "EnterpriseInstanceChargeType", this.EnterpriseInstanceChargeType);
            this.SetParamSimple(map, prefix + "EnterpriseInstanceType", this.EnterpriseInstanceType);
        }
    }
}

