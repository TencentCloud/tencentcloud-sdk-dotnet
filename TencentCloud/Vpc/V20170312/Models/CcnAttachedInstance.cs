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

    public class CcnAttachedInstance : AbstractModel
    {
        
        /// <summary>
        /// <p>云联网实例ID。</p>
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// <p>关联实例类型：</p><li><code>VPC</code>：私有网络</li><li><code>DIRECTCONNECT</code>：专线网关</li><li><code>BMVPC</code>：黑石私有网络</li>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>关联实例ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>关联实例名称。</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>关联实例所属大区，例如：ap-guangzhou。</p>
        /// </summary>
        [JsonProperty("InstanceRegion")]
        public string InstanceRegion{ get; set; }

        /// <summary>
        /// <p>关联实例所属UIN（根账号）。</p>
        /// </summary>
        [JsonProperty("InstanceUin")]
        public string InstanceUin{ get; set; }

        /// <summary>
        /// <p>关联实例CIDR。</p>
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string[] CidrBlock{ get; set; }

        /// <summary>
        /// <p>关联实例状态：</p><li><code>PENDING</code>：申请中</li><li><code>ACTIVE</code>：已连接</li><li><code>EXPIRED</code>：已过期</li><li><code>REJECTED</code>：已拒绝</li><li><code>DELETED</code>：已删除</li><li><code>FAILED</code>：失败的（2小时后将异步强制解关联）</li><li><code>ATTACHING</code>：关联中</li><li><code>DETACHING</code>：解关联中</li><li><code>DETACHFAILED</code>：解关联失败（2小时后将异步强制解关联）</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>关联时间。</p>
        /// </summary>
        [JsonProperty("AttachedTime")]
        public string AttachedTime{ get; set; }

        /// <summary>
        /// <p>云联网所属UIN（根账号）。</p>
        /// </summary>
        [JsonProperty("CcnUin")]
        public string CcnUin{ get; set; }

        /// <summary>
        /// <p>关联实例所属的大地域，如: CHINA_MAINLAND</p>
        /// </summary>
        [JsonProperty("InstanceArea")]
        public string InstanceArea{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>路由表ID</p>
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// <p>路由表名称</p>
        /// </summary>
        [JsonProperty("RouteTableName")]
        public string RouteTableName{ get; set; }

        /// <summary>
        /// <p>别名类型</p>
        /// </summary>
        [JsonProperty("AliasType")]
        public string AliasType{ get; set; }

        /// <summary>
        /// <p>别名ID</p>
        /// </summary>
        [JsonProperty("AliasInstanceId")]
        public string AliasInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceRegion", this.InstanceRegion);
            this.SetParamSimple(map, prefix + "InstanceUin", this.InstanceUin);
            this.SetParamArraySimple(map, prefix + "CidrBlock.", this.CidrBlock);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AttachedTime", this.AttachedTime);
            this.SetParamSimple(map, prefix + "CcnUin", this.CcnUin);
            this.SetParamSimple(map, prefix + "InstanceArea", this.InstanceArea);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamSimple(map, prefix + "RouteTableName", this.RouteTableName);
            this.SetParamSimple(map, prefix + "AliasType", this.AliasType);
            this.SetParamSimple(map, prefix + "AliasInstanceId", this.AliasInstanceId);
        }
    }
}

