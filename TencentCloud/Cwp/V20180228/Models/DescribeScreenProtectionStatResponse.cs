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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScreenProtectionStatResponse : AbstractModel
    {
        
        /// <summary>
        /// 文件查杀 status:  0:从未检测过，或0资产付费情况, 1:已检测，存在恶意文件, 2:已检测，未开启隔离防护, 3:已检测且已开启防护且无风险
        /// 暴力破解status: 0:未开启防护或0付费资产情况 1:已开启防护 2:存在带处理事件
        /// 漏洞扫描status: 0:从未检测过，或0资产付费情况, 1:存在漏洞风险, 2:无风险
        /// 基线检测status: 0:从未检测过，或0资产付费情况, 1:存在基线风险,2:无风险
        /// </summary>
        [JsonProperty("Info")]
        public ScreenProtection[] Info{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Info.", this.Info);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

