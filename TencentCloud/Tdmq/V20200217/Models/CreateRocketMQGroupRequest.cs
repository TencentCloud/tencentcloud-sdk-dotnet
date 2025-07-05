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

    public class CreateRocketMQGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Group名称，8~64个字符
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 命名空间，目前只支持单个命名空间
        /// </summary>
        [JsonProperty("Namespaces")]
        public string[] Namespaces{ get; set; }

        /// <summary>
        /// 是否开启消费
        /// </summary>
        [JsonProperty("ReadEnable")]
        public bool? ReadEnable{ get; set; }

        /// <summary>
        /// 是否开启广播消费
        /// </summary>
        [JsonProperty("BroadcastEnable")]
        public bool? BroadcastEnable{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 说明信息，最长128个字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Group类型（TCP/HTTP）
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// Group最大重试次数
        /// </summary>
        [JsonProperty("RetryMaxTimes")]
        public ulong? RetryMaxTimes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "Namespaces.", this.Namespaces);
            this.SetParamSimple(map, prefix + "ReadEnable", this.ReadEnable);
            this.SetParamSimple(map, prefix + "BroadcastEnable", this.BroadcastEnable);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "RetryMaxTimes", this.RetryMaxTimes);
        }
    }
}

