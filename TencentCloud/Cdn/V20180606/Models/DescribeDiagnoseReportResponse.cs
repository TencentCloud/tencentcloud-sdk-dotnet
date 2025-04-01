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

    public class DescribeDiagnoseReportResponse : AbstractModel
    {
        
        /// <summary>
        /// 诊断报告基础信息
        /// </summary>
        [JsonProperty("BaskInfo")]
        public DiagnoseData BaskInfo{ get; set; }

        /// <summary>
        /// CNAME检测信息
        /// </summary>
        [JsonProperty("CnameInfo")]
        public DiagnoseData CnameInfo{ get; set; }

        /// <summary>
        /// 客户端检测信息
        /// </summary>
        [JsonProperty("ClientInfo")]
        public DiagnoseData ClientInfo{ get; set; }

        /// <summary>
        /// DNS检测信息
        /// </summary>
        [JsonProperty("DnsInfo")]
        public DiagnoseData DnsInfo{ get; set; }

        /// <summary>
        /// 网络检测信息
        /// </summary>
        [JsonProperty("NetworkInfo")]
        public DiagnoseData NetworkInfo{ get; set; }

        /// <summary>
        /// 边缘节点检测信息
        /// </summary>
        [JsonProperty("OcNodeInfo")]
        public DiagnoseData OcNodeInfo{ get; set; }

        /// <summary>
        /// 中间源节点检测信息
        /// </summary>
        [JsonProperty("MidNodeInfo")]
        public DiagnoseData MidNodeInfo{ get; set; }

        /// <summary>
        /// 源站检测信息
        /// </summary>
        [JsonProperty("OriginInfo")]
        public DiagnoseData OriginInfo{ get; set; }

        /// <summary>
        /// 刷新检测信息
        /// </summary>
        [JsonProperty("PurgeInfo")]
        public DiagnoseData PurgeInfo{ get; set; }

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
            this.SetParamObj(map, prefix + "BaskInfo.", this.BaskInfo);
            this.SetParamObj(map, prefix + "CnameInfo.", this.CnameInfo);
            this.SetParamObj(map, prefix + "ClientInfo.", this.ClientInfo);
            this.SetParamObj(map, prefix + "DnsInfo.", this.DnsInfo);
            this.SetParamObj(map, prefix + "NetworkInfo.", this.NetworkInfo);
            this.SetParamObj(map, prefix + "OcNodeInfo.", this.OcNodeInfo);
            this.SetParamObj(map, prefix + "MidNodeInfo.", this.MidNodeInfo);
            this.SetParamObj(map, prefix + "OriginInfo.", this.OriginInfo);
            this.SetParamObj(map, prefix + "PurgeInfo.", this.PurgeInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

