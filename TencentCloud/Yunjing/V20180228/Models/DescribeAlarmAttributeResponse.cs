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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmAttributeResponse : AbstractModel
    {
        
        /// <summary>
        /// 防护软件离线告警状态：
        /// <li>OPEN：告警已开启</li>
        /// <li>CLOSE： 告警已关闭</li>
        /// </summary>
        [JsonProperty("Offline")]
        public string Offline{ get; set; }

        /// <summary>
        /// 发现木马告警状态：
        /// <li>OPEN：告警已开启</li>
        /// <li>CLOSE： 告警已关闭</li>
        /// </summary>
        [JsonProperty("Malware")]
        public string Malware{ get; set; }

        /// <summary>
        /// 发现异地登录告警状态：
        /// <li>OPEN：告警已开启</li>
        /// <li>CLOSE： 告警已关闭</li>
        /// </summary>
        [JsonProperty("NonlocalLogin")]
        public string NonlocalLogin{ get; set; }

        /// <summary>
        /// 被暴力破解成功告警状态：
        /// <li>OPEN：告警已开启</li>
        /// <li>CLOSE： 告警已关闭</li>
        /// </summary>
        [JsonProperty("CrackSuccess")]
        public string CrackSuccess{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offline", this.Offline);
            this.SetParamSimple(map, prefix + "Malware", this.Malware);
            this.SetParamSimple(map, prefix + "NonlocalLogin", this.NonlocalLogin);
            this.SetParamSimple(map, prefix + "CrackSuccess", this.CrackSuccess);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

