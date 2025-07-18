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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRabbitMQUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，形如 amqp-xxxxxxxx。有效的 InstanceId 可通过登录 [TDMQ RabbitMQ 控制台](https://console.cloud.tencent.com/trabbitmq/cluster?rid=1)查询。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 用户名，形如 admin。有效的 User 名称可通过登录 [TDMQ RabbitMQ 控制台](https://console.cloud.tencent.com/trabbitmq/cluster?rid=1)查询，点击集群列表中的集群，进入集群详情，并在用户与权限页签中找到用户列表，从而找到用户名称。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 密码，登录时使用。规范：不能为空，8-64个字符，至少要包含小写字母、大写字母、数字、特殊字符【()`~!@#$%^&*_=|{}[]:;',.?/】中的两项
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 描述，不传则不修改
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 用户标签，用于决定改用户访问 RabbitMQ Management 的权限范围
        /// management：普通控制台用户，monitoring：管理型控制台用户，其他值：非控制台用户
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 该用户的最大连接数，不传则不修改
        /// </summary>
        [JsonProperty("MaxConnections")]
        public long? MaxConnections{ get; set; }

        /// <summary>
        /// 该用户的最大channel数，不传则不修改
        /// </summary>
        [JsonProperty("MaxChannels")]
        public long? MaxChannels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "MaxConnections", this.MaxConnections);
            this.SetParamSimple(map, prefix + "MaxChannels", this.MaxChannels);
        }
    }
}

