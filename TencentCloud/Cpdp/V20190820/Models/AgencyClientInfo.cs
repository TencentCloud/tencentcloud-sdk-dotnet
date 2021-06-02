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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgencyClientInfo : AbstractModel
    {
        
        /// <summary>
        /// 经办人姓名，存在经办人必输
        /// </summary>
        [JsonProperty("AgencyClientName")]
        public string AgencyClientName{ get; set; }

        /// <summary>
        /// 经办人证件类型，存在经办人必输
        /// </summary>
        [JsonProperty("AgencyClientGlobalType")]
        public string AgencyClientGlobalType{ get; set; }

        /// <summary>
        /// 经办人证件号，存在经办人必输
        /// </summary>
        [JsonProperty("AgencyClientGlobalId")]
        public string AgencyClientGlobalId{ get; set; }

        /// <summary>
        /// 经办人手机号，存在经办人必输
        /// </summary>
        [JsonProperty("AgencyClientMobile")]
        public string AgencyClientMobile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgencyClientName", this.AgencyClientName);
            this.SetParamSimple(map, prefix + "AgencyClientGlobalType", this.AgencyClientGlobalType);
            this.SetParamSimple(map, prefix + "AgencyClientGlobalId", this.AgencyClientGlobalId);
            this.SetParamSimple(map, prefix + "AgencyClientMobile", this.AgencyClientMobile);
        }
    }
}

