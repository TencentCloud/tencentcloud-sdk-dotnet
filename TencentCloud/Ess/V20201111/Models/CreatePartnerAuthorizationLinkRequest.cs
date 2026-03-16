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

    public class CreatePartnerAuthorizationLinkRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。<br/>注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 腾讯电子签平台给生态集成方分配的**生态集成业务标识**，
        /// <font color="red">**此生态集成业务标识需要提前联系产品经理配置**。</font>
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 合作方企业在腾讯电子签注册企业后生成的企业id，需要合作方企业登录
        /// <a href="https://qian.tencent.com/console/company-settings/company-center" target="_blank">电子签控制台</a>获取
        /// 
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/20ce774cf8118b9f3742b8519ef935db.png)
        /// </summary>
        [JsonProperty("PartnerOrganizationId")]
        public string PartnerOrganizationId{ get; set; }

        /// <summary>
        /// 第三方应用的配置信息。
        /// 其中包括 回调地址，加密KEY等信息。
        /// </summary>
        [JsonProperty("ApplicationInfo")]
        public CallbackInfo ApplicationInfo{ get; set; }

        /// <summary>
        /// 第三方应用下企业用户信息。
        /// 其中包括企业的OrganizationOpenId和超管的UserOpenId。
        /// 具体含义请参考结构体解释
        /// </summary>
        [JsonProperty("ProxyOrganizationInfo")]
        public ProxyOrganizationInfo ProxyOrganizationInfo{ get; set; }

        /// <summary>
        /// 若未填写，则会创建一个生态集成应用。
        /// 若填写， 则必须是生态集成企业给合作方企业通过此接口**CreatePartnerAuthorizationLink**创建的应用号。
        /// 应用号可以从下图位置获取。
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/9bc4ee2bd5972035d12033608df157c9.png)
        /// </summary>
        [JsonProperty("PartnerApplicationId")]
        public string PartnerApplicationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "PartnerOrganizationId", this.PartnerOrganizationId);
            this.SetParamObj(map, prefix + "ApplicationInfo.", this.ApplicationInfo);
            this.SetParamObj(map, prefix + "ProxyOrganizationInfo.", this.ProxyOrganizationInfo);
            this.SetParamSimple(map, prefix + "PartnerApplicationId", this.PartnerApplicationId);
        }
    }
}

