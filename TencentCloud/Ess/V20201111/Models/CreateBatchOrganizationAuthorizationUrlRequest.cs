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

    public class CreateBatchOrganizationAuthorizationUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 组织机构超管姓名。 在注册流程中，必须是超管本人进行操作。
        /// 此参数需要跟[创建企业批量认证链接](https://qian.tencent.com/developers/companyApis/organizations/CreateBatchOrganizationRegistrationTasks)中 AdminName 保持一致。
        /// </summary>
        [JsonProperty("AdminName")]
        public string AdminName{ get; set; }

        /// <summary>
        /// 组织机构超管手机号。 在注册流程中，必须是超管本人进行操作。此参数需要跟[创建企业批量认证链接](https://qian.tencent.com/developers/companyApis/organizations/CreateBatchOrganizationRegistrationTasks)中 Admin Mobile保持一致。
        /// </summary>
        [JsonProperty("AdminMobile")]
        public string AdminMobile{ get; set; }

        /// <summary>
        /// 代理相关应用信息，如集团主企业代子企业操作的场景中ProxyOrganizationId必填
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 企业批量认证链接的子任务 SubTaskId，该 SubTaskId 是通过接口 查询企业批量认证链接 DescribeBatchOrganizationRegistrationUrls 获得。此参数需与超管个人三要素（AdminName，AdminMobile，AdminIdCardNumber）配合使用。若 SubTaskId 不属于传入的超级管理员，将进行筛选。
        /// </summary>
        [JsonProperty("SubTaskIds")]
        public string[] SubTaskIds{ get; set; }

        /// <summary>
        /// 组织机构超管证件类型支持以下类型
        /// - ID_CARD : 中国大陆居民身份证 (默认值)
        /// -  HONGKONG_AND_MACAO : 中国港澳居民来往内地通行证
        /// - HONGKONG_MACAO_AND_TAIWAN : 中国港澳台居民居住证(格式同中国大陆居民身份证)
        /// 此参数需要跟[创建企业批量认证链接](https://qian.tencent.com/developers/companyApis/organizations/CreateBatchOrganizationRegistrationTasks)中 AdminIdCardType保持一致。
        /// </summary>
        [JsonProperty("AdminIdCardType")]
        public string AdminIdCardType{ get; set; }

        /// <summary>
        /// 组织机构超管证件号。 在注册流程中，必须是超管本人进行操作。此参数需要跟[创建企业批量认证链接](https://qian.tencent.com/developers/companyApis/organizations/CreateBatchOrganizationRegistrationTasks)中 AdminIdCardNumber保持一致。
        /// </summary>
        [JsonProperty("AdminIdCardNumber")]
        public string AdminIdCardNumber{ get; set; }

        /// <summary>
        /// 要跳转的链接类型<ul><li> **HTTP**：跳转电子签小程序的http_url, 短信通知或者H5跳转适合此类型  ，此时返回长链 (默认类型)</li><li>**HTTP_SHORT_URL**：跳转电子签小程序的http_url, 短信通知或者H5跳转适合此类型，此时返回短链</li><li>**APP**： 第三方APP或小程序跳转电子签小程序的path,  APP或者小程序跳转适合此类型</li><li>**QR_CODE**： 跳转电子签小程序的http_url的二维码形式,  可以在页面展示适合此类型</li></ul>
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "AdminName", this.AdminName);
            this.SetParamSimple(map, prefix + "AdminMobile", this.AdminMobile);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "SubTaskIds.", this.SubTaskIds);
            this.SetParamSimple(map, prefix + "AdminIdCardType", this.AdminIdCardType);
            this.SetParamSimple(map, prefix + "AdminIdCardNumber", this.AdminIdCardNumber);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
        }
    }
}

