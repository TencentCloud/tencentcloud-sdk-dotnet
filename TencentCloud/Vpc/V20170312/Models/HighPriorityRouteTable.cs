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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HighPriorityRouteTable : AbstractModel
    {
        
        /// <summary>
        /// 高优路由表唯一 ID。
        /// </summary>
        [JsonProperty("HighPriorityRouteTableId")]
        public string HighPriorityRouteTableId{ get; set; }

        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 高优路由表名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 高优路由表关联的子网列表。
        /// </summary>
        [JsonProperty("SubnetSet")]
        public string[] SubnetSet{ get; set; }

        /// <summary>
        /// 高优路由表条目信息
        /// </summary>
        [JsonProperty("HighPriorityRouteSet")]
        public HighPriorityRoute[] HighPriorityRouteSet{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HighPriorityRouteTableId", this.HighPriorityRouteTableId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "SubnetSet.", this.SubnetSet);
            this.SetParamArrayObj(map, prefix + "HighPriorityRouteSet.", this.HighPriorityRouteSet);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

