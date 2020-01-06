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

namespace TencentCloud.Bmeip.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyEipAclRequest : AbstractModel
    {
        
        /// <summary>
        /// ACL 实例 ID
        /// </summary>
        [JsonProperty("AclId")]
        public string AclId{ get; set; }

        /// <summary>
        /// ACL 名称
        /// </summary>
        [JsonProperty("AclName")]
        public string AclName{ get; set; }

        /// <summary>
        /// ACL 状态。0：无状态 1：有状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 规则类型（in/out）。in：入站规则 out：出站规则
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// ACL规则列表
        /// </summary>
        [JsonProperty("Rules")]
        public EipAclRule[] Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AclId", this.AclId);
            this.SetParamSimple(map, prefix + "AclName", this.AclName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

