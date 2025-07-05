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

    public class UnbindEmployeeUserIdWithClientOpenIdRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。使用此接口时，必须填写UserId。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 员工在腾讯电子签平台的唯一身份标识，为32位字符串。
        /// 
        /// 通过<a href="https://qian.tencent.com/developers/companyApis/staffs/DescribeIntegrationEmployees" target="_blank">DescribeIntegrationEmployees</a>接口获取，也可登录腾讯电子签控制台查看
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/97cfffabb0caa61df16999cd395d7850.png)
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 员工在贵司业务系统中的唯一身份标识，用于与腾讯电子签账号进行映射，确保在同一企业内不会出现重复。
        /// 该标识最大长度为64位字符串，仅支持包含26个英文字母和数字0-9的字符。
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

