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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HasAuthUser : AbstractModel
    {
        
        /// <summary>
        /// 员工在腾讯电子签平台的唯一身份标识，为32位字符串。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 当前员工的归属情况，可能值是：
        /// MainOrg：在集团企业的场景下，返回此值代表是归属主企业
        /// CurrentOrg：在普通企业场景下返回此值；或者在集团企业的场景下，返回此值代表归属子企业
        /// </summary>
        [JsonProperty("BelongTo")]
        public string BelongTo{ get; set; }

        /// <summary>
        /// 集团主企业id，当前企业为集团子企业时，该字段有值
        /// </summary>
        [JsonProperty("MainOrganizationId")]
        public string MainOrganizationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "BelongTo", this.BelongTo);
            this.SetParamSimple(map, prefix + "MainOrganizationId", this.MainOrganizationId);
        }
    }
}

