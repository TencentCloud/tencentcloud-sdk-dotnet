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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SessionResourceTemplate : AbstractModel
    {
        
        /// <summary>
        /// driver规格：small,medium,large,xlarge；内存型(引擎类型)：m.small,m.medium,m.large,m.xlarge
        /// </summary>
        [JsonProperty("DriverSize")]
        public string DriverSize{ get; set; }

        /// <summary>
        /// executor规格：small,medium,large,xlarge；内存型(引擎类型)：m.small,m.medium,m.large,m.xlarge
        /// </summary>
        [JsonProperty("ExecutorSize")]
        public string ExecutorSize{ get; set; }

        /// <summary>
        /// 指定executor数量，最小值为1，最大值小于集群规格
        /// </summary>
        [JsonProperty("ExecutorNums")]
        public ulong? ExecutorNums{ get; set; }

        /// <summary>
        /// 指定executor max数量（动态配置场景下），最小值为1，最大值小于集群规格（当ExecutorMaxNumbers小于ExecutorNums时，改值设定为ExecutorNums）
        /// </summary>
        [JsonProperty("ExecutorMaxNumbers")]
        public ulong? ExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// 运行时参数
        /// </summary>
        [JsonProperty("RunningTimeParameters")]
        public DataEngineConfigPair[] RunningTimeParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DriverSize", this.DriverSize);
            this.SetParamSimple(map, prefix + "ExecutorSize", this.ExecutorSize);
            this.SetParamSimple(map, prefix + "ExecutorNums", this.ExecutorNums);
            this.SetParamSimple(map, prefix + "ExecutorMaxNumbers", this.ExecutorMaxNumbers);
            this.SetParamArrayObj(map, prefix + "RunningTimeParameters.", this.RunningTimeParameters);
        }
    }
}

