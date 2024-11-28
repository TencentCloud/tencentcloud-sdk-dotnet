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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrganizationServiceAssign : AbstractModel
    {
        
        /// <summary>
        /// 集团服务ID。
        /// </summary>
        [JsonProperty("ServiceId")]
        public ulong? ServiceId{ get; set; }

        /// <summary>
        /// 集团服务产品名称。
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 是否支持委派。取值: 1-是  2-否
        /// </summary>
        [JsonProperty("IsAssign")]
        public ulong? IsAssign{ get; set; }

        /// <summary>
        /// 集团服务描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 当前委派管理员数。
        /// </summary>
        [JsonProperty("MemberNum")]
        public string MemberNum{ get; set; }

        /// <summary>
        /// 帮助文档。
        /// </summary>
        [JsonProperty("Document")]
        public string Document{ get; set; }

        /// <summary>
        /// 集团服务产品控制台路径。
        /// </summary>
        [JsonProperty("ConsoleUrl")]
        public string ConsoleUrl{ get; set; }

        /// <summary>
        /// 是否接入使用状态。取值: 1-是 
        ///  2-否
        /// </summary>
        [JsonProperty("IsUsageStatus")]
        public ulong? IsUsageStatus{ get; set; }

        /// <summary>
        /// 委派管理员数量限制。
        /// </summary>
        [JsonProperty("CanAssignCount")]
        public ulong? CanAssignCount{ get; set; }

        /// <summary>
        /// 集团服务产品标识。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 是否支持集团服务授权。取值 1-是、2-否
        /// </summary>
        [JsonProperty("ServiceGrant")]
        public ulong? ServiceGrant{ get; set; }

        /// <summary>
        /// 集团服务授权启用状态。ServiceGrant值为1时该字段有效 ，取值：Enabled-开启  Disabled-关闭 
        /// </summary>
        [JsonProperty("GrantStatus")]
        public string GrantStatus{ get; set; }

        /// <summary>
        /// 是否支持设置委派管理范围。取值: 1-是  2-否
        /// </summary>
        [JsonProperty("IsSetManagementScope")]
        public ulong? IsSetManagementScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "IsAssign", this.IsAssign);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MemberNum", this.MemberNum);
            this.SetParamSimple(map, prefix + "Document", this.Document);
            this.SetParamSimple(map, prefix + "ConsoleUrl", this.ConsoleUrl);
            this.SetParamSimple(map, prefix + "IsUsageStatus", this.IsUsageStatus);
            this.SetParamSimple(map, prefix + "CanAssignCount", this.CanAssignCount);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "ServiceGrant", this.ServiceGrant);
            this.SetParamSimple(map, prefix + "GrantStatus", this.GrantStatus);
            this.SetParamSimple(map, prefix + "IsSetManagementScope", this.IsSetManagementScope);
        }
    }
}

