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

    public class CreateBatchOrganizationRegistrationTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 组织机构注册信息。
        /// 一次最多支持10条认证流
        /// </summary>
        [JsonProperty("RegistrationOrganizations")]
        public RegistrationOrganizationInfo[] RegistrationOrganizations{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 要生成链接的类型, 可以选择的值如下: 
        /// 
        /// <ul>
        /// <li>(默认)PC: 生成PC端的链接</li>
        /// <li>SHORT_URL: H5跳转到电子签小程序链接的短链形式, 一般用于发送短信中带的链接, 打开后进入腾讯电子签小程序</li>
        /// <li>APP：生成小程序跳转链接</li>
        /// <li>H5：生成H5跳转长链接</li>
        /// <li>SHORT_H5：生成H5跳转短链</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 认证链接使用单链接还是多链接模式
        /// 
        /// <ul>
        /// <li>0 - 多链接(默认)，指批量生成链接， 每一个企业会拥有一个认证链接，然后分别认证</li>
        /// <li>1 - 单链接 ， 指批量生成链接，然后会将多个链接聚合成一个链接，进行认证</li>
        /// </ul>
        /// 
        /// p.s.
        /// 请注意， 如果使用单链接的模式并且认证方式是授权书方式的时候，必须在接口中传递超管授权书。
        /// </summary>
        [JsonProperty("BatchAuthMethod")]
        public ulong? BatchAuthMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArrayObj(map, prefix + "RegistrationOrganizations.", this.RegistrationOrganizations);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "BatchAuthMethod", this.BatchAuthMethod);
        }
    }
}

