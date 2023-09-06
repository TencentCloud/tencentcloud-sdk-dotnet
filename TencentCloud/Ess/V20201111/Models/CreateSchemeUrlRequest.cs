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

    public class CreateSchemeUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息, userId 必填。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 合同流程签署方的组织机构名称。
        /// 如果名称中包含英文括号()，请使用中文括号（）代替。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 合同流程里边签署方经办人的姓名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 合同流程里边签署方经办人手机号码， 支持国内手机号11位数字(无需加+86前缀或其他字符)。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 要跳转的链接类型
        /// 
        /// <ul><li> **HTTP**：跳转电子签小程序的http_url, 短信通知或者H5跳转适合此类型  ，此时返回长链 (默认类型)</li>
        /// <li>**HTTP_SHORT_URL**：跳转电子签小程序的http_url, 短信通知或者H5跳转适合此类型，此时返回短链</li>
        /// <li>**APP**： 第三方APP或小程序跳转电子签小程序的path,  APP或者小程序跳转适合此类型</li></ul>
        /// </summary>
        [JsonProperty("EndPoint")]
        public string EndPoint{ get; set; }

        /// <summary>
        /// 合同流程ID 
        /// 注: `如果准备跳转到合同流程签署的详情页面(即PathType=1时)必传,   跳转其他页面可不传`
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 合同流程组的组ID, 在合同流程组场景下，生成合同流程组的签署链接时需要赋值
        /// </summary>
        [JsonProperty("FlowGroupId")]
        public string FlowGroupId{ get; set; }

        /// <summary>
        /// 要跳转到的页面类型 
        /// 
        /// <ul><li> **0** : 腾讯电子签小程序个人首页 (默认)</li>
        /// <li> **1** : 腾讯电子签小程序流程合同的详情页 (即合同签署页面)</li>
        /// <li> **2** : 腾讯电子签小程序合同列表页</li></ul>
        /// </summary>
        [JsonProperty("PathType")]
        public ulong? PathType{ get; set; }

        /// <summary>
        /// 签署完成后是否自动回跳
        /// <ul><li>**false**：否, 签署完成不会自动跳转回来(默认)</li><li>**true**：是, 签署完成会自动跳转回来</li></ul>
        /// 注:  ` 该参数只针对"APP" 类型的签署链接有效`
        /// </summary>
        [JsonProperty("AutoJumpBack")]
        public bool? AutoJumpBack{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 生成的签署链接在签署页面隐藏的按钮列表，可设置如下：
        /// 
        /// <ul><li> **0** :合同签署页面更多操作按钮</li>
        /// <li> **1** :合同签署页面更多操作的拒绝签署按钮</li>
        /// <li> **2** :合同签署页面更多操作的转他人处理按钮</li>
        /// <li> **3** :签署成功页的查看详情按钮</li></ul>
        /// 
        /// 注:  `字段为数组, 可以传值隐藏多个按钮`
        /// </summary>
        [JsonProperty("Hides")]
        public long?[] Hides{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "EndPoint", this.EndPoint);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "FlowGroupId", this.FlowGroupId);
            this.SetParamSimple(map, prefix + "PathType", this.PathType);
            this.SetParamSimple(map, prefix + "AutoJumpBack", this.AutoJumpBack);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "Hides.", this.Hides);
        }
    }
}

