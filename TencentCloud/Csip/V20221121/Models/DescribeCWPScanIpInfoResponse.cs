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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCWPScanIpInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>所属业务</p>
        /// </summary>
        [JsonProperty("Bussiness")]
        public string Bussiness{ get; set; }

        /// <summary>
        /// <p>业务特征</p>
        /// </summary>
        [JsonProperty("Characteristic")]
        public string Characteristic{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// <p>官方公告</p>
        /// </summary>
        [JsonProperty("Referer")]
        public string Referer{ get; set; }

        /// <summary>
        /// <p>扫描示例</p>
        /// </summary>
        [JsonProperty("Demo")]
        public string Demo{ get; set; }

        /// <summary>
        /// <p>扫描对象</p>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// <p>扫描目的</p>
        /// </summary>
        [JsonProperty("Purpose")]
        public string Purpose{ get; set; }

        /// <summary>
        /// <p>产品文案</p>
        /// </summary>
        [JsonProperty("Announcement")]
        public string Announcement{ get; set; }

        /// <summary>
        /// <p>地理位置</p>
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// <p>所属运营商</p>
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }

        /// <summary>
        /// <p>是否归属于腾讯</p>
        /// </summary>
        [JsonProperty("IsBelongTencent")]
        public bool? IsBelongTencent{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bussiness", this.Bussiness);
            this.SetParamSimple(map, prefix + "Characteristic", this.Characteristic);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "Referer", this.Referer);
            this.SetParamSimple(map, prefix + "Demo", this.Demo);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Purpose", this.Purpose);
            this.SetParamSimple(map, prefix + "Announcement", this.Announcement);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
            this.SetParamSimple(map, prefix + "IsBelongTencent", this.IsBelongTencent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

