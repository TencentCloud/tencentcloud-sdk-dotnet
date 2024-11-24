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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScaleCNOutUpInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例唯一ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// warehouse名称
        /// </summary>
        [JsonProperty("VirtualCluster")]
        public string VirtualCluster{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("UserSubnetID")]
        public string UserSubnetID{ get; set; }

        /// <summary>
        /// 新的warehouse的个数
        /// </summary>
        [JsonProperty("NewCount")]
        public long? NewCount{ get; set; }

        /// <summary>
        /// 集群的规格2X-Small、X-Small、Small
        /// </summary>
        [JsonProperty("NewSpecName")]
        public string NewSpecName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualCluster", this.VirtualCluster);
            this.SetParamSimple(map, prefix + "UserSubnetID", this.UserSubnetID);
            this.SetParamSimple(map, prefix + "NewCount", this.NewCount);
            this.SetParamSimple(map, prefix + "NewSpecName", this.NewSpecName);
        }
    }
}

