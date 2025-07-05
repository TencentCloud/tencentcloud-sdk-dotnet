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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTargetGroupAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 目标组的ID。
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// 目标组的新名称。
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// 目标组的新默认端口。全监听目标组不支持此参数。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 后端服务默认权重。
        /// <ul>
        ///     <li>取值范围[0, 100]</li>
        ///     <li>设置该值后，添加后端服务到目标组时， 若后端服务不单独设置权重， 则使用这里的默认权重。 </li> 
        /// </ul>
        /// v1目标组类型不支持设置Weight参数。
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// 是否开启长连接，此参数仅适用于HTTP/HTTPS目标组，true:关闭；false:开启， 默认关闭。
        /// </summary>
        [JsonProperty("KeepaliveEnable")]
        public bool? KeepaliveEnable{ get; set; }

        /// <summary>
        /// 会话保持时间，单位：秒。可选值：30~3600，默认 0，表示不开启。TCP/UDP目标组不支持该参数。
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public ulong? SessionExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "KeepaliveEnable", this.KeepaliveEnable);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
        }
    }
}

