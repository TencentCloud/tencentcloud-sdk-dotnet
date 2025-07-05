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

    public class Caller : AbstractModel
    {
        
        /// <summary>
        /// 应用号
        /// </summary>
        [JsonProperty("ApplicationId")]
        [System.Obsolete]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 主机构ID
        /// </summary>
        [JsonProperty("OrganizationId")]
        [System.Obsolete]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// 经办人的用户ID，同UserId
        /// </summary>
        [JsonProperty("OperatorId")]
        public string OperatorId{ get; set; }

        /// <summary>
        /// 下属机构ID
        /// </summary>
        [JsonProperty("SubOrganizationId")]
        [System.Obsolete]
        public string SubOrganizationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "OperatorId", this.OperatorId);
            this.SetParamSimple(map, prefix + "SubOrganizationId", this.SubOrganizationId);
        }
    }
}

