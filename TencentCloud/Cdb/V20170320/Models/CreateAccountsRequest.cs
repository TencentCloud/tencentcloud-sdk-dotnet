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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAccountsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，格式如：cdb-c1nl9rpv，与云数据库控制台页面中显示的实例 ID 相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 云数据库账号。
        /// </summary>
        [JsonProperty("Accounts")]
        public Account[] Accounts{ get; set; }

        /// <summary>
        /// 新账户的密码。
        /// 说明：
        /// 1. 在8 ～ 64位字符数以内（推荐12位以上）。
        /// 2. 至少包含其中两项：小写字母 a ~ z 或 大写字母 A ～ Z。数字0 ～ 9。_+-,&=!@#$%^*().|。
        /// 3. 不能包含非法字符。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 备注信息。最多支持输入255个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 新账户最大可用连接数，默认值为10240，最大可设置值为10240。
        /// </summary>
        [JsonProperty("MaxUserConnections")]
        public long? MaxUserConnections{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Accounts.", this.Accounts);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MaxUserConnections", this.MaxUserConnections);
        }
    }
}

