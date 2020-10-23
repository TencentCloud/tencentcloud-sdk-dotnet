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

    public class DescribeBaseOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 模块数量，单位：个
        /// </summary>
        [JsonProperty("ModuleNum")]
        public long? ModuleNum{ get; set; }

        /// <summary>
        /// 节点数量，单位：个
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// cpu核数，单位：个
        /// </summary>
        [JsonProperty("VcpuNum")]
        public long? VcpuNum{ get; set; }

        /// <summary>
        /// 内存大小，单位：G
        /// </summary>
        [JsonProperty("MemoryNum")]
        public long? MemoryNum{ get; set; }

        /// <summary>
        /// 硬盘大小，单位：G
        /// </summary>
        [JsonProperty("StorageNum")]
        public long? StorageNum{ get; set; }

        /// <summary>
        /// 昨日网络峰值,单位：M
        /// </summary>
        [JsonProperty("NetworkNum")]
        public long? NetworkNum{ get; set; }

        /// <summary>
        /// 实例数量，单位：台
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// 运行中数量，单位：台
        /// </summary>
        [JsonProperty("RunningNum")]
        public long? RunningNum{ get; set; }

        /// <summary>
        /// 安全隔离数量，单位：台
        /// </summary>
        [JsonProperty("IsolationNum")]
        public long? IsolationNum{ get; set; }

        /// <summary>
        /// 过期实例数量，单位：台
        /// </summary>
        [JsonProperty("ExpiredNum")]
        public long? ExpiredNum{ get; set; }

        /// <summary>
        /// 即将过期实例数量，单位：台
        /// </summary>
        [JsonProperty("WillExpireNum")]
        public long? WillExpireNum{ get; set; }

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
            this.SetParamSimple(map, prefix + "ModuleNum", this.ModuleNum);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "VcpuNum", this.VcpuNum);
            this.SetParamSimple(map, prefix + "MemoryNum", this.MemoryNum);
            this.SetParamSimple(map, prefix + "StorageNum", this.StorageNum);
            this.SetParamSimple(map, prefix + "NetworkNum", this.NetworkNum);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "RunningNum", this.RunningNum);
            this.SetParamSimple(map, prefix + "IsolationNum", this.IsolationNum);
            this.SetParamSimple(map, prefix + "ExpiredNum", this.ExpiredNum);
            this.SetParamSimple(map, prefix + "WillExpireNum", this.WillExpireNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

