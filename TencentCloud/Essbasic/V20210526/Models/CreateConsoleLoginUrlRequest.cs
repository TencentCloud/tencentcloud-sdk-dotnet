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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateConsoleLoginUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用信息
        /// 此接口Agent.AppId、Agent.ProxyOrganizationOpenId 和 Agent. ProxyOperator.OpenId 必填
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 子客企业名称，最大长度64个字符
        /// 注意：
        /// 1、如果您的企业已经在认证授权中或者激活完成，这里修改子客企业名字将不会生效。
        /// 2、该名称需要与Agent.ProxyOrganizationOpenId相匹配。
        /// </summary>
        [JsonProperty("ProxyOrganizationName")]
        public string ProxyOrganizationName{ get; set; }

        /// <summary>
        /// 子客企业统一社会信用代码，最大长度200个字符
        /// 注意：
        /// 1、如果您的企业已经在认证授权中或者激活完成，这里修改子客企业名字将不会生效。
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// 子客企业经办人的姓名，最大长度50个字符
        /// 注意：
        /// 1、若经办人已经实名，这里修改经办人名字传入将不会生效。
        /// 2、该名称需要和Agent. ProxyOperator.OpenId相匹配
        /// </summary>
        [JsonProperty("ProxyOperatorName")]
        public string ProxyOperatorName{ get; set; }

        /// <summary>
        /// PC控制台登录后进入该参数指定的模块，如果不传递，将默认进入控制台首页。支持的模块包括：
        /// 1、DOCUMENT:合同管理模块，
        /// 2、TEMPLATE:企业模板管理模块，
        /// 3、SEAL:印章管理模块，
        /// 4、OPERATOR:组织管理模块，
        /// 默认将进入企业中心模块
        /// 注意：
        /// 1、如果EndPoint选择"CHANNEL"或"APP"，该参数仅支持传递"SEAL"，进入印章管理模块
        /// 2、该参数仅在企业和员工激活完成，登录控制台场景才生效。
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 该参数和Module参数配合使用，用于指定模块下的资源Id，指定后链接登录将展示该资源的详情。
        /// 根据Module参数的不同所代表的含义不同。当前支持：
        /// 1、如果Module="SEAL"，ModuleId代表印章Id, 登录链接将直接查看指定印章的详情。
        /// 2、如果Module="TEMPLATE"，ModuleId代表模版Id，登录链接将直接查看指定模版的详情。
        /// 3、如果Module="1、DOCUMENT"，ModuleId代表合同Id，登录链接将直接查看指定合同的详情。
        /// 注意：
        /// 1、该参数仅在企业和员工激活完成，登录控制台场景才生效。
        /// 2、ModuleId需要和Module对应，ModuleId可以通过API或者控制台获取到。
        /// </summary>
        [JsonProperty("ModuleId")]
        public string ModuleId{ get; set; }

        /// <summary>
        /// 是否展示左侧菜单栏 
        /// "ENABLE": 是，展示 
        /// “DISABLE”: 否，不展示
        /// 默认值为ENABLE
        /// 注意：
        /// 1、该参数仅在企业和员工激活完成，登录控制台场景才生效。
        /// </summary>
        [JsonProperty("MenuStatus")]
        public string MenuStatus{ get; set; }

        /// <summary>
        /// 生成链接的类型：
        /// "PC"：PC控制台链接
        /// "CHANNEL"：H5跳转到电子签小程序链接
        /// "APP"：第三方APP或小程序跳转电子签小程序链接
        /// 默认将生成PC控制台链接
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 触发自动跳转事件，仅对EndPoint为App类型有效，可选值包括：
        /// "VERIFIED":企业认证完成/员工认证完成后跳回原App/小程序
        /// </summary>
        [JsonProperty("AutoJumpBackEvent")]
        public string AutoJumpBackEvent{ get; set; }

        /// <summary>
        /// 可选的企业授权方式: 
        /// 1：上传授权书 
        /// 2：转法定代表人授权
        /// 4：企业实名认证（信任第三方认证源）（此项仅支持单选）
        /// 未选择信任第三方认证源时，如果是法人进行企业激活，仅支持法人扫脸直接授权，该配置不生效；选择信任第三方认证源时，请先通过“同步企业信息”接口同步信息。
        /// 该参数仅在企业激活场景生效
        /// </summary>
        [JsonProperty("AuthorizationTypes")]
        public long?[] AuthorizationTypes{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ProxyOrganizationName", this.ProxyOrganizationName);
            this.SetParamSimple(map, prefix + "UniformSocialCreditCode", this.UniformSocialCreditCode);
            this.SetParamSimple(map, prefix + "ProxyOperatorName", this.ProxyOperatorName);
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamSimple(map, prefix + "MenuStatus", this.MenuStatus);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "AutoJumpBackEvent", this.AutoJumpBackEvent);
            this.SetParamArraySimple(map, prefix + "AuthorizationTypes.", this.AuthorizationTypes);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

