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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckLogKafkaConnectionStateRequest : AbstractModel
    {
        
        /// <summary>
        /// 接入方式,1公网域名接入，2支撑环境接入
        /// </summary>
        [JsonProperty("AccessType")]
        public ulong? AccessType{ get; set; }

        /// <summary>
        /// 接入地址，域名或ip，带端口
        /// </summary>
        [JsonProperty("AccessAddr")]
        public string AccessAddr{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 0不用密码，1有密码
        /// </summary>
        [JsonProperty("HasPwd")]
        public ulong? HasPwd{ get; set; }

        /// <summary>
        /// 密码，使用aes加密
        /// </summary>
        [JsonProperty("Pwd")]
        public string Pwd{ get; set; }

        /// <summary>
        /// kafka实例id
        /// </summary>
        [JsonProperty("KafkaId")]
        public string KafkaId{ get; set; }

        /// <summary>
        /// kafka版本
        /// </summary>
        [JsonProperty("InsVersion")]
        public string InsVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "AccessAddr", this.AccessAddr);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "HasPwd", this.HasPwd);
            this.SetParamSimple(map, prefix + "Pwd", this.Pwd);
            this.SetParamSimple(map, prefix + "KafkaId", this.KafkaId);
            this.SetParamSimple(map, prefix + "InsVersion", this.InsVersion);
        }
    }
}

