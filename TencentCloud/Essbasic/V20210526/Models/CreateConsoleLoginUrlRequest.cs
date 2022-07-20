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
        /// 渠道侧合作企业名称，最大长度64个字符
        /// </summary>
        [JsonProperty("ProxyOrganizationName")]
        public string ProxyOrganizationName{ get; set; }

        /// <summary>
        /// 渠道侧合作企业经办人的姓名，最大长度50个字符
        /// </summary>
        [JsonProperty("ProxyOperatorName")]
        public string ProxyOperatorName{ get; set; }

        /// <summary>
        /// 控制台指定模块，文件/合同管理:"DOCUMENT"，模板管理:"TEMPLATE"，印章管理:"SEAL"，组织架构/人员:"OPERATOR"，空字符串："账号信息"
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 控制台指定模块Id
        /// </summary>
        [JsonProperty("ModuleId")]
        public string ModuleId{ get; set; }

        /// <summary>
        /// 渠道侧合作企业统一社会信用代码，最大长度200个字符
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// 是否展示左侧菜单栏 是：ENABLE（默认） 否：DISABLE
        /// </summary>
        [JsonProperty("MenuStatus")]
        public string MenuStatus{ get; set; }

        /// <summary>
        /// 操作者的信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ProxyOrganizationName", this.ProxyOrganizationName);
            this.SetParamSimple(map, prefix + "ProxyOperatorName", this.ProxyOperatorName);
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamSimple(map, prefix + "UniformSocialCreditCode", this.UniformSocialCreditCode);
            this.SetParamSimple(map, prefix + "MenuStatus", this.MenuStatus);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

