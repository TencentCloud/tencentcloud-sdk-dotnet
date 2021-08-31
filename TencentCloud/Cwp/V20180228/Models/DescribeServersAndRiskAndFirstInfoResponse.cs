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

    public class DescribeServersAndRiskAndFirstInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 风险文件数
        /// </summary>
        [JsonProperty("RiskFileCount")]
        public ulong? RiskFileCount{ get; set; }

        /// <summary>
        /// 今日新增风险文件数
        /// </summary>
        [JsonProperty("AddRiskFileCount")]
        public ulong? AddRiskFileCount{ get; set; }

        /// <summary>
        /// 受影响服务器台数
        /// </summary>
        [JsonProperty("ServersCount")]
        public ulong? ServersCount{ get; set; }

        /// <summary>
        /// 是否试用
        /// </summary>
        [JsonProperty("IsFirstCheck")]
        public bool? IsFirstCheck{ get; set; }

        /// <summary>
        /// 木马最近检测时间
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskFileCount", this.RiskFileCount);
            this.SetParamSimple(map, prefix + "AddRiskFileCount", this.AddRiskFileCount);
            this.SetParamSimple(map, prefix + "ServersCount", this.ServersCount);
            this.SetParamSimple(map, prefix + "IsFirstCheck", this.IsFirstCheck);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

