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

    public class CreateUserAutoSignEnableUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 自动签使用的场景值, 可以选择的场景值如下:
        /// <ul><li> **E_PRESCRIPTION_AUTO_SIGN** :  电子处方场景</li><li> **OTHER** :  通用场景</li></ul>
        /// </summary>
        [JsonProperty("SceneKey")]
        public string SceneKey{ get; set; }

        /// <summary>
        /// 自动签开通配置信息, 包括开通的人员的信息等
        /// </summary>
        [JsonProperty("AutoSignConfig")]
        public AutoSignConfig AutoSignConfig{ get; set; }

        /// <summary>
        /// 生成的链接类型：
        /// <ul><li> 不传(即为空值) 则会生成小程序端开通链接(默认)</li>
        /// <li> **H5SIGN** : 生成H5端开通链接</li></ul>
        /// </summary>
        [JsonProperty("UrlType")]
        public string UrlType{ get; set; }

        /// <summary>
        /// 是否通知开通方，通知类型:
        /// <ul><li>默认不设置为不通知开通方</li>
        /// <li>**SMS** :  短信通知 ,如果需要短信通知则NotifyAddress填写对方的手机号</li></ul>
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// 如果通知类型NotifyType选择为SMS，则此处为手机号, 其他通知类型不需要设置此项
        /// </summary>
        [JsonProperty("NotifyAddress")]
        public string NotifyAddress{ get; set; }

        /// <summary>
        /// 链接的过期时间，格式为Unix时间戳，不能早于当前时间，且最大为当前时间往后30天。`如果不传，默认过期时间为当前时间往后7天。`
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public long? ExpiredTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "SceneKey", this.SceneKey);
            this.SetParamObj(map, prefix + "AutoSignConfig.", this.AutoSignConfig);
            this.SetParamSimple(map, prefix + "UrlType", this.UrlType);
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamSimple(map, prefix + "NotifyAddress", this.NotifyAddress);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

