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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID，请登录<a href="https://console.cloud.tencent.com/redis">Redis控制台</a>在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>自定义的访问数据库的账号名称。</p><ul><li>仅由字母、数字、下划线、中划线组成。</li><li>长度不能大于32位。</li></ul>
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// <p>设置自定义账号的密码。密码复杂度要求如下：</p><ul><li>字符个数为[8,64]。</li><li>至少包含小写字母、大写字母、数字和字符 ()`~!@#$%^&amp;*-+=_|{}[]:;&lt;&gt;,.?/ 中的两种。</li><li>不能以&quot;/&quot;开头。</li></ul>
        /// </summary>
        [JsonProperty("AccountPassword")]
        public string AccountPassword{ get; set; }

        /// <summary>
        /// <p>指定账号的读请求路由分发至主节点或副本节点。未开启副本只读，不支持选择副本节点。</p><ul><li>master：主节点</li><li>replication：副本节点</li></ul>
        /// </summary>
        [JsonProperty("ReadonlyPolicy")]
        public string[] ReadonlyPolicy{ get; set; }

        /// <summary>
        /// <p>账户读写权限，支持选择只读与读写权限。</p><ul><li>r：只读。</li><li>rw: 读写。</li></ul>
        /// </summary>
        [JsonProperty("Privilege")]
        public string Privilege{ get; set; }

        /// <summary>
        /// <p>账号备注描述信息，长度为[0,64] 字节，支持中文。</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>是否启用密码加密传输。</p><ul><li>true：加密。</li><li>false：不加密（默认值）。</li></ul>
        /// </summary>
        [JsonProperty("EncryptPassword")]
        public bool? EncryptPassword{ get; set; }


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
            this.SetParamSimple(map, prefix + "EncryptPassword", this.EncryptPassword);
        }
    }
}

