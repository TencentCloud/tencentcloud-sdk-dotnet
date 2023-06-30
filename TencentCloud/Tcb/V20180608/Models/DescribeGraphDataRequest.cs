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

    public class DescribeGraphDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 指标名: 
        /// StorageRead: 存储读请求次数 
        /// StorageWrite: 存储写请求次数 
        /// StorageCdnOriginFlux: CDN回源流量, 单位字节 
        /// CDNFlux: CDN回源流量, 单位字节 
        /// FunctionInvocation: 云函数调用次数 
        /// FunctionGBs: 云函数资源使用量, 单位Mb*Ms 
        /// FunctionFlux: 云函数流量, 单位千字节(KB) 
        /// FunctionError: 云函数调用错误次数 
        /// FunctionDuration: 云函数运行时间, 单位毫秒 
        /// DbRead: 数据库读请求数 
        /// DbWrite: 数据库写请求数 
        /// DbCostTime10ms: 数据库耗时在10ms~50ms请求数 
        /// DbCostTime50ms: 数据库耗时在50ms~100ms请求数 
        /// DbCostTime100ms: 数据库耗时在100ms以上请求数 
        /// TkeCpuRatio: 容器CPU占用率 
        /// TkeMemRatio: 容器内存占用率 
        /// TkeCpuUsed: 容器CPU使用量 
        /// TkeMemUsed: 容器内存使用量 
        /// TkeInvokeNum: 调用量 
        /// FunctionConcurrentExecutions: 云函数并发执行个数
        /// FunctionIdleProvisioned: 云函数预置并发闲置量 
        /// FunctionConcurrencyMemoryMB: 云函数并发执行内存量 
        /// FunctionThrottle: 云函数受限次数 
        /// FunctionProvisionedConcurrency: 云函数预置并发 
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 开始时间，如2018-08-24 10:50:00, 开始时间需要早于结束时间至少五分钟(原因是因为目前统计粒度最小是5分钟).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，如2018-08-24 10:50:00, 结束时间需要晚于开始时间至少五分钟(原因是因为目前统计粒度最小是5分钟)..
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 资源ID, 目前仅对云函数、容器托管相关的指标有意义。云函数(FunctionInvocation, FunctionGBs, FunctionFlux, FunctionError, FunctionDuration)、容器托管（服务名称）, 如果想查询某个云函数的指标则在ResourceId中传入函数名; 如果只想查询整个namespace的指标, 则留空或不传.如果想查询数据库某个集合相关信息，传入集合名称
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
        }
    }
}

