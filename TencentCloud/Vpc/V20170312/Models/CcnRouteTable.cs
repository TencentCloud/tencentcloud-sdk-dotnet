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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcnRouteTable : AbstractModel
    {
        
        /// <summary>
        /// 云联网ID。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 云联网路由表ID。
        /// </summary>
        [JsonProperty("CcnRouteTableId")]
        public string CcnRouteTableId{ get; set; }

        /// <summary>
        /// 云联网路由表名称。
        /// </summary>
        [JsonProperty("RouteTableName")]
        public string RouteTableName{ get; set; }

        /// <summary>
        /// 云联网路由表描述。
        /// </summary>
        [JsonProperty("RouteTableDescription")]
        public string RouteTableDescription{ get; set; }

        /// <summary>
        /// True：是默认路由表 False：非默认路由表。
        /// </summary>
        [JsonProperty("IsDefaultTable")]
        public bool? IsDefaultTable{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CcnRouteTableId", this.CcnRouteTableId);
            this.SetParamSimple(map, prefix + "RouteTableName", this.RouteTableName);
            this.SetParamSimple(map, prefix + "RouteTableDescription", this.RouteTableDescription);
            this.SetParamSimple(map, prefix + "IsDefaultTable", this.IsDefaultTable);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

