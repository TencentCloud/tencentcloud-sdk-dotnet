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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostingConfig : AbstractModel
    {
        
        /// <summary>
        /// 托管资源替换时间， 默认为证书过期前30天存在续费证书则替换
        /// </summary>
        [JsonProperty("ReplaceTime")]
        public long? ReplaceTime{ get; set; }

        /// <summary>
        /// 托管发送消息类型：0，托管开始前消息提醒（没有续费证书也会收到该提示消息）； 1， 托管开始消息提醒（存在续费证书才会收到消息提醒）； 2， 托管资源替换失败消息提醒； 3 托管资源替换成功消息提醒
        /// </summary>
        [JsonProperty("MessageTypes")]
        public long?[] MessageTypes{ get; set; }

        /// <summary>
        /// 资源替换开始时间
        /// </summary>
        [JsonProperty("ReplaceStartTime")]
        public string ReplaceStartTime{ get; set; }

        /// <summary>
        /// 资源替换结束时间
        /// </summary>
        [JsonProperty("ReplaceEndTime")]
        public string ReplaceEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReplaceTime", this.ReplaceTime);
            this.SetParamArraySimple(map, prefix + "MessageTypes.", this.MessageTypes);
            this.SetParamSimple(map, prefix + "ReplaceStartTime", this.ReplaceStartTime);
            this.SetParamSimple(map, prefix + "ReplaceEndTime", this.ReplaceEndTime);
        }
    }
}

