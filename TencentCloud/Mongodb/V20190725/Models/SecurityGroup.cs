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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroup : AbstractModel
    {
        
        /// <summary>
        /// 所属项目 ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 安全组创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 安全组入站规则。
        /// </summary>
        [JsonProperty("Inbound")]
        public SecurityGroupBound[] Inbound{ get; set; }

        /// <summary>
        /// 安全组出站规则。
        /// </summary>
        [JsonProperty("Outbound")]
        public SecurityGroupBound[] Outbound{ get; set; }

        /// <summary>
        /// 安全组 ID。
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// 安全组名称。
        /// </summary>
        [JsonProperty("SecurityGroupName")]
        public string SecurityGroupName{ get; set; }

        /// <summary>
        /// 安全组备注信息。
        /// </summary>
        [JsonProperty("SecurityGroupRemark")]
        public string SecurityGroupRemark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "Inbound.", this.Inbound);
            this.SetParamArrayObj(map, prefix + "Outbound.", this.Outbound);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamSimple(map, prefix + "SecurityGroupName", this.SecurityGroupName);
            this.SetParamSimple(map, prefix + "SecurityGroupRemark", this.SecurityGroupRemark);
        }
    }
}

