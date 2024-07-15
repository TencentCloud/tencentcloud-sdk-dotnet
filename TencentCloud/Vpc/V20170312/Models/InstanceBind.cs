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

    public class InstanceBind : AbstractModel
    {
        
        /// <summary>
        /// 云联网ID。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 实例类型：VPC，DIRECTCONNECT，BMVPC，EDGE，EDGE_TUNNEL，EDGE_VPNGW，VPNGW。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例绑定路由表的时间。
        /// </summary>
        [JsonProperty("InstanceBindTime")]
        public string InstanceBindTime{ get; set; }

        /// <summary>
        /// 路由表ID。
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例所在地域。
        /// </summary>
        [JsonProperty("InstanceRegion")]
        public string[] InstanceRegion{ get; set; }

        /// <summary>
        /// 实例所属的账户uin。
        /// </summary>
        [JsonProperty("InstanceUin")]
        public string InstanceUin{ get; set; }

        /// <summary>
        /// 关联实例状态：
        /// <li>`PENDING`：申请中</li>
        /// <li>`ACTIVE`：已连接</li>
        /// <li>`EXPIRED`：已过期</li>
        /// <li>`REJECTED`：已拒绝</li>
        /// <li>`DELETED`：已删除</li>
        /// <li>`FAILED`：失败的（2小时后将异步强制解关联）</li>
        /// <li>`ATTACHING`：关联中</li>
        /// <li>`DETACHING`：解关联中</li>
        /// <li>`DETACHFAILED`：解关联失败（2小时后将异步强制解关联）</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceBindTime", this.InstanceBindTime);
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "InstanceRegion.", this.InstanceRegion);
            this.SetParamSimple(map, prefix + "InstanceUin", this.InstanceUin);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

