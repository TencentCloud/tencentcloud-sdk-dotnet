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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeQuotaDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <li> 指标名: </li>
        /// <li> StorageSizepkg: 当月存储空间容量, 单位MB </li>
        /// <li> StorageReadpkg: 当月存储读请求次数 </li>
        /// <li> StorageWritepkg: 当月存储写请求次数 </li>
        /// <li> StorageCdnOriginFluxpkg: 当月CDN回源流量, 单位字节 </li>
        /// <li> StorageCdnOriginFluxpkgDay: 当日CDN回源流量, 单位字节 </li>
        /// <li> StorageReadpkgDay: 当日存储读请求次数 </li>
        /// <li> StorageWritepkgDay: 当日写请求次数 </li>
        /// <li> CDNFluxpkg: 当月CDN流量, 单位为字节 </li>
        /// <li> CDNFluxpkgDay: 当日CDN流量, 单位为字节 </li>
        /// <li> FunctionInvocationpkg: 当月云函数调用次数 </li>
        /// <li> FunctionGBspkg: 当月云函数资源使用量, 单位Mb*Ms </li>
        /// <li> FunctionFluxpkg: 当月云函数流量, 单位千字节(KB) </li>
        /// <li> FunctionInvocationpkgDay: 当日云函数调用次数 </li>
        /// <li> FunctionGBspkgDay: 当日云函数资源使用量, 单位Mb*Ms </li>
        /// <li> FunctionFluxpkgDay: 当日云函数流量, 单位千字节(KB) </li>
        /// <li> DbSizepkg: 当月数据库容量大小, 单位MB </li>
        /// <li> DbReadpkg: 当日数据库读请求数 </li>
        /// <li> DbWritepkg: 当日数据库写请求数 </li>
        /// <li> StaticFsFluxPkgDay: 当日静态托管流量 </li>
        /// <li> StaticFsFluxPkg: 当月静态托管流量</li>
        /// <li> StaticFsSizePkg: 当月静态托管容量 </li>
        /// <li> TkeCpuUsedPkg: 当月容器托管CPU使用量，单位核 </li>
        /// <li> TkeMemUsedPkg: 当月容器托管内存使用量，单位MB </li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 资源ID, 目前仅对云函数、容器托管相关的指标有意义。云函数(FunctionInvocationpkg, FunctionGBspkg, FunctionFluxpkg)、容器托管（服务名称）。如果想查询某个云函数的指标则在ResourceId中传入函数名; 如果只想查询整个namespace的指标, 则留空或不传。
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
        }
    }
}

