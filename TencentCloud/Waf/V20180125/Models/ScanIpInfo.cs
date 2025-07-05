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

    public class ScanIpInfo : AbstractModel
    {
        
        /// <summary>
        /// 所属业务
        /// </summary>
        [JsonProperty("Bussiness")]
        public string Bussiness{ get; set; }

        /// <summary>
        /// 扫描对象
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// ip列表
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

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
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bussiness", this.Bussiness);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamSimple(map, prefix + "Descibe", this.Descibe);
            this.SetParamSimple(map, prefix + "Referer", this.Referer);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

