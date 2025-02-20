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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQConnection : AbstractModel
    {
        
        /// <summary>
        /// 连接名称
        /// </summary>
        [JsonProperty("ConnectionName")]
        public string ConnectionName{ get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [JsonProperty("PeerHost")]
        public string PeerHost{ get; set; }

        /// <summary>
        /// 连接状态，包括 starting、tuning、opening、running、flow、blocking、blocked、closing 和 closed
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 连接使用用户
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 是否开启ssl
        /// </summary>
        [JsonProperty("SSL")]
        public bool? SSL{ get; set; }

        /// <summary>
        /// 连接协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 连接下的channel数
        /// </summary>
        [JsonProperty("Channels")]
        public long? Channels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConnectionName", this.ConnectionName);
            this.SetParamSimple(map, prefix + "PeerHost", this.PeerHost);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "SSL", this.SSL);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Channels", this.Channels);
        }
    }
}

