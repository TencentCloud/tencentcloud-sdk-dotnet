/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBPerformanceDetailsResponse : AbstractModel
    {
        
        /// <summary>
        /// 主节点性能监控数据
        /// </summary>
        [JsonProperty("Master")]
        public PerformanceMonitorSet Master{ get; set; }

        /// <summary>
        /// 备机1性能监控数据
        /// </summary>
        [JsonProperty("Slave1")]
        public PerformanceMonitorSet Slave1{ get; set; }

        /// <summary>
        /// 备机2性能监控数据，如果实例是一主一从，则没有该字段
        /// </summary>
        [JsonProperty("Slave2")]
        public PerformanceMonitorSet Slave2{ get; set; }

        /// <summary>
        /// 唯一请求ID，每次请求都会返回。定位问题时需要提供该次请求的RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Master.", this.Master);
            this.SetParamObj(map, prefix + "Slave1.", this.Slave1);
            this.SetParamObj(map, prefix + "Slave2.", this.Slave2);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

