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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDisasterRecoverGroupQuotaResponse : AbstractModel
    {
        
        /// <summary>
        /// 可创建置放群组数量的上限。
        /// </summary>
        [JsonProperty("GroupQuota")]
        public long? GroupQuota{ get; set; }

        /// <summary>
        /// 当前用户已经创建的置放群组数量。
        /// </summary>
        [JsonProperty("CurrentNum")]
        public long? CurrentNum{ get; set; }

        /// <summary>
        /// 物理机类型容灾组内实例的配额数。
        /// </summary>
        [JsonProperty("CvmInHostGroupQuota")]
        public long? CvmInHostGroupQuota{ get; set; }

        /// <summary>
        /// 交换机类型容灾组内实例的配额数。
        /// </summary>
        [JsonProperty("CvmInSwGroupQuota")]
        public long? CvmInSwGroupQuota{ get; set; }

        /// <summary>
        /// 机架类型容灾组内实例的配额数。
        /// </summary>
        [JsonProperty("CvmInRackGroupQuota")]
        public long? CvmInRackGroupQuota{ get; set; }

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
            this.SetParamSimple(map, prefix + "GroupQuota", this.GroupQuota);
            this.SetParamSimple(map, prefix + "CurrentNum", this.CurrentNum);
            this.SetParamSimple(map, prefix + "CvmInHostGroupQuota", this.CvmInHostGroupQuota);
            this.SetParamSimple(map, prefix + "CvmInSwGroupQuota", this.CvmInSwGroupQuota);
            this.SetParamSimple(map, prefix + "CvmInRackGroupQuota", this.CvmInRackGroupQuota);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

