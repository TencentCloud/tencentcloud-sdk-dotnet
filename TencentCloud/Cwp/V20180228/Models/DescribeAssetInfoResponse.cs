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

    public class DescribeAssetInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 主机数
        /// </summary>
        [JsonProperty("MachineCount")]
        public ulong? MachineCount{ get; set; }

        /// <summary>
        /// 账号数
        /// </summary>
        [JsonProperty("AccountCount")]
        public ulong? AccountCount{ get; set; }

        /// <summary>
        /// 端口数
        /// </summary>
        [JsonProperty("PortCount")]
        public ulong? PortCount{ get; set; }

        /// <summary>
        /// 进程数
        /// </summary>
        [JsonProperty("ProcessCount")]
        public ulong? ProcessCount{ get; set; }

        /// <summary>
        /// 软件数
        /// </summary>
        [JsonProperty("SoftwareCount")]
        public ulong? SoftwareCount{ get; set; }

        /// <summary>
        /// 数据库数
        /// </summary>
        [JsonProperty("DatabaseCount")]
        public ulong? DatabaseCount{ get; set; }

        /// <summary>
        /// Web应用数
        /// </summary>
        [JsonProperty("WebAppCount")]
        public ulong? WebAppCount{ get; set; }

        /// <summary>
        /// Web框架数
        /// </summary>
        [JsonProperty("WebFrameCount")]
        public ulong? WebFrameCount{ get; set; }

        /// <summary>
        /// Web服务数
        /// </summary>
        [JsonProperty("WebServiceCount")]
        public ulong? WebServiceCount{ get; set; }

        /// <summary>
        /// Web站点数
        /// </summary>
        [JsonProperty("WebLocationCount")]
        public ulong? WebLocationCount{ get; set; }

        /// <summary>
        /// 账号今日新增
        /// </summary>
        [JsonProperty("AccountNewCount")]
        public long? AccountNewCount{ get; set; }

        /// <summary>
        /// 端口今日新增
        /// </summary>
        [JsonProperty("PortNewCount")]
        public long? PortNewCount{ get; set; }

        /// <summary>
        /// 进程今日新增
        /// </summary>
        [JsonProperty("ProcessNewCount")]
        public long? ProcessNewCount{ get; set; }

        /// <summary>
        /// 软件今日新增
        /// </summary>
        [JsonProperty("SoftwareNewCount")]
        public long? SoftwareNewCount{ get; set; }

        /// <summary>
        /// 数据库今日新增
        /// </summary>
        [JsonProperty("DatabaseNewCount")]
        public long? DatabaseNewCount{ get; set; }

        /// <summary>
        /// Web应用今日新增
        /// </summary>
        [JsonProperty("WebAppNewCount")]
        public long? WebAppNewCount{ get; set; }

        /// <summary>
        /// Web框架今日新增
        /// </summary>
        [JsonProperty("WebFrameNewCount")]
        public long? WebFrameNewCount{ get; set; }

        /// <summary>
        /// Web服务今日新增
        /// </summary>
        [JsonProperty("WebServiceNewCount")]
        public long? WebServiceNewCount{ get; set; }

        /// <summary>
        /// Web站点今日新增
        /// </summary>
        [JsonProperty("WebLocationNewCount")]
        public long? WebLocationNewCount{ get; set; }

        /// <summary>
        /// 主机今日新增
        /// </summary>
        [JsonProperty("MachineNewCount")]
        public long? MachineNewCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "MachineCount", this.MachineCount);
            this.SetParamSimple(map, prefix + "AccountCount", this.AccountCount);
            this.SetParamSimple(map, prefix + "PortCount", this.PortCount);
            this.SetParamSimple(map, prefix + "ProcessCount", this.ProcessCount);
            this.SetParamSimple(map, prefix + "SoftwareCount", this.SoftwareCount);
            this.SetParamSimple(map, prefix + "DatabaseCount", this.DatabaseCount);
            this.SetParamSimple(map, prefix + "WebAppCount", this.WebAppCount);
            this.SetParamSimple(map, prefix + "WebFrameCount", this.WebFrameCount);
            this.SetParamSimple(map, prefix + "WebServiceCount", this.WebServiceCount);
            this.SetParamSimple(map, prefix + "WebLocationCount", this.WebLocationCount);
            this.SetParamSimple(map, prefix + "AccountNewCount", this.AccountNewCount);
            this.SetParamSimple(map, prefix + "PortNewCount", this.PortNewCount);
            this.SetParamSimple(map, prefix + "ProcessNewCount", this.ProcessNewCount);
            this.SetParamSimple(map, prefix + "SoftwareNewCount", this.SoftwareNewCount);
            this.SetParamSimple(map, prefix + "DatabaseNewCount", this.DatabaseNewCount);
            this.SetParamSimple(map, prefix + "WebAppNewCount", this.WebAppNewCount);
            this.SetParamSimple(map, prefix + "WebFrameNewCount", this.WebFrameNewCount);
            this.SetParamSimple(map, prefix + "WebServiceNewCount", this.WebServiceNewCount);
            this.SetParamSimple(map, prefix + "WebLocationNewCount", this.WebLocationNewCount);
            this.SetParamSimple(map, prefix + "MachineNewCount", this.MachineNewCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

