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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkStorageRange : AbstractModel
    {
        
        /// <summary>
        /// 网络带宽上限
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public long? MaxBandwidth{ get; set; }

        /// <summary>
        /// 数据盘上限
        /// </summary>
        [JsonProperty("MaxSystemDiskSize")]
        public long? MaxSystemDiskSize{ get; set; }

        /// <summary>
        /// 网络带宽下限
        /// </summary>
        [JsonProperty("MinBandwidth")]
        public long? MinBandwidth{ get; set; }

        /// <summary>
        /// 数据盘下限
        /// </summary>
        [JsonProperty("MinSystemDiskSize")]
        public long? MinSystemDiskSize{ get; set; }

        /// <summary>
        /// 最大数据盘大小
        /// </summary>
        [JsonProperty("MaxDataDiskSize")]
        public long? MaxDataDiskSize{ get; set; }

        /// <summary>
        /// 最小数据盘大小
        /// </summary>
        [JsonProperty("MinDataDiskSize")]
        public long? MinDataDiskSize{ get; set; }

        /// <summary>
        /// 建议带宽
        /// </summary>
        [JsonProperty("SuggestBandwidth")]
        public long? SuggestBandwidth{ get; set; }

        /// <summary>
        /// 建议硬盘大小
        /// </summary>
        [JsonProperty("SuggestDataDiskSize")]
        public long? SuggestDataDiskSize{ get; set; }

        /// <summary>
        /// 建议系统盘大小
        /// </summary>
        [JsonProperty("SuggestSystemDiskSize")]
        public long? SuggestSystemDiskSize{ get; set; }

        /// <summary>
        /// Cpu核数峰值
        /// </summary>
        [JsonProperty("MaxVcpu")]
        public long? MaxVcpu{ get; set; }

        /// <summary>
        /// Cpu核最小值
        /// </summary>
        [JsonProperty("MinVcpu")]
        public long? MinVcpu{ get; set; }

        /// <summary>
        /// 单次请求最大cpu核数
        /// </summary>
        [JsonProperty("MaxVcpuPerReq")]
        public long? MaxVcpuPerReq{ get; set; }

        /// <summary>
        /// 带宽步长
        /// </summary>
        [JsonProperty("PerBandwidth")]
        public long? PerBandwidth{ get; set; }

        /// <summary>
        /// 数据盘步长
        /// </summary>
        [JsonProperty("PerDataDisk")]
        public long? PerDataDisk{ get; set; }

        /// <summary>
        /// 总模块数量
        /// </summary>
        [JsonProperty("MaxModuleNum")]
        public long? MaxModuleNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamSimple(map, prefix + "MaxSystemDiskSize", this.MaxSystemDiskSize);
            this.SetParamSimple(map, prefix + "MinBandwidth", this.MinBandwidth);
            this.SetParamSimple(map, prefix + "MinSystemDiskSize", this.MinSystemDiskSize);
            this.SetParamSimple(map, prefix + "MaxDataDiskSize", this.MaxDataDiskSize);
            this.SetParamSimple(map, prefix + "MinDataDiskSize", this.MinDataDiskSize);
            this.SetParamSimple(map, prefix + "SuggestBandwidth", this.SuggestBandwidth);
            this.SetParamSimple(map, prefix + "SuggestDataDiskSize", this.SuggestDataDiskSize);
            this.SetParamSimple(map, prefix + "SuggestSystemDiskSize", this.SuggestSystemDiskSize);
            this.SetParamSimple(map, prefix + "MaxVcpu", this.MaxVcpu);
            this.SetParamSimple(map, prefix + "MinVcpu", this.MinVcpu);
            this.SetParamSimple(map, prefix + "MaxVcpuPerReq", this.MaxVcpuPerReq);
            this.SetParamSimple(map, prefix + "PerBandwidth", this.PerBandwidth);
            this.SetParamSimple(map, prefix + "PerDataDisk", this.PerDataDisk);
            this.SetParamSimple(map, prefix + "MaxModuleNum", this.MaxModuleNum);
        }
    }
}

