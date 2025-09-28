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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MailConfiguration : AbstractModel
    {
        
        /// <summary>
        /// 是否开启邮件发送: 0, 否; 1, 是。
        /// </summary>
        [JsonProperty("SendMail")]
        public long? SendMail{ get; set; }

        /// <summary>
        /// 地域配置, 如["ap-guangzhou", "ap-shanghai"]。巡检的邮件发送模板，配置需要发送巡检邮件的地域；订阅的邮件发送模板，配置当前订阅实例的所属地域。
        /// </summary>
        [JsonProperty("Region")]
        public string[] Region{ get; set; }

        /// <summary>
        /// 包含的健康等级，包括值：HEALTH-健康，SUB_HEALTH-亚健康，RISK-风险，HIGH_RISK-高危。
        /// </summary>
        [JsonProperty("HealthStatus")]
        public string[] HealthStatus{ get; set; }

        /// <summary>
        /// 联系人id, 联系人/联系组不能都为空。
        /// </summary>
        [JsonProperty("ContactPerson")]
        public long?[] ContactPerson{ get; set; }

        /// <summary>
        /// 联系组id, 联系人/联系组不能都为空。
        /// </summary>
        [JsonProperty("ContactGroup")]
        public long?[] ContactGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SendMail", this.SendMail);
            this.SetParamArraySimple(map, prefix + "Region.", this.Region);
            this.SetParamArraySimple(map, prefix + "HealthStatus.", this.HealthStatus);
            this.SetParamArraySimple(map, prefix + "ContactPerson.", this.ContactPerson);
            this.SetParamArraySimple(map, prefix + "ContactGroup.", this.ContactGroup);
        }
    }
}

