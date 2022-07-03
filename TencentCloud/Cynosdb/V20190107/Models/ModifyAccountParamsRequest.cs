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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAccountParamsRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id，不超过32个字符
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 账号信息
        /// </summary>
        [JsonProperty("Account")]
        public InputAccount Account{ get; set; }

        /// <summary>
        /// 数据库表权限数组,当前仅支持参数：max_user_connections，max_user_connections不能大于10240
        /// </summary>
        [JsonProperty("AccountParams")]
        public AccountParam[] AccountParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamObj(map, prefix + "Account.", this.Account);
            this.SetParamArrayObj(map, prefix + "AccountParams.", this.AccountParams);
        }
    }
}

