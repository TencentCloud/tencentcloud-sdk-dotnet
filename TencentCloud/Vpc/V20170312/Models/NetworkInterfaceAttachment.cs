/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkInterfaceAttachment : AbstractModel
    {
        
        /// <summary>
        /// 云主机实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 网卡在云主机实例内的序号。
        /// </summary>
        [JsonProperty("DeviceIndex")]
        public ulong? DeviceIndex{ get; set; }

        /// <summary>
        /// 云主机所有者账户信息。
        /// </summary>
        [JsonProperty("InstanceAccountId")]
        public string InstanceAccountId{ get; set; }

        /// <summary>
        /// 绑定时间。
        /// </summary>
        [JsonProperty("AttachTime")]
        public string AttachTime{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DeviceIndex", this.DeviceIndex);
            this.SetParamSimple(map, prefix + "InstanceAccountId", this.InstanceAccountId);
            this.SetParamSimple(map, prefix + "AttachTime", this.AttachTime);
        }
    }
}

