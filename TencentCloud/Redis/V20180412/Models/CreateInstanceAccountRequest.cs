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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 自定义访问数据库的名称。
        /// - 仅由字母、数字、下划线、中划线组成。
        /// - 长度不能大于32位。
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// 设置自定义账号的密码。密码复杂度要求如下：
        /// - 字符个数为[8,32]。
        /// - 至少包含小写字母、大写字母、数字和字符 ()`~!@#$%^&*-+=_|{}[]:;<>,.?/ 中的两种。
        /// - 不能以"/"开头。
        /// </summary>
        [JsonProperty("AccountPassword")]
        public string AccountPassword{ get; set; }

        /// <summary>
        /// 指定账号的读请求路由分发至主节点或副本节点。未开启副本只读，不支持选择副本节点。
        /// - master：主节点
        /// - replication：副本节点
        /// </summary>
        [JsonProperty("ReadonlyPolicy")]
        public string[] ReadonlyPolicy{ get; set; }

        /// <summary>
        /// 账户读写权限，支持选择只读与读写权限。
        /// - r：只读
        /// - rw: 读写权限
        /// </summary>
        [JsonProperty("Privilege")]
        public string Privilege{ get; set; }

        /// <summary>
        /// 子账号描述信息，长度[0,64] 字节，支持中文。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "AccountPassword", this.AccountPassword);
            this.SetParamArraySimple(map, prefix + "ReadonlyPolicy.", this.ReadonlyPolicy);
            this.SetParamSimple(map, prefix + "Privilege", this.Privilege);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

