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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteShareUnitMembersRequest : AbstractModel
    {
        
        /// <summary>
        /// 共享单元ID。
        /// </summary>
        [JsonProperty("UnitId")]
        public string UnitId{ get; set; }

        /// <summary>
        /// 共享单元地域。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 成员列表。
        /// </summary>
        [JsonProperty("Members")]
        public ShareMember[] Members{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UnitId", this.UnitId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArrayObj(map, prefix + "Members.", this.Members);
        }
    }
}

