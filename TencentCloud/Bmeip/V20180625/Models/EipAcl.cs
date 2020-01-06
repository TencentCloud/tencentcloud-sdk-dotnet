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

    public class EipAcl : AbstractModel
    {
        
        /// <summary>
        /// ACL 实例 ID。
        /// </summary>
        [JsonProperty("AclId")]
        public string AclId{ get; set; }

        /// <summary>
        /// ACL 实例名称
        /// </summary>
        [JsonProperty("AclName")]
        public string AclName{ get; set; }

        /// <summary>
        /// ACL 状态。0：无状态，1：有状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// EIPACL 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// EIPACL 已关联的 eip 数目
        /// </summary>
        [JsonProperty("EipNum")]
        public long? EipNum{ get; set; }

        /// <summary>
        /// 出站规则
        /// </summary>
        [JsonProperty("OutRules")]
        public EipAclRule[] OutRules{ get; set; }

        /// <summary>
        /// 入站规则
        /// </summary>
        [JsonProperty("InRules")]
        public EipAclRule[] InRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AclId", this.AclId);
            this.SetParamSimple(map, prefix + "AclName", this.AclName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "EipNum", this.EipNum);
            this.SetParamArrayObj(map, prefix + "OutRules.", this.OutRules);
            this.SetParamArrayObj(map, prefix + "InRules.", this.InRules);
        }
    }
}

