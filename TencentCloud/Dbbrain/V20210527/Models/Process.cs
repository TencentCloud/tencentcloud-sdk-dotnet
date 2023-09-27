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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Process : AbstractModel
    {
        
        /// <summary>
        /// 会话 ID。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 访问来源，IP 地址和端口号。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 文件描述符。
        /// </summary>
        [JsonProperty("FileDescriptor")]
        public long? FileDescriptor{ get; set; }

        /// <summary>
        /// 会话名称，使用 CLIENT SETNAME 命令设置。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 最后一次执行的命令。
        /// </summary>
        [JsonProperty("LastCommand")]
        public string LastCommand{ get; set; }

        /// <summary>
        /// 会话存活时间，单位：秒。
        /// </summary>
        [JsonProperty("Age")]
        public long? Age{ get; set; }

        /// <summary>
        /// 最后一次执行命令后空闲的时间，单位：秒。
        /// </summary>
        [JsonProperty("Idle")]
        public long? Idle{ get; set; }

        /// <summary>
        /// 会话所属的 Proxy节点 ID。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "FileDescriptor", this.FileDescriptor);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "LastCommand", this.LastCommand);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Idle", this.Idle);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
        }
    }
}

