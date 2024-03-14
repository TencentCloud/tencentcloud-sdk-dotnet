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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateIntegrationEmployeesRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。使用此接口时，必须填写userId。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 待创建员工的信息最多不超过20个。
        /// 
        /// **1. 在创建企业微信员工的场景下** :  只需传入下面的参数，其他信息不支持设置。
        /// <table> <thead> <tr> <th>参数</th> <th>是否必填</th> <th>含义</th> </tr> </thead> <tbody> <tr> <td>WeworkOpenId</td> <td>是</td> <td>企业微信用户账号ID</td> </tr> </tbody> </table>
        /// 
        /// **2. 在其他场景下** :   只需传入下面的参数，其他信息不支持设置。
        /// <table> <thead> <tr> <th>参数</th> <th>是否必填</th> <th>含义</th> </tr> </thead> <tbody> <tr> <td>DisplayName</td> <td>是</td> <td>用户的真实名字</td> </tr> <tr> <td>Mobile</td> <td>是</td> <td>用户手机号码</td> </tr> <tr> <td>OpenId</td> <td>否</td> <td>用户的自定义ID</td> </tr> <tr> <td>Email</td> <td>否</td> <td>用户的邮箱</td> </tr> <tr> <td>Department.DepartmentId</td> <td>否</td> <td>用户加入后的部门ID</td> </tr> </tbody> </table>
        /// 
        /// 
        /// 注: `每个手机号每天最多使用3次`
        /// </summary>
        [JsonProperty("Employees")]
        public Staff[] Employees{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 员工邀请方式可通过以下方式进行设置：
        /// 
        /// **H5**：会生成H5的链接，点击链接进入H5的认证加入企业的逻辑。
        /// **SMS（默认）**：会通过短信或企业微信消息进行邀请。如果非企业微信场景，则是企业微信消息。其他场景则是短信通知，短信中包含链接，点击后进入微信小程序进行认证加入企业的逻辑。
        /// </summary>
        [JsonProperty("InvitationNotifyType")]
        public string InvitationNotifyType{ get; set; }

        /// <summary>
        /// 回跳地址，为认证成功后页面进行回跳的URL，请确保回跳地址的可用性。
        /// 
        /// 注：`只有在员工邀请方式（InvitationNotifyType参数）为H5场景下才生效， 其他方式下设置无效。`
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArrayObj(map, prefix + "Employees.", this.Employees);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "InvitationNotifyType", this.InvitationNotifyType);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
        }
    }
}

