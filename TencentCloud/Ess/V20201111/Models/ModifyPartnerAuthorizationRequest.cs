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

    public class ModifyPartnerAuthorizationRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。<br/>注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 腾讯电子签平台分配的生态集成业务的**业务标识**，**需要联系接入产品经理提供**。
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 合作方企业通过集成方创建的应用id, 必须与业务标记（Business）保持对应。
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/9bc4ee2bd5972035d12033608df157c9.png)
        /// </summary>
        [JsonProperty("PartnerApplicationId")]
        public string PartnerApplicationId{ get; set; }

        /// <summary>
        /// 第三方应用的配置信息。其中包括 回调地址，加密KEY等信息。
        /// 执行成功后会覆盖掉对应的第三方应用的回调相关配置。
        /// </summary>
        [JsonProperty("ApplicationInfo")]
        public CallbackInfo ApplicationInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "PartnerApplicationId", this.PartnerApplicationId);
            this.SetParamObj(map, prefix + "ApplicationInfo.", this.ApplicationInfo);
        }
    }
}

