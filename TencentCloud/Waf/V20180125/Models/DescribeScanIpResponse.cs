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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScanIpResponse : AbstractModel
    {
        
        /// <summary>
        /// ip列表,当入参Ip为all时，返回所有已知ip列表
        /// </summary>
        [JsonProperty("IpList")]
        public ScanIpInfo[] IpList{ get; set; }

        /// <summary>
        /// 所属业务
        /// </summary>
        [JsonProperty("Bussiness")]
        public string Bussiness{ get; set; }

        /// <summary>
        /// 业务特征
        /// </summary>
        [JsonProperty("Characteristic")]
        public string Characteristic{ get; set; }

        /// <summary>
        /// 扫描说明
        /// </summary>
        [JsonProperty("Descibe")]
        public string Descibe{ get; set; }

        /// <summary>
        /// 官方公告
        /// </summary>
        [JsonProperty("Referer")]
        public string Referer{ get; set; }

        /// <summary>
        /// 扫描示例
        /// </summary>
        [JsonProperty("Demo")]
        public string Demo{ get; set; }

        /// <summary>
        /// 扫描对象
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// 扫描目的
        /// </summary>
        [JsonProperty("Purpose")]
        public string Purpose{ get; set; }

        /// <summary>
        /// 产品文案
        /// </summary>
        [JsonProperty("Announcement")]
        public string Announcement{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// ipowner
        /// </summary>
        [JsonProperty("IpOwner")]
        public string IpOwner{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "IpList.", this.IpList);
            this.SetParamSimple(map, prefix + "Bussiness", this.Bussiness);
            this.SetParamSimple(map, prefix + "Characteristic", this.Characteristic);
            this.SetParamSimple(map, prefix + "Descibe", this.Descibe);
            this.SetParamSimple(map, prefix + "Referer", this.Referer);
            this.SetParamSimple(map, prefix + "Demo", this.Demo);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Purpose", this.Purpose);
            this.SetParamSimple(map, prefix + "Announcement", this.Announcement);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IpOwner", this.IpOwner);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

