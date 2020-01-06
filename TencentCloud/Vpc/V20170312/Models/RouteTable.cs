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

    public class RouteTable : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 路由表实例ID，例如：rtb-azd4dt1c。
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// 路由表名称。
        /// </summary>
        [JsonProperty("RouteTableName")]
        public string RouteTableName{ get; set; }

        /// <summary>
        /// 路由表关联关系。
        /// </summary>
        [JsonProperty("AssociationSet")]
        public RouteTableAssociation[] AssociationSet{ get; set; }

        /// <summary>
        /// 路由表策略集合。
        /// </summary>
        [JsonProperty("RouteSet")]
        public Route[] RouteSet{ get; set; }

        /// <summary>
        /// 是否默认路由表。
        /// </summary>
        [JsonProperty("Main")]
        public bool? Main{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamSimple(map, prefix + "RouteTableName", this.RouteTableName);
            this.SetParamArrayObj(map, prefix + "AssociationSet.", this.AssociationSet);
            this.SetParamArrayObj(map, prefix + "RouteSet.", this.RouteSet);
            this.SetParamSimple(map, prefix + "Main", this.Main);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

