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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CdnIp : AbstractModel
    {
        
        /// <summary>
        /// 节点 ip。
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 是否为腾讯云 CDN 加速节点。yes 表示该节点为腾讯云 CDN 节点，no 表示该节点不是腾讯云 CDN 节点。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 表示该节点所处的省份/国家。unknown 表示节点位置未知。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 节点上下线历史记录。
        /// </summary>
        [JsonProperty("History")]
        public CdnIpHistory[] History{ get; set; }

        /// <summary>
        /// 节点的服务地域。mainland 表示服务地域为中国境内，overseas 表示服务地域为中国境外， unknown 表示服务地域未知。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamArrayObj(map, prefix + "History.", this.History);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

